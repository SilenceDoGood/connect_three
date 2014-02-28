using UnityEngine;
using System.Collections;

public class stickToBody : MonoBehaviour 
{
	public GameObject body = new GameObject(); 
	
	// Update is called once per frame
	void Update () 
	{
			transform.position = body.transform.position;
	}
}
