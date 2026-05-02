using UnityEngine;

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
    }

    public void SecondObject()
    {
        BarberTwo = true;
        ItemTwo.SetActive(false);
        Buttons.SetActive(false);
    }

    public void ThirdObject()
    {
        BarberThree = true;
        ItemThree.SetActive(false);
        Buttons.SetActive(false);
    }
}
