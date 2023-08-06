using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    
    // This is a variable to reference a PlayerMovement script, to turn off when collides
    public PlayerMovement movement;

    void OnCollisionEnter (Collision collisionInfo) {
        
        if (collisionInfo.collider.tag == "Obstacle") {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
