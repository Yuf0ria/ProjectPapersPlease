using UnityEngine;

public class StudentLoiterCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // if (collision.collider.tag == "Chair")
        // {
        //     Debug.Log("obj is chair");
        //     //player moves 'chair' 
        //     Vector3 moveChair = collision.transform.position - transform.position;
        //     double ogPos = 0.08;
        //     moveChair.y = (float)ogPos;
        //     collision.transform.position = moveChair;
        //     float forceMagnitude = 1f;
        //     collision.gameObject.GetComponent<Rigidbody>().AddForce(-moveChair * forceMagnitude);
        //
        // }
    }
}
