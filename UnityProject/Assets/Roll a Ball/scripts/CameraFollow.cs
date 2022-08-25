using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float smoothness;
    public Transform targetObject;
    private Vector3 initialOffeset;
    private Vector3 cameraPosition;

    // Start is called before the first frame update
    void Start()
    {
        initialOffeset = transform.position - targetObject.position;
    }

    // Update is called once per frame
    void Update()
    {
        cameraPosition=targetObject.position+initialOffeset;
        transform.position = Vector3.Lerp(transform.position, cameraPosition, smoothness * Time.fixedDeltaTime);
    }
}
