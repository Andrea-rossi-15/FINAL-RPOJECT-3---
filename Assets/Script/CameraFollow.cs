using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] Transform PlayerTARGET;
    private float Speed = 1;
    Vector3 Camera = new Vector3(0, 0, -20);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = PlayerTARGET.position + Camera;
    }
}
