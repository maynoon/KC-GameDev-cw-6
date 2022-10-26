
using UnityEngine;

public class playercolision : MonoBehaviour
{

    public player movement;
    
    private void OnCollisionEnter (Collision collisioninfo)
    {
        

        if(collisioninfo.collider.tag == "obstacle")
        {


            movement.enabled = false;   
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
