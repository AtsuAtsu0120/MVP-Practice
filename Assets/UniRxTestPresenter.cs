using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class UniRxTestPresenter
{
    //Action�Ƃ�Func
    private Subject<string> subject = new();
    private ReactiveCollection<int> collection = new();

    //Action�Ƃ�Func�̎��s�ł��镔��������public�Œ�
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
        //���ۂɂ͂�����Model��View�Ȃǂ�G�鏈��������
        Debug.Log(msg);

        collection.Add(collection.Count);
    }
}
