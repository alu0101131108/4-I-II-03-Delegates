using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoB : MonoBehaviour
{
    public int force = 0;

    void Start() 
    {
      MainController.Instance.incrementForce += incrementForce; 
    }
    
    void Update()
    {
      TextMesh forceText = transform.GetChild(0).gameObject.GetComponent("TextMesh") as TextMesh;
      forceText.text = "Force " + force;
    }

    void incrementForce()
    {
      force++;
    }
}
