using UnityEngine;

public class BoolHolder : MonoBehaviour
{
    public static BoolHolder Instance;

    public bool door1;
    public bool door2;
    public bool door3;
    public bool door4;

    public bool BarberOne;
    public bool BarberTwo;
    public bool BarberThree;

    public bool BodyOne;
    public bool BodyTwo;
    public bool BodyThree;

    public bool PersOne;
    public bool PersTwo;
    public bool PersThree;

    public bool HobbyOne;
    public bool HobbyTwo;
    public bool HobbyThree;

    public Vector2 tempPos;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
