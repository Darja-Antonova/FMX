using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bfs : MonoBehaviour
{

    private bool bfSpawnable;
    public GameObject ExplosionAnimation;
    public AudioSource CauldronSound;
    public AudioSource Explosion;
    public AudioSource BFBeingDisgusting;


    public GameObject BF1;
    public GameObject BF2;
    public GameObject BF3;
    public GameObject BF4;
    public GameObject BF5;
    public GameObject BF6;
    public GameObject BF7;
    public GameObject BF8;
    public GameObject BF9;
    public GameObject BF10;
    public GameObject BF11;
    public GameObject BF12;
    public GameObject BF13;
    public GameObject BF14;
    public GameObject BF15;
    public GameObject BF16;
    public GameObject BF17;
    public GameObject BF18;
    public GameObject BF19;
    public GameObject BF20;
    public GameObject BF21;
    public GameObject BF22;
    public GameObject BF23;
    public GameObject BF24;
    public GameObject BF25;
    public GameObject BF26;
    public GameObject BF27;

void Start()
    {
        bfSpawnable = false;
    }
 void Update()
    {
        if (bfSpawnable)
        {
            if (BoolHolder.Instance.BodyOne && BoolHolder.Instance.PersOne && BoolHolder.Instance.HobbyOne == true)
            {
                BF1.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyOne && BoolHolder.Instance.PersTwo && BoolHolder.Instance.HobbyOne == true)
            {
                BF2.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyOne && BoolHolder.Instance.PersThree && BoolHolder.Instance.HobbyOne == true)
            {
                BF3.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyTwo && BoolHolder.Instance.PersOne && BoolHolder.Instance.HobbyOne == true)
            {
                BF4.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyTwo && BoolHolder.Instance.PersTwo && BoolHolder.Instance.HobbyOne == true)
            {
                BF5.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyTwo && BoolHolder.Instance.PersThree && BoolHolder.Instance.HobbyOne == true)
            {
                BF6.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyThree && BoolHolder.Instance.PersOne && BoolHolder.Instance.HobbyOne == true)
            {
                BF7.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyThree && BoolHolder.Instance.PersTwo && BoolHolder.Instance.HobbyOne == true)
            {
                BF8.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyThree && BoolHolder.Instance.PersThree && BoolHolder.Instance.HobbyOne == true)
            {
                BF9.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            if (BoolHolder.Instance.BodyOne && BoolHolder.Instance.PersOne && BoolHolder.Instance.HobbyTwo == true)
            {
                BF10.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyOne && BoolHolder.Instance.PersTwo && BoolHolder.Instance.HobbyTwo == true)
            {
                BF11.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyOne && BoolHolder.Instance.PersThree && BoolHolder.Instance.HobbyTwo == true)
            {
                BF12.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyTwo && BoolHolder.Instance.PersOne && BoolHolder.Instance.HobbyTwo == true)
            {
                BF13.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyTwo && BoolHolder.Instance.PersTwo && BoolHolder.Instance.HobbyTwo == true)
            {
                BF14.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyTwo && BoolHolder.Instance.PersThree && BoolHolder.Instance.HobbyTwo == true)
            {
                BF15.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyThree && BoolHolder.Instance.PersOne && BoolHolder.Instance.HobbyTwo == true)
            {
                BF16.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyThree && BoolHolder.Instance.PersTwo && BoolHolder.Instance.HobbyTwo == true)
            {
                BF17.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyThree && BoolHolder.Instance.PersThree && BoolHolder.Instance.HobbyTwo == true)
            {
                BF18.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            if (BoolHolder.Instance.BodyOne && BoolHolder.Instance.PersOne && BoolHolder.Instance.HobbyThree == true)
            {
                BF19.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyOne && BoolHolder.Instance.PersTwo && BoolHolder.Instance.HobbyThree == true)
            {
                BF20.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyOne && BoolHolder.Instance.PersThree && BoolHolder.Instance.HobbyThree == true)
            {
                BF21.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyTwo && BoolHolder.Instance.PersOne && BoolHolder.Instance.HobbyThree == true)
            {
                BF22.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyTwo && BoolHolder.Instance.PersTwo && BoolHolder.Instance.HobbyThree == true)
            {
                BF23.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyTwo && BoolHolder.Instance.PersThree && BoolHolder.Instance.HobbyThree == true)
            {
                BF24.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyThree && BoolHolder.Instance.PersOne && BoolHolder.Instance.HobbyThree == true)
            {
                BF25.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyThree && BoolHolder.Instance.PersTwo && BoolHolder.Instance.HobbyThree == true)
            {
                BF26.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
            else if (BoolHolder.Instance.BodyThree && BoolHolder.Instance.PersThree && BoolHolder.Instance.HobbyThree == true)
            {
                BF27.SetActive(true);
                AudioManager.Instance.PlayVoice(AudioManager.Instance.BFDialogue1);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CauldronSound.Play();
            print("PlayerEntered");
            StartCoroutine("PlayAnimation");
            
        }
    }

    IEnumerator PlayAnimation()
    {
        yield return new WaitForSeconds(1);
        ExplosionAnimation.SetActive(true);
        Explosion.Play();
        StartCoroutine("SpawnBoyfriend");
    }

    IEnumerator SpawnBoyfriend()
    {
        yield return new WaitForSeconds(1);
        bfSpawnable = true;
        BFBeingDisgusting.Play();
    }

}
