using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
* 测试镜头跟着物体进行旋转
 */
public class RotationTest : MonoBehaviour {
	public Camera mainCamear;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis( "Horizontal" );
		float v = Input.GetAxis( "Vertical" );
		transform.Rotate(0,-h,0);
		mainCamear.transform.RotateAround( transform.position,  Vector3.up, -h);
		Debug.Log( "h:" + h );
	}
}
