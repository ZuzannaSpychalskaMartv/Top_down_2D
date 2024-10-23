using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [Header("Info: to work, collision must be set as a trigger")]
    [Space]
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        //lifesText.text = GameManager.Instance.playerLifes.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Triggered by Player");
            var dir = (other.transform.position - transform.position).normalized;
            other.GetComponent<PlayerTDM>().Damage(dir); 
        }
    }
}
