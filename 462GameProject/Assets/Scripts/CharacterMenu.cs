using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMenu : MonoBehaviour
{
    public GameObject character;
    public void Submit() {
        PrefabUtility.SaveAsPrefabAsset(character, "Assets/Prefabs/Player.prefab");
        SceneManager.LoadScene(2);
    }
}
