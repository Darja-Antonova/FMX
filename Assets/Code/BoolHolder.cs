using UnityEngine;

public class BoolHolder : MonoBehaviour
{
    public static BoolHolder Instance;

    public bool door1;
    public bool door2;
    public bool door3;
    public bool door4;

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
