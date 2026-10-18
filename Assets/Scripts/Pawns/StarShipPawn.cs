using UnityEngine;

public class StarShipPawn : Pawn
{
    public float minX;
    public float maxX;

    public float minY;
    public float maxY;

    public Transform tf;

    public float normalSpeed;

    public float turboSpeed;

    public float normalRotationSpeed;

    public float turboRotationSpeed;

    private Shooter sh;

    public override void MoveForwardLocal()
    {
        tf.position = tf.position + tf.up * normalSpeed * Time.deltaTime;
    }
    public override void MoveBackwardLocal()
    {
        tf.position = tf.position + tf.up * -normalSpeed * Time.deltaTime;
    }
    public override void RotateClockwise()
    {
        tf.Rotate(0, 0, normalRotationSpeed * -Time.deltaTime);
    }
    public override void RotateCounterClockwise()
    {
        tf.Rotate(0, 0, normalRotationSpeed * Time.deltaTime);
    }
    public override void MoveForwardLocalTurbo()
    {
        tf.position = tf.position + tf.up * turboSpeed * Time.deltaTime;
    }
    public override void MoveBackwardLocalTurbo()
    {
        tf.position = tf.position + tf.up * -turboSpeed * Time.deltaTime;
    }
    public override void RotateClockwiseTurbo()
    {
        tf.Rotate(0, 0, turboRotationSpeed * -Time.deltaTime);
    }
    public override void RotateCounterClockwiseTurbo()
    {
        tf.Rotate(0, 0, turboRotationSpeed * Time.deltaTime);
    }
    public override void MoveForwardWorld()
    {
        tf.position = tf.position + Vector3.up;
    }
    public override void MoveBackwardWorld()
    {
        tf.position = tf.position + Vector3.down;
    }
    public override void MoveRightWorld()
    {
        tf.position = tf.position + Vector3.right;
    }
    public override void MoveLeftWorld()
    {
        tf.position = tf.position + Vector3.left;
    }

    public override void Teleport()
    {
        tf.position = new Vector3(Random.Range(minX,maxX),Random.Range(minY,maxY));
    }

    public override void Shoot()
    {
        if (sh != null)
        {
            sh.Shoot();
        }
    }   

    public override void Start()
    {
        tf = GetComponent<Transform>();
        sh = GetComponent<Shooter>();
    }

    public override void Update()
    {
        
    }
}
