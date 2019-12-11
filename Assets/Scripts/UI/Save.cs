using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Main").GetComponent<Main>().AddReference("SaveButton", gameObject);
        GetComponent<Button>().onClick.AddListener(OnClick);
        gameObject.SetActive(false);
    }

    private void OnClick()
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(@"settings.dat", FileMode.OpenOrCreate)))
        {
            writer.Write(GameObject.Find("NumberOfPersons").GetComponent<Slider>().value);
            writer.Close();
        }
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("Main").GetComponent<Main>().music_volume = GameObject.Find("NumberOfPersons").GetComponent<Slider>().value;
    }
}
