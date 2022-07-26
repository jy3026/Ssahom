using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.IO;
using System.Xml;


public class MouseEvent : MonoBehaviour
{
    
    public RectTransform transform_tooltips;
    public Text text0;

    void Start()
    {

       
    }

    void Update()
    {
        
    }


    public void HideTooltip()
    {
        
        Vector2 mousePos = Input.mousePosition;

        float w = transform_tooltips.rect.width;
        float h = transform_tooltips.rect.height;
        transform_tooltips.position = mousePos + (new Vector2(w, h) * 10); // 툴팁 가리개
    }
     

    public void SkillToolTip(BaseEventData baseEventData)
    {;
        Vector2 mousePos = Input.mousePosition;
        float w = transform_tooltips.rect.width;
        float h = transform_tooltips.rect.height;
        transform_tooltips.position = mousePos - (new Vector2(w, h) * 0.7f);
    }

    public void StatToolTip(BaseEventData baseEventData)
    {
        GameObject StatToolTip;
        StatToolTip = GameObject.Find("StatToolTip");
        string objectName = ((PointerEventData)baseEventData).pointerEnter.name;
        //Debug.Log(((PointerEventData)baseEventData));
        //Debug.Log((((PointerEventData)baseEventData).pointerEnter).ToString());
        int id = PlayerPrefs.GetInt("id");
        string path = Path.Combine(Application.streamingAssetsPath, "StatDataTest.xml");
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[id];
        if (objectName == "adup")
        {
            int i = int.Parse(character.SelectSingleNode("ad").InnerText);
            double result = System.Math.Truncate((double)i / 10);
            result += 1;
            StatToolTip.GetComponent<Text>().text = result.ToString() + " 의 능력치가 필요합니다.";

        }
        else if (objectName == "지력UP" || objectName == "apup")
        {
            int i = int.Parse(character.SelectSingleNode("ap").InnerText);
            double result = System.Math.Truncate((double)i / 10);
            result += 1;
            StatToolTip.GetComponent<Text>().text = result.ToString() + " 의 능력치가 필요합니다.";
        }
        else if (objectName == "체력UP" || objectName == "hpup")
        {
            int i = int.Parse(character.SelectSingleNode("hp").InnerText);
            double result = System.Math.Truncate((double)i / 10);
            result += 1;
            StatToolTip.GetComponent<Text>().text = result.ToString() + " 의 능력치가 필요합니다.";
        }
        else if (objectName == "마력UP" || objectName == "mpup")
        {
            int i = int.Parse(character.SelectSingleNode("mp").InnerText);
            double result = System.Math.Truncate((double)i / 10);
            result += 1;
            StatToolTip.GetComponent<Text>().text = result.ToString() + " 의 능력치가 필요합니다.";
        }
        
        Vector2 mousePos = Input.mousePosition;
        float w = transform_tooltips.rect.width;
        float h = transform_tooltips.rect.height;
        transform_tooltips.position = mousePos + (new Vector2(w, 0) * 0.6f);
    }

