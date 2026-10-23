using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter( Collision collision )
    {
        if (collision.collider.tag == "Paper")
        {
            Debug.Log("is paper");
            //remove obj
            Destroy(collision.gameObject);
        }
        if (collision.collider.tag == "Student")
            Debug.Log("boom paper +1");
    }
}
