using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        // did we collide with player
        Player player = null;
        if (other.TryGetComponent<Player>(out player))
        {
            //if so, give player a point
            player.points = player.points + 1;
            //destroy pickup
            Destroy(gameObject);

        }

        //if not, do nothing

        //make the level end after all points are picked up
        if (player.points = 9)
        {
         
        }

    }
}
