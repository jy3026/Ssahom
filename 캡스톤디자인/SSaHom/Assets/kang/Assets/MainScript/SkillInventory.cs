using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SkillInventory : MonoBehaviour
{
    GameObject Bag;
    GameObject SkillBag;
    public Text text0, text1, text2, text3, text4, text5, text6, text7, text8, text9;
    public Text s_text1, s_text2, s_text3, s_text4, s_text5, s_text6, s_text7, s_text8, s_text9, s_text10, s_text11, s_text12, s_text13, s_text14, s_text15, s_text16, s_text17, s_text18, s_text19, s_text20, s_text21, s_text22, s_text23, s_text24, s_text25, s_text26, s_text27, s_text28, s_text29, s_text30, s_text31, s_text32;
    public Text Change_Text1;
    public Text Change_Text2;
    NoticeUI1 _notice;
    public Image SkillImage01;
    public Image SkillImage02;
    public GameObject S1,S2,S3,S4,S5,S6,S7,S8,S9,S10,S11,S12,S13,S14,S15,S16;
    public GameObject S17, S18, S19, S20, S21, S22, S23, S24, S25, S26, S27;
    public GameObject S28, S29, S30, S31, S32;
    string weapon;

    // Start is called before the first frame update
    private void Awake()
    {
        this.Bag = GameObject.Find("Inventory");
        this.SkillBag = GameObject.Find("SkillInventory");
        _notice = FindObjectOfType<NoticeUI1>();
        string path = Path.Combine(Application.streamingAssetsPath, "StatDataTest.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        SkillBag.SetActive(true);
        XmlNode character = nodes[PlayerPrefs.GetInt("id")];
        this.weapon = character.SelectSingleNode("weapon").InnerText;
        S1.GetComponentInChildren<Button>().interactable = false;
        S2.GetComponentInChildren<Button>().interactable = false;
        S3.GetComponentInChildren<Button>().interactable = false;
        S4.GetComponentInChildren<Button>().interactable = false;
        S5.GetComponentInChildren<Button>().interactable = false;
        S6.GetComponentInChildren<Button>().interactable = false;
        S7.GetComponentInChildren<Button>().interactable = false;
        S8.GetComponentInChildren<Button>().interactable = false;
        S9.GetComponentInChildren<Button>().interactable = false;
        S10.GetComponentInChildren<Button>().interactable = false;
        S11.GetComponentInChildren<Button>().interactable = false;
        S12.GetComponentInChildren<Button>().interactable = false;
        S13.GetComponentInChildren<Button>().interactable = false;
        S14.GetComponentInChildren<Button>().interactable = false;
        S15.GetComponentInChildren<Button>().interactable = false;
        S16.GetComponentInChildren<Button>().interactable = false;
        S17.GetComponentInChildren<Button>().interactable = false;
        S18.GetComponentInChildren<Button>().interactable = false;
        S19.GetComponentInChildren<Button>().interactable = false;
        S20.GetComponentInChildren<Button>().interactable = false;
        S21.GetComponentInChildren<Button>().interactable = false;
        S22.GetComponentInChildren<Button>().interactable = false;
        S23.GetComponentInChildren<Button>().interactable = false;
        S24.GetComponentInChildren<Button>().interactable = false;
        S25.GetComponentInChildren<Button>().interactable = false;
        S26.GetComponentInChildren<Button>().interactable = false;
        S27.GetComponentInChildren<Button>().interactable = false;
        S28.GetComponentInChildren<Button>().interactable = false;
        S29.GetComponentInChildren<Button>().interactable = false;
        S30.GetComponentInChildren<Button>().interactable = false;
        S31.GetComponentInChildren<Button>().interactable = false;
        S32.GetComponentInChildren<Button>().interactable = false;

    }
    void Start()
    {
        Bag.SetActive(false);
        SkillBag.SetActive(false);
        switch (weapon)
        {
            case "검":
                S1.GetComponentInChildren<Button>().interactable = true;
                S2.GetComponentInChildren<Button>().interactable = true;
                S3.GetComponentInChildren<Button>().interactable = true;
                S4.GetComponentInChildren<Button>().interactable = true;
                S5.GetComponentInChildren<Button>().interactable = true;
                S6.GetComponentInChildren<Button>().interactable = true;
                S7.GetComponentInChildren<Button>().interactable = true;
                S8.GetComponentInChildren<Button>().interactable = true;
                break;
            case "활":
                S9.GetComponentInChildren<Button>().interactable = true;
                S10.GetComponentInChildren<Button>().interactable = true;
                S11.GetComponentInChildren<Button>().interactable = true;
                S12.GetComponentInChildren<Button>().interactable = true;
                S13.GetComponentInChildren<Button>().interactable = true;
                S14.GetComponentInChildren<Button>().interactable = true;
                S15.GetComponentInChildren<Button>().interactable = true;
                S16.GetComponentInChildren<Button>().interactable = true;
                break;
            case "방패":
                S17.GetComponentInChildren<Button>().interactable = true;
                S18.GetComponentInChildren<Button>().interactable = true;
                S19.GetComponentInChildren<Button>().interactable = true;
                S20.GetComponentInChildren<Button>().interactable = true;
                S21.GetComponentInChildren<Button>().interactable = true;
                S22.GetComponentInChildren<Button>().interactable = true;
                S23.GetComponentInChildren<Button>().interactable = true;
                S24.GetComponentInChildren<Button>().interactable = true;
                break;
            case "지팡이":
                S25.GetComponentInChildren<Button>().interactable = true;
                S26.GetComponentInChildren<Button>().interactable = true;
                S27.GetComponentInChildren<Button>().interactable = true;
                S28.GetComponentInChildren<Button>().interactable = true;
                S29.GetComponentInChildren<Button>().interactable = true;
                S30.GetComponentInChildren<Button>().interactable = true;
                S31.GetComponentInChildren<Button>().interactable = true;
                S32.GetComponentInChildren<Button>().interactable = true;
                break;

        }
        // XmlNode character = nodes[id];
    }

    public void OpenSkillBag()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "MixSkill.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        SkillBag.SetActive(true);
        XmlNode character = nodes[1];
        //Debug.Log(character.SelectSingleNode("count").InnerText);
        s_text1.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[2];
        s_text2.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[3];
        s_text3.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[4];
        s_text4.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[5];
        s_text5.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[6];
        s_text6.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[7];
        s_text7.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[8];
        s_text8.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[9];
        s_text9.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[10];
        s_text10.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[11];
        s_text11.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[12];
        s_text12.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[13];
        s_text13.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[14];
        s_text14.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[15];
        s_text15.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[16];
        s_text16.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[17];
        s_text17.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[18];
        s_text18.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[19];
        s_text19.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[20];
        s_text20.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[21];
        s_text21.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[22];
        s_text22.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[23];
        s_text23.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[24];
        s_text24.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[25];
        s_text25.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[26];
        s_text26.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[27];
        s_text27.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[28];
        s_text28.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[29];
        s_text29.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[30];
        s_text30.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[31];
        s_text31.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[32];
        s_text32.text = character.SelectSingleNode("count").InnerText.ToString();
    }

    public void OpenBag()
    {
       
        string path = Path.Combine(Application.streamingAssetsPath, "SourceInventory.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        Bag.SetActive(true);
        XmlNode character = nodes[0];
        //Debug.Log(character.SelectSingleNode("count").InnerText);
        text0.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[1];
        text1.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[2];
        text2.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[3];
        text3.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[4];
        text4.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[5];
        text5.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[6];
        text6.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[7];
        text7.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[8];
        text8.text = character.SelectSingleNode("count").InnerText.ToString();
        character = nodes[9];
        text9.text = character.SelectSingleNode("count").InnerText.ToString();
    }
    public void CloseBag()
    {
        Bag.SetActive(false);
    }
    public void CloseSkillBag()
    {
        SkillBag.SetActive(false);
    }

    public void ChangeSkill()
    {
        Debug.Log(PlayerPrefs.GetString("SkillButton"));
        string path = Path.Combine(Application.streamingAssetsPath, "StatDataTest.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        SkillBag.SetActive(true);
        XmlNode character = nodes[PlayerPrefs.GetInt("id")];
        //Debug.Log(PlayerPrefs.GetInt("id"));
        string buttonName = EventSystem.current.currentSelectedGameObject.name.ToString();
        string path2 = Path.Combine(Application.streamingAssetsPath, "MixSkill.xml");
        XmlDocument xmlDoc2 = new XmlDocument();
        xmlDoc2.LoadXml(File.ReadAllText(path2));
        XmlNodeList nodes2 = xmlDoc2.SelectNodes("rows/row");
        XmlNode character2 = nodes2[int.Parse(buttonName)];
        int count = int.Parse(character2.SelectSingleNode("count").InnerText);
        if (PlayerPrefs.GetString("SkillButton") == "skill1")
        {
            if (count >= 1)
            {
                if (PlayerPrefs.GetString("MixSkill01_"+ PlayerPrefs.GetInt("id").ToString()) == buttonName)
                {
                    _notice.SUB("이미 장착한 도술입니다 !");
                }
                else
                {
                    if (character.SelectSingleNode("skillIndex2").InnerText == buttonName)
                    {
                        _notice.SUB("이미 장착한 도술입니다 !");
                    }
                    else
                    {
                        GameObject clickObject = EventSystem.current.currentSelectedGameObject;
                        SkillImage01.sprite = clickObject.GetComponentInChildren<Image>().sprite;
                        count -= 1;
                        character.SelectSingleNode("skillIndex1").InnerText = buttonName;
                        character2.SelectSingleNode("count").InnerText = count.ToString();
                        Change_Text1.text = "  " + character2.SelectSingleNode("U_skillname").InnerText + " : " + character2.SelectSingleNode("U_skilltext").InnerText;
                        int id = int.Parse(PlayerPrefs.GetString("MixSkill01_"+ PlayerPrefs.GetInt("id").ToString(), "0"));
                        Debug.Log("id" + id);
                        character2 = nodes2[id];
                        count = int.Parse(character2.SelectSingleNode("count").InnerText);
                        count += 1;
                        character2.SelectSingleNode("count").InnerText = count.ToString();
                        xmlDoc2.Save(path2);
                        xmlDoc.Save(path);
                        PlayerPrefs.SetString("MixSkill01_"+ PlayerPrefs.GetInt("id").ToString(), buttonName);
                    }
                }
            }
            else
            {
                _notice.SUB(character2.SelectSingleNode("U_skillname").InnerText + "이(가) 부족합니다.");
            }
        }
        if (PlayerPrefs.GetString("SkillButton") == "skill2")
        {
            if (count >= 1)
            {
                if (PlayerPrefs.GetString("MixSkill02_" + PlayerPrefs.GetInt("id").ToString()) == buttonName)
                {
                    _notice.SUB("이미 장착한 도술입니다 !");
                }
                else
                {
                    if (character.SelectSingleNode("skillIndex1").InnerText == buttonName)
                    {
                        _notice.SUB("중복된 도술입니다 !");
                    }
                    else
                    {
                        GameObject clickObject = EventSystem.current.currentSelectedGameObject;
                        SkillImage02.sprite = clickObject.GetComponentInChildren<Image>().sprite;
                        count -= 1;
                        character.SelectSingleNode("skillIndex2").InnerText = buttonName;
                        character2.SelectSingleNode("count").InnerText = count.ToString();
                        Change_Text2.text = "  " + character2.SelectSingleNode("U_skillname").InnerText + " : " + character2.SelectSingleNode("U_skilltext").InnerText;
                        int id = int.Parse(PlayerPrefs.GetString("MixSkill02_" + PlayerPrefs.GetInt("id").ToString(), "0"));
                        Debug.Log("id" + id);
                        character2 = nodes2[id];
                        count = int.Parse(character2.SelectSingleNode("count").InnerText);
                        count += 1;
                        character2.SelectSingleNode("count").InnerText = count.ToString();
                        xmlDoc2.Save(path2);
                        xmlDoc.Save(path);
                        PlayerPrefs.SetString("MixSkill02_" + PlayerPrefs.GetInt("id").ToString(), buttonName);
                    }
                }
            }
            else
            {
                _notice.SUB(character2.SelectSingleNode("U_skillname").InnerText + "이(가) 부족합니다.");
            }
        }
        //SkillImage01.sprite = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Sprite>();
        //EventSystem.current.currentSelectedGameObject.
        Debug.Log("버튼 네임 : " + buttonName);
    }

    public void SkillOut()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "StatDataTest.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        SkillBag.SetActive(true);
        XmlNode character = nodes[PlayerPrefs.GetInt("id")];
        string skillIndex1 = character.SelectSingleNode("skillIndex1").InnerText;
        string skillIndex2 = character.SelectSingleNode("skillIndex2").InnerText;
        string path2 = Path.Combine(Application.streamingAssetsPath, "MixSkill.xml");
        XmlDocument xmlDoc2 = new XmlDocument();
        xmlDoc2.LoadXml(File.ReadAllText(path2));
        XmlNodeList nodes2 = xmlDoc2.SelectNodes("rows/row");
        XmlNode character2 = nodes2[int.Parse(skillIndex1)];
        XmlNode character3 = nodes2[int.Parse(skillIndex2)];
        int count = int.Parse(character2.SelectSingleNode("count").InnerText);
        int count2 = int.Parse(character3.SelectSingleNode("count").InnerText);
        if (PlayerPrefs.GetString("SkillButton") == "skill1")
        {
            count += 1;
            character2.SelectSingleNode("count").InnerText = count.ToString();
            skillIndex1 = "0";
            character.SelectSingleNode("skillIndex1").InnerText = skillIndex1;
            xmlDoc.Save(path);
            xmlDoc2.Save(path2);
            PlayerPrefs.SetString("MixSkill01_" + PlayerPrefs.GetInt("id").ToString(), "0");
        }
        else if (PlayerPrefs.GetString("SkillButton") == "skill2")
        {
            count2 += 1;
            character3.SelectSingleNode("count").InnerText = count2.ToString();
            skillIndex2 = "0";
            character.SelectSingleNode("skillIndex2").InnerText = skillIndex2;
            xmlDoc.Save(path);
            xmlDoc2.Save(path2);
            PlayerPrefs.SetString("MixSkill02_" + PlayerPrefs.GetInt("id").ToString(), "0");
        }
    }

    public void ClickObjectName()
    {
        PlayerPrefs.SetString("SkillButton", EventSystem.current.currentSelectedGameObject.name);
        Debug.Log(PlayerPrefs.GetString("SkillButton"));
    }
    // Update is called once per frame
    void Update()
    {

    }
}
