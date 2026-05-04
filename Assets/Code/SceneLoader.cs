using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        AudioManager.Instance.PlaySFX(AudioManager.Instance.buttonSFX);
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }

    public void ReloadScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        AudioManager.Instance.PlaySFX(AudioManager.Instance.buttonSFX);
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
