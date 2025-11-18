using UnityEngine;

public class ShootingSystem : MonoBehaviour
{

    //Variables for managing the player's shooting mechanics
    [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletPosition;
    public float bulletSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            FireProjectile();
        }
        
    }

    public void FireProjectile()
    {
        //Allows the player to fire their bullet projectile towards the cubes
        if (Input.GetButtonDown("Fire1"));
        {
            //Player has clicked the fire button. Fire bullet projectile.
            GameObject bulletProjectile = Instantiate(bullet, bulletPosition.position, bulletPosition.rotation);
            Rigidbody bulletRB = bulletProjectile.GetComponent<Rigidbody>();
            bulletRB.AddForce(bulletRB.transform.forward * bulletSpeed, ForceMode.Acceleration);
        }
    }
}
