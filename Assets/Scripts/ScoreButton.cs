using System;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class ScoreButton : MonoBehaviour
{
    public Button scoreButton;
    public int score = 0;
    public Action<int> OnScoreChanged;

    private void Awake()
    {
        scoreButton = GetComponent<Button>();
        scoreButton.onClick.AddListener(PointUp);
    }

    void PointUp()
    {
        score++;
        OnScoreChanged?.Invoke(score);
        AnimationController.instance.OnMouseDown();
    }
}
