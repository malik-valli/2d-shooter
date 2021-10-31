using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGameKey : MonoBehaviour
{
    private InputManager inputManager;

    private void Start() {
        inputManager = InputManager.instance;
    }

    void Update()
    {
        if (inputManager.pausePressed)
        {
            QuitGame();
        }
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
