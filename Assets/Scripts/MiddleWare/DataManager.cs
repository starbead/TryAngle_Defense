using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{

    private void Awake(){
        MakeSingleton();
    }

    #region Make Singleton 
    public static DataManager singleton {get; private set;} = null;
    private void MakeSingleton(){
        if(singleton == null){
            singleton = this;
            DontDestroyOnLoad(this.gameObject);
            Debug.Log("DataManager Loaded.");
        }
        else{
            Debug.LogError("DataManager의 싱글톤이 이미 존재합니다. 중복되어 생성된 DataManager를 파괴합니다.");
            Destroy(this);
            Debug.Log("DataManager를 제거했습니다.");
        }
    }

    #endregion

}
