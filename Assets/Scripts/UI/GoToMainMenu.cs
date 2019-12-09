public class GoToMainMenu : UnityEngine.MonoBehaviour
{
    void Start()
    {
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() => UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu"));
    }
}
