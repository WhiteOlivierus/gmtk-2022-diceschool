using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SceneManagement = UnityEngine.SceneManagement;

public class SceneManager : Singleton<SceneManager>
{
    private string loadedScene = Constants.EntryScene;
    private IList<string> AllScenes { get; set; } = new List<string>();
    private IList<string> AllLevels { get; set; } = new List<string>();

    private void Awake()
    {
        CollectScenes();
        AllLevels = AllScenes.Where(sceneName => sceneName.Contains(Constants.LevelIdentifier)).ToList();
        SceneManagement.SceneManager.LoadScene(Constants.EntryScene, SceneManagement.LoadSceneMode.Additive);
    }

    internal void LoadRandomLevel()
    {
        SceneManagement.SceneManager.UnloadSceneAsync(loadedScene);

        int randomIndex = new Random().Next(AllLevels.Count);
        string sceneName = AllLevels[randomIndex];
        SceneManagement.SceneManager.LoadScene(sceneName, SceneManagement.LoadSceneMode.Additive);
        loadedScene = sceneName;
    }

    private void CollectScenes()
    {
        int sceneCount = SceneManagement.SceneManager.sceneCountInBuildSettings;

        for (int i = 0; i < sceneCount; i++)
        {
            AllScenes.Add(Path.GetFileNameWithoutExtension(SceneManagement.SceneUtility.GetScenePathByBuildIndex(i)));
        }
    }
}
