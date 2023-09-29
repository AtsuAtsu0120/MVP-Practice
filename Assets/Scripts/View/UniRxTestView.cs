//using UniRx;
//using UnityEngine;

//public class UniRxTestView : MonoBehaviour
//{
//    private UniRxTestPresenter presenter;
//    // Start is called before the first frame update
//    void Start()
//    {
//        presenter = new();

//        presenter.CollectionObserver.Subscribe(x => Debug.Log(x.Value));
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if(Input.GetKeyDown(KeyCode.Space))
//        {
//            presenter.SubjectObserver.OnNext("aaa");
//        }
//    }
//}
