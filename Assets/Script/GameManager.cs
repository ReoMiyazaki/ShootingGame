using UnityEngine;
using UnityEditor.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void SceneReset()
    {
        string activeSceneName = EditorSceneManager.GetActiveScene().name;
        EditorSceneManager.LoadScene(activeSceneName);
    }
    public void ChangeScene(string nextScene)
    {
        EditorSceneManager.LoadScene(nextScene);
    }
}
