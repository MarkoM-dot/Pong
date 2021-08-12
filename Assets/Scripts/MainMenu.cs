using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayTournament()
    {
        //SceneManager.LoadScene(2);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void OptionsMenu()
    {

    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
