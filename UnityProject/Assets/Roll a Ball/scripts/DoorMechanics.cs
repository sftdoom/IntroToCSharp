using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMechanics : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Player player = null;
        if(other.TryGetComponent<Player>(out player))
        {
            Destroy(GameObject.Find("Door"));

        }
    }
}
