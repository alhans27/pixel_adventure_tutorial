using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    private int highscore;
    private int item;
    private int level;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = "GameManager";
                    instance = obj.AddComponent<GameManager>();
                    DontDestroyOnLoad(obj);
                }
            }
            return instance;
        }
    }

    public int GetItem()
    {
        return item;
    }

    public void SetItem(int value)
    {
        item = value;
        if (item > highscore)
        {
            GameManager.Instance.SetHighScore(item);
        }
    }

    public int GetHighScore()
    {
        return highscore;
    }

    public void SetHighScore(int value)
    {
        highscore = value;
    }

    public int GetLevel()
    {
        return level;
    }

    public void SetLevel(int value)
    {
        level = value;
    }

    // Tambahkan metode dan logika lain yang diperlukan untuk game Anda
}
