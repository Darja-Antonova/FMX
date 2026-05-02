using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DoorScript3 : MonoBehaviour
{
    public GameObject FadeIn;

    public PlayerMovement playerMovement;

    public bool door3 = false;
    public DoorScript2 door;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && playerMovement.isInteracting && door3 == false && door.door2 == true)
        {
            playerMovement.enabled = false;
            FadeIn.SetActive(true);
            StartCoroutine("LoadShop");
        }
    }

    IEnumerator LoadShop()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(4);
    }

}
