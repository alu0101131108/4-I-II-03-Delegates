using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    // public Transform target;

    void Start()
    {
      MainController.Instance.lookAtPlayer += lookAtPlayer; 
    }

    void Update()
    {
      Debug.DrawRay(transform.position, transform.forward * 5f, Color.red);
    }

    void lookAtPlayer() 
    {
      transform.LookAt(GameObject.Find("Player").transform);
      // transform.LookAt(target, Vector3.down);
    }
}
