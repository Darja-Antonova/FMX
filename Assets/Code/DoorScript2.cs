using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DoorScript2 : MonoBehaviour
{
    public GameObject FadeIn;

    public PlayerMovement playerMovement;

    public bool door2 = false;
    public DoorScript door;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && playerMovement.isInteracting && door2 == false && door.door1 == true)
        {
            playerMovement.enabled = false;
            FadeIn.SetActive(true);
            StartCoroutine("LoadShop");
        }
    }

    IEnumerator LoadShop()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(3);
    }

}
