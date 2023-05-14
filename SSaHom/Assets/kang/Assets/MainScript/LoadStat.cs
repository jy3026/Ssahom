using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using LitJson;
using System.Xml;


public class LoadStat : MonoBehaviour
{
    
    GameObject level;
    GameObject _name;
    GameObject ad;
    GameObject ap;
    GameObject hp;
    GameObject mp;
    GameObject type;
    GameObject stat_info;
    GameObject uniqueskillindex;
    GameObject skillindex1;
    GameObject skillindex2;
    GameObject word;
    GameObject Unit000;
    GameObject Unit001;
    GameObject Unit002;
    GameObject Unit003;
    GameObject Unit004;
    GameObject Unit005;
    GameObject Unit006;
    GameObject Unit007;
    GameObject Unit008;
    GameObject Unit009;
    GameObject Unit010;
    GameObject Unit011;
    GameObject Unit012;
    GameObject Unit013;
    GameObject Unit014;
    GameObject skilltext;
    NoticeUI _notice;

    public Image skillImage;
    public Image C_skillImage01;
    public Image C_skillImage02;
    public Sprite CS_00;
    public Image CS_01, CS_02, CS_03, CS_04;
    public Image CS_05, CS_06, CS_07, CS_08;
    public Image CS_09, CS_10, CS_11, CS_12;
    public Image CS_13, CS_14, CS_15, CS_16;
    public Image CS_17, CS_18, CS_19, CS_20;
    public Image CS_21, CS_22, CS_23, CS_24;
    public Image CS_25, CS_26, CS_27, CS_28;
    public Image CS_29, CS_30, CS_31, CS_32;
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
    //public Text text000;
    public Text text0;
    public Text text1;
    public int max_ad;
    public int max_ap;
    public int max_hp;
    public int max_mp;


