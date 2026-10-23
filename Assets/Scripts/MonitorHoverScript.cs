using UnityEngine;
using UnityEngine.EventSystems;

public class MonitorHoverScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public RectTransform monitorRectTransform;
    
    [SerializeField] private bool isHovered = false;
    public bool IsHovered => isHovered;

    public void OnPointerEnter(PointerEventData eventData)
    {
        isHovered = !isHovered;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
    }

    void FixedUpdate() 
    {
        if (isHovered) 
        {
            monitorRectTransform.anchoredPosition = new Vector2(monitorRectTransform.anchoredPosition.x, 40f); 
        }
        else 
        {
            monitorRectTransform.anchoredPosition = new Vector2(monitorRectTransform.anchoredPosition.x, 340f); 
        }
    }
}
