using System.ComponentModel;
using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace GameEventManager
{
    public enum EventCode{
        Default = 0,

    }

    public class EventManager : MonoBehaviour, IEventManager
    {
	
    	public static EventManager singleton {get; private set;} = null;
        public EventCode curEvent {get; set;} = EventCode.Default;
        public Dictionary<EventCode, IGameEvent> eventTable = default;

		private void Awake(){
			MakeSingleton();
            MakeEventTable();
        }


        /***************************/
        #region  Init

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
        
        #region Make eventTable

        public void MakeEventTable(){
            eventTable = new Dictionary<EventCode, IGameEvent>();
            eventTable.Add(EventCode.Default, default);
        }

        #endregion
        
        #endregion
        /****************************/
        
        public void ChangeEventMode(EventCode toMode){
            curEvent = toMode;
            ExcuteEventMode(curEvent);
            return;
        }

        public void ExcuteEventMode(EventCode code){
            var gameEvent = eventTable[code];
            gameEvent.ExcuteGameEvent();
            return;
        }
    }
}