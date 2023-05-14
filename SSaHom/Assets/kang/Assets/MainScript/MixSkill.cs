using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using System.IO;
using System.Xml;

public class MixSkill : MonoBehaviour
{
    public Image mix01_image;
    public Image mix02_image;
    public Image mix03_image;
    public Image mixResult_image;
    public Sprite Mix0image0, Mix0image1, Mix0image2, Mix0image3;
    public Sprite Mix1image0, Mix1image1, Mix1image2, Mix1image3;
    public Sprite Mix2image0, Mix2imge2;
    public Sprite ResultImage0, ResultImage1, ResultImage2, ResultImage3, ResultImage4, ResultImage5, ResultImage6, ResultImage7, ResultImage8, ResultImage9, ResultImage10, ResultImage11, ResultImage12, ResultImage13, ResultImage14, ResultImage15, ResultImage16, ResultImage17, ResultImage18, ResultImage19, ResultImage20, ResultImage21, ResultImage22, ResultImage23, ResultImage24, ResultImage25, ResultImage26, ResultImage27, ResultImage28, ResultImage29, ResultImage30, ResultImage31, ResultImage32;
    public Sprite MixClear;
    GameObject Mix1ToolTip, Mix2ToolTip, Mix3ToolTip;
    public Text text0;

    NoticeUI _notice;


