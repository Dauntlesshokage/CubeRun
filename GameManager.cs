
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text canvastext;
    public TMP_Text scoretext;
    public TMP_Text score;
    bool gameHasEnded=false;
    public float restartDelay=2f;
    public GameObject completelevelUI;
    public void Completelevel1()
    {
        completelevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gameHasEnded==false)
        {
            gameHasEnded=true;
            Debug.Log("Game Over");
            canvastext.text="Game Over";
            score.text="";
            scoretext.text="";
            Invoke("Restart",restartDelay);
           
             
           
        }
        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}
