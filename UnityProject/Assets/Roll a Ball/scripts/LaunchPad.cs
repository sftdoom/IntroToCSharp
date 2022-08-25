using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchPad : MonoBehaviour
{
    public float launchStrength = 15.0f;
    private void OnTriggerEnter(Collider other)
    {
        Player player = null;
        if (other.TryGetComponent<Player>(out player))
        {
            Rigidbody playerRb=other.GetComponent<Rigidbody>();
            playerRb.AddForce(0, launchStrength, 0, ForceMode.Impulse);

        }
    }
}
