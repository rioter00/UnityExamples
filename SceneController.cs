using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// basic scene controller
public class SceneController : MonoBehaviour
{
    public int currentSceneIndex;

    private void Awake()
    {
        // grabs the current scene's index
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // feed the desired scene index to load
    public void loadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    // feed the desired scene name (a string -- use QUOTES) to load
    public void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void delayedReload(float delay)
    {
        Invoke("ReloadScene", 2);
    }

    // adds 1 to the current scene index and loads it
    public void loadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // reload the current scene
    public void ReloadScene()
    {
        SceneManager.LoadScene(currentSceneIndex);
    }
}
