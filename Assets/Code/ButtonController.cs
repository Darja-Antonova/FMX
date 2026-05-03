using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;

    public InputAction EnterAction;

    void OnEnable()
    {
        EnterAction.Enable();
    }

    void OnDisable()
    {
        EnterAction.Disable();
    }


    private void Update()
    {
        GameObject selected = EventSystem.current.currentSelectedGameObject;

        if (EnterAction.WasPressedThisFrame() && selected == button1.gameObject)
        {
            button1.onClick.Invoke();
        }
        else if (EnterAction.WasPressedThisFrame() && selected == button2.gameObject)
        {
            button2.onClick.Invoke();
        }
        else if (EnterAction.WasPressedThisFrame() && selected == button3.gameObject)
        {
            button3.onClick.Invoke();
        }
    }
}
