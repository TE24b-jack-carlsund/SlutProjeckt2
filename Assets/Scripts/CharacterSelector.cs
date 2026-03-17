using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour
{
    public GameObject[] playerObjects;

    [SerializeField]
    int selectedCharacter = 0;

    public float switchTime = 3f;

    bool valid = false;
    public string gameScene = "Game";
    private string selectedCharacterDataName = "SelectedCharacter";

     void Start()
    {
        StartCoroutine(CharacterLoop());
        HideAllCharacters();
        selectedCharacter = PlayerPrefs.GetInt(selectedCharacterDataName, 0);
        playerObjects[selectedCharacter].SetActive(true);
    }
    private void HideAllCharacters()
    {
        foreach (GameObject g in playerObjects)
        {
            g.SetActive(false);
        }
    }
    public IEnumerator CharacterLoop()
    {
        while (true)
        {
            playerObjects[selectedCharacter].SetActive(false);
            selectedCharacter++;
            if (selectedCharacter >= playerObjects.Length)
            {
                selectedCharacter = 0;
            }
            playerObjects[selectedCharacter].SetActive(true);
             yield return new WaitForSeconds(switchTime);
        }
    }
    public void StartGame ()
    {
        PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
        SceneManager.LoadScene("Game");
    }
}

