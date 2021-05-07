using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Packet : MonoBehaviour
{
    enum AddTowerStat{
        AttackPower = 0,
        AttackSpeed = 1,
        AttackRange = 2,
        Health = 3,
        Defence = 4
    }

    enum SkillAttributeCode{
        Fire = 0,
        Ice = 1,
        // ...
    }

}
