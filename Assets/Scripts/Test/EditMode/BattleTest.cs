using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

public class BattleTest
{
    //‚»‚à‚»‚à–{—ˆPrivateƒƒ\ƒbƒh‚Å‚ ‚é‚×‚«GetEntity‚ÌƒeƒXƒg‚ğ‚·‚é‚×‚«‚È‚Ì‚©cH
    [Test]
    public void GetEntity_HP‚ª9_“G‚ªƒXƒ‰ƒCƒ€()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(9);

        Assert.That(entity.Name == "Slime");
    }
    [Test]
    public void GetEntity_HP‚ª10_“G‚ªƒSƒuƒŠƒ“()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(10);

        Assert.That(entity.Name == "Goblin");
    }
    [Test]
    public void GetEntity_HP‚ª19_“G‚ªƒSƒuƒŠƒ“()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(19);

        Assert.That(entity.Name == "Goblin");
    }
    [Test]
    public void GetEntity_HP‚ª20_“G‚ªím()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(20);

        Assert.That(entity.Name == "Knight");
    }
    [Test]
    public void GetEntity_HP‚ª29_“G‚ªím()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(20);

        Assert.That(entity.Name == "Knight");
    }
    [Test]
    public void GetEntity_HP‚ª30_“G‚ªƒhƒ‰ƒSƒ“()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(30);

        Assert.That(entity.Name == "Dragon");
    }
    //‘±‚­
}
