using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// VR 互動物件
/// </summary>


public class VRInteractionObject : MonoBehaviour
{
    [Header("事件:看到、離開與點擊"), Space(10)]
    public UnityEvent onEnter;
    public UnityEvent onExit;
    public UnityEvent onClick;


    public void OnPointerEnter()
    {
        print("注視點看到");
        onEnter.Invoke();
    }

    public void OnPointerExit()
    {
        print("注視點離開");
        onExit.Invoke();
    }

    public void OnPointerClick()
    {
        print("注視點點擊");
        onClick.Invoke();
    }
}
