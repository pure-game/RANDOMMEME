using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class SaveAndLoad
{
    static string upPath = Application.persistentDataPath + "/upString.de";
    static string downPath = Application.persistentDataPath + "/downString.de";

    public static void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream upFile = File.Create(upPath);
        FileStream downFile = File.Create(downPath);
        bf.Serialize(upFile, MemLists.strings_up);
        bf.Serialize(downFile, MemLists.strings_down);
        upFile.Close();
        downFile.Close();
    }

    public static void Load()
    {
        BinaryFormatter bf = new BinaryFormatter();
        if (File.Exists(upPath))
        {
            FileStream upFile = File.Open(upPath, FileMode.Open);
            MemLists.strings_up = (List<string>)bf.Deserialize(upFile);
            upFile.Close();
        }
        if (File.Exists(downPath))
        {
            FileStream downFile = File.Open(downPath, FileMode.Open);
            MemLists.strings_down = (List<string>)bf.Deserialize(downFile);
            downFile.Close();
        }
    }
}
