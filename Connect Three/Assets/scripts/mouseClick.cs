using UnityEngine;
using System.Collections;

public class mouseClick : MonoBehaviour {

	private bool isMouseInside = false;
	private static GameObject lastClicked = null; 
	private static int lastRow; 
	private static int lastCol; 
	public int row;
	public int col;

	public void OnMouseEnter()
	{
		isMouseInside = true;
	}
	
	public void OnMouseExit()
	{
		isMouseInside = false;
	}
	
	public void Update()
	{
		if (isMouseInside && Input.GetMouseButtonDown(0))
		{
			var gameObject = this.gameObject; 
			if(lastClicked == null)
			{
				lastClicked = gameObject;
				lastRow = row;
				lastCol = col;
			}
			else
			{
				//Ask gameboard if gameobject can move.
				if (GameBoard.moveIfAble(row, col, lastRow, lastCol) && GameObject.Find("Game Controller").GetComponent<GameControllerScript>().completeBoard)
				{
					var lastPosition = lastClicked.transform.position;
					lastClicked.transform.position = gameObject.transform.position;
					gameObject.transform.position = lastPosition;
					var rowTemp = row;
					var colTemp = col;
					row = lastRow;
					col = lastCol;
					lastClicked.GetComponent<mouseClick>().col = colTemp;
					lastClicked.GetComponent<mouseClick>().row = rowTemp;
					lastClicked = null;
				}
			}
		}
	}
}
