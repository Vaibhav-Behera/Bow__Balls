using UnityEngine;
using UnityEngine.UI;

public class TimeLeft : MonoBehaviour
{
    [SerializeField] public float timerDuration = 10f;
    private float timerStartTime = 1f;
    private Text timerText;
    public static float remainingTime = 1f;

    private void Start()
    {
        timerStartTime = Time.time + 1f;
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
            timerText.text = " 0";
            // Timer has elapsed, do something
        }
    }
    public void ResetTimer()
    {
        timerStartTime = Time.time + 1f;
    }
}

