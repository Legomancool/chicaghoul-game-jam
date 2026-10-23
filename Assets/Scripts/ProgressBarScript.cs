using UnityEngine;
using UnityEngine.UI;

public class ProgressBarScript : MonoBehaviour
{
    private GameManagerScript gameManager;

    [Header("UI Reference")]
    public Image fillImage;

    [Header("Progress Data (0 to 100)")]
    public float currentFill = 0f;
    public float maxProgress = 100f;
    public bool isPower = false;
    public bool isOxygen = false;
    public bool isTemp = false;

    void Start()
    {
        gameManager = GameObject.FindWithTag("GameController").GetComponent<GameManagerScript>();
    }

    void Update()
    {
        if (isPower) currentFill = gameManager.power;
        if (isOxygen) currentFill = gameManager.oxygen;
        if (isTemp) currentFill = gameManager.temp;
        float clampedValue = Mathf.Clamp(currentFill, 0f, maxProgress);
        fillImage.fillAmount = clampedValue / maxProgress;
    }
}