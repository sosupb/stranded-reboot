using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 prevPosition;
    // Start is called before the first frame update
    void Start()
    {
        prevPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(prevPosition != transform.position)
        {
            prevPosition = transform.position;
            Debug.Log(prevPosition.ToString());
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Hello");
        }
    }
}