    public void LoadStatInfo()
    {

        string path2 = Path.Combine(Application.streamingAssetsPath, "SkillInfo.Json");
        string JsonString = File.ReadAllText(path2);
        JsonData jsonData = JsonMapper.ToObject(JsonString);
        string skillName = jsonData[PlayerPrefs.GetInt("id")]["skillname"].ToString();
        string skillText = jsonData[PlayerPrefs.GetInt("id")]["skilltext"].ToString();

        this.skilltext.GetComponent<Text>().text = skillName + " : " + skillText;
        this.stat_info = GameObject.Find("stat_info");
        this.stat_info.GetComponent<Text>().text = PlayerPrefs.GetInt("stat_info").ToString();

        if (PlayerPrefs.GetInt("id") == 0)
        {
            skillImage.sprite = Image0;
        }
        else if (PlayerPrefs.GetInt("id") == 1)
        {
            skillImage.sprite = Image1;
        }
        else if (PlayerPrefs.GetInt("id") == 2)
        {
            skillImage.sprite = Image2;
        }
        else if (PlayerPrefs.GetInt("id") == 3)
        {
            skillImage.sprite = Image3;
        }
        else if (PlayerPrefs.GetInt("id") == 4)
        {
            skillImage.sprite = Image4;
        }
        else if (PlayerPrefs.GetInt("id") == 5)
        {
            skillImage.sprite = Image5;
        }
        else if (PlayerPrefs.GetInt("id") == 6)
        {
            skillImage.sprite = Image6;
        }
        else if (PlayerPrefs.GetInt("id") == 7)
        {
            skillImage.sprite = Image7;
        }
        else if (PlayerPrefs.GetInt("id") == 8)
        {
            skillImage.sprite = Image8;
        }
        else if (PlayerPrefs.GetInt("id") == 9)
        {
            skillImage.sprite = Image9;
        }
        else if (PlayerPrefs.GetInt("id") == 10)
        {
            skillImage.sprite = Image10;
        }
        else if (PlayerPrefs.GetInt("id") == 11)
        {
            skillImage.sprite = Image11;
        }
        else if (PlayerPrefs.GetInt("id") == 12)
        {
            skillImage.sprite = Image12;
        }
        else if (PlayerPrefs.GetInt("id") == 13)
        {
            skillImage.sprite = Image13;
        }
        else if (PlayerPrefs.GetInt("id") == 14)
        {
            skillImage.sprite = Image14;
        }


        int id = PlayerPrefs.GetInt("id");
        string path = Path.Combine(Application.streamingAssetsPath, "StatDataTest.xml");
        string path3 = Path.Combine(Application.streamingAssetsPath, "MixSkill.xml");
        XmlDocument xmlDoc3 = new XmlDocument();
        xmlDoc3.LoadXml(File.ReadAllText(path3));
        XmlNodeList nodes3 = xmlDoc3.SelectNodes("rows/row");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[id];
        XmlNode character3_sk01 = nodes3[int.Parse(character.SelectSingleNode("skillIndex1").InnerText)];
        XmlNode character3_sk02 = nodes3[int.Parse(character.SelectSingleNode("skillIndex2").InnerText)];
        this.level = GameObject.Find("level");
        this.level.GetComponent<Text>().text = character.SelectSingleNode("weapon").InnerText.ToString();

        this.type = GameObject.Find("type");
        this.type.GetComponent<Text>().text = character.SelectSingleNode("type").InnerText.ToString();

        this._name = GameObject.Find("name");
        this._name.GetComponent<Text>().text = character.SelectSingleNode("name").InnerText.ToString();

        this.word = GameObject.Find("word");
        this.word.GetComponent<Text>().text = character.SelectSingleNode("story").InnerText.ToString();

        this.ad = GameObject.Find("ad");
        this.ad.GetComponent<Text>().text = character.SelectSingleNode("ad").InnerText.ToString();

        this.ap = GameObject.Find("ap");
        this.ap.GetComponent<Text>().text = character.SelectSingleNode("ap").InnerText.ToString();

        this.hp = GameObject.Find("hp");
        this.hp.GetComponent<Text>().text = character.SelectSingleNode("hp").InnerText.ToString();

        this.mp = GameObject.Find("mp");
        this.mp.GetComponent<Text>().text = character.SelectSingleNode("mp").InnerText.ToString();

        string SkillIndex1 = character.SelectSingleNode("skillIndex1").InnerText.ToString();
        string SkillIndex2 = character.SelectSingleNode("skillIndex2").InnerText.ToString();
        //Debug.Log(character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText);
        switch (SkillIndex1)
        {
            case "0":
                C_skillImage01.sprite = CS_00;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "1":
                C_skillImage01.sprite = CS_01.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "2":
                C_skillImage01.sprite = CS_02.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "3":
                C_skillImage01.sprite = CS_03.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "4":
                C_skillImage01.sprite = CS_04.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "5":
                C_skillImage01.sprite = CS_05.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "6":
                C_skillImage01.sprite = CS_06.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "7":
                C_skillImage01.sprite = CS_07.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "8":
                C_skillImage01.sprite = CS_08.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "9":
                C_skillImage01.sprite = CS_09.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "10":
                C_skillImage01.sprite = CS_10.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "11":
                C_skillImage01.sprite = CS_11.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "12":
                C_skillImage01.sprite = CS_12.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "13":
                C_skillImage01.sprite = CS_13.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "14":
                C_skillImage01.sprite = CS_14.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "15":
                C_skillImage01.sprite = CS_15.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "16":
                C_skillImage01.sprite = CS_16.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "17":
                C_skillImage01.sprite = CS_17.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "18":
                C_skillImage01.sprite = CS_18.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "19":
                C_skillImage01.sprite = CS_19.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "20":
                C_skillImage01.sprite = CS_20.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "21":
                C_skillImage01.sprite = CS_21.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "22":
                C_skillImage01.sprite = CS_22.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "23":
                C_skillImage01.sprite = CS_23.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "24":
                C_skillImage01.sprite = CS_24.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "25":
                C_skillImage01.sprite = CS_25.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "26":
                C_skillImage01.sprite = CS_26.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "27":
                C_skillImage01.sprite = CS_27.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "28":
                C_skillImage01.sprite = CS_28.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "29":
                C_skillImage01.sprite = CS_29.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "30":
                C_skillImage01.sprite = CS_30.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "31":
                C_skillImage01.sprite = CS_31.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "32":
                C_skillImage01.sprite = CS_32.sprite;
                text0.text = character3_sk01.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk01.SelectSingleNode("U_skilltext").InnerText;
                break;

        }
        switch (SkillIndex2)
        {
            case "0":
                C_skillImage02.sprite = CS_00;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "1":
                C_skillImage02.sprite = CS_01.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "2":
                C_skillImage02.sprite = CS_02.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "3":
                C_skillImage02.sprite = CS_03.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "4":
                C_skillImage02.sprite = CS_04.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "5":
                C_skillImage02.sprite = CS_05.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "6":
                C_skillImage02.sprite = CS_06.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "7":
                C_skillImage02.sprite = CS_07.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "8":
                C_skillImage02.sprite = CS_08.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "9":
                C_skillImage02.sprite = CS_09.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "10":
                C_skillImage02.sprite = CS_10.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "11":
                C_skillImage02.sprite = CS_11.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "12":
                C_skillImage02.sprite = CS_12.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "13":
                C_skillImage02.sprite = CS_13.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "14":
                C_skillImage02.sprite = CS_14.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "15":
                C_skillImage02.sprite = CS_15.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "16":
                C_skillImage02.sprite = CS_16.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "17":
                C_skillImage02.sprite = CS_17.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "18":
                C_skillImage02.sprite = CS_18.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "19":
                C_skillImage02.sprite = CS_19.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "20":
                C_skillImage02.sprite = CS_20.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "21":
                C_skillImage02.sprite = CS_21.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "22":
                C_skillImage02.sprite = CS_22.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "23":
                C_skillImage02.sprite = CS_23.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "24":
                C_skillImage02.sprite = CS_24.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "25":
                C_skillImage02.sprite = CS_25.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "26":
                C_skillImage02.sprite = CS_26.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "27":
                C_skillImage02.sprite = CS_27.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "28":
                C_skillImage02.sprite = CS_28.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "29":
                C_skillImage02.sprite = CS_29.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "30":
                C_skillImage02.sprite = CS_30.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "31":
                C_skillImage02.sprite = CS_31.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;
            case "32":
                C_skillImage02.sprite = CS_32.sprite;
                text1.text = character3_sk02.SelectSingleNode("U_skillname").InnerText + " : " + character3_sk02.SelectSingleNode("U_skilltext").InnerText;
                break;

        }
        //this.uniqueskillindex.GetComponent<Text>().text = character.SelectSingleNode("uniqueskillindex").InnerText.ToString();
        //this.skillindex1.GetComponent<Text>().text = character.SelectSingleNode("skillindex1").InnerText.ToString();
        //this.skillindex1.GetComponent<Text>().text = character.SelectSingleNode("skillindex1").InnerText.ToString();

        /*string fileName = "statData";
        string path = Application.dataPath + "/" + fileName + ".Json";
        FileStream fileStream = new FileStream(path, FileMode.Open);
        byte[] data = new byte[fileStream.Length];
        fileStream.Read(data, 0, data.Length);
        fileStream.Close();
        string Json = Encoding.UTF8.GetString(data);
        infoStat = JsonUtility.FromJson<InfoStat>(Json);*/




    }
    public void StatUp()
    {

        GameObject clickObject = EventSystem.current.currentSelectedGameObject;
        string stat = clickObject.name;

        Debug.Log(stat);

        int id = PlayerPrefs.GetInt("id");
        string path = Path.Combine(Application.streamingAssetsPath, "StatDataTest.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[id];
        string type = character.SelectSingleNode("type").InnerText;
        
        if (stat == "근력UP")
        {
            switch(type)
            {
                case "싸움꾼":
                    this.max_ad = 150;
                    break;
                case "방패군":
                    this.max_ad = 60;
                    break;
                case "의원":
                    this.max_ad = 30;
                    break;
            }
            Debug.Log(max_ad);
            int i = int.Parse(character.SelectSingleNode("ad").InnerText);
            if (i < max_ad)
            {
                if (PlayerPrefs.GetInt("stat_info") - StatCalc(i) >= 0)
                {
                    PlayerPrefs.SetInt("stat_info", PlayerPrefs.GetInt("stat_info") - StatCalc(i));
                    this.stat_info.GetComponent<Text>().text = PlayerPrefs.GetInt("stat_info").ToString();
                    i += 1;
                    character.SelectSingleNode("ad").InnerText = i.ToString();
                    xmlDoc.Save(path);
                    this.ad = GameObject.Find("ad");
                    this.ad.GetComponent<Text>().text = character.SelectSingleNode("ad").InnerText.ToString();
                }
                else
                {
                    _notice.SUB("능력치가 부족합니다!");
                }
            }
            else
            {
                _notice.SUB("능력치가 한계입니다!");
            }
            /*int data = int.Parse(this.ad.GetComponent<Text>().text);
            data += 1;
            Debug.Log(data);
            this.ad.GetComponent<Text>().text = data.ToString();
            this.infoStat.ad = data;

            Debug.Log(infoStat.ad);
            string jsonData = JsonUtility.ToJson(infoStat);
            string path = Path.Combine(Application.dataPath, "statData.json");
            File.WriteAllText(path, jsonData);*/







        }
        else if (stat == "지력UP")
        {
            switch (type)
            {
                case "싸움꾼":
                    this.max_ap = 40;
                    break;
                case "방패군":
                    this.max_ap = 40;
                    break;
                case "의원":
                    this.max_ap = 150;
                    break;
            }
            Debug.Log(max_ap);
            int i = int.Parse(character.SelectSingleNode("ap").InnerText);
            if (i < max_ap)
            {
                if (PlayerPrefs.GetInt("stat_info") - StatCalc(i) >= 0)
                {
                    PlayerPrefs.SetInt("stat_info", PlayerPrefs.GetInt("stat_info") - StatCalc(i));

                    this.stat_info.GetComponent<Text>().text = PlayerPrefs.GetInt("stat_info").ToString();
                    i += 1;
                    character.SelectSingleNode("ap").InnerText = i.ToString();
                    xmlDoc.Save(path);
                    this.ad = GameObject.Find("ap");
                    this.ad.GetComponent<Text>().text = character.SelectSingleNode("ap").InnerText.ToString();
                }
                else
                {
                    _notice.SUB("능력치가 부족합니다!");
                }
            }
            else
            {
                _notice.SUB("능력치가 한계입니다!");
            }


        }
        else if (stat == "체력UP")
        {
            switch (type)
            {
                case "싸움꾼":
                    this.max_hp = 120;
                    break;
                case "방패군":
                    this.max_hp = 180;
                    break;
                case "의원":
                    this.max_hp = 50;
                    break;
            }
            Debug.Log(max_hp);
            int i = int.Parse(character.SelectSingleNode("hp").InnerText);
            if (i < max_hp)
            {
                if (PlayerPrefs.GetInt("stat_info") - StatCalc(i) >= 0)
                {
                    PlayerPrefs.SetInt("stat_info", PlayerPrefs.GetInt("stat_info") - StatCalc(i));

                    this.stat_info.GetComponent<Text>().text = PlayerPrefs.GetInt("stat_info").ToString();
                    i += 1;
                    character.SelectSingleNode("hp").InnerText = i.ToString();
                    xmlDoc.Save(path);
                    this.ad = GameObject.Find("hp");
                    this.ad.GetComponent<Text>().text = character.SelectSingleNode("hp").InnerText.ToString();
                }
                else
                {
                    _notice.SUB("능력치가 부족합니다!");
                }
            }
            else
            {
                _notice.SUB("능력치가 한계입니다!");
            }
        }
        else if (stat == "마력UP")
        {
            switch (type)
            {
                case "싸움꾼":
                    this.max_mp = 30;
                    break;
                case "방패군":
                    this.max_mp = 30;
                    break;
                case "의원":
                    this.max_mp = 150;
                    break;
            }
            Debug.Log(max_mp);
            int i = int.Parse(character.SelectSingleNode("mp").InnerText);
            if (i < max_mp)
            {
                if (PlayerPrefs.GetInt("stat_info") - StatCalc(i) >= 0)
                {
                    PlayerPrefs.SetInt("stat_info", PlayerPrefs.GetInt("stat_info") - StatCalc(i));

                    this.stat_info.GetComponent<Text>().text = PlayerPrefs.GetInt("stat_info").ToString();
                    i += 1;
                    character.SelectSingleNode("mp").InnerText = i.ToString();
                    xmlDoc.Save(path);
                    this.ad = GameObject.Find("mp");
                    this.ad.GetComponent<Text>().text = character.SelectSingleNode("mp").InnerText.ToString();
                }
                else
                {
                    _notice.SUB("능력치가 부족합니다!");
                }
            }
            else
            {
                _notice.SUB("능력치가 한계입니다!");
            }
        }
    }

    public int StatCalc(int i)
    {
        double result = System.Math.Truncate((double)i / 10);
        result += 1;
        return (int)result;
    }

    void Awake()
    {
        _notice = FindObjectOfType<NoticeUI>();
    }

    // Start is called before the first frame update
    void Start()
    {
        this.Unit000 = GameObject.Find("Unit000");
        this.Unit001 = GameObject.Find("Unit001");
        this.Unit002 = GameObject.Find("Unit002");
        this.Unit003 = GameObject.Find("Unit003");
        this.Unit004 = GameObject.Find("Unit004");
        this.Unit005 = GameObject.Find("Unit005");
        this.Unit006 = GameObject.Find("Unit006");
        this.Unit007 = GameObject.Find("Unit007");
        this.Unit008 = GameObject.Find("Unit008");
        this.Unit009 = GameObject.Find("Unit009");
        this.Unit010 = GameObject.Find("Unit010");
        this.Unit011 = GameObject.Find("Unit011");
        this.Unit012 = GameObject.Find("Unit012");
        this.Unit013 = GameObject.Find("Unit013");
        this.Unit014 = GameObject.Find("Unit014");
        this.skilltext = GameObject.Find("skilltext");

        Unit000.SetActive(false);
        Unit001.SetActive(false);
        Unit002.SetActive(false);
        Unit003.SetActive(false);
        Unit004.SetActive(false);
        Unit005.SetActive(false);
        Unit006.SetActive(false);
        Unit007.SetActive(false);
        Unit008.SetActive(false);
        Unit009.SetActive(false);
        Unit010.SetActive(false);
        Unit011.SetActive(false);
        Unit012.SetActive(false);
        Unit013.SetActive(false);
        Unit014.SetActive(false);


        int C_I = PlayerPrefs.GetInt("id");
        LoadStatInfo();
        Debug.Log("스탯 씬의 프리펄 id :" + C_I);

        switch(C_I)
        {
            case 0:
                Unit000.SetActive(true);
                break;
            case 1:
                Unit001.SetActive(true);
                break;
            case 2:
                Unit002.SetActive(true);
                break;
            case 3:
                Unit003.SetActive(true);
                break;
            case 4:
                Unit004.SetActive(true);
                break;
            case 5:
                Unit005.SetActive(true);
                break;
            case 6:
                Unit006.SetActive(true);
                break;
            case 7:
                Unit007.SetActive(true);
                break;
            case 8:
                Unit008.SetActive(true);
                break;
            case 9:
                Unit009.SetActive(true);
                break;
            case 10:
                Unit010.SetActive(true);
                break;
            case 11:
                Unit011.SetActive(true);
                break;
            case 12:
                Unit012.SetActive(true);
                break;
            case 13:
                Unit013.SetActive(true);
                break;
            case 14:
                Unit014.SetActive(true);
                break;
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}


public class InfoStat
{
    public string name;
    public int id;
    public int level;
    public int ad;
    public int ap;
    public int hp;
    public int mp;
}


