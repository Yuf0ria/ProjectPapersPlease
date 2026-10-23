using UnityEngine;

public class RunStudentLoiter : MonoBehaviour
{
    public Transform[] runAtPoints;
    public int targetPoint;
    public float studentSpeed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetPoint = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == runAtPoints[targetPoint].position)
        {
            NextTargetPoint();
        }
        transform.position = Vector3.MoveTowards(transform.position, runAtPoints[targetPoint].position,studentSpeed * Time.deltaTime);
    }

    void NextTargetPoint()
    {
        targetPoint++;
        if (targetPoint >= runAtPoints.Length)
        {
            targetPoint = 0;
        }
    }
    
    
}