    public void MixSkillToolTip()
    {
        /*string path = Path.Combine(Application.streamingAssetsPath, "MixSkill.xml");
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character;*/
        // U_skillname
        if (PlayerPrefs.GetInt("Mix01") == 0 && PlayerPrefs.GetInt("Mix02") == 0 && PlayerPrefs.GetInt("Mix03") == 0)
        {
            //character = nodes[0];
            //text0.text = character.SelectSingleNode("U_skillname").InnerText + " : " + character.SelectSingleNode("U_skilltext").InnerText;
            text0.text = ChangeToolTip0(0);
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 1) // 1
        {
            //character = nodes[1];
            //text0.text = character.SelectSingleNode("U_skillname").InnerText + " : " + character.SelectSingleNode("U_skilltext").InnerText;
            text0.text = ChangeToolTip0(1);
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 2) // 2
        {
            //character = nodes[2];
            //text0.text = character.SelectSingleNode("U_skillname").InnerText + " : " + character.SelectSingleNode("U_skilltext").InnerText;
            text0.text = ChangeToolTip0(2);
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 1) // 3
        {
            //character = nodes[3];
            //text0.text = character.SelectSingleNode("U_skillname").InnerText + " : " + character.SelectSingleNode("U_skilltext").InnerText;
            text0.text = ChangeToolTip0(3);
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 2) // 4
        {
            //character = nodes[4];
            //text0.text = character.SelectSingleNode("U_skillname").InnerText + " : " + character.SelectSingleNode("U_skilltext").InnerText;
            text0.text = ChangeToolTip0(4);
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 1) // 5
        {
            //character = nodes[5];
            //text0.text = character.SelectSingleNode("U_skillname").InnerText + " : " + character.SelectSingleNode("U_skilltext").InnerText;
            text0.text = ChangeToolTip0(5);
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 2) // 6
        {
            //character = nodes[6];
            //text0.text = character.SelectSingleNode("U_skillname").InnerText + " : " + character.SelectSingleNode("U_skilltext").InnerText;
            text0.text = ChangeToolTip0(6);
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 1) // 7
        {
            //character = nodes[7];
            //text0.text = character.SelectSingleNode("U_skillname").InnerText + " : " + character.SelectSingleNode("U_skilltext").InnerText;
            text0.text = ChangeToolTip0(7);
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 1 && PlayerPrefs.GetInt("Mix03") == 2) // 8
        {
            //character = nodes[8];
            //text0.text = character.SelectSingleNode("U_skillname").InnerText + " : " + character.SelectSingleNode("U_skilltext").InnerText;
            text0.text = ChangeToolTip0(8);
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 1) // 9
        {
            //character = nodes[9];
            //text0.text = character.SelectSingleNode("U_skillname").InnerText + " : " + character.SelectSingleNode("U_skilltext").InnerText;
            text0.text = ChangeToolTip0(9);
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 2) // 10
        {
            //character = nodes[10];
            //text0.text = character.SelectSingleNode("U_skillname").InnerText + " : " + character.SelectSingleNode("U_skilltext").InnerText;
            text0.text = ChangeToolTip0(10);
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 1) // 11
        {
            //character = nodes[11];
            //text0.text = character.SelectSingleNode("U_skillname").InnerText + " : " + character.SelectSingleNode("U_skilltext").InnerText;
            text0.text = ChangeToolTip0(11);
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 2) // 12
        {
            //character = nodes[12];
            //text0.text = character.SelectSingleNode("U_skillname").InnerText + " : " + character.SelectSingleNode("U_skilltext").InnerText;
            text0.text = ChangeToolTip0(12);
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 1) // 13
        {
            //character = nodes[13];
            //text0.text = character.SelectSingleNode("U_skillname").InnerText + " : " + character.SelectSingleNode("U_skilltext").InnerText;
            text0.text = ChangeToolTip0(13);
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 2) // 14
        {
            //character = nodes[14];
            //text0.text = character.SelectSingleNode("U_skillname").InnerText + " : " + character.SelectSingleNode("U_skilltext").InnerText;
            text0.text = ChangeToolTip0(14);
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 1) // 15
        {
            text0.text = ChangeToolTip0(15);
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 2 && PlayerPrefs.GetInt("Mix03") == 2) // 16
        {
            text0.text = ChangeToolTip0(16);
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 1) // 17
        {
            text0.text = ChangeToolTip0(17);
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 2) // 18
        {
            text0.text = ChangeToolTip0(18);
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 1) // 19
        {
            text0.text = ChangeToolTip0(19);
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 2) // 20
        {
            text0.text = ChangeToolTip0(20);
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 1) // 21
        {
            text0.text = ChangeToolTip0(21);
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 2) // 22
        {
            text0.text = ChangeToolTip0(22);
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 1) // 23
        {
            text0.text = ChangeToolTip0(23);
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 3 && PlayerPrefs.GetInt("Mix03") == 2) // 24
        {
            text0.text = ChangeToolTip0(24);
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 1) // 25
        {
            text0.text = ChangeToolTip0(25);
        }
        if (PlayerPrefs.GetInt("Mix01") == 1 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 2) // 26
        {
            text0.text = ChangeToolTip0(26);
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 1) // 27
        {
            text0.text = ChangeToolTip0(27);
        }
        if (PlayerPrefs.GetInt("Mix01") == 2 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 2) // 28
        {
            text0.text = ChangeToolTip0(28);
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 1) // 29
        {
            text0.text = ChangeToolTip0(29);
        }
        if (PlayerPrefs.GetInt("Mix01") == 3 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 2) // 30
        {
            text0.text = ChangeToolTip0(30);
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 1) // 31
        {
            text0.text = ChangeToolTip0(31);
        }
        if (PlayerPrefs.GetInt("Mix01") == 4 && PlayerPrefs.GetInt("Mix02") == 4 && PlayerPrefs.GetInt("Mix03") == 2) // 32
        {
            text0.text = ChangeToolTip0(32);
        }
        Vector2 mousePos = Input.mousePosition;
        float w = transform_tooltips.rect.width;
        float h = transform_tooltips.rect.height;
        transform_tooltips.position = mousePos - (new Vector2(w, h) * 0.7f);
    }

    public string ChangeToolTip0 (int i)
    {
        string path = Path.Combine(Application.streamingAssetsPath, "MixSkill.xml");
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character;
        character = nodes[i];
        return character.SelectSingleNode("U_skillname").InnerText + " : " + character.SelectSingleNode("U_skilltext").InnerText;
    }


}
