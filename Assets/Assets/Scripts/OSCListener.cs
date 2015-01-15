using UnityEngine;
using System.Collections;
using System.Linq;

public class OSCListener : MonoBehaviour {

	public void OnEnable(){
		UnityOSCReceiver.OSCMessageReceived += new UnityOSCReceiver.OSCMessageReceivedHandler(OSCMessageReceived);
		
	}
	public void OnDisable(){
		UnityOSCReceiver.OSCMessageReceived -= new UnityOSCReceiver.OSCMessageReceivedHandler(OSCMessageReceived);
		
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OSCMessageReceived(OSC.NET.OSCMessage message){
		string address = message.Address; //this has the address
		ArrayList args = message.Values;
		/*
		 * args is an array with received parameters. args[0] gets first one. args[1] gets second one. etc.
		 * Cast to transform to desired type:
		 * (int)args[0]
		 * (float)args[1]
		 * 
		 * Typical way to use:
		 * 
		 * if (address == "/gesture/mouth/height") {
		 * 	do something, probably with args.
		 * }
		 * 
		 * Use BroadcastMessage to send message to descendants
		*/
		Debug.Log("address: "+ address + "     |     args: "+string.Join(",",args.ToArray().Select(x => x.ToString()).ToArray()));
	}
}
