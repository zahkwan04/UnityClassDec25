using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    int score;
    public TMP_Text text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        
    }

    public void AddScore(int scoreIn)
    {
        score = score + scoreIn;
        text.text = score.ToString();
    }
}
