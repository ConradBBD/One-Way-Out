using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager musicManager;

    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this);

        if (musicManager == null)
        {
            musicManager = this;
        } else
        {
            Destroy(gameObject);
        }
    }
}
