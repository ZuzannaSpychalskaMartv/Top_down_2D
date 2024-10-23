using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public TMP_Text lifesText;
    public TMP_Text collectiblesText;

    public PlayerTDM player;
    public Collectibles collectibles;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private void Update()
    {
        collectiblesText.text = collectibles.collected.ToString() + "/" + collectibles.allCollectible.ToString();

        lifesText.text = player.playerLifes.ToString();
        if(player.playerLifes == 0)
        {
            RestartGame();
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
