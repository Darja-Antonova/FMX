using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectCollect : MonoBehaviour
{
    public bool BarberOne = false;
    public bool BarberTwo = false;
    public bool BarberThree = false;

    public GameObject Buttons;
    public GameObject ItemOne;
    public GameObject ItemTwo;
    public GameObject ItemThree;

    public void FirstObject()
    {
        BarberOne = true;
        ItemOne.SetActive(false);
        Buttons.SetActive(false);
        StartCoroutine("ExitShop");
    }

    public void SecondObject()
    {
        BarberTwo = true;
        ItemTwo.SetActive(false);
        Buttons.SetActive(false);
        StartCoroutine("ExitShop");
    }

    public void ThirdObject()
    {
        BarberThree = true;
        ItemThree.SetActive(false);
        Buttons.SetActive(false);
        StartCoroutine("ExitShop");
    }

    IEnumerator ExitShop()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
