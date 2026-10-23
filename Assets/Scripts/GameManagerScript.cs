using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public float power; 
    public float oxygen; 
    public float temp; 
    public bool isDoingTask = false;
    public bool powerDrain = false;
    public bool oxygenDrain = true;
    public bool shipIsFacingSun = false;
    public bool tempDrain = false;

    private float timer = 0f;

    void Start()
    {
        power = 80f;
        oxygen = 80f;
        temp = 25f;
    }

    void FixedUpdate() 
    { 
        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();

        timer += Time.deltaTime; 

        if (power <= 0f) { SceneManager.LoadScene("End"); } 
        if (oxygen <= 0f) { SceneManager.LoadScene("End"); } 
        if (temp >= 100f) { SceneManager.LoadScene("End"); } 

        if (timer >= 0.1f) 
        { 
            timer -= 0.1f; 

            // power
            if (shipIsFacingSun && power < 100f) power += 0.1f; 
            else if (isDoingTask) power -= 0.1f; 

            // oxygen
            if (oxygenDrain && oxygen > 0f) oxygen -= 0.1f; 
            else if (oxygen < 100f) oxygen += 0.1f; 

            // temperature
            if (shipIsFacingSun) temp += 0.1f; 
            else if (tempDrain || temp > 50f) temp -= 0.1f; 

            if (tempDrain && temp > 50f) temp -= 0.2f; 

            power = (float)System.Math.Round(power, 1);
            oxygen = (float)System.Math.Round(oxygen, 1);
            temp = (float)System.Math.Round(temp, 1);
        } 
    } 

        public void ToggleShipState()
    {
        shipIsFacingSun = !shipIsFacingSun;
    }
}
