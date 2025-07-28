using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    private int coinCounter = 0;
    public int playerHealth = 3;
    public float maxHealth = 3;
    public Transform RespawnPoint;
    public int CoinsInLevel = 0;


    private PlayerUIController _pUIc;

    private void Start()
    {
        _pUIc = GetComponent<PlayerUIController>();
        _pUIc.StartUI();
        _pUIc.UpdateHealth(playerHealth, maxHealth);
        CoinsInLevel = GameObject.Find("Coins").transform.childCount;
        _pUIc.UpdateText(coinCounter + "/" + CoinsInLevel);
    }
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Respawn":
                {
                    RespawnPoint.position = collision.transform.Find("Point").position;
                    break;
                }
            case "Death":
                {
                    playerHealth--;
                    _pUIc.UpdateHealth(playerHealth, maxHealth);
                    if (playerHealth <= 0)
                    {
                        string thislevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thislevel);
                    }
                    else
                    {
                        transform.position = RespawnPoint.position;
                    }
                        break;
                }
            case "Coin":
                {
                    coinCounter++;
                    _pUIc.UpdateText(coinCounter + "/" + CoinsInLevel);
                    Destroy(collision.gameObject);
                    break;
                }
            case "Health":
                {
                    
                    if (playerHealth < 3)
                    {
                        playerHealth++;
                        Destroy(collision.gameObject);
                    }
                    _pUIc.UpdateHealth(playerHealth, maxHealth);
                    break;
                   
                }
                
           case "Finish":
                        {
                    string nextLevel = collision.GetComponent<LevelGoal>().nextLevel;
                    SceneManager.LoadScene(nextLevel);
                    break;
                        }
                    }

                }
        }
    

