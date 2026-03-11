using System;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    [SerializeField]
    GameObject[] characters;

    [SerializeField]
    int selectedCharacter = 0;

    bool valid = false;


    
    private void HideAllCharacters()
    {
        foreach (GameObject g in characters)
        {
            g.SetActive(false);
        }
    }
    // public void RightCharacter()
    // {
    // characters[selectedCharacter].SetActive(false);
    //     selectedCharacter++;
    //     if (selectedCharacter > characters.Length)
    //     {
    //         selectedCharacter = 0;
    //     }
    //     characters[selectedCharacter].SetActive(true);
    // }
    // public void PreviousCharacter()
    // {
    //     characters[selectedCharacter].SetActive(false);
    //     selectedCharacter--;
    //     if (selectedCharacter < characters.Length)
    //     {
    //         selectedCharacter = 3;
    //     }
    //     characters[selectedCharacter].SetActive(true);
    // }
    public void CharacterLoop()
    {
        while (selectedCharacter < characters.Length && !valid)
        {
            characters[selectedCharacter].SetActive(false);
            selectedCharacter++;
            if (selectedCharacter == characters.Length)
            {
                selectedCharacter = 0;
            }
            characters[selectedCharacter].SetActive(true);

        }
    }

}

