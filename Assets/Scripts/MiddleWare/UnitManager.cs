using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    public static UnitManager singleton {get; private set;} = null;

    public Dictionary<int, IUnit> unitsTable {get; private set;} = default;

    public void Awake(){
        MakeSingleton();
    }

    #region Make Singleton

    private void MakeSingleton(){
        if(singleton == null){
            singleton = this;
            Debug.Log("UnitManager Loaded.");
        }
        else{
            Debug.LogError("중복된 UnitManager 생성. 삭제합니다.");
            Destroy(this);
            Debug.Log("중복된 UnitManager 제거.");
        }
    }

    #endregion
}
