using UnityEngine;

public class ShooterBullet : Shooter
{

    public Transform bulletSpawnPoint;

    public GameObject bulletPrefab;

    public override void Shoot()
    {
        if (bulletPrefab != null && bulletSpawnPoint != null)
        {
            Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        }
        
    }
   
    public override void Start()
    {

    }

    // Update is called once per frame
    public override void Update()
    {

    }

   
}

