using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

	public void MyStartHost () {
		StartHost ();
		Debug.Log (Time.timeSinceLevelLoad + " Starting Host at ");
	}

	public override void OnStartHost() {
		Debug.Log ( Time.timeSinceLevelLoad + "Host started");
	}

	public override void OnStartClient (NetworkClient client) {
		Debug.Log (Time.timeSinceLevelLoad + " Client start requested.");
		InvokeRepeating ("PrintDot", 0, 1f);
	}

	public override void OnClientConnect (NetworkConnection conn) {
		Debug.Log (Time.timeSinceLevelLoad + " Client is connected to IP: " + conn.address);
		CancelInvoke ();
	}

	void PrintDot () {
		print (".");
	}
}
