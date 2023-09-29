//using UnityEngine;
//using UniRx;
//using TMPro;

//public class BattleView : MonoBehaviour
//{
//    private BattlePresenter battlePresenter;

//    [Header("GameObject")]
//    [SerializeField] private GameObject entitiesList;
//    [Header("Prefab")]
//    [SerializeField] private GameObject entityPrefab;
//    private void Start()
//    {
//        battlePresenter = new();

//        battlePresenter.OnEntitiesAdd.Subscribe(item => OnAddEntity(item.Value));
//        battlePresenter.OnEntitiesRemove.Subscribe(item => OnRemoveEntity(item.Index));
//    }
//    private void Update()
//    {
//        if(Input.GetKeyDown(KeyCode.Space))
//        {
//            battlePresenter.AddEntitesInput.OnNext(Unit.Default);
//        }
//    }

//    private void OnAddEntity(Entity entity)
//    {
//        var instance = Instantiate(entityPrefab, entitiesList.transform);

//        instance.GetComponent<TextMeshProUGUI>().text = $"{entity.Name}\nHP:{entity.Hp}";
//    }
//    private void OnRemoveEntity(int index)
//    {
//        Destroy(entitiesList.transform.GetChild(index));
//    }
//}
