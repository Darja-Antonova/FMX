using UnityEngine;


[System.Serializable]

public class BackgroundElement
{
    public SpriteRenderer backgroundSprite;
    [Range(0,1)] public float scrollSpeed;
    [HideInInspector] public Material spriteMaterial;
}


public class CameraParallax : MonoBehaviour
{

    private const float SCROLL_MULTIPLIER = 0.01f;

    [SerializeField] private BackgroundElement[] backgroundElements;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (BackgroundElement element in backgroundElements)
        {
            element.spriteMaterial = element.backgroundSprite.material;
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach(BackgroundElement element in backgroundElements)
        {
            element.spriteMaterial.mainTextureOffset = new Vector2(transform.position.x * element.scrollSpeed * SCROLL_MULTIPLIER, 0);
        }
    }
}
