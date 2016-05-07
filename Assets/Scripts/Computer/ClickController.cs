using UnityEngine;
using System.Collections;

 public class ClickController : MonoBehaviour
 {
   private float lastClickTime;

public float catchTime = 0.25f;

void Update ()
{

  if(Input.GetButtonDown("Fire1"))
  {
      if(Time.time - lastClickTime < catchTime)
      {
          //double click
          print("Double click");
      }
      else
      {

        print("Singlw click");
          //normal click
      }
      lastClickTime = Time.time;
  }
}
 }
