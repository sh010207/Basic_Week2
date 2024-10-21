using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public ScoreButton scoreButton;
    public TextMeshProUGUI scoreText;
    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreButton.OnScoreChanged += RefreshUI;
    }

    void RefreshUI(int newscore)
    {
        scoreText.text = newscore.ToString();
    }
}
