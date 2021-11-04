using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void delegateMethod();

public class MainController : MonoBehaviour
{
  public static MainController controller;
  public event delegateMethod collideText;
  public event delegateMethod incrementForce;
  public event delegateMethod setRandomColor;
  public event delegateMethod lookAtPlayer;

  public static MainController Instance 
  {
    get 
    {
      return controller;
    }
  }

  void Awake() 
  {
    if (controller == null) 
    {
      controller = this;
      DontDestroyOnLoad(this);
    } 
    else if (controller != this) 
    {
      Destroy(gameObject);
    }
  }

  void Update() {
    float distance = Vector3.Distance(transform.position, GameObject.Find("CylinderA").transform.position);
    if (distance < 5) {
      setRandomColor();
      lookAtPlayer();
    }
  }

  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "objectA") {
      incrementForce();
    } else if (collision.gameObject.tag == "objectB") {
      collideText();
    }
  }
}
