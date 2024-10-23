using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PlayerScript requires the GameObject to have a Rigidbody component
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerTDM : MonoBehaviour
{
    [Header("Info: This object must have Tag set as Player")]
    [Space]

    public float moveSpeed = 5f;
    public int playerLifes = 3;
    public Color damageColor = Color.red;
    int thrust = 1500;

    Rigidbody2D rb;
    SpriteRenderer mySprite;
    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mySprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if(movement.magnitude > 0)
        {
            var dir = movement;
            Debug.Log(dir);
        }

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public void Damage(Vector2 dir)
    {
        StartCoroutine("BlinkCoroutine");
        rb.AddForce(dir * thrust, ForceMode2D.Force);
        playerLifes -= 1;
    }

    private IEnumerator BlinkCoroutine()
    {
        mySprite.color = damageColor;
        yield return new WaitForSeconds(0.2f);
        mySprite.color = Color.white;
        yield return null;
        
    }
}
