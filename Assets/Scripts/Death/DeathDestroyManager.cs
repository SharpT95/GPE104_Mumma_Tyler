using UnityEngine;

public class DeathDestroyManager : Death
{
    
    private Obstacle obstacleToRemoveOnDeath;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Die()
    {
        if (GameManager.instance != null)
        {
           
           
           
            if (GameManager.instance.obstacleList != null && obstacleToRemoveOnDeath != null)
            {
                GameManager.instance.obstacleList.Remove(obstacleToRemoveOnDeath);
            }

                
            
            
             
            
        }
    }

    // Update is called once per frame
    public override void Start()
    {
        obstacleToRemoveOnDeath = GetComponent<Obstacle>();
    }

    public override void Update()
    {
        
    }
}
