using UnityEngine;
using System.Collections;

public class PlayMenu : MonoBehaviour
{
    public void PlayLevel(int i)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(i);
    }
}
