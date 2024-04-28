using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public void Awake() {
        scoreText.SetText($"Your Score\n{ScoreCounter.Instance.Score}");
    }

    public void Retry() {
        SceneManager.LoadSceneAsync(1);
    }

    public void MainMenu() {
        SceneManager.LoadSceneAsync(0);
    }
}
