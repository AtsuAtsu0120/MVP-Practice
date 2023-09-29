using System;
using UniRx;

public class BattleManagerWithDI
{
	private ReactiveCollection<Entity> entities = new();
	public IObservable<CollectionAddEvent<Entity>> OnEntitiesAdd
	{
		get { return entities.ObserveAdd(); }
	}
	public IObservable<CollectionRemoveEvent<Entity>> OnEntitiesRemove
	{
		get { return entities.ObserveRemove(); }
	}
	public BattleManagerWithDI()
	{
		
	}
	public void AddEntity()
	{
		var random = new Random().Next(0, 100);

		entities.Add(GetEntity(random));
	}
	public void RemoveEntity()
	{
		if (entities.Count == 0) return;
		entities.RemoveAt(entities.Count - 1);
	}
	public Entity GetEntity(int hp)
	{
		var entityName = hp switch
		{
			< 10 => "Slime",
			< 20 => "Goblin",
			< 30 => "Knight",
			< 40 => "Dragon",
			< 50 => "Wizard",
			< 60 => "Devil",
			< 70 => "Super Dragon",
			< 80 => "Satan",
			< 90 => "Satan Dragon",
			< 100 => "Ultimate Slime",
			_ => "???"
		};

		return new(entityName, hp);
	}
}
