using UnityEngine;

public class GoToMainMenu : MonoBehaviour
{
    void Start()
    {
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(
        () =>
        {
            GameObject.Find("NetworkMaster").GetComponent<NetworkMaster>().StopServer();
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        });
    }
}
