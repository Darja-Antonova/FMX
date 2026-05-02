using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DoorScript4 : MonoBehaviour
{
    public GameObject FadeIn;

    public PlayerMovement playerMovement;

    public bool door4 = false;
    public DoorScript3 door;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && playerMovement.isInteracting && door4 == false && door.door3 == true)
        {
            playerMovement.enabled = false;
            FadeIn.SetActive(true);
            StartCoroutine("LoadShop");
        }
    }

    IEnumerator LoadShop()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(5);
    }

}
