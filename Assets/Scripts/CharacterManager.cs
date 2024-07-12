using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEditor.SearchService;
using Unity.VisualScripting;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;


public class CharacterManager : MonoBehaviour
{ 

    public CharacterDatabase characterDB;

    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] List<Sprite> Chars = new();
    [SerializeField] GameObject Char;
    public Text nameText;

    private int selectedOption = 0;

    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }

        else
        {
            Load();
        }

        spriteRenderer.sprite = Chars[selectedOption]; 
    }

    public void NextOption()
    {
        selectedOption++;
        if(selectedOption >= characterDB.CharacterCount)
        {
            selectedOption = 0;
        }

        UpdateCharacter(selectedOption);
        spriteRenderer.sprite = Chars[selectedOption];
        PlayerPrefs.Save();
    }

    public void BackOption()
    {
        selectedOption--;
        if(selectedOption < 0)
        {
            selectedOption = characterDB.CharacterCount - 1;
        }

        UpdateCharacter(selectedOption);
        spriteRenderer.sprite = Chars[selectedOption];
        PlayerPrefs.Save();
    }

    private void UpdateCharacter(int selectedOption)
    {
        Character character = characterDB.GetCharacter(selectedOption);
        _ = character.Char;
        nameText.text = character.characterName;
    }

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

    public void ChangeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
