using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterCollections : MonoBehaviour
{
    [SerializeField] private int coinsCollected;

    private void OnEnable()
    {
        if (PlayerPrefs.HasKey("Coins"))
        {
            coinsCollected = PlayerPrefs.GetInt("Coins");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //coinsCollected = 0;
    }

    public int GetCoins()
    {
        return coinsCollected;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Collectible"))
        {
            // oh we ran into a collectible!
            Destroy(collision.gameObject);
            coinsCollected++;
        }
    }

    private void OnDestroy()
    {
        savePrefs();
    }

    void savePrefs()
    {
        // Set the PlayerPref of 'Coins' with the number of coins Collected
        PlayerPrefs.SetInt("Coins", coinsCollected);
        PlayerPrefs.Save();
    }
}
