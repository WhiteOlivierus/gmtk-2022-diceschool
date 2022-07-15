using System;

public class GameManager : Singleton<GameManager>
{
    private int levelPlayed;

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
        throw new NotImplementedException("Game over");
    }
}
