using UnityEngine;
using System.IO;

public class JSONDes : MonoBehaviour
{
    private string _path;
    private string _jsonString;

    private void Start()
    {
        _path = Application.streamingAssetsPath + "/CreatureChubaka.json";
        _jsonString = File.ReadAllText(_path);
        Creature Chubaka = JsonUtility.FromJson<Creature>(_jsonString);
        Debug.Log(Chubaka.Name);        
    }
}

[System.Serializable]
public class Creature
{
    public string Name;
    public int Level;
    public int[] Stats;
}
