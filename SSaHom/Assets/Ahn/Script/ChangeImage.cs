using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using LitJson;


public class ChangeImage : MonoBehaviour
{
    public Sprite BG;
    public Sprite Image0;
    public Sprite Image1;
    public Sprite Image2;
    public Sprite Image3;
    public Sprite Image4;
    public Sprite Image5;
    public Sprite Image6;
    public Sprite Image7;
    public Sprite Image8;
    public Sprite Image9;
    public Sprite Image10;
    public Sprite Image11;
    public Sprite Image12;
    public Sprite Image13;
    public Sprite Image14;
    public Sprite Image15;
    public Sprite Image16;
    public Sprite Image17;
    public Sprite Image18;
    public Sprite Image19;
    public Image ToolTip0;
    public TextAsset dataToolTipList;
    public Image S_Image0, S_Image1, S_Image2, S_Image3, S_Image4;

    // Start is called before the first frame update
    void Start()
    {

        string path = Path.Combine(Application.streamingAssetsPath, "ToolTip.json");
        File.ReadAllText(path);

        //FileStream fileStream = new FileStream(path, FileMode.Open);
        //byte[] data = new byte[fileStream.Length];
        //fileStream.Read(data, 0, data.Length);
        //fileStream.Close();
        //string Json = Encoding.UTF8.GetString(data); //json파일 불러오기
        
       

    }

    // Update is called once per frame
    void Update()
    {
        int id = PlayerPrefs.GetInt("Stage");
        //Debug.Log(myData[0]["id"]);

        if (id / 5 == 0)
        {
            S_Image0.sprite = Image0;
            S_Image1.sprite = Image1;
            S_Image2.sprite = Image2;
            S_Image3.sprite = Image3;
            S_Image4.sprite = Image4;
        }
        if (id / 5 == 1)
        {
            S_Image0.sprite = Image5;
            S_Image1.sprite = Image6;
            S_Image2.sprite = Image7;
            S_Image3.sprite = Image8;
            S_Image4.sprite = Image9;
        }
        if (id / 5 == 2)
        {
            S_Image0.sprite = Image10;
            S_Image1.sprite = Image11;
            S_Image2.sprite = Image12;
            S_Image3.sprite = Image13;
            S_Image4.sprite = Image14;
        }
        if (id / 5 == 3)
        {
            S_Image0.sprite = Image15;
            S_Image1.sprite = Image16;
            S_Image2.sprite = Image17;
            S_Image3.sprite = Image18;
            S_Image4.sprite = Image19;
        }
        if (id / 5 == 4)
        {
            BG = Image4;
        }
    }

}
