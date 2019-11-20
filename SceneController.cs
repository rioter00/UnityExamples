using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// basic scene controller
public class SceneController : MonoBehaviour
{
    private int currentSceneIndex;

    private void Awake()
    {
        // grabs the current scene's index
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // feed the desired scene index to load
    public void loadScene(int sceneIndex)
    {
        loadScene(sceneIndex);
    }

    // feed the desired scene name (a string -- use QUOTES) to load
    public void loadScene(string sceneName)
    {
        loadScene(sceneName);
    }

    // adds 1 to the current scene index and loads it
    public void loadNextScene()
    {
        loadScene(currentSceneIndex + 1);
    }

    // reload the current scene
    public void ReloadScene()
    {
        loadScene(currentSceneIndex);
    }
}
