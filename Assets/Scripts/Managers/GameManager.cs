using System;

public class GameManager : Singleton<GameManager>
{
    private int levelPlayed;
    private TimeSpan time;

    public void Awake()
    {
        time = DateTime.Now.TimeOfDay;
    }

    public void StartGame()
    {
        SceneManager.Instance.LoadRandomLevel();
        levelPlayed++;
    }

    public void NextLevel()
    {
        if (levelPlayed < Constants.LevelsToPlay)
        {
            SceneManager.Instance.LoadRandomLevel();
            levelPlayed++;
        }

        GameOver();
    }

    private void GameOver()
    {
    }

    public TimeSpan GetTime()
    {
        return DateTime.Now.TimeOfDay - time;
    }
}
