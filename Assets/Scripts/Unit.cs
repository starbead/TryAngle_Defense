using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public bool lMoveable = false;
    public bool lDamageable = false;
    public bool lAttackable = false;
    public bool lSpawnable = false;

}

public class Tower : Unit{
    public bool lSkillable = false;
    
}
