using UnityEngine;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveLoad
{
    
    public static void Save(PlayerData data)
    {
        // Set up to write a file
        var bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/saveData.txt", FileMode.OpenOrCreate);  // open or create is a must
        // save the data to the file
        bf.Serialize(file, data);
        file.Close();
        Debug.Log("File Saved..");
    }

    public static PlayerData Load()
    {
        Debug.Log("loading save data");
        if (File.Exists(Application.persistentDataPath + "/saveData.txt"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/saveData.txt", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            
            file.Close();

            return data;
        }
        else
        {
            Debug.Log("No prior saved PlayerData");
            var data = new PlayerData();
            data.ResetData();
            return data;
            //return null;
        }
    }
}
