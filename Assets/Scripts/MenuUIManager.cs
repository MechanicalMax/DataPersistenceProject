using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
# if UNITY_EDITOR
using UnityEditor;
# endif

public class MenuUIManager : MonoBehaviour
{
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void NameEntered(string name)
    {
        PersistentData.Instance.PlayerName = name;
        PersistentData.Instance.UpdateSceneBestDisplay();
    }
    public void Exit()
    {
        PersistentData.Instance.SaveBest();
# if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
# else
        Application.Quit();
# endif
    }
}
