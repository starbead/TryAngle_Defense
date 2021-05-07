using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    /// <summary>
    /// 체력. // 데미지를 입으면 감소한다.
    /// </summary>
    public float health{get; set;}

    /// <summary>
    /// 입은 데미지를 감소시키는 수치 // 수식은 아직 미정. 
    /// </summary>
    public float defence{get; set;}  
}
