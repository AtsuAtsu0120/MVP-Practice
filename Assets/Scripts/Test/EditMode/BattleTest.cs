using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

public class BattleTest
{
    //そもそも本来PrivateメソッドであるべきGetEntityのテストをするべきなのか…？
    [Test]
    public void GetEntity_HPが9()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(9);

        Assert.That(entity.Name == "Slime");
    }
    [Test]
    public void GetEntity_HPが10()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(10);

        Assert.That(entity.Name == "Goblin");
    }
    [Test]
    public void GetEntity_HPが19()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(19);

        Assert.That(entity.Name == "Goblin");
    }
    [Test]
    public void GetEntity_HPが20()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(20);

        Assert.That(entity.Name == "Knight");
    }
    [Test]
    public void GetEntity_HPが29()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(20);

        Assert.That(entity.Name == "Knight");
    }
    [Test]
    public void GetEntity_HPが30()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(30);

        Assert.That(entity.Name == "Dragon");
    }
    //続く
}
