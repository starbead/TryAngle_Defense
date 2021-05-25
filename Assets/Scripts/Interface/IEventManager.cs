using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEventManager
{
    public interface IEventManager
    {
        void MakeSingleton();
        EventCode curEvent {get; set;}
        
        void MakeEventTable();
        void ChangeEventMode(EventCode toMode);
        void ExcuteEventMode(EventCode code);
    }
}
