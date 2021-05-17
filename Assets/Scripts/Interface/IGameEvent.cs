using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEventManager
{
    public interface IGameEvent
    {
        void ExcuteGameEvent();
        float attackMul{get; set;}
        float damagedMul{get; set;}
        float attackSpeedMul{get; set;}
        float moveSpeedMul{get; set;}
        float skillCostMul{get; set;}
        float costMul{get; set;}
    }
}
