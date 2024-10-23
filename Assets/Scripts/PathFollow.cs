using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollow : MonoBehaviour
{
    public LineRenderer lr;
    public float speed;
    public bool loop = false;
    bool goBack = false;
    int moveIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 target = lr.GetPosition(moveIndex);
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        float distance = Vector2.Distance(transform.position, target);
        
        if(distance <= 0.05f)
        {
            UpdateMoveIndex();
        }
    }

    void UpdateMoveIndex()
    {
        if (moveIndex == 0)
        {
            goBack = false;
        }

        if (moveIndex == lr.positionCount-1 && !loop)
        {
            goBack = true;
        }
        else if(moveIndex == lr.positionCount - 1 && loop)
        {
            moveIndex = 0;
        }

        if (!goBack)
        {
            moveIndex++;
        }
        else
        {
            moveIndex--;
        }

        

    }
}
