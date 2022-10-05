using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    public void ExitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
