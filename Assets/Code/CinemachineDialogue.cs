using Unity.Cinemachine;
using UnityEngine;

public class CinemachineDialogue : MonoBehaviour
{
    public CinemachineCamera cineCamera;
    public Vector3 targetOffset = new Vector3(0, 2, -10);
    public float smoothSpeed = 5f;

    private CinemachineFollow followComponent;
    private Vector3 originalOffset;
    private Vector3 currentGoalOffset;

    public PlayerMovement playerMovement;
    public GameObject textBox;

    void Start()
    {
        followComponent = cineCamera.GetComponent<CinemachineFollow>();

        if (followComponent != null)
        {
            originalOffset = followComponent.FollowOffset;
            currentGoalOffset = originalOffset;
        }
    }

    void Update()
    {
        if (followComponent != null)
        {
            followComponent.FollowOffset = Vector3.Lerp(
                followComponent.FollowOffset,
                currentGoalOffset,
                smoothSpeed * Time.deltaTime
            );
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && playerMovement.isInteracting)
        {
            currentGoalOffset = targetOffset;
            playerMovement.enabled = false;
            textBox.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            currentGoalOffset = originalOffset;
        }
    }
}
