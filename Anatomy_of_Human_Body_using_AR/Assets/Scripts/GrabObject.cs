using UnityEngine;
using System.Collections;

public class GrabObject : MonoBehaviour {

 Vector3 dist;
 float posX;
 float posY;
 
 void OnMouseDown(){
  dist = Camera.main.WorldToScreenPoint(transform.position);
  posX = Input.mousePosition.x - dist.x;
  posY = Input.mousePosition.y - dist.y;
  
 }
 
 void OnMouseDrag(){
  Vector3 curPos = 
   new Vector3(Input.mousePosition.x - posX, 
               Input.mousePosition.y - posY, dist.z);  
  
  Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
  transform.position = worldPos;
 }
}