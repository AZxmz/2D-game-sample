using UnityEngine;
using UnityEngine.SceneManagement;

/*Used to unify the playback of various sound effects (SFX) in the game.
 */
public class CharacterSelectUI : MonoBehaviour
{
    public static CharacterSelectUI instance;

    private void Awake()
    {
        instance = this;
    }
    public string selectedCharacterName;
    public void SelectCharacter(string characterName)
    {
        PlayerPrefs.SetString("SelectedCharacter", characterName);
        selectedCharacterName = characterName;
        SceneManager.LoadScene("Main");

    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}