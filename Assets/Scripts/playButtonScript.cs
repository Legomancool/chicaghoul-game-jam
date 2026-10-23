using UnityEngine;
using UnityEngine.SceneManagement;

public class playButtonScript : MonoBehaviour
{
    void Start()
    {
        
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("CockPit");
    }
}
