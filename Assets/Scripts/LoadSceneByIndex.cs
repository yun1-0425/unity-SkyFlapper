using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneByIndex : MonoBehaviour
{
    public void LoadScene(int sceneIdx)
    {
        SceneManager.LoadScene(sceneIdx);
    }
}
