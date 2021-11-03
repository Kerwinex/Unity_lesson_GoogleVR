using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// VR ���ʪ���
/// </summary>


public class VRInteractionObject : MonoBehaviour
{
    [Header("�ƥ�:�ݨ�B���}�P�I��"), Space(10)]
    public UnityEvent onEnter;
    public UnityEvent onExit;
    public UnityEvent onClick;


    public void OnPointerEnter()
    {
        print("�`���I�ݨ�");
        onEnter.Invoke();
    }

    public void OnPointerExit()
    {
        print("�`���I���}");
        onExit.Invoke();
    }

    public void OnPointerClick()
    {
        print("�`���I�I��");
        onClick.Invoke();
    }
}
