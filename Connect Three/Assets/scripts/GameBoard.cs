using UnityEngine;
using System.Collections;

public abstract class GameBoard {
	public static int[,] board = new int[9,9];

	public static void newBoard() {
		// create game board here

		for (int i = 0; i < 9; i++) //BOARD "GRID" in ROWS
		{
			for(int c = 0; c < 9; c++)//BOARD "GRID" in COLs
			{
				board[i,c] = Random.Range (0, 6);
			}
		}
	}


	public static bool moveIfAble(int row1, int col1, int row2, int col2) {
		var rowDelta = Mathf.Abs(row1 - row2);
		var colDelta = Mathf.Abs(col1 - col2);
		Debug.Log (rowDelta + " | " + colDelta);
		Debug.Log (row1 + " / " + row2);
		Debug.Log (col1 + " ~ " + col2);
		var isAdjacent = (rowDelta + colDelta) == 1;
		if (!isAdjacent) {
			return false;
		}

		var isMatch = true;
		if (!isMatch) {
			return false;
		}

		var temp = board[row1,col1];
		board[row1,col1] = board[row2,col2];
		board[row2,col2] = temp;

		return true;
	}
}
