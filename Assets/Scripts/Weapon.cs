using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Weapon : MonoBehaviour
{
    [Header("Info 01: To destroy Enemy object, it should have tag: Enemy")]
    [Header("Info 02: To attack use the button named: Attack")]
    [Header("Info 03: Rigidbody2D - Body Type - should be set to Kinematic")]
    [Space]

    public PlayerTDM playerScirpt;
    public GameObject weapon;
    public float appearTime = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        weapon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = playerScirpt.dir;

        // the second argument, upwards, defaults to Vector3.up
        Quaternion rotation = Quaternion.LookRotation(weapon.transform.forward, relativePos);
        weapon.transform.rotation = rotation;


        if (Input.GetButtonDown("Attack"))
        {
            Debug.Log("Attack key was pressed");
            StartAttack();
        }

        if (Input.GetButtonUp("Attack"))
        {
            //EndAttack();
        }
    }

    void StartAttack()
    {
        //weapon.transform.Rotate()
        weapon.SetActive(true);
        Invoke("EndAttack", appearTime);
    }

    void EndAttack()
    {
        weapon.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }


}

