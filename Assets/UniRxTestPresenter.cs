using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class UniRxTestPresenter
{
    //Action‚Æ‚©Func
    private Subject<string> subject = new();

    public UniRxTestPresenter()
    {
        subject.Subscribe(msg => Test(msg));
    }

    //Action‚Æ‚©Func‚ÌÀs‚Å‚«‚é•”•ª‚¾‚¯‚ğpublic‚Å’ñ‹Ÿ
    public IObserver<string> SubjectObserver
    {
        get { return subject; }
    }
    public void Test(string msg)
    {
        //ÀÛ‚É‚Í‚±‚±‚ÉModel‚âView‚È‚Ç‚ğG‚éˆ—‚ğ‘‚­
        Debug.Log(msg);
    }
}
