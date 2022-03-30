using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;


public class DataScript : MonoBehaviour
{
   public string Myname = "Keertana";
    public int Myage = 21;
   // public String fileName = "SampleDataFile";
    public string filePath = "C:/Users/Keertana.Govte/Desktop/Unity/MyData/SampleDataFile.txt";

    // Start is called before the first frame update
    void Start()
    {
        /* if(File.Exists(fileName))
           {
               using FileStream fileStream = File.Open(fileName, FileMode.Open);
               using BinaryReader binaryReader = new(fileStream);
               Myage = binaryReader.ReadInt32();




           }*/
      /* StreamWriter streamWriter = new StreamWriter(filePath);
        

        // StreamWriter streamWriter1 = new StreamWriter(filePath);
        streamWriter.WriteLine(Myage);
        streamWriter.WriteLine(Myname);
        streamWriter.Close();
      

        StreamReader streamReader = new StreamReader(filePath);
       // StreamReader stream = new StreamReader(filePath);
       // StreamReader stream1 = new StreamReader(filePath);
        Debug.Log(streamReader.ReadToEnd());
       // Debug.Log(stream.ReadToEnd());
     */







    }

    public void CreateText()
    {
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        BinaryWriter bw = new BinaryWriter(fileStream);
        bw.Write(Myage);
        bw.Write(Myname);
        bw.Write("Keertana");
        bw.Write(30.7f);
        bw.Write(true);
        bw.Close();
        fileStream.Close();
    }
    public void ReadText()
    {
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        BinaryReader bw = new BinaryReader(fileStream);
       Debug.Log( bw.Read());
     
        bw.Close();
        fileStream.Close();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.W))
        {
            CreateText();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReadText();
        }

    }
}
