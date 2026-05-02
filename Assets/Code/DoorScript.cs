using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public GameObject FadeIn;
    public PlayerMovement playerMovement;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && playerMovement.isInteracting)
        {
            FadeIn.SetActive(true);
            StartCoroutine("LoadShop1");
        }
    }

    IEnumerator LoadShop1()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
    }
}
