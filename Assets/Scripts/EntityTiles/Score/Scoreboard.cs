using UnityEngine;

public class Scoreboard
{
    private int highscore;

    public Scoreboard()
    {
        LoadScore();
    }

    private void LoadScore()
    {
        highscore = PlayerPrefs.GetInt("Highscore");
    }

    private void SaveScore()
    {
        PlayerPrefs.SetInt("Highscore", highscore);
    }

    public bool SetScore(int _newScore)
    {
        if (_newScore > highscore)
        {
            highscore = _newScore;
            SaveScore();
            return true;
        }
        return false;
    }

    public int GetScore()
    {
        LoadScore();
        return highscore;
    }

    public void ResetScoreboard()
    {
        PlayerPrefs.SetInt("Highscore", 0);
    }
}
