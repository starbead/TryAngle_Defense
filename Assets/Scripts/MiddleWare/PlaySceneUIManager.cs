using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace MinZu{
    public class PlaySceneUIManager{
		public static PlaySceneUIManager singleton {get; private set; } = null;

        #region Make Singleton

        private void MakeSingleton(){
            if(singleton == null){

				singleton = this;
                Debug.log("PlaySceneManager loaded.");

            }
            else{
				Destroy(this);
                Debug.log("Destroy PlaySceneManager");
            }
        }

        #endregion
    }
}