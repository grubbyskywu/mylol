using UnityEngine;
using System.Collections;

public class InitMainScene : MonoBehaviour {



	// Use this for initialization
	void Start () {

		//TextAsset textAsset = Resources.Load( "Lua/ApplicationInit.lua", typeof(TextAsset)) as TextAsset;

		//StackMgr.getState ().DoString (textAsset.text);
		ApplicationInit.Start();
	}


}
