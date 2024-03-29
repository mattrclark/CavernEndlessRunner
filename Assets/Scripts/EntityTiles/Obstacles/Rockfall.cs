﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rockfall : Obstacle
{
    public GameObject rockfallPieceGO;
    public Sprite RockfallCrackSprite;
    bool cracked;

    float crackTime = 0.5f;
    float timeActivated;

    public AudioClip crackAudio;

    Rockfall()
    {
        EntityName = EntityType.Rockfall;
    }

    private void Start()
    {
        cracked = false;
    }

    private void Update()
    {
        if (cracked && timeActivated + crackTime < Time.time)
        {
            float playerYPos = GameObject.FindGameObjectWithTag("Player").transform.position.y;
            SoundManager.instance.ChangeSoundVolumeWithMultiplier(Mathf.Abs(1 / (playerYPos - transform.position.y + 1)));
            SoundManager.instance.RandomizeSfx(crackAudio);

            // Create 3 rocks at the position of the parent but scattered 
            for (int i = 0; i < 3; i++)
            {
                GameObject newRockfallPiece = Instantiate(rockfallPieceGO, new Vector2(transform.position.x + Random.Range(-0.5f, 0.5f), transform.position.y + Random.Range(-0.5f, 0f)), Quaternion.identity);
            }

            // The rocks have fallen
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        // Trigger only when the player enters the box collider and only if the rocks have not fallen
        if(coll.tag == "Player" && !cracked)
        {
            timeActivated = Time.time;
            GetComponent<SpriteRenderer>().sprite = RockfallCrackSprite;
            cracked = true;
        }
    }
}
