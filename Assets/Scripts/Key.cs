using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    [Header("Info: to work, collision must be set as a trigger")]
    [Space]
    public GameObject door;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            door.GetComponent<Door>().haveKey = true;
            Destroy(this.gameObject);
        }
    }

}
