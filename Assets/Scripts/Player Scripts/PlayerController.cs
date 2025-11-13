using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Variables for the player's movement
    public float playerXMovement;
    public float playerYMovement;
    public float playerSpeed;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    public void PlayerMovement()
    {
        float xPlayerMovement = Input.GetAxis("Horizontal");
        float yPlayerMovement = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(xPlayerMovement, 0f, yPlayerMovement);
        transform.Translate(playerMovement * playerSpeed * Time.deltaTime);
    }
}
