/*
 * Author: Jacie Thoo Yixuan
 * Date: 5/26/2024
 * Description: Contains functions related to the collectible that increases player jump height.
 */

using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseJump : Collectible
{
    /// <summary>
    /// Overrides base collected() function. When collected, player jump height is increased
    /// </summary>
    /// <param name="player"></param>
    public override void Collected(GameObject player) //override base collected()
    {
        var playerController = player.GetComponent<FirstPersonController>(); //access player properties
        if (playerController != null) //null check
        {
            playerController.JumpHeight += 7.5f; //amount to increase by
            Debug.Log("Increased player jump height");
        }
        Destroy(gameObject); //Dstroy after collecting
    }
}
