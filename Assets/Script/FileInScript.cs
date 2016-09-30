using UnityEngine;
using System.IO;
using System.Collections;

public class FileInScript : MonoBehaviour {
	private StreamReader positionReader;

	void OnEnable() {
		positionReader = new StreamReader("PositionLog.txt");
	}
	void OnDisable() {
		positionReader.Close();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (!positionReader.EndOfStream) {
			var _str = positionReader.ReadLine().Split(',');
			var position = new Vector3 (float.Parse(_str[0]),float.Parse(_str[1]),float.Parse(_str[2]));
			this.gameObject.transform.position = position;
		}
	
	}
}
