//using System;
//using UniRx;
//using VContainer;

//public class BattlePresenter
//{
//    private ReactiveCollection<Entity> entities = new();
//    private Subject<Unit> onAddEntitesInput = new();
//    public IObservable<CollectionAddEvent<Entity>> OnEntitiesAdd
//    {
//        get { return entities.ObserveAdd(); }
//    }
//    public IObservable<CollectionRemoveEvent<Entity>> OnEntitiesRemove
//    {
//        get { return entities.ObserveRemove(); }
//    }
//    public IObserver<Unit> AddEntitesInput
//    {
//        get { return onAddEntitesInput; }
//    }

//    [Inject]
//    public BattlePresenter()
//    {
//        // Presenter‚Í‚½‚¾‚ÌƒŠƒŒ[‚ð‚·‚é–ðŠ„‚É‚È‚é‚±‚Æ‚à‚ ‚éB
//        Model.BattleManager.OnEntitiesAdd.Subscribe(item => entities.Add(item.Value));
//        Model.BattleManager.OnEntitiesRemove.Subscribe(item => entities.Remove(item.Value));

//        onAddEntitesInput.Subscribe(unit => Model.BattleManager.AddEneity());
//    }
//}
