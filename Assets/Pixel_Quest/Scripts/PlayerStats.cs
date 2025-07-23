using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    private int coinCounter = 0;
    public int playerHealth = 3;
    public Transform RespawnPoint;
    // Start is called before the first frame update
    void Start()
    {

    }

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
    

