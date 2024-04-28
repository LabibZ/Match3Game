using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void Restart() {
        SceneManager.LoadSceneAsync(1);
    }
}
