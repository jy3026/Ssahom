using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.EventSystems;
using System.Xml;

public class RandomDraw : MonoBehaviour
{
    GameObject stat_info;
    public GameObject DrawShop;
    public GameObject DrawWindow;
    public GameObject skill_piece;

    public Image DrawImage;

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

    public int RandomInt;
    public int c;
    public bool on = false;

    NoticeUI _notice;

    void Awake()
    {
        _notice = FindObjectOfType<NoticeUI>();
        this.skill_piece = GameObject.Find("skill_piece");
    }
    GameObject cointext;

    // Start is called before the first frame update
    void Start()
    {
        
        DrawWindow.SetActive(false);
        this.cointext = GameObject.Find("cointext"); // ¿Ã∞‘ ¿Ã¡¶ ƒ⁄¿Œ ∞™¿ª √£æ∆º≠ ≈ÿΩ∫∆Æ∏¶ ø©±‚¥Ÿ æ≤¥¬ ƒ⁄µÂ
        stat_info = GameObject.Find("stat_info");
        
        if (stat_info != null)
        {
            this.stat_info.GetComponent<Text>().text = "∫∏¿Ø ¥…∑¬ƒ° : " + PlayerPrefs.GetInt("stat_info").ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OneDraw()
    {
        RandomInt = Random.Range(1, 13);
        this.c = PlayerPrefs.GetInt("coin");
        //int.Parse(this.cointext.GetComponent<Text>().text); // ¿Ã∑± Ωƒ¿∏∑Œ πﬁæ∆º≠ «ÿ¡‡æﬂ«ÿ

        string path = Path.Combine(Application.streamingAssetsPath, "SourceInventory.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        // XmlNode character = nodes[id];

        if (this.c >= 50)
        {
            
            
            this.on = true;
            DrawShop.SetActive(false);
            DrawWindow.SetActive(true);
            this.c -= 50;
            PlayerPrefs.SetInt("coin", c);
            this.cointext.GetComponent<Text>().text = this.c.ToString();
            //Debug.Log(this.cointext.GetComponent<Text>().text = this.c.ToString());
        
           

            if (RandomInt == 1)
            {
                int id = 0;
                XmlNode character = nodes[id];
                int count = int.Parse(character.SelectSingleNode("count").InnerText);
                count += 1;
                character.SelectSingleNode("count").InnerText = count.ToString();
                xmlDoc.Save(path);
                DrawImage.sprite = Image1;
                this.skill_piece.GetComponent<Text>().text = "»Êºˆ¡§¿ª »πµÊ«œºÃΩ¿¥œ¥Ÿ.";
            }
            else if (RandomInt == 2)
            {
                int id = 1;
                XmlNode character = nodes[id];
                int count = int.Parse(character.SelectSingleNode("count").InnerText);
                count += 1;
                character.SelectSingleNode("count").InnerText = count.ToString();
                xmlDoc.Save(path);
                DrawImage.sprite = Image2;
                this.skill_piece.GetComponent<Text>().text = "¿⁄ºˆ¡§¿ª »πµÊ«œºÃΩ¿¥œ¥Ÿ.";
            }
            else if (RandomInt == 3)
            {
                int id = 2;
                XmlNode character = nodes[id];
                int count = int.Parse(character.SelectSingleNode("count").InnerText);
                count += 1;
                character.SelectSingleNode("count").InnerText = count.ToString();
                xmlDoc.Save(path);
                DrawImage.sprite = Image3;
                this.skill_piece.GetComponent<Text>().text = "∞≠√∂¿ª »πµÊ«œºÃΩ¿¥œ¥Ÿ.";
            }
            else if (RandomInt == 4)
            {
                int id = 3;
                XmlNode character = nodes[id];
                int count = int.Parse(character.SelectSingleNode("count").InnerText);
                count += 1;
                character.SelectSingleNode("count").InnerText = count.ToString();
                xmlDoc.Save(path);
                DrawImage.sprite = Image4;
                this.skill_piece.GetComponent<Text>().text = "√ªµø¿ª »πµÊ«œºÃΩ¿¥œ¥Ÿ.";
            }
            else if (RandomInt == 5)
            {
                int id = 8;
                XmlNode character = nodes[id];
                int count = int.Parse(character.SelectSingleNode("count").InnerText);
                count += 1;
                character.SelectSingleNode("count").InnerText = count.ToString();
                xmlDoc.Save(path);
                DrawImage.sprite = Image5;
                this.skill_piece.GetComponent<Text>().text = "«ÿ¿« ±‚øÓ¿ª »πµÊ«œºÃΩ¿¥œ¥Ÿ.";
            }
            else if (RandomInt == 6)
            {
                int id = 9;
                XmlNode character = nodes[id];
                int count = int.Parse(character.SelectSingleNode("count").InnerText);
                count += 1;
                character.SelectSingleNode("count").InnerText = count.ToString();
                xmlDoc.Save(path);
                DrawImage.sprite = Image6;
                this.skill_piece.GetComponent<Text>().text = "¥ﬁ¿« ±‚øÓ¿ª »πµÊ«œºÃΩ¿¥œ¥Ÿ.";
            }
            else if (RandomInt == 7)
            {
                int id = 4;
                XmlNode character = nodes[id];
                int count = int.Parse(character.SelectSingleNode("count").InnerText);
                count += 1;
                character.SelectSingleNode("count").InnerText = count.ToString();
                xmlDoc.Save(path);
                DrawImage.sprite = Image7;
                this.skill_piece.GetComponent<Text>().text = "∞À¿« ¡∂∞¢¿ª »πµÊ«œºÃΩ¿¥œ¥Ÿ.";
            }
            else if (RandomInt == 8)
            {
                int id = 5;
                XmlNode character = nodes[id];
                int count = int.Parse(character.SelectSingleNode("count").InnerText);
                count += 1;
                character.SelectSingleNode("count").InnerText = count.ToString();
                xmlDoc.Save(path);
                DrawImage.sprite = Image8;
                this.skill_piece.GetComponent<Text>().text = "»∞¿« ¡∂∞¢¿ª »πµÊ«œºÃΩ¿¥œ¥Ÿ.";
            }
            else if (RandomInt == 9)
            {
                int id = 6;
                XmlNode character = nodes[id];
                int count = int.Parse(character.SelectSingleNode("count").InnerText);
                count += 1;
                character.SelectSingleNode("count").InnerText = count.ToString();
                xmlDoc.Save(path);
                DrawImage.sprite = Image9;
                this.skill_piece.GetComponent<Text>().text = "πÊ∆–¿« ¡∂∞¢¿ª »πµÊ«œºÃΩ¿¥œ¥Ÿ.";
            }
            else if (RandomInt == 10)
            {
                int id = 7;
                XmlNode character = nodes[id];
                int count = int.Parse(character.SelectSingleNode("count").InnerText);
                count += 1;
                character.SelectSingleNode("count").InnerText = count.ToString();
                xmlDoc.Save(path);
                DrawImage.sprite = Image10;
                this.skill_piece.GetComponent<Text>().text = "¡ˆ∆Œ¿Ã¿« ¡∂∞¢¿ª »πµÊ«œºÃΩ¿¥œ¥Ÿ.";
            }
            else if (RandomInt == 11)
            {
                int id = 8;
                XmlNode character = nodes[id];
                int count = int.Parse(character.SelectSingleNode("count").InnerText);
                count += 1;
                character.SelectSingleNode("count").InnerText = count.ToString();
                xmlDoc.Save(path);
                DrawImage.sprite = Image5;
                this.skill_piece.GetComponent<Text>().text = "«ÿ¿« ±‚øÓ¿ª »πµÊ«œºÃΩ¿¥œ¥Ÿ.";
            }
            else if (RandomInt == 12)
            {
                int id = 9;
                XmlNode character = nodes[id];
                int count = int.Parse(character.SelectSingleNode("count").InnerText);
                count += 1;
                character.SelectSingleNode("count").InnerText = count.ToString();
                xmlDoc.Save(path);
                DrawImage.sprite = Image6;
                this.skill_piece.GetComponent<Text>().text = "¥ﬁ¿« ±‚øÓ¿ª »πµÊ«œºÃΩ¿¥œ¥Ÿ.";
            }

            Invoke("CloseDraw", 2.0f);
            this.on = false;
        }
        else
        {
            this.on = false;
            DrawShop.SetActive(true);
            _notice.SUB("ø±¿¸¿Ã ∫Œ¡∑«’¥œ¥Ÿ!");

        }
            
    }
    public void OneDrawStat()
    {

        RandomInt = Random.Range(1, 13);
        this.c = int.Parse(this.cointext.GetComponent<Text>().text); // ¿Ã∑± Ωƒ¿∏∑Œ πﬁæ∆º≠ «ÿ¡‡æﬂ«ÿ


        Debug.Log(this.c);
        if (this.c >= 50)
        {


            this.on = true;
            DrawShop.SetActive(false);
            DrawWindow.SetActive(true);
            this.c -= 50;
            PlayerPrefs.SetInt("coin", c);
            this.cointext.GetComponent<Text>().text = this.c.ToString();
            



            if (RandomInt == 1)
            {
                DrawImage.sprite = Image1;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 1;
                Debug.Log(i + "∞≥ »πµÊ");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 2)
            {
                DrawImage.sprite = Image2;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 1;
                Debug.Log(i + "∞≥ »πµÊ");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 3)
            {
                DrawImage.sprite = Image3;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 1;
                Debug.Log(i + "∞≥ »πµÊ");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 4)
            {
                DrawImage.sprite = Image4;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 1;
                Debug.Log(i + "∞≥ »πµÊ");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 5)
            {
                DrawImage.sprite = Image5;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 2;
                Debug.Log(i + "∞≥ »πµÊ");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 6)
            {
                DrawImage.sprite = Image6;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 2;
                Debug.Log(i + "∞≥ »πµÊ");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 7)
            {
                DrawImage.sprite = Image7;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 2;
                Debug.Log(i + "∞≥ »πµÊ");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 8)
            {
                DrawImage.sprite = Image8;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 3;
                Debug.Log(i + "∞≥ »πµÊ");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 9)
            {
                DrawImage.sprite = Image9;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 3;
                Debug.Log(i + "∞≥ »πµÊ");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 10)
            {
                DrawImage.sprite = Image10;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 4;
                Debug.Log(i + "∞≥ »πµÊ");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 11)
            {
                DrawImage.sprite = Image11;
                int i = PlayerPrefs.GetInt("stat_info");
                i += 4;
                Debug.Log(i + "∞≥ »πµÊ");
                PlayerPrefs.SetInt("stat_info", i);
            }
            else if (RandomInt == 12)
            {
                DrawImage.sprite = Image12;
                
                int i = PlayerPrefs.GetInt("stat_info");
                i += 5;
                Debug.Log(i + "∞≥ »πµÊ");
                PlayerPrefs.SetInt("stat_info", i);
            }
            this.stat_info.GetComponent<Text>().text ="∫∏¿Ø ¥…∑¬ƒ° : " + PlayerPrefs.GetInt("stat_info").ToString();
            Invoke("CloseDraw", 2.0f);
            this.on = false;
        }

        else
        {
            this.on = false;
            DrawShop.SetActive(true);
            _notice.SUB("ø±¿¸¿Ã ∫Œ¡∑«’¥œ¥Ÿ!");

        }
    }

    public void CloseDraw()
    {
        DrawImage.sprite = null;
        DrawShop.SetActive(true);
        DrawWindow.SetActive(false);
    }
  

    
}
