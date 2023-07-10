using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum KillDirection: ushort {
    Left,
    Up,
    Right,
    Down,
    Omni,
    Destroy
}

public class DeathEventTrigger : MonoBehaviour
{
    private ushort killDirectionVal;
    public string killDirection = "Up";
    private float killerBase;

    private DeathEvent die;

    // Start is called before the first frame update
    void Start()
    {
        killerBase = FindBase();
        // killDirection = "Up";
        die = FindObjectOfType<DeathEvent>();

        switch (killDirection)
        {
            case "Left":
                killDirectionVal = (ushort)KillDirection.Left;
                break;
            case "Up":
                killDirectionVal = (ushort)KillDirection.Up;
                break;
            case "Right":
                killDirectionVal = (ushort)KillDirection.Right;
                break;
            case "Down":
                killDirectionVal = (ushort)KillDirection.Down;
                break;
            case "Omni":
                killDirectionVal = (ushort)KillDirection.Omni;
                break;
            default:
                killDirectionVal = (ushort)KillDirection.Destroy;
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {


        if (collider.gameObject.tag == "Player")
        {
            //die.DebugMessageSned();
            die.TriggerDeathEvent(this.gameObject, killDirectionVal, killerBase);
        }
    }

    private float FindBase()
    {
        // Check if spike is on bottom

        return 0f;
    }
}
