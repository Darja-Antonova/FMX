using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [Header("Text Settings")]
    [SerializeField][TextArea] private string[] speech;
    [SerializeField] private float textSpeed = 0.01f;

    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI speechText;
    private int currentDisplayingText = 0;
    public Button textBox;
    public GameObject dialoguePanel;
    private bool isTyping = false;

    [Header("Audio Settings")]
    [SerializeField] private AudioClip[] dialogueClips;

    [Header("Portrait Objects")]
    [SerializeField] private GameObject[] portraitObjects;
    private GameObject currentActivePortrait;

    public PlayerMovement playerMovement;

    public InputAction EnterAction;

    void OnEnable()
    {
        EnterAction.Enable();
    }

    void OnDisable()
    {
        EnterAction.Disable();
    }

    public void Update()
    {
        if (dialoguePanel.activeInHierarchy && EnterAction.WasPressedThisFrame())
        {
            ActivateText();
        }
    }
    public void ActivateText()
    {
        if (isTyping)
        {
            StopAllCoroutines();
            speechText.text = speech[currentDisplayingText];
            currentDisplayingText++;
            isTyping = false;
            AudioManager.Instance.sfxSource.Stop();
            return;
        }

        if (currentDisplayingText >= speech.Length)
        {
            dialoguePanel.SetActive(false);
            playerMovement.enabled = true;
            AudioManager.Instance.DuckMusic(false);
            return;
        }

        AudioManager.Instance.DuckMusic(true);
        StartCoroutine(AnimateText());
    }

    IEnumerator AnimateText()
    {
        isTyping = true;
        speechText.text = "";

        if (dialogueClips.Length > currentDisplayingText && dialogueClips[currentDisplayingText] != null)
        {
            AudioManager.Instance.PlayVoice(dialogueClips[currentDisplayingText]);
        }

        if (currentActivePortrait != null)
        {
            currentActivePortrait.SetActive(false);
        }

        if (portraitObjects.Length > currentDisplayingText && portraitObjects[currentDisplayingText] != null)
        {
            currentActivePortrait = portraitObjects[currentDisplayingText];
            currentActivePortrait.SetActive(true);
        }

        string currentLine = speech[currentDisplayingText];

        foreach (char letter in currentLine.ToCharArray())
        {
            speechText.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }

        currentDisplayingText++;
        isTyping = false;
    }
}
