using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelWithDI
{
	public BattleManagerWithDI BattleManager { get; set; }
	public ModelWithDI()
	{
		BattleManager = new();
	}
}
