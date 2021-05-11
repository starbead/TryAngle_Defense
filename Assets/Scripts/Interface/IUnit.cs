using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUnit : IAttackable, IDamageable
{
    int code{get; set;}
}
