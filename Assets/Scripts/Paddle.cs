using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 padddlePos = new Vector3(0.5f,this.transform.position.y,0f);
		
		float mousePosInBlocks = Input.mousePosition.x/Screen.width * 16;
		
		padddlePos.x = Mathf.Clamp(mousePosInBlocks,0.5f,15.5f);
		
		this.transform.position = padddlePos;
		print(mousePosInBlocks);
	}
}
