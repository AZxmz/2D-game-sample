using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    /*CharacterManager£º In charge of selected character is active.
     */
    public GameObject[] characters; 

    void Start()
    {
        string selectedCharacter = CharacterSelectUI.instance.selectedCharacterName;

        foreach (GameObject character in characters)
        {
            if (character.name == selectedCharacter)
            {
                character.SetActive(true);
            }
            else
            {
                character.SetActive(false);
            }
        }
    }
}