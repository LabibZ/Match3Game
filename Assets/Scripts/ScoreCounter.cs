using TMPro;
using UnityEngine;

public sealed class ScoreCounter : MonoBehaviour {
    public static ScoreCounter Instance { get; private set; }

    private int _score;

    [SerializeField] private TextMeshProUGUI scoreText;

    public int Score {
        get { return _score; }
        set {
            if (_score == value) return;
            _score = value;

            scoreText.SetText($"{_score}");
        }
    }

    private void Awake() {
        Instance = this;
    }
}
