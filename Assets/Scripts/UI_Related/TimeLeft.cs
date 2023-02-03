using UnityEngine;
using UnityEngine.UI;

public class TimeLeft : MonoBehaviour
{
    [SerializeField] public float timerDuration = 5.0f;
    private float timerStartTime;
    private Text timerText;
    public static float remainingTime;

    private void Start()
    {
        timerStartTime = Time.time;
        timerText = GetComponent<Text>();
    }

    private void Update()
    {
        float elapsedTime = Time.time - timerStartTime;
        remainingTime = timerDuration - elapsedTime;
        int remainingTimeInt = Mathf.RoundToInt(remainingTime);
        timerText.text = remainingTimeInt.ToString();

        if (remainingTime <= 0)
        {
            timerText.text = "0.00";
            // Timer has elapsed, do something
        }
    }
}

