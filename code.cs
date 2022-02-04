using UnityEngine;
using System;
using System.IO;

// SAVE
class Test
{
    public static void Main()
    {
        string path = @"c:\temp\MyTest.txt";
        // This text is added only once to the file.
        if (!File.Exists(path))
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hello");
            }	
        }
    }
}

// LOAD

using UnityEngine;
using System.Collections;
using System;
using System.IO;
 
public class LineReader : MonoBehaviour
{
    protected FileInfo theSourceFile = null;
    protected StreamReader reader = null;
    protected string text = " "; // assigned to allow first line to be read below
    string objmode ==
    
    void Start () {
        theSourceFile = new FileInfo ("Test.txt");
        reader = theSourceFile.OpenText();
    }
   
    void Update () {
        if (text != null) {
            text = reader.ReadLine();
            if (objmode == "dirt") 
            {
                Instatiate(prefab, new Coords(VECTOR2), Quaternion.identity);
            } 
            text = reader.ReadLine();
        }
    }
}
