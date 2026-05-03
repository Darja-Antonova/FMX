using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectCollect : MonoBehaviour
{

    public GameObject Buttons;
    public GameObject ItemOne;
    public GameObject ItemTwo;
    public GameObject ItemThree;
    public void FirstObject2()
    {
        BoolHolder.Instance.BodyOne = true;
        ItemOne.SetActive(false);
        Buttons.SetActive(false);
        StartCoroutine("ExitShop2");
    }

    public void SecondObject2()
    {
        BoolHolder.Instance.BodyTwo = true;
        ItemTwo.SetActive(false);
        Buttons.SetActive(false);
        StartCoroutine("ExitShop2");
    }

    public void ThirdObject2()
    {
        BoolHolder.Instance.BodyThree = true;
        ItemThree.SetActive(false);
        Buttons.SetActive(false);
        StartCoroutine("ExitShop2");
    }

    IEnumerator ExitShop2()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }

    public void FirstObject3()
    {
        BoolHolder.Instance.PersOne = true;
        ItemOne.SetActive(false);
        Buttons.SetActive(false);
        StartCoroutine("ExitShop3");
    }

    public void SecondObject3()
    {
        BoolHolder.Instance.PersTwo = true;
        ItemTwo.SetActive(false);
        Buttons.SetActive(false);
        StartCoroutine("ExitShop3");
    }

    public void ThirdObject3()
    {
        BoolHolder.Instance.PersThree = true;
        ItemThree.SetActive(false);
        Buttons.SetActive(false);
        StartCoroutine("ExitShop3");
    }

    IEnumerator ExitShop3()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }

    public void FirstObject4()
    {
        BoolHolder.Instance.HobbyOne = true;
        ItemOne.SetActive(false);
        Buttons.SetActive(false);
        StartCoroutine("ExitShop4");
    }

    public void SecondObject4()
    {
        BoolHolder.Instance.HobbyTwo = true;
        ItemTwo.SetActive(false);
        Buttons.SetActive(false);
        StartCoroutine("ExitShop4");
    }

    public void ThirdObject4()
    {
        BoolHolder.Instance.HobbyThree = true;
        ItemThree.SetActive(false);
        Buttons.SetActive(false);
        StartCoroutine("ExitShop4");
    }

    IEnumerator ExitShop4()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
