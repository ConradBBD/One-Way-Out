using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{

    private AudioClip startSound;

    private void Start()
    {
        startSound = (AudioClip)Resources.Load("Press_Play");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }
}
