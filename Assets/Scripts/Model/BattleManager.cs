using System;
using UniRx;

public class BattleManager
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
    public BattleManager()
    {
        Model.BattleManager = this;
        entities.Add(new Entity("Slime", 10));
    }
    public void AddEneity()
    {
        var random = new Random().Next(0, 100);

        entities.Add(GetEntity(random));
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
