
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playermovement Movement;
    public GameManager gameManager;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "rintangan")
        {
            Movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
}
