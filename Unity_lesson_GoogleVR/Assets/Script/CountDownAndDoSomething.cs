using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class CountDownAndDoSomething : MonoBehaviour
{
    [Header("�˼Ʈɶ�"), Range(1, 5)]
    public float countdowntime = 3;
    [Header("�˼ƫ�ƥ�")]
    public UnityEvent onTimeUp;
    [Header("����")]
    public Image imgBar;

    private float timeMax;
    public bool startCountDown { get; set; }

    private void Awake()
    {
        timeMax = countdowntime;
    }

    private void Update()
    {
        CountDown();
    }
    private float timer;

    private void CountDown()
    {
        if (startCountDown) {
            if (timer < countdowntime) {
                timer += Time.deltaTime;
            }
            else {
                onTimeUp.Invoke();
            }

            imgBar.fillAmount = timer / timeMax;
        }
        else {
            timer = 0;
            imgBar.fillAmount = 0;
        }
    }
}
