/*
 * Author: Jacie Thoo Yixuan
 * Date: 5/26/2024
 * Description: Contains functions related to the Player.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    /// <summary>
    /// When player collides with something, check if it is a collectible.
    /// If it is a collectible, call collected function
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        //check if item collided with is a collectible and assign to currentCollectible
        Collectible currentCollectible = collision.gameObject.GetComponent<Collectible>();
        if (currentCollectible != null) //null check
        {
            //call collected function on it
            currentCollectible.Collected(gameObject);
        }
    }
}
