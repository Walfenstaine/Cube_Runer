using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Andlevel : MonoBehaviour
{
    public Data data;
    public string nextLvl;
    public void NextLevel()
    {
        data.currentScene = nextLvl;
        SaveAndLoad.Instance.Save();
        SceneManager.LoadScene(nextLvl);
    }
    public void Reload()
    {
        SaveAndLoad.Instance.Save();
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
