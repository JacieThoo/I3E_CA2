/*
 * Author: Jacie Thoo Yixuan
 * Date: 5/26/2024
 * Description: Contains functions related to the collectibles.
 */

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    /// <summary>
    /// Base collected function that can be overridden
    /// </summary>
    /// <param name="player"></param>
    public virtual void Collected(GameObject player) //marks the function as one that can be overridden by derived classes
    {
        UnityEngine.Debug.Log("Collectible has been collected");
    }
}
