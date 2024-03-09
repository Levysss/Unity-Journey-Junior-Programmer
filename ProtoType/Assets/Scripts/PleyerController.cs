using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleyerController : MonoBehaviour
{
    #region 
    [Header("Car Config")]
    public float speed= 15.0f;
    public float turnSpeed;

    #endregion
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //we'll move vihicle forward
        transform.Translate(Vector3.forward * Time.deltaTime*speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
    }
}
