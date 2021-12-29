using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class CountDownAndDoSomething : MonoBehaviour
{
    [Header("倒數時間"), Range(1, 5)]
    public float countdowntime = 3;
    [Header("倒數後事件")]
    public UnityEvent onTimeUp;
    [Header("介面")]
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
