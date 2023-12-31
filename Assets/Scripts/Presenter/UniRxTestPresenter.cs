using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class UniRxTestPresenter
{
    //ActionとかFunc
    private Subject<string> subject = new();
    private ReactiveCollection<int> collection = new();

    //ActionとかFuncの実行できる部分だけをpublicで提供
    public IObserver<string> SubjectObserver
    {
        get { return subject; }
    }
    public IObservable<CollectionAddEvent<int>> CollectionObserver
    {
        get { return collection.ObserveAdd(); }
    }
    public UniRxTestPresenter()
    {
        subject.Subscribe(msg => Test(msg));
    }
    public void Test(string msg)
    {
        //実際にはここにModelやViewなどを触る処理を書く
        Debug.Log(msg);

        collection.Add(collection.Count);
    }
}
