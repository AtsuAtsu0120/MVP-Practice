using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

public class BattleTest
{
    //そもそも本来PrivateメソッドであるべきGetEntityのテストをするべきなのか…？
    [Test]
    public void GetEntity_HPが9_敵がスライム()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(9);

        Assert.That(entity.Name == "Slime");
    }
    [Test]
    public void GetEntity_HPが10_敵がゴブリン()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(10);

        Assert.That(entity.Name == "Goblin");
    }
    [Test]
    public void GetEntity_HPが19_敵がゴブリン()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(19);

        Assert.That(entity.Name == "Goblin");
    }
    [Test]
    public void GetEntity_HPが20_敵が戦士()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(20);

        Assert.That(entity.Name == "Knight");
    }
    [Test]
    public void GetEntity_HPが29_敵が戦士()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(20);

        Assert.That(entity.Name == "Knight");
    }
    [Test]
    public void GetEntity_HPが30_敵がドラゴン()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(30);

        Assert.That(entity.Name == "Dragon");
    }
    //続く
}
