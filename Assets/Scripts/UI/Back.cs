using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Back : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        objHandler.AddReference("Back", gameObject);
        gameObject.GetComponent<Button>().onClick.AddListener(OnClick);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnClick()
    {
        foreach (GameObject obj in objHandler.objRefs.Values)
        {
            if (obj.CompareTag("Main UI")) obj.SetActive(true);
        }

        foreach (GameObject obj in objHandler.objRefs.Values)
        {
            if (obj.CompareTag("Game UI")) obj.SetActive(false);
        }
    }
}
