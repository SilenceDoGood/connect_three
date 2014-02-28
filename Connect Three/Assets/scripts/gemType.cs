using UnityEngine;
using System.Collections;

public class gemType 
{
	private string[] gemTypeArray = new string[6] {"berry", "cube", "diamond", "ring", "sphere", "triangle"};
	private GameObject _prefabGem;
	private int _gemType;

	gemType(GameObject prefabGem, int gemType){
		var temp = gemTypeArray [gemType];
		_prefabGem = prefabGem;
	}

	void setGemType (int newGemType){
		_gemType = newGemType;
	} 
}
