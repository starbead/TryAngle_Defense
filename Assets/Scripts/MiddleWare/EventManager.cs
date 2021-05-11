using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace MinShigee
{
    public class EventManager : MonoBehaviour
    {
	
    	public static EventManager singleton {get; private set;} = null;
		private void Awake(){
			MakeSingleton();
        }

        #region Make Singleton

        public void MakeSingleton(){
			if(singleton == null){
                singleton = this;
                Debug.Log("EventManager Loaded");
            }
            else{
                Destroy(this);
                Debug.Log("Remove EventManager");
            }
        }
        #endregion
        
    }
}