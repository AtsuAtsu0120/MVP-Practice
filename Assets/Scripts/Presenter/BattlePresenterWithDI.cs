using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class BattlePresenterWithDI : IInitializable
{
	private readonly ModelWithDI model;
	private readonly BattleViewWithDI view;
	
	private ReactiveCollection<Entity> entities = new();
	private Subject<Unit> onAddEntitesInput = new();

	private IDisposable inputUpdate;
	public IObservable<CollectionAddEvent<Entity>> OnEntitiesAdd
	{
		get { return entities.ObserveAdd(); }
	}
	public IObservable<CollectionRemoveEvent<Entity>> OnEntitiesRemove
	{
		get { return entities.ObserveRemove(); }
	}

	[Inject]
	public BattlePresenterWithDI(ModelWithDI model, BattleViewWithDI view)
	{
		this.model = model;
		this.view = view;
	}

	public void Initialize()
	{
		// Presenter‚Í‚½‚¾‚ÌƒŠƒŒ[‚ð‚·‚é–ðŠ„‚É‚È‚é‚±‚Æ‚à‚ ‚éB
		model.BattleManager.OnEntitiesAdd.Subscribe(item => entities.Add(item.Value));
		model.BattleManager.OnEntitiesRemove.Subscribe(item => entities.Remove(item.Value));

		onAddEntitesInput.Subscribe(unit => Model.BattleManager.AddEneity());

		Observable.EveryUpdate()
			.Where(_ => Input.GetKeyDown(KeyCode.Space))
			.Subscribe(_ => model.BattleManager.AddEntity()).AddTo(view);

		Observable.EveryUpdate()
			.Where(_ => Input.GetKeyDown(KeyCode.LeftControl))
			.Subscribe(_ => model.BattleManager.RemoveEntity()).AddTo(view);

		entities.ObserveAdd().Subscribe(item => view.AddEntityText(item.Value));
		entities.ObserveRemove().Subscribe(item => view.RemoveEntityText(item.Index));
	}
}
