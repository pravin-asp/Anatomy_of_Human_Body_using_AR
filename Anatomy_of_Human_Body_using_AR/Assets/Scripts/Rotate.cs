using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
 
 // Update is called once per frame
 void Update () {
  transform.Rotate(0,20*Time.deltaTime,0);
 }
}