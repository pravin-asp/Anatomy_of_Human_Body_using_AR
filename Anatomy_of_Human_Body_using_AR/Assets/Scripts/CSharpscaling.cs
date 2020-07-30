using UnityEngine;
using System.Collections;

public class CSharpscaling : MonoBehaviour 
{
 
 
	public float initialFingersDistance;
	public Vector3 initialScale;
	public static Transform ScaleTransform;
 
 
	void  Update ()
	{
		int fingersOnScreen = 0;
  
		foreach(Touch touch in Input.touches) 
		{
			fingersOnScreen++; //Count fingers (or rather touches) on screen as you iterate through all screen touches.
   
   //You need two fingers on screen to pinch.
			if(fingersOnScreen == 2)
			{
    
		//First set the initial distance between fingers so you can compare.
				if(touch.phase == TouchPhase.Began)
				{
					initialFingersDistance = Vector2.Distance(Input.touches[0].position, Input.touches[1].position);
					initialScale = ScaleTransform.localScale;
				}
				else
				{
					float currentFingersDistance = Vector2.Distance(Input.touches[0].position, Input.touches[1].position);
     
					float scaleFactor = currentFingersDistance / initialFingersDistance;
     
     //transform.localScale = initialScale * scaleFactor;
					ScaleTransform.localScale = initialScale * scaleFactor; 
				}
			}
		}
	}
}