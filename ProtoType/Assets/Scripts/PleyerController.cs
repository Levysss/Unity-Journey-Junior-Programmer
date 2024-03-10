using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleyerController : MonoBehaviour
{
    #region 
    [Header("Car Config")]
    public float speed= 15.0f;
    public float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    #endregion
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //we'll move vihicle forward
        transform.Translate(Vector3.forward * Time.deltaTime*speed*forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed *horizontalInput);
    }
}
