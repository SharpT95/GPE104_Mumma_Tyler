using UnityEngine;

public class DeathPawn : Death
{
    private Controller controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Die()
    {
        if (controller != null)
        {
            controller.pawn = null;
        }
        Destroy(gameObject);
    }

    public override void Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {
        
    }
}
