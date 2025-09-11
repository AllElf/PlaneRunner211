using UnityEngine;
using UnityEngine.UI;

public class TriggerPlane : MonoBehaviour
{
    [SerializeField] bool paused;
    [SerializeField] int countStars;
    [SerializeField] Text textStars;
    [SerializeField] Text gameOverText;
    [SerializeField] GameObject buttonRestart;

    private void Start()
    {
        paused = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag != "Stars")
        {
            Debug.Log("Столкнулся");
            paused = true;
        }
        else if(other.tag == "Stars")
        {
            countStars++;
            textStars.text = $"Stars {countStars}";
            Destroy(other.gameObject);
        }
    }

    private void Update()
    {
        if (paused)
        {
            Time.timeScale = 0.0f;
            if(gameOverText != null) { gameOverText.text = "GAME OVER"; }
            if (buttonRestart != null) { buttonRestart.SetActive(true); }
        }
        else if(!paused)
        {
            Time.timeScale = 1.0f;
            if (gameOverText != null) { gameOverText.text = ""; }
            if (buttonRestart != null) { buttonRestart.SetActive(false); }
        }
    }
}
