using UnityEngine;
using System.Collections;

public class GameControllerScript : MonoBehaviour {
	
	public GameObject item;
	public GameObject[] allItems = new GameObject[6];
	public bool completeBoard = false;
	private Vector3 spawnPosition = new Vector3();

	// Use this for initialization
	void Start ()
	{
		GameBoard.newBoard ();
		StartCoroutine(spawnBoard ());
	}
	
	IEnumerator spawnBoard ()
	{
		// grab stuff from GameBoard

		for (int i = 0; i < 9; i++) //BOARD "GRID" in ROWS
		{
			for(int c = 0; c < 9; c++)//BOARD "GRID" in COLs
			{
				spawnPosition.Set(0, 11, Mathf.Clamp(c - 4, c - 4, c - 4)); //POSTION OF NEW ITEM
				var myGameObject = Instantiate(allItems[GameBoard.board[i,c]], spawnPosition, Quaternion.identity) as GameObject;
				var myMouseClick = myGameObject.GetComponent<mouseClick>();
				myMouseClick.row = i;
				myMouseClick.col = c;
			}
			yield return new WaitForSeconds(1);
		}
		yield return new WaitForSeconds(3);
		completeBoard = true;
	}
}
