﻿using UnityEngine;
using System.Collections;

/*
Will mainly contains stats related to players, possibly some helper functions
*/

public class Player {

	public float money = 1000f;
	public int gas = 0;
	public int share = 0;
	public int wells = 0;
	public int lawyers = 0;
	public int research = 0;
	public int publicity = 0;
	public int cellsOwned = 0;
	public Cell[] playerOwnedCells = new Cell[200];

}
