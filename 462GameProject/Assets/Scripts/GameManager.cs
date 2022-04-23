using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake() {
        if(GameManager.instance != null) {
            Destroy(gameObject);
            return;
        }

        instance = this;
    }

    // Resources
    public List<Sprite> platerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrices;
    public List<int> xpTable;

    // References 
    public Player player;

    // Logic 
    public int coins;
    public int experience;


    // Saving and loading state
    public void SaveState() {
        Debug.Log("SaveState");

        string s = "";

        s += "0" + "|";                     // s[0]: Skin
        s += coins.ToString() + "|";          // s[1]: Coins
        s += experience.ToString() + "|";   // s[2]: XP
        s += "0";                           // s[3]: Weapon Level

        PlayerPrefs.SetString("SaveState", s);

    }
    public void LoadState() {
        Debug.Log("LoadState");

        if(!PlayerPrefs.HasKey("SaveState")) 
            return;

        string[] data = PlayerPrefs.GetString("SaveState").Split('|');  // Splits s by | and saves to an array
        
        // TODO: Change the Player's skin
        coins = int.Parse(data[1]);
        experience = int.Parse(data[2]);
        // TODO: Change the Weapon's Level

    }
}
