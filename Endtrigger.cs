
using UnityEngine;

public class Endtrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.Completelevel1();
    }
}