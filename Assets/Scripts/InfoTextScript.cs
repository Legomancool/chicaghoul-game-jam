using UnityEngine;
using TMPro; 

public class InfoTextScript : MonoBehaviour
{
    private GameManagerScript gameManager;
    private TextMeshProUGUI textMeshProUGUI;

    void Start()
    {
        gameManager = GameObject.FindWithTag("GameController").GetComponent<GameManagerScript>();
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = "power: " + gameManager.power + "\noxygen: " + gameManager.oxygen + "\ntemp: " + gameManager.temp;
    }
}