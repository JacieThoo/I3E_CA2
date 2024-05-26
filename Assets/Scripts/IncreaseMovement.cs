/*
 * Author: Jacie Thoo Yixuan
 * Date: 5/26/2024
 * Description: Contains functions related to the collectible that increases player movement speed.
 */


using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseMovement : Collectible
{
    /// <summary>
    /// Overrides base collected() function. When collected, player movement speed is increased
    /// </summary>
    /// <param name="player"></param>
    public override void Collected(GameObject player) //override base collected()
    {
        var playerController = player.GetComponent<FirstPersonController>(); //access player properties
        if (playerController != null) //null check
        {
            playerController.MoveSpeed += 7.5f; //amount to increase by
            Debug.Log("Player movement speed has been increased");
        }
        Destroy(gameObject); //Dstroy after collecting
    }
}
