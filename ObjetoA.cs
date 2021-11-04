using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetoA : MonoBehaviour
{
  public int collitions = 0;

  void Start() 
  {
    MainController.Instance.collideText += collideText;
  }

  void collideText() 
  {
    collitions++;
    TextMesh warning = GameObject.Find("WarningText").GetComponent("TextMesh") as TextMesh;
    warning.text = "Player collided " + collitions + "\ntimes with B Object";
  }
}
