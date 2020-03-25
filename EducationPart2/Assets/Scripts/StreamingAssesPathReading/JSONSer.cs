using UnityEngine;
using System.IO;

public class JSONSer : MonoBehaviour
{     
    private void Start()
    {
        Creature newCreature = new Creature();
        newCreature.Name = "Yoda";
        newCreature.Level = 1000;
        newCreature.Stats = new int[] { 20, 20 };
        string json = JsonUtility.ToJson(newCreature);

        FileStream fileStream = new FileStream(Application.streamingAssetsPath + "/CreatureYoda.json", FileMode.CreateNew);
        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(json);
        }
    }    
}
