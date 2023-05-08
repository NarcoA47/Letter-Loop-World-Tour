using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour
{
    public Slider slider;
    public Text LoopNumberTxt;
    public int LoopNumber;
    public float sliderValue;
    public float fillTime = 1.0f;

    private float fillSpeed;
    private int fillCount;

    private void Start()
    {
        fillCount = 0;
        slider.value = sliderValue - 0.2f;
        fillSpeed = sliderValue / fillTime;
        FillSlider();
    }

    public void FillSlider()
    {
        fillCount++;

        if (fillCount <= 4)
        {
            StartCoroutine(FillSliderCoroutine(() =>
            {
                SetLoopNumber();
            }));

        }
    }

    private IEnumerator FillSliderCoroutine(System.Action onFillComplete)
    {
        float currentValue = slider.value;
        float targetValue = fillCount * sliderValue;
        float t = 0f;

        while (t < 1.0f)
        {
            t += Time.deltaTime * fillSpeed;
            slider.value = Mathf.Lerp(currentValue, targetValue, t);
            yield return null;
        }

        onFillComplete?.Invoke();
    }

    private void SetLoopNumber()
    {
        LoopNumberTxt.text = "" + LoopNumber;
    }

}
