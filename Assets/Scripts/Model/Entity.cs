using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity
{
    public string Name { get; private set; }
    public int Hp { get; private set; }
    internal Entity(string name, int hp)
    {
        Name = name;
        Hp = hp;
    }
}
