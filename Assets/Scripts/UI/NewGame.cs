using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NewGame : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnClick()
    {
        foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("Main UI"))
            gameObject.SetActive(false);
        foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("Game UI"))
            gameObject.SetActive(true);
    }
}
