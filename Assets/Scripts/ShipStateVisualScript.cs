using UnityEngine;
using TMPro; 

public class ShipStateVisualScript : MonoBehaviour
{
    private GameManagerScript gameManager;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        gameManager = GameObject.FindWithTag("GameController").GetComponent<GameManagerScript>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        spriteRenderer.enabled = gameManager.shipIsFacingSun;
    }
}
