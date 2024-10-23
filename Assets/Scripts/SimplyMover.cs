using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplyMover : MonoBehaviour
{
    public Vector3 startPos;
    public Vector3 endPos;
    Vector2 target;
    Vector3 targetPosA;
    Vector3 targetPosB;

    public float speed = 3;
    //public int damage;

    // Start is called before the first frame update
    void Start()
    {
        //startPos = transform.position;
        targetPosA = transform.position + endPos;
        targetPosB = transform.position + startPos;
        target = targetPosA;
    }

    void OnDrawGizmosSelected()
    {
        // Draw a yellow cube at the transform position
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position + startPos, new Vector3(1, 1, 1));
        Gizmos.DrawWireCube(transform.position + endPos, new Vector3(1, 1, 1));
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = transform.position;

        if (currentPos == targetPosA)
        {
            target = targetPosB;
        }
        else if (currentPos == targetPosB)
        {
            target = targetPosA;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
