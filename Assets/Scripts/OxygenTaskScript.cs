using UnityEngine;
using UnityEngine.EventSystems;

public class OxygenTaskScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
    private GameManagerScript gameManager;

    void Start()
    {
        gameManager = GameObject.FindWithTag("GameController").GetComponent<GameManagerScript>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("increasing oxygen");
        gameManager.oxygenDrain = false;
        gameManager.isDoingTask = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("draining oxygen");
        gameManager.oxygenDrain = true;
        gameManager.isDoingTask = false;
    }

    // Optional: Reset bool if the pointer exits the button while held
    public void OnPointerExit(PointerEventData eventData)
    {
        gameManager.oxygenDrain = true;
        gameManager.isDoingTask = false;
    }
}