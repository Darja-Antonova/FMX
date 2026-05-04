using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ObjectCollect : MonoBehaviour
{

    public GameObject Buttons;
    public GameObject ItemOne;
    public GameObject ItemTwo;
    public GameObject ItemThree;
    public Animator animator;
    public GameObject FadeIn;
    public GameObject FadeOut;

    public Image imageOne;
    public Image imageTwo;
    public Image imageThree;

    private void Start()
    {
        FadeOut.SetActive(true);
        imageOne = ItemOne.GetComponent<Image>();
        imageTwo = ItemTwo.GetComponent<Image>();
        imageThree = ItemThree.GetComponent<Image>();
    }

    public void FirstObject2()
    {
        BoolHolder.Instance.BodyOne = true;

        if (animator != null)
        {
            animator.SetBool("BodyOne", BoolHolder.Instance.BodyOne);
        }

        imageOne.color = new Color32(255,255,225,100);
        //Buttons.SetActive(false);
        StartCoroutine("ExitShop2");
    }

    public void SecondObject2()
    {
        BoolHolder.Instance.BodyTwo = true;

        if (animator != null)
        {
            animator.SetBool("BodyTwo", BoolHolder.Instance.BodyTwo);
        }

        imageTwo.color = new Color32(255, 255, 225, 100);
        //Buttons.SetActive(false);
        StartCoroutine("ExitShop2");
    }

    public void ThirdObject2()
    {
        BoolHolder.Instance.BodyThree = true;

        if (animator != null)
        {
            animator.SetBool("BodyThree", BoolHolder.Instance.BodyThree);
        }

        imageThree.color = new Color32(255, 255, 225, 100);
        //Buttons.SetActive(false);
        StartCoroutine("ExitShop2");
    }

    IEnumerator ExitShop2()
    {
        yield return new WaitForSeconds(2);
        FadeIn.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }

    public void FirstObject3()
    {
        BoolHolder.Instance.PersOne = true;

        if (animator != null)
        {
            animator.SetBool("PersOne", BoolHolder.Instance.PersOne);
        }

        imageOne.color = new Color32(255, 255, 225, 100);
        Buttons.SetActive(false);
        StartCoroutine("ExitShop3");
    }

    public void SecondObject3()
    {
        BoolHolder.Instance.PersTwo = true;

        if (animator != null)
        {
            animator.SetBool("PersTwo", BoolHolder.Instance.PersTwo);
        }

        imageTwo.color = new Color32(255, 255, 225, 100);
        //Buttons.SetActive(false);
        StartCoroutine("ExitShop3");
    }

    public void ThirdObject3()
    {
        BoolHolder.Instance.PersThree = true;

        if (animator != null)
        {
            animator.SetBool("PersThree", BoolHolder.Instance.PersThree);
        }

        imageThree.color = new Color32(255, 255, 225, 100);
        Buttons.SetActive(false);
        StartCoroutine("ExitShop3");
    }

    IEnumerator ExitShop3()
    {
        yield return new WaitForSeconds(2);
        FadeIn.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }

    public void FirstObject4()
    {
        BoolHolder.Instance.HobbyOne = true;

        if (animator != null)
        {
            animator.SetBool("HobbyOne", BoolHolder.Instance.HobbyOne);
        }

        imageOne.color = new Color32(255, 255, 225, 100);
        Buttons.SetActive(false);
        StartCoroutine("ExitShop4");
    }

    public void SecondObject4()
    {
        BoolHolder.Instance.HobbyTwo = true;


        if (animator != null)
        {
            animator.SetBool("HobbyTwo", BoolHolder.Instance.HobbyTwo);
        }

        imageTwo.color = new Color32(255, 255, 225, 100);
        Buttons.SetActive(false);
        StartCoroutine("ExitShop4");
    }

    public void ThirdObject4()
    {
        BoolHolder.Instance.HobbyThree = true;

        if (animator != null)
        {
            animator.SetBool("HobbyThree", BoolHolder.Instance.HobbyThree);
        }

        imageThree.color = new Color32(255, 255, 225, 100);
        Buttons.SetActive(false);
        StartCoroutine("ExitShop4");
    }

    IEnumerator ExitShop4()
    {
        yield return new WaitForSeconds(2);
        FadeIn.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
