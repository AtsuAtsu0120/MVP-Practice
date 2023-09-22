using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class UniRxTestPresenter
{
    //Action�Ƃ�Func
    private Subject<string> subject = new();

    public UniRxTestPresenter()
    {
        subject.Subscribe(msg => Test(msg));
    }

    //Action�Ƃ�Func�̎��s�ł��镔��������public�Œ�
    public IObserver<string> SubjectObserver
    {
        get { return subject; }
    }
    public void Test(string msg)
    {
        //���ۂɂ͂�����Model��View�Ȃǂ�G�鏈��������
        Debug.Log(msg);
    }
}
