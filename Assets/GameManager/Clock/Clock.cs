﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Used to show remaining Round Time
/// An analog clock, with hands
/// NOTICE ONLY USING MINUTE HAND, HOUR HAND NOT IMPLEMENTED
/// </summary>
public class Clock : MonoBehaviour
{
    // We rotate this about the face
    public GameObject minuteHand;

    // We also rotate this about the face, albeit more slowly
    // TODO FUTURE
    // public GameObject hourHand;

    // Who we notify on round over
    public GameManager gameManager;

    // What time remains right now
    public float currentTime;

    // What time we start with
    public float startTime;

    // When we are not runnin
    private bool stopped;

    void Start()
    {
        // Reset the time
        currentTime = startTime;

        // Set the alarm
        stopped = false;
    }

    void Update()
    {
        // If we should be running
        if (currentTime > 0.0f)
        {
            // Remove time while time remains
            currentTime -= Time.deltaTime;

            // Update the Clock Hands
            // TODO
        }

        // Do something only once, when time stops
        if (!stopped)
        {
            TimeOut();
        }
    }

    /// <summary>
    /// Trigger effects, etc to signify time is up
    /// </summary>
    private void TimeOut()
    {
        // Alert the game manager the time is up
        gameManager.RoundOver();
    }

}
