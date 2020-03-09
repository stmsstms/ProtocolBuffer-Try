using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jaihk662;
using Google.Protobuf;
using System.IO;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TestForProto testForProto = new TestForProto();
        testForProto.Name = "stms";
        Debug.Log(testForProto.ToByteArray());
        Debug.Log(Application.dataPath);
        FileStream fileStream = new FileStream(Application.dataPath + "/local/file.txt", FileMode.OpenOrCreate, FileAccess.Write);
        StreamWriter streamWriter = new StreamWriter(fileStream);
        //fileStream.
        //streamWriter.Write("ddddddddddddddddd");
        fileStream.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
