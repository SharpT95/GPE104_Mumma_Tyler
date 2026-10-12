using UnityEngine;

public class PlayerController : Controller
{
    public KeyCode teleportKey;

    public KeyCode moveForwardLocal;

    public KeyCode moveBackwardLocal;

    public KeyCode rotateClockwise;

    public KeyCode rotateCounterClockwise;

    public KeyCode moveForwardWorld;

    public KeyCode moveBackwardWorld;

    public KeyCode moveRightWorld;

    public KeyCode moveLeftWorld;

    public KeyCode turboBoost1;

    public KeyCode turboBoost2;

    public KeyCode quitKey;
    public override void MakeDecisions()
    {
        //Turbos
        if (Input.GetKey(turboBoost1) || Input.GetKey(turboBoost2))
        {
           //Faster Movement
        
            if (Input.GetKey(moveForwardLocal))
            {
                pawn.MoveForwardLocalTurbo();
            }
         
            if (Input.GetKey(moveBackwardLocal))
            {
                pawn.MoveBackwardLocalTurbo();
            }
            if (Input.GetKey(rotateClockwise))
            {
                pawn.RotateClockwiseTurbo();
            }
            if (Input.GetKey(rotateCounterClockwise))
            {
                pawn.RotateCounterClockwiseTurbo();
            }
        }
        else
        {
            //Normal Movement
            if (Input.GetKey(moveForwardLocal))
            {
                pawn.MoveForwardLocal();
            }
            if (Input.GetKey(moveBackwardLocal))
            {
                pawn.MoveBackwardLocal();
            }
            if (Input.GetKey(rotateClockwise))
            {
                pawn.RotateClockwise();
            }
            if (Input.GetKey(rotateCounterClockwise))
            {
                pawn.RotateCounterClockwise();
            }
        }
        //World Space Movement
        if (Input.GetKeyDown(moveForwardWorld))
        {
            pawn.MoveForwardWorld();
        }
        if (Input.GetKeyDown(moveBackwardWorld))
        {
            pawn.MoveBackwardWorld();
        }
        if (Input.GetKeyDown(moveRightWorld))
        {
            pawn.MoveRightWorld();
        }
        if (Input.GetKeyDown(moveLeftWorld))
        {
            pawn.MoveLeftWorld();
        }

        //Teleportation
        if (Input.GetKeyDown(teleportKey))
        {
            pawn.Teleport();
        }

        if (Input.GetKeyDown(quitKey))
        {
            Application.Quit();
        }
    }
    public override void Start()
    {
    
    }

    public override void Update()
    {
        MakeDecisions();
    }

}