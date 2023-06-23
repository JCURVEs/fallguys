using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newCountDown : MonoBehaviour
{
    public Text countdownText;
    public float countdownDuration = 1f;
    public float scaleMultiplier = 2f;
    public float rotationSpeed = 100f;

    private int currentNumber = 3;
    private float countdownTimer;
    private Vector3 originalScale;
    private Quaternion originalRotation;

    private void Start()
    {
        countdownTimer = countdownDuration;
        originalScale = countdownText.transform.localScale;
        originalRotation = countdownText.transform.rotation;
        UpdateCountdownText();
    }

    private void Update()
    {
        countdownTimer -= Time.deltaTime;

        if (countdownTimer <= 0f)
        {
            currentNumber--;
            countdownTimer = countdownDuration;

            if (currentNumber <= 0)
            {
                // Countdown completed, do something
                Debug.Log("Countdown finished!");
                Destroy(gameObject);
            }
            else
            {
                // Reset scale and rotation
                countdownText.transform.localScale = originalScale;
                countdownText.transform.rotation = originalRotation;
                UpdateCountdownText();
            }
        }

        // Scale and rotate the countdown text
        float scale = 1f + (1f - countdownTimer / countdownDuration) * scaleMultiplier;
        countdownText.transform.localScale = new Vector3(scale, scale, 1f);

        float rotation = countdownTimer / countdownDuration * rotationSpeed;
        countdownText.transform.rotation = Quaternion.Euler(0f, 0f, rotation);
    }

    private void UpdateCountdownText()
    {
        countdownText.text = currentNumber.ToString();
    }
}
