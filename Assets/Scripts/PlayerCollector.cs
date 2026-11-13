using UnityEngine;
using TMPro;
public class PlayerCollector : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public RigidBodyPlayer playerScript;
    private int CollectedItems = 0;
    private int totalitems = 0;
    void Start()
    {
        totalitems = GameObject.FindGameObjectsWithTag("Item").Length;
    }

    void Update()
    {

    }
    private void UpdateScore()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + CollectedItems + "/" + totalitems;
        }
    }
    
}

