using UnityEngine;

public class MonitorButtonScript : MonoBehaviour
{
    public GameObject monitor;

    public void MonitorToggle() 
    {
        monitor.SetActive(!monitor.activeSelf);
    }
}
