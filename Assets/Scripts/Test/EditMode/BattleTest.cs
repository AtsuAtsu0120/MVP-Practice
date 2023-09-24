using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

public class BattleTest
{
    //���������{��Private���\�b�h�ł���ׂ�GetEntity�̃e�X�g������ׂ��Ȃ̂��c�H
    [Test]
    public void GetEntity_HP��9_�G���X���C��()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(9);

        Assert.That(entity.Name == "Slime");
    }
    [Test]
    public void GetEntity_HP��10_�G���S�u����()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(10);

        Assert.That(entity.Name == "Goblin");
    }
    [Test]
    public void GetEntity_HP��19_�G���S�u����()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(19);

        Assert.That(entity.Name == "Goblin");
    }
    [Test]
    public void GetEntity_HP��20_�G����m()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(20);

        Assert.That(entity.Name == "Knight");
    }
    [Test]
    public void GetEntity_HP��29_�G����m()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(20);

        Assert.That(entity.Name == "Knight");
    }
    [Test]
    public void GetEntity_HP��30_�G���h���S��()
    {
        var battleManager = new BattleManager();

        var entity = battleManager.GetEntity(30);

        Assert.That(entity.Name == "Dragon");
    }
    //����
}