    private void Awake()
    {
        _notice = FindObjectOfType<NoticeUI>();
        Mix1ToolTip = GameObject.Find("Mix1ToolTip");
        Mix2ToolTip = GameObject.Find("Mix2ToolTip");
        Mix3ToolTip = GameObject.Find("Mix3ToolTip");
    }
    public void CloseMix()
    {
        mix01_image.sprite = MixClear;
        mix02_image.sprite = MixClear;
        mix03_image.sprite = MixClear;
        Mix1ToolTip.GetComponent<Text>().text = "º¸¼® Á¶°¢À» ÀåÂøÇØÁÖ¼¼¿ä.";
        Mix2ToolTip.GetComponent<Text>().text = "¹«±â Á¶°¢À» ÀåÂøÇØÁÖ¼¼¿ä.";
        Mix3ToolTip.GetComponent<Text>().text = "¼Ó¼º Á¶°¢À» ÀåÂøÇØÁÖ¼¼¿ä.";
        PlayerPrefs.SetInt("Mix01", 0);
        PlayerPrefs.SetInt("Mix02", 0);
        PlayerPrefs.SetInt("Mix03", 0);
    }
    public void Mix01()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "SourceInventory.xml");
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        switch (EventSystem.current.currentSelectedGameObject.name.ToString())
        {
            case "Slot":
                XmlNode character = nodes[0];
                int count = int.Parse(character.SelectSingleNode("count").InnerText);
                if (count >= 1)
                {
                    mix01_image.sprite = Mix0image0;
                    Mix1ToolTip.GetComponent<Text>().text = "Èæ¼öÁ¤ÀÇ Á¶°¢";
                    PlayerPrefs.SetInt("Mix01", 1);
                    break;
                }
                else
                {
                    _notice.SUB("Èæ¼öÁ¤ÀÇ Á¶°¢ÀÌ ºÎÁ·ÇÕ´Ï´Ù!");
                    break;
                }
                
            case "Slot (1)":
                character = nodes[1];
                count = int.Parse(character.SelectSingleNode("count").InnerText);
                if (count >= 1)
                {
                    mix01_image.sprite = Mix0image1;
                    Mix1ToolTip.GetComponent<Text>().text = "ÀÚ¼öÁ¤ÀÇ Á¶°¢";
                    PlayerPrefs.SetInt("Mix01", 2);
                    break;
                }
                else
                {
                    _notice.SUB("ÀÚ¼öÁ¤ÀÇ Á¶°¢ÀÌ ºÎÁ·ÇÕ´Ï´Ù!");
                    break;
                }
            case "Slot (2)":
                character = nodes[2];
                count = int.Parse(character.SelectSingleNode("count").InnerText);
                if (count >= 1)
                {
                    mix01_image.sprite = Mix0image2;
                    Mix1ToolTip.GetComponent<Text>().text = "°­Ã¶ÀÇ Á¶°¢";
                    PlayerPrefs.SetInt("Mix01", 3);
                    break;
                }
                else
                {
                    _notice.SUB("°­Ã¶ÀÇ Á¶°¢ÀÌ ºÎÁ·ÇÕ´Ï´Ù!");
                    break;
                }
            case "Slot (3)":
                character = nodes[3];
                count = int.Parse(character.SelectSingleNode("count").InnerText);
                if (count >= 1)
                {
                    mix01_image.sprite = Mix0image3;
                    Mix1ToolTip.GetComponent<Text>().text = "Ã»µ¿ÀÇ Á¶°¢";
                    PlayerPrefs.SetInt("Mix01", 4);
                    break;
                }
                else
                {
                    _notice.SUB("Ã»µ¿ÀÇ Á¶°¢ÀÌ ºÎÁ·ÇÕ´Ï´Ù!");
                    break;
                }

        }

    

    }
    public void Mix02()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "SourceInventory.xml");
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        //Debug.Log(EventSystem.current.currentSelectedGameObject.name.ToString());
        switch (EventSystem.current.currentSelectedGameObject.name.ToString())
        {
            case "Slot (4)":
                XmlNode character = nodes[4];
                int count = int.Parse(character.SelectSingleNode("count").InnerText);
                if (count >= 1)
                {
                    mix02_image.sprite = Mix1image0;
                    Mix2ToolTip.GetComponent<Text>().text = "°ËÀÇ Á¶°¢";
                    PlayerPrefs.SetInt("Mix02", 1);
                    break;
                }
                else
                {
                    _notice.SUB("°ËÀÇ Á¶°¢ÀÌ ºÎÁ·ÇÕ´Ï´Ù!");
                    break;
                }

            case "Slot (5)":
                character = nodes[5];
                count = int.Parse(character.SelectSingleNode("count").InnerText);
                if (count >= 1)
                {
                    mix02_image.sprite = Mix1image1;
                    Mix2ToolTip.GetComponent<Text>().text = "È°ÀÇ Á¶°¢";
                    PlayerPrefs.SetInt("Mix02", 2);
                    break;
                }
                else
                {
                    _notice.SUB("È°ÀÇ Á¶°¢ÀÌ ºÎÁ·ÇÕ´Ï´Ù!");
                    break;
                }
            case "Slot (6)":
                character = nodes[6];
                count = int.Parse(character.SelectSingleNode("count").InnerText);
                if (count >= 1)
                {
                    mix02_image.sprite = Mix1image2;
                    Mix2ToolTip.GetComponent<Text>().text = "¹æÆÐÀÇ Á¶°¢";
                    PlayerPrefs.SetInt("Mix02", 3);
                    break;
                }
                else
                {
                    _notice.SUB("¹æÆÐÀÇ Á¶°¢ÀÌ ºÎÁ·ÇÕ´Ï´Ù!");
                    break;
                }
            case "Slot (7)":
                character = nodes[7];
                count = int.Parse(character.SelectSingleNode("count").InnerText);
                if (count >= 1)
                {
                    mix02_image.sprite = Mix1image3;
                    Mix2ToolTip.GetComponent<Text>().text = "ÁöÆÎÀÌÀÇ Á¶°¢";
                    PlayerPrefs.SetInt("Mix02", 4);
                    break;
                }
                else
                {
                    _notice.SUB("ÁöÆÎÀÌÀÇ Á¶°¢ÀÌ ºÎÁ·ÇÕ´Ï´Ù!");
                    break;
                }

        }
    }
    public void Mix03()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "SourceInventory.xml");
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        //Debug.Log(EventSystem.current.currentSelectedGameObject.name.ToString());
        switch (EventSystem.current.currentSelectedGameObject.name.ToString())
        {
            case "Slot (8)":
                XmlNode character = nodes[8];
                int count = int.Parse(character.SelectSingleNode("count").InnerText);
                if (count >= 1)
                {
                    mix03_image.sprite = Mix2image0;
                    Mix3ToolTip.GetComponent<Text>().text = "ÇØÀÇ Á¶°¢";
                    PlayerPrefs.SetInt("Mix03", 1);
                    break;
                }
                else
                {
                    _notice.SUB("ÇØÀÇ Á¶°¢ÀÌ ºÎÁ·ÇÕ´Ï´Ù!");
                    break;
                }
            case "Slot (9)":
                character = nodes[9];
                count = int.Parse(character.SelectSingleNode("count").InnerText);
                if (count >= 1)
                {
                    mix03_image.sprite = Mix2imge2;
                    Mix3ToolTip.GetComponent<Text>().text = "´ÞÀÇ Á¶°¢";
                    PlayerPrefs.SetInt("Mix03", 2);
                    break;
                }
                else
                {
                    _notice.SUB("´ÞÀÇ Á¶°¢ÀÌ ºÎÁ·ÇÕ´Ï´Ù!");
                    break;
                }

        }
    }

    public void MixResult()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "SourceInventory.xml");
        string path2 = Path.Combine(Application.streamingAssetsPath, "MixSkill.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        XmlDocument xmlDoc2 = new XmlDocument();
        xmlDoc2.LoadXml(File.ReadAllText(path2));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNodeList nodes2 = xmlDoc2.SelectNodes("rows/row");
        if (PlayerPrefs.GetInt("Mix01") == 0 || PlayerPrefs.GetInt("Mix02") == 0 || PlayerPrefs.GetInt("Mix03") == 0)
        {
            _notice.SUB("ºó ½½·ÔÀÌ ÀÖ½À´Ï´Ù!");
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 1) // 1
        {
            XmlNode character = nodes[0];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[4];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[8];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[1];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("Èæ°ø°Ë È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 2) // 2
        {
            XmlNode character = nodes[0];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[4];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[9];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[2];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("Èæ»ç°Ë È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 1) // 3
        {
            XmlNode character = nodes[1];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[4];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[8];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[3];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("ÀÚ°ø°Ë È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 2) // 4
        {
            XmlNode character = nodes[1];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[4];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[9];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[4];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("ÀÚ»ç°Ë È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 1) // 5
        {
            XmlNode character = nodes[2];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[4];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[8];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[5];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("°­°ø°Ë È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 2) // 6
        {
            XmlNode character = nodes[2];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[4];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[9];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[6];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("°­»ç°Ë È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 1) // 7
        {
            XmlNode character = nodes[3];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[4];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[8];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[7];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("Ã»°ø°Ë È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 2) // 8
        {
            XmlNode character = nodes[3];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[4];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[9];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[8];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("Ã»»ç°Ë È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 1) // 9
        {
            XmlNode character = nodes[0];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[5];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[8];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[9];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("Èæ°øÈ° È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 2) // 10
        {
            XmlNode character = nodes[0];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[5];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[9];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[10];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("Èæ»çÈ° È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 1) // 11
        {
            XmlNode character = nodes[1];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[5];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[8];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[11];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("ÀÚ°øÈ° È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 2) // 12
        {
            XmlNode character = nodes[1];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[5];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[9];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[12];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("ÀÚ»çÈ° È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 1) // 13
        {
            XmlNode character = nodes[2];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[5];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[8];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[13];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("°­°øÈ° È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 2) // 14
        {
            XmlNode character = nodes[2];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[5];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[9];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[14];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("°­»çÈ° È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 1) // 15
        {
            XmlNode character = nodes[3];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[5];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[8];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[15];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("Ã»°øÈ° È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 2) // 16
        {
            XmlNode character = nodes[3];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[5];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[9];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[16];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("Ã»»çÈ° È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 1) // 17
        {
            XmlNode character = nodes[0];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[6];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[8];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[17];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("Èæ°ø¹æ È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 2) // 18
        {
            XmlNode character = nodes[0];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[6];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[9];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[18];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("Èæ»ç¹æ È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 1) // 19
        {
            XmlNode character = nodes[1];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[6];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[8];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[19];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("ÀÚ°ø¹æ È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 2) // 20
        {
            XmlNode character = nodes[1];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[6];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[9];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[20];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("ÀÚ»ç¹æ È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 1) // 21
        {
            XmlNode character = nodes[2];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[6];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[8];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[21];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("°­°ø¹æ È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 2) // 22
        {
            XmlNode character = nodes[2];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[6];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[9];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[22];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("°­»ç¹æ È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 1) // 23
        {
            XmlNode character = nodes[3];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[6];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[8];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[23];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("Ã»°ø¹æ È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 2) // 24
        {
            XmlNode character = nodes[3];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[6];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[9];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[24];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("Ã»»ç¹æ È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 1) // 25
        {
            XmlNode character = nodes[0];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[7];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[8];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[25];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("Èæ°øÁö È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 2) // 26
        {
            XmlNode character = nodes[0];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[7];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[9];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[26];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("Èæ»çÁö È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 1) // 27
        {
            XmlNode character = nodes[1];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[7];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[8];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[27];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("ÀÚ°øÁö È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 2) // 28
        {
            XmlNode character = nodes[1];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[7];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[9];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[28];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("ÀÚ»çÁö È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 1) // 29
        {
            XmlNode character = nodes[2];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[7];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[8];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[29];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("°­°øÁö È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 2) // 30
        {
            XmlNode character = nodes[2];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[7];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[9];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[30];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("°­»çÁö È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 1) // 31
        {
            XmlNode character = nodes[3];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[7];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[8];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[31];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("Ã»°øÁö È¹µæ");
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 2) // 32
        {
            XmlNode character = nodes[3];
            int count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[7];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            character = nodes[9];
            count = int.Parse(character.SelectSingleNode("count").InnerText);
            count -= 1;
            Debug.Log(count);
            character.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc.Save(path);
            XmlNode character2 = nodes2[32];
            count = int.Parse(character2.SelectSingleNode("count").InnerText);
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            xmlDoc2.Save(path2);
            _notice.SUB("Ã»»çÁö È¹µæ");
        }


    }


        // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Mix01", 0);
        PlayerPrefs.SetInt("Mix02", 0);
        PlayerPrefs.SetInt("Mix03", 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Mix01") == 0 && PlayerPrefs.GetInt("Mix02") == 0 && PlayerPrefs.GetInt("Mix03") == 0)
        {
            mixResult_image.sprite = ResultImage0;
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 1) // 1
        {
            mixResult_image.sprite = ResultImage1;
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 2) // 2
        {
            mixResult_image.sprite = ResultImage2;
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 1) // 3
        {
            mixResult_image.sprite = ResultImage3;
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 2) // 4
        {
            mixResult_image.sprite = ResultImage4;
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 1) // 5
        {
            mixResult_image.sprite = ResultImage5;
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 2) // 6
        {
            mixResult_image.sprite = ResultImage6;
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 1) // 7
        {
            mixResult_image.sprite = ResultImage7;
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 2) // 8
        {
            mixResult_image.sprite = ResultImage8;
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 1) // 9
        {
            mixResult_image.sprite = ResultImage9;
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 2) // 10
        {
            mixResult_image.sprite = ResultImage10;
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 1) // 11
        {
            mixResult_image.sprite = ResultImage11;
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 2) // 12
        {
            mixResult_image.sprite = ResultImage12;
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 1) // 13
        {
            mixResult_image.sprite = ResultImage13;
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 2) // 14
        {
            mixResult_image.sprite = ResultImage14;
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 1) // 15
        {
            mixResult_image.sprite = ResultImage15;
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 2) // 16
        {
            mixResult_image.sprite = ResultImage16;
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 1) // 17
        {
            mixResult_image.sprite = ResultImage17;
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 2) // 18
        {
            mixResult_image.sprite = ResultImage18;
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 1) // 19
        {
            mixResult_image.sprite = ResultImage19;
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 2) // 20
        {
            mixResult_image.sprite = ResultImage20;
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 1) // 21
        {
            mixResult_image.sprite = ResultImage21;
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 2) // 22
        {
            mixResult_image.sprite = ResultImage22;
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 1) // 23
        {
            mixResult_image.sprite = ResultImage23;
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 2) // 24
        {
            mixResult_image.sprite = ResultImage24;
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 1) // 25
        {
            mixResult_image.sprite = ResultImage25;
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 2) // 26
        {
            mixResult_image.sprite = ResultImage26;
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 1) // 27
        {
            mixResult_image.sprite = ResultImage27;
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 2) // 28
        {
            mixResult_image.sprite = ResultImage28;
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 1) // 29
        {
            mixResult_image.sprite = ResultImage29;
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 2) // 30
        {
            mixResult_image.sprite = ResultImage30;
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 1) // 31
        {
            mixResult_image.sprite = ResultImage31;
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 2) // 32
        {
            mixResult_image.sprite = ResultImage32;
        }

    }
}
