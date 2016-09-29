using UnityEngine;
using System.IO;
using System.Collections;

public class FileIOScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		WriteText("test_file.txt","hogehoge");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// [_filePath]
	// Running in Editor, root path is the project root path.
	// Running in Application, root path is the Application existing folder path.
	public void WriteText( string _filePath, string _contents ){
		StreamWriter sw;
		sw = new StreamWriter(_filePath, true);
		sw.WriteLine(_contents);
		sw.Close();
	}
}
