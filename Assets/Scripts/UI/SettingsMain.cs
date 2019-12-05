using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class SettingsMain : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        objHandler.AddReference("SettingsMain", gameObject);
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        objHandler.objRefs["Back"].SetActive(true);
        objHandler.objRefs["NumbText"].SetActive(true);
        objHandler.objRefs["NumberOfPersons"].SetActive(true);
        objHandler.objRefs["SaveButton"].SetActive(true);
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
        using (BinaryReader reader = new BinaryReader(File.Open(@"settings.dat", FileMode.Open)))
        {
            slider.value = reader.ReadSingle();
            reader.Close();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
