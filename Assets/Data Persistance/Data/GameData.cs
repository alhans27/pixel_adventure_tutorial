using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameData
{
    public int item = GameManager.Instance.GetItem();
    public int highscore = GameManager.Instance.GetHighScore();
    public int level = GameManager.Instance.GetLevel();
}
