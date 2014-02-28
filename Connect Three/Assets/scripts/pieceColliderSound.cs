using UnityEngine;
using System.Collections;

public class pieceColliderSound : MonoBehaviour {

	void OnCollisionEnter(Collision collision){
		if(collision.contacts.Length > 0 && GameObject.Find("Game Controller").GetComponent<GameControllerScript>().completeBoard)
		{
			ContactPoint contact = collision.contacts[0];
			if(Vector3.Dot(contact.normal, Vector3.up) > 0.5)
			{
				audio.Play();
			}
		}
	}
}
