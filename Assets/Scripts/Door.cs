using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool haveKey = false;
    public Sprite doorOpenSprite;
    public Collider2D myCollider;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && haveKey)
        {
            GetComponent<SpriteRenderer>().sprite = doorOpenSprite;
            myCollider.enabled = !enabled;
        }
    }

}
