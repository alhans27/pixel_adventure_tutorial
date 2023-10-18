using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int collectItems = 0;
    [SerializeField] private Text countText;
    [SerializeField] private Text highscoreText;
    [SerializeField] private AudioSource collectSoundEffect;

    private int highscore;

    private void Start()
    {
        highscore = GameManager.Instance.GetHighScore();
        highscoreText.text = $"Highscore : {highscore}";
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("CollectableItem"))
        {
            collectSoundEffect.Play();
            Destroy(other.gameObject);
            collectItems++;
            GameManager.Instance.SetItem(collectItems);
            countText.text = collectItems.ToString();
            // Debug.Log("Item yang tersimpan : " + GameManager.Instance.GetItem());
        }
    }
}