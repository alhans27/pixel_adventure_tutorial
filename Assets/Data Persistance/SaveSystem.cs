using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/savedata.txt";

        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData();

        formatter.Serialize(stream, data);
        stream.Close();
        Debug.Log("Game Tersimpan");
        Debug.Log("Level Tersimpan: " + data.level);
    }

    public static GameData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/savedata.txt";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Data tidak ada di " + path);
            return null;
        }

    }
}
