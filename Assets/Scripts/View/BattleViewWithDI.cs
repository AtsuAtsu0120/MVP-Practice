using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UniRx;

public class BattleViewWithDI : MonoBehaviour 
{
	[Header("GameObject")]
	[SerializeField] private GameObject entitiesList;
	[Header("Prefab")]
	[SerializeField] private GameObject entityPrefab;
	private void Start()
	{

	}

	public void AddEntityText(Entity entity)
	{
		var instance = Instantiate(entityPrefab, entitiesList.transform);

		instance.GetComponent<TextMeshProUGUI>().text = $"{entity.Name}\nHP:{entity.Hp}";
	}
	public void RemoveEntityText(int index)
	{
		Destroy(entitiesList.transform.GetChild(index).gameObject);
	}
}
