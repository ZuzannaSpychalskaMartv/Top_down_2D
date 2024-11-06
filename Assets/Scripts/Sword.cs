using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        
        Vector3 wordPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(wordPos);
        Vector3 mousePos = new Vector3(wordPos.x, wordPos.y, 0);
        Vector3 relativePos = mousePos - transform.position;
        Quaternion rotation = Quaternion.LookRotation(transform.forward, relativePos);
        transform.rotation = rotation;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }


}
