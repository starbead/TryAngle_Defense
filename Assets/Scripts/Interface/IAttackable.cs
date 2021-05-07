using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttackable
{
    /// <summary>
    /// 공격했을 때 입히는 데미지.
    /// ex:) damage = 5; // 공격시 5의 데미지를 입힘.
    /// </summary>
    public float damage{get; set;}

    /// <summary>
    /// 공격을 시도하는 거리
    /// ex:) range = 5; // 5이내의 거리에서 공격.
    /// </summary>
    public float range{get; set;}
    
    /// <summary>
    /// 1초당 공격하는 횟수.
    /// ex:) attackSpeed = 0.5f; // 2초에 1번 공격.
    /// </summary>
    public float attackSpeed{get; set;}  
}

