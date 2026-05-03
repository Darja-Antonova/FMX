using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DoorScript2 : MonoBehaviour
{
    public GameObject FadeIn;

    public PlayerMovement playerMovement;

    public DoorScript door;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && playerMovement.isInteracting && BoolHolder.Instance.door2 == false && BoolHolder.Instance.door1 == true)
        {
            playerMovement.enabled = false;
            FadeIn.SetActive(true);
            StartCoroutine("LoadShop");
            BoolHolder.Instance.door2 = true;
        }
    }

    IEnumerator LoadShop()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(3);
    }

}
