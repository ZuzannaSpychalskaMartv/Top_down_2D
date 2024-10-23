using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Collectibles : MonoBehaviour
{
    [Header("Info01: this script should be in the player")]
    [Header("Info02: to work, Collectible Objects collision must be set as a trigger")]
    [Space]
    public int collected = 0;
    public int allCollectible;

    // Start is called before the first frame update
    void Start()
    {

        allCollectible = GameObject.FindGameObjectsWithTag("Collectible").Length;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Collectible")
        {
            collected += 1;
            Destroy(other.gameObject);
        }
    }
}
