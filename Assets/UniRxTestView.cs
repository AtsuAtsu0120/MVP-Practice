using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniRxTestView : MonoBehaviour
{
    private UniRxTestPresenter presenter;
    // Start is called before the first frame update
    void Start()
    {
        presenter = new();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            presenter.SubjectObserver.OnNext("aaa");
        }
    }
}
