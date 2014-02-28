using UnityEngine;
using System.Collections;

public class onClickDestroy : MonoBehaviour {
	public GameObject explosion;

	void Update(){
		if(Input.GetMouseButtonDown(0)){
			Instantiate(explosion, transform.position, Quaternion.identity);
			Destroy(this.gameObject);
			Destroy(explosion);
		}
	}




}
