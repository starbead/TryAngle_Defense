using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace MinShigee
{
    public class EventManager{
	
    	public static EventManager singleton {get; private set;} = null;
		private void Awake(){
			MakeSingleton();
        }

        #region Make Singleton

        public void MakeSingleton(){
			if(singleton == null){
                singleton = this;
                Debug.log("EventManager Loaded");
            }
            else{
                Destroy(this);
                Debug.log("Remove EventManager");
            }
        }
        #endregion
        
    }
}