using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class SettingsMain : MonoBehaviour
{
    Main handler
    {
        get => GameObject.Find("Main").GetComponent<Main>();
    }
    // Use this for initialization
    void Start()
    {
        handler.AddReference("SettingsMain", gameObject);
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        handler.objRefs["Back"].SetActive(true);
        handler.objRefs["NumbText"].SetActive(true);
        handler.objRefs["NumberOfPersons"].SetActive(true);
        handler.objRefs["SaveButton"].SetActive(true);
        GameObject.Find("NumbText").GetComponent<Text>().text = "Music volume:";
        GameObject.Find("Name").GetComponent<Text>().text = "Settings";

        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Main UI"))
        {
            obj.SetActive(false);
        }

        //настраиваем слайдер
        Slider slider = GameObject.Find("NumberOfPersons").GetComponent<Slider>();
        slider.maxValue = 1;
        slider.minValue = 0;
        slider.value = GameObject.Find("Main").GetComponent<Main>().music_volume;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
