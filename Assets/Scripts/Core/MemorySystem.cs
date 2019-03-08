using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Core.MemorySystem
{
    public class MemorySystem
    {
        public static void NewGame(string gameName)
        {

            string pathCombined = Path.Combine(Application.persistentDataPath,
                gameName + ".data");

            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(pathCombined);
            bf.Serialize(file, new GameData(gameName, 15, 24));
            file.Close();
        }

        public static void SaveGame(GameData gameData)
        {
            string pathCombined = Path.Combine(Application.persistentDataPath,
                gameData.GameName + ".data");

            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(pathCombined);
            bf.Serialize(file, gameData);
            file.Close();
        }

        public static GameData LoadGame(string gameName)
        {

            string pathCombined = Path.Combine(Application.persistentDataPath,
                gameName + ".data");

            if (File.Exists(pathCombined))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(pathCombined, FileMode.Open);
                GameData currentGameData = (GameData)bf.Deserialize(file);
                file.Close();
                return currentGameData;
            }
            return new GameData();
        }

        public static void EreaseGame(string gameName)
        {
            string pathCombined = Path.Combine(Application.persistentDataPath, 
                gameName + ".data");

            if (File.Exists(pathCombined))
            {
                File.Delete(pathCombined);
            }
        }

        

        public static FileInfo[] FilePaths
        {
            get => new DirectoryInfo(Application.persistentDataPath + "/").GetFiles("*.data*");
        }
    }
}
