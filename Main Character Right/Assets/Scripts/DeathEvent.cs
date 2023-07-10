using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEvent : MonoBehaviour
{
    private GameObject Players;
    public PlayerState currentPlayer;
    public GameObject nextPlayer;

    public GameObject spawnPoint;

    private void Start()
    {
        Players = GameObject.FindGameObjectWithTag("Player");
        if(Players != null )
        {
            currentPlayer = Players.GetComponent<PlayerState>();
        }
        else
        {
            currentPlayer = null;
        }
    }

    public void TriggerDeathEvent (GameObject killer, ushort direction, float killBase)
    {
        Debug.Log("Triggered Death Event");
        currentPlayer.transform.SetParent(killer.transform.parent);


        if(direction == (ushort)KillDirection.Destroy)
        {
            Destroy(currentPlayer.gameObject);
        }
        
        currentPlayer.Dies(); // Only changes labels, not position or rotation

        currentPlayer.transform.Rotate(0, 0, -90);

        SpawnPlayer();


        //Rotate the player to be perpendicular
    }

    public void SpawnPlayer()
    {
        Debug.Log("SwapPlayer() was called");
        Vector3 spawnCoords = spawnPoint.transform.position;
        currentPlayer = 
            Instantiate(nextPlayer, 
                        spawnCoords + new Vector3(0f, 2f, 0f), 
                        Quaternion.identity)
            .GetComponent<PlayerState>();

        // Disable PlayerController Script from this player object

        // Set player object's Layer to Ground

        // Rotate Player object

        // Spawn new player object at beginning of level or checkpoint

        // Enable PlayerController (should be default)

        // Layer is unset by default
    }

    public void DebugMessageSned()
    {
        Debug.Log("DeathEvent exists");
    }
}
