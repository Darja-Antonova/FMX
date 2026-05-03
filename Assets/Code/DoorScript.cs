using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public GameObject FadeIn;

    public PlayerMovement playerMovement;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && playerMovement.isInteracting && BoolHolder.Instance.door1 == false)
        {
            playerMovement.enabled = false;
            FadeIn.SetActive(true);
            StartCoroutine("LoadShop");
            BoolHolder.Instance.door1 = true;
        }
    }

    IEnumerator LoadShop()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
    }
}
