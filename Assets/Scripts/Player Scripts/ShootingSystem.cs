using UnityEngine;

public class ShootingSystem : MonoBehaviour
{

    //Variables for managing the player's shooting mechanics
    [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletPosition;
    public float bulletSpeed;

    //Variables for switching the player's ammo types during the game
    public bool hasSwitchedAmmo;
    public bool hasFireBulletsEquipped;
    public bool hasIceBulletEquipped;
    public bool hasDarkBulletsEquipped;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hasSwitchedAmmo = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            FireProjectile();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            SwitchAmmo();
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
            bulletRB.AddForce(bulletRB.transform.forward * bulletSpeed, ForceMode.Force);
            Destroy(bulletProjectile, 0.8f);
        }
    }

    public void SwitchAmmo()
    {
        //Allows the player to switch their ammo type during the game
        //Certain ammos are needed to hit specific targets in the later level to gain points
        if (Input.GetButtonDown("Fire2"))
        {
            Debug.Log("Player has switched ammo types!");
            hasSwitchedAmmo = true;
        }
    }
}
