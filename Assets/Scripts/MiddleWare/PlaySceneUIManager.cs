using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace MinZu{
    public class PlaySceneUIManager : MonoBehaviour
    {
		public static PlaySceneUIManager singleton {get; private set; } = null;

        #region Make Singleton

        private void MakeSingleton(){
            if(singleton == null){

				singleton = this;
                Debug.Log("PlaySceneManager loaded.");

            }
            else{
				Destroy(this);
                Debug.Log("Destroy PlaySceneManager");
            }
        }

        #endregion
    }
}