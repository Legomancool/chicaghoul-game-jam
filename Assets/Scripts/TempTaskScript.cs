using UnityEngine;
using UnityEngine.EventSystems;

public class TempTaskScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
    private GameManagerScript gameManager;

    void Start()
    {
        gameManager = GameObject.FindWithTag("GameController").GetComponent<GameManagerScript>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("draining temp");
        gameManager.tempDrain = true;
        gameManager.isDoingTask= true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("increasing temp");
        gameManager.tempDrain = false;
        gameManager.isDoingTask = false;
    }

    // Optional: Reset bool if the pointer exits the button while held
    public void OnPointerExit(PointerEventData eventData)
    {
        gameManager.tempDrain = false;
        gameManager.isDoingTask = false;
    }
}