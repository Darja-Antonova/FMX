using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DoorScript4 : MonoBehaviour
{
    public GameObject FadeIn;

    public PlayerMovement playerMovement;

    public DoorScript3 door;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && playerMovement.isInteracting && BoolHolder.Instance.door4 == false && BoolHolder.Instance.door3 == true)
        {
            playerMovement.enabled = false;
            FadeIn.SetActive(true);
            StartCoroutine("LoadShop");
            BoolHolder.Instance.door4 = true;
        }
    }

    IEnumerator LoadShop()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(5);
    }

}
