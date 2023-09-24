using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

public class BattleTest
{
    //���������{��Private���\�b�h�ł���ׂ�GetEntity�̃e�X�g������ׂ��Ȃ̂��c�H
    [Test]
    public void GetEntity_HP��9()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(9);

        Assert.That(entity.Name == "Slime");
    }
    [Test]
    public void GetEntity_HP��10()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(10);

        Assert.That(entity.Name == "Goblin");
    }
    [Test]
    public void GetEntity_HP��19()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(19);

        Assert.That(entity.Name == "Goblin");
    }
    [Test]
    public void GetEntity_HP��20()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(20);

        Assert.That(entity.Name == "Knight");
    }
    [Test]
    public void GetEntity_HP��29()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(20);

        Assert.That(entity.Name == "Knight");
    }
    [Test]
    public void GetEntity_HP��30()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(30);

        Assert.That(entity.Name == "Dragon");
    }
    //����
}
