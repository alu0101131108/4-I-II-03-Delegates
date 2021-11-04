using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderB : MonoBehaviour
{
    void Start()
    {
      MainController.Instance.setRandomColor += setRandomColor; 
    }

    void setRandomColor() {
      GetComponent<Renderer>().material.color = new Color( Random.value, Random.value, Random.value, 1.0f );
    }
}
