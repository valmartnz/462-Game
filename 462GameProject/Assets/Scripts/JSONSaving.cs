using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JSONSaving : MonoBehaviour {
    
    private Player player;
    private string path = "";
    private string persistentPath = "";

    // Start is called before the first frame update
    void Start()
    {
        CreatePlayer();
        SetPaths();
    }

    private void CreatePlayer() {
        player = new Player();
    }

    private void SetPaths() {
        path = Application.dataPath + Path.AltDirectorySeparatorChar + "SaveData.json";
        persistentPath = Application.persistentDataPath + Path.AltDirectorySeparatorChar + "SaveData.json";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1)) { SaveData(); }
        if(Input.GetKeyDown(KeyCode.F2)) { LoadData(); }
    }

    public void SaveData() {
        string savePath = persistentPath;

        Debug.Log("Saving Data at " + savePath);
        string json = JsonUtility.ToJson(player);
        Debug.Log(json);

        using StreamWriter writer = new StreamWriter(savePath);
        writer.Write(json);
    }

    public void LoadData() {
        using StreamReader reader = new StreamReader(persistentPath);
        string json = reader.ReadToEnd();

        Player data = JsonUtility.FromJson<Player>(json);
        Debug.Log(data.ToString());
    }
}
