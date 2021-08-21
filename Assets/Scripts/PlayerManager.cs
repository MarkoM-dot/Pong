using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public PlayerDatabase playerDatabase;

    public SpriteRenderer paddleArt;

    int selectedOption = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }
        
        UpdatePlayer(selectedOption);
    }
    public void NextOption()
    {
        selectedOption ++;

        if (selectedOption >= playerDatabase.PlayerCount)
        {
            selectedOption = 0;
        }
        UpdatePlayer(selectedOption);
        Save();
    }
    public void BackOption()
    {
        selectedOption--;
        if (selectedOption < 0)
        {
            selectedOption = playerDatabase.PlayerCount - 1;
        }
        UpdatePlayer(selectedOption);
        Save();
    }
    void UpdatePlayer(int selectedOption)
    {
        Player player = playerDatabase.GetPlayer(selectedOption);
        paddleArt.sprite = player.paddleSprite;
    }
    void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }
    void Save()
    {
        PlayerPrefs.SetInt("selectedOption", selectedOption);
    }
    public void EnterTournament() 
    {
        SceneManager.LoadScene(2);
    }
}
