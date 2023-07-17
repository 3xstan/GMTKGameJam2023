using System.Collections;
using System.Collections.Generic;
using TarodevController;
using UnityEngine;

public class PlayerState : MonoBehaviour
{

    private bool dead;
    private BoxCollider2D boxCollider;
    private PlayerController controller;
    //TODO
    // Disable PlayerController Script from this player object

    // Set player object's Layer to Ground

    // Rotate Player object (logic manager)

    // Start is called before the first frame update
    void Start()
    {
        InitialSettings();
    }

    void Awake()
    {
        InitialSettings();
    }

    private void InitialSettings()
    {
        dead = false;
        boxCollider = GetComponent<BoxCollider2D>();
        controller = GetComponent<PlayerController>();
        controller.enabled = true;
        boxCollider.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Dies()
    {
        if (!dead)
        {
            dead = true;
            PlayerController playerController = GetComponent<PlayerController>();
            playerController.AnimateDeath();
            playerController.enabled = false;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static; // Removes motion physics
            //boxCollider.enabled = true;
            tag = "Untagged";
            gameObject.layer = 3; // Layer becomes Ground
        }

    }
}
