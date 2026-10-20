using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public PlayerController playerController;
    public List<Obstacle> obstacleList;

    public int score;

    public TMPro.TMP_Text text;

    private void Awake()
    {
        obstacleList = new List<Obstacle>();

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(obstacleList != null)
        {
            if (obstacleList.Count <= 0 && playerController != null)
            {
                if (playerController.pawn != null)
                {
                    Debug.Log("Victory!");
                }
            }
        }   
        if (playerController != null)
        {
            if (playerController.pawn == null)
            {
                Debug.Log("Failure");
            }
        }
        if (text != null)
        {
            text.text = "Score: " + score;
        }
       
    }
}
