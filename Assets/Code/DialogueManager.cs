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
    [SerializeField] private GameObject dialoguePanel;

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
        GameObject selected = EventSystem.current.currentSelectedGameObject;

        if (EnterAction.WasPressedThisFrame() && selected == textBox.gameObject)
        {
            textBox.onClick.Invoke();
        }
    }
    public void ActivateText()
    {
        if (currentDisplayingText >= speech.Length)
        {
            dialoguePanel.SetActive(false);
            playerMovement.enabled = true;
            return;
        }

        StopAllCoroutines();
        StartCoroutine(AnimateText());
    }

    IEnumerator AnimateText()
    {
        speechText.text = "";
        string currentLine = speech[currentDisplayingText];

        for (int i = 0; i < speech[currentDisplayingText].Length + 1; i++)
        {
            speechText.text = speech[currentDisplayingText].Substring(0, i);
            yield return new WaitForSeconds(textSpeed);
        }
        currentDisplayingText++;
    }
}
