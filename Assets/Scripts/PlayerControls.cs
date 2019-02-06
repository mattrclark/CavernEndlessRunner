﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    public bool isPlayerLeft = true;
    bool moving = false;

    Vector2 newPosition;
    float t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetMouseButtonDown(0)) {
        //     Debug.Log("1");
        // }

        if (!moving)
        {
            foreach (Touch touch in Input.touches)
            {

                // Check the user has tapped the screen
                if (touch.phase == TouchPhase.Began)
                {
                    t = 0;
                    // As the user has tapped the screen, they will move up one tile
                    Vector2 totalMovement = new Vector2(0, 0);

                    totalMovement.y ++;

                    // Check if they move left or right
                    bool userTouchedLeft = touch.position.x < Screen.width / 2;

                    if (!isPlayerLeft && userTouchedLeft)
                    { // If the player is on the right and the user touched the left side
                        totalMovement.x = -3.5f;
                        isPlayerLeft = true; // Player is now on the left
                    }
                    else if (isPlayerLeft && !userTouchedLeft)
                    { // If the player is on the left and the user touched the right side
                        totalMovement.x = 3.5f;
                        isPlayerLeft = false; // Player is now on the right
                    }

                    // Set the new position
                    newPosition = new Vector2(transform.position.x + totalMovement.x, transform.position.y + totalMovement.y);

                    moving = true;
                    // Debug.Log("First finger entered!");
                }
            }
        }
        else
        {
            t += Time.deltaTime / 0.1f;
            transform.position = Vector2.Lerp(transform.position, newPosition, t);
            if (transform.position.Equals(newPosition))
            {
                moving = false;
            }
        }
    }
}