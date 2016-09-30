using UnityEngine;
using System.IO;
using System.Collections;

public class FileOutScript : MonoBehaviour {
	private StreamWriter positionLog;

	void OnEnable() {
		positionLog = new StreamWriter("PositionLog.txt",false);
	}

	void OnDisable() {
		positionLog.Close();
	}

	// Use this for initialization
	void Start () {
		WriteText("test_file.txt","hogehoge");
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 position = this.gameObject.transform.position;
		WriteLine(positionLog,GetPositonString(position));
	
	}

	// [_filePath]
	// Running in Editor, root path is the project root path.
	// Running in Application, root path is the Application existing folder path.
	public void WriteText( string _filePath, string _contents ){
		StreamWriter sw;
		sw = new StreamWriter(_filePath, false);
		sw.WriteLine(_contents);
		sw.Close();
	}

	private void WriteLine(StreamWriter _sw, string _line ) {
		_sw.WriteLine(_line);
	}

	private string GetPositonString(Vector3 _position) {
		return _position.x + "," + _position.y + "," + _position.z;
	}
}
