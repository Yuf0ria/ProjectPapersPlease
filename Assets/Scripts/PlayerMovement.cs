using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed, groundDis;
    public LayerMask groundLayer;
    public Rigidbody rb;
    public SpriteRenderer sr;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 raycastPos = transform.position;
        raycastPos.y += 1;
        if (Physics.Raycast(raycastPos, -transform.up, out hit, Mathf.Infinity, groundLayer))
        {
            if (hit.collider != null)
            {
                Vector3 movePos = transform.position;
                movePos.y = hit.point.y + groundDis;
                transform.position = movePos;
            }
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(x, 0, z);
        rb.linearVelocity = movement * speed;
        
        if(x != 0 && x < 0)
            sr.flipX = true;
        else if (x != 0 && x > 0)
            sr.flipX = false;
        
    }
}
