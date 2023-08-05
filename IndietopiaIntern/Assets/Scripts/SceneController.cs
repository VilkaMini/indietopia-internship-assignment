using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController: MonoBehaviour
{
    public void SwitchToGame()
    {
        SceneManager.LoadScene("MovieSet");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
