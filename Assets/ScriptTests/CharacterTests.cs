using NUnit.Framework;
using UnityEngine;

public class CharacterTests
{
    [Test(Description = "角色攻擊敵人")]
    public void Character_Attack_Enemy()
    {

        //arrange
        //建立角色元件
        var characterGo = new GameObject();
        characterGo.AddComponent<Character>();
        var character = characterGo.GetComponent<Character>();
        character.SetAttack(10);

        //建立敵人元件
        var enemyGo = new GameObject();
        enemyGo.AddComponent<Enemy>();
        var enemy = enemyGo.GetComponent<Enemy>();
        enemy.SetHp(100);

        //act
        character.Attack(enemy);
        
        //assert
        var enemyHp = enemy.GetHp();
        Assert.AreEqual(90,enemyHp);

    }
}
