using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using UnityEngine;
using UnityEngine.UI;

public class PublicSkill : MonoBehaviour
{
    public GameObject Skill01, Skill02, Skill03, Skill04, Skill05, Skill06, Skill07, Skill08;
    public Sprite Ch00, Ch01, Ch02, Ch03, Ch04, Ch05, Ch06, Ch07, Ch08, Ch09, Ch10, Ch11, Ch12, Ch13, Ch14;
    public Sprite sk01, sk02, sk03, sk04, sk05, sk06, sk07, sk08;
    public Sprite sk09, sk10, sk11, sk12, sk13, sk14, sk15, sk16;
    public Sprite sk17, sk18, sk19, sk20, sk21, sk22, sk23, sk24;
    public Sprite sk25, sk26, sk27, sk28, sk29, sk30, sk31, sk32;
    public Sprite sk00;
    public Text name01, name02, name03, name04;
    NoticeUI1 _notice;
    public Image sk001;
    public SPUM_Prefabs _spumPref0;
    public SPUM_Prefabs _spumPref1;
    public SPUM_Prefabs _spumPref2;
    public SPUM_Prefabs _spumPref3;
    public SPUM_Prefabs _spumPref4;
    public SPUM_Prefabs _spumPref5;
    public SPUM_Prefabs _spumPref6;
    public SPUM_Prefabs _spumPref7;
    public SPUM_Prefabs _spumPref8;
    public SPUM_Prefabs _spumPref9;
    public SPUM_Prefabs _spumPref10;
    public SPUM_Prefabs _spumPref11;
    public SPUM_Prefabs _spumPref12;
    public SPUM_Prefabs _spumPref13;
    public SPUM_Prefabs _spumPref14;
    public GameObject Leaves, Snow, Rain, Firefiles, Windy, Blizzard, HeavyRain;
    private void Awake()
    {
        _notice = FindObjectOfType<NoticeUI1>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Skill01.GetComponentInChildren<Image>().sprite = sk00;
        Skill02.GetComponentInChildren<Image>().sprite = sk00;
        Skill03.GetComponentInChildren<Image>().sprite = sk00;
        Skill04.GetComponentInChildren<Image>().sprite = sk00;
        Skill05.GetComponentInChildren<Image>().sprite = sk00;
        Skill06.GetComponentInChildren<Image>().sprite = sk00;
        Skill07.GetComponentInChildren<Image>().sprite = sk00;
        Skill08.GetComponentInChildren<Image>().sprite = sk00;
        name01.text = "�̸�";
        name02.text = "�̸�";
        name03.text = "�̸�";
        name04.text = "�̸�";

    }

    public Sprite ChangeSkillImage(string skillindex)
    {
        Sprite result = sk00;
        switch (skillindex)
        {
            case "0":
                result = sk00;
                break;
            case "1":
                result = sk01;
                break;
            case "2":
                result = sk02;
                break;
            case "3":
                result = sk03;
                break;
            case "4":
                result = sk04;
                break;
            case "5":
                result = sk05;
                break;
            case "6":
                result = sk06;
                break;
            case "7":
                result = sk07;
                break;
            case "8":
                result = sk08;
                break;
            case "9":
                result = sk09;
                break;
            case "10":
                result = sk10;
                break;
            case "11":
                result = sk11;
                break;
            case "12":
                result = sk12;
                break;
            case "13":
                result = sk13;
                break;
            case "14":
                result = sk14;
                break;
            case "15":
                result = sk15;
                break;
            case "16":
                result = sk16;
                break;
            case "17":
                result = sk17;
                break;
            case "18":
                result = sk18;
                break;
            case "19":
                result = sk19;
                break;
            case "20":
                result = sk20;
                break;
            case "21":
                result = sk21;
                break;
            case "22":
                result = sk22;
                break;
            case "23":
                result = sk23;
                break;
            case "24":
                result = sk24;
                break;
            case "25":
                result = sk25;
                break;
            case "26":
                result = sk26;
                break;
            case "27":
                result = sk27;
                break;
            case "28":
                result = sk28;
                break;
            case "29":
                result = sk29;
                break;
            case "30":
                result = sk30;
                break;
            case "31":
                result = sk31;
                break;
            case "32":
                result = sk32;
                break;
        }
        return result;
    }
    // Update is called once per frame
    void Update()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[0];
        string pick1 = character.SelectSingleNode("pickId").InnerText;
        character = nodes[1];
        string pick2 = character.SelectSingleNode("pickId").InnerText;
        character = nodes[2];
        string pick3 = character.SelectSingleNode("pickId").InnerText;
        character = nodes[3];
        string pick4 = character.SelectSingleNode("pickId").InnerText;
        string path2 = Path.Combine(Application.streamingAssetsPath, "StatDataTest.xml");
        XmlDocument xmlDoc2 = new XmlDocument();
        xmlDoc2.LoadXml(File.ReadAllText(path2));
        XmlNodeList nodes2 = xmlDoc2.SelectNodes("rows/row");
        XmlNode character1 = nodes2[int.Parse(pick1)];
        XmlNode character2 = nodes2[int.Parse(pick2)];
        XmlNode character3 = nodes2[int.Parse(pick3)];
        XmlNode character4 = nodes2[int.Parse(pick4)];
        Skill01.GetComponentInChildren<Image>().sprite = ChangeSkillImage(character1.SelectSingleNode("skillIndex1").InnerText);
        Skill02.GetComponentInChildren<Image>().sprite = ChangeSkillImage(character1.SelectSingleNode("skillIndex2").InnerText);
        Skill03.GetComponentInChildren<Image>().sprite = ChangeSkillImage(character2.SelectSingleNode("skillIndex1").InnerText);
        Skill04.GetComponentInChildren<Image>().sprite = ChangeSkillImage(character2.SelectSingleNode("skillIndex2").InnerText);
        Skill05.GetComponentInChildren<Image>().sprite = ChangeSkillImage(character3.SelectSingleNode("skillIndex1").InnerText);
        Skill06.GetComponentInChildren<Image>().sprite = ChangeSkillImage(character3.SelectSingleNode("skillIndex2").InnerText);
        Skill07.GetComponentInChildren<Image>().sprite = ChangeSkillImage(character4.SelectSingleNode("skillIndex1").InnerText);
        Skill08.GetComponentInChildren<Image>().sprite = ChangeSkillImage(character4.SelectSingleNode("skillIndex2").InnerText);
        name01.text = character1.SelectSingleNode("name").InnerText;
        name02.text = character2.SelectSingleNode("name").InnerText;
        name03.text = character3.SelectSingleNode("name").InnerText;
        name04.text = character4.SelectSingleNode("name").InnerText;
    }

    void TurnOff()
    {
        if (HeavyRain)
        {
            HeavyRain.SetActive(false);
        }
        if (Leaves)
        {
            Leaves.SetActive(false);
        }
        if (Snow)
        {
            Snow.SetActive(false);
        }
        if (Rain)
        {
            Rain.SetActive(false);
        }
        if (Firefiles)
        {
            Firefiles.SetActive(false);
        }
        if (Windy)
        {
            Windy.SetActive(false);
        }
        if (Blizzard)
        {
            Blizzard.SetActive(false);
        }

    }
    public void ActiveSkill01()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[0];
        string pick1 = character.SelectSingleNode("pickId").InnerText;
        string path2 = Path.Combine(Application.streamingAssetsPath, "StatDataTest.xml");
        XmlDocument xmlDoc2 = new XmlDocument();
        xmlDoc2.LoadXml(File.ReadAllText(path2));
        XmlNodeList nodes2 = xmlDoc2.SelectNodes("rows/row");
        XmlNode character1 = nodes2[int.Parse(pick1)];
        string skillindex1 = character1.SelectSingleNode("skillIndex1").InnerText;
        Debug.Log(name01.text);
        if (name01.text == "������")
        {
            sk001.sprite = Ch00;
            if (skillindex1 == "0")
            {
                Skill01.GetComponentInChildren<Button>().interactable = false;
            }
            else
            {
                _notice.SUB("������!!");
                Skill01.GetComponentInChildren<Button>().interactable = false;
                if (skillindex1 == "1")
                {

                }
                if (skillindex1 == "2")
                {
                    _spumPref0.GetComponent<SA_Unit>()._unitAT += 10;

                    HeavyRain.SetActive(true);
                    Invoke("TurnOff", 5);
                    //HeavyRain.SetActive(false);
                }
                if (skillindex1 == "3")
                {
                    //Leaves, Snow, Rain, Firefiles, Windy, Blizzard, HeavyRain;
                }
                if (skillindex1 == "4")
                {
                    _spumPref0.GetComponent<SA_Unit>()._unitAP += 10;
                    Leaves.SetActive(true);
                    Invoke("TurnOff", 5);
                }
                if (skillindex1 == "5")
                {

                }
                if (skillindex1 == "6")
                {
                    _spumPref0.GetComponent<SA_Unit>()._unitMP += 10;
                    Snow.SetActive(true);
                    Invoke("TurnOff", 5);
                }
                if (skillindex1 == "7")
                {

                }
                if (skillindex1 == "8")
                {
                    _spumPref0.GetComponent<SA_Unit>()._unitHP += 10;
                    Rain.SetActive(true);
                    Invoke("TurnOff", 5);
                }
            }
        }
        if (name01.text == "�ٿ�")
        {
            sk001.sprite = Ch01;
            if (skillindex1 == "0")
            {
                Skill01.GetComponentInChildren<Button>().interactable = false;
            }
            else
            {
                _notice.SUB("�ٿ�!!");
                Skill01.GetComponentInChildren<Button>().interactable = false;
                Debug.Log(skillindex1);
                if (skillindex1 == "9")
                {

                }
                if (skillindex1 == "10")
                {
                    _spumPref1.GetComponent<SA_Unit>()._unitAT += 10;
                    Rain.SetActive(true);
                    Invoke("TurnOff", 5);
                }
                if (skillindex1 == "11")
                {

                }
                if (skillindex1 == "12")
                {
                    _spumPref1.GetComponent<SA_Unit>()._unitAP += 10;
                    Blizzard.SetActive(true);
                    Invoke("TurnOff", 5);
                }
                if (skillindex1 == "13")
                {

                }
                if (skillindex1 == "14")
                {
                    _spumPref1.GetComponent<SA_Unit>()._unitMP += 10;
                    HeavyRain.SetActive(true);
                    Invoke("TurnOff", 5);
                }
                if (skillindex1 == "15")
                {

                }
                if (skillindex1 == "16")
                {
                    _spumPref1.GetComponent<SA_Unit>()._unitHP += 10;
                    Firefiles.SetActive(true);
                    Invoke("TurnOff", 5);
                }
            }
        }
        if (name01.text == "����")
        {
            sk001.sprite = Ch02;
            if (skillindex1 == "0")
            {
                Skill01.GetComponentInChildren<Button>().interactable = false;
            }
            else
            {
                _notice.SUB("����!!");
                Skill01.GetComponentInChildren<Button>().interactable = false;
                if (skillindex1 == "1")
                {

                }
                if (skillindex1 == "2")
                {
                    _spumPref2.GetComponent<SA_Unit>()._unitAT += 10;
                }
                if (skillindex1 == "3")
                {

                }
                if (skillindex1 == "4")
                {
                    _spumPref2.GetComponent<SA_Unit>()._unitAP += 10;
                }
                if (skillindex1 == "5")
                {

                }
                if (skillindex1 == "6")
                {
                    _spumPref2.GetComponent<SA_Unit>()._unitMP += 10;
                }
                if (skillindex1 == "7")
                {

                }
                if (skillindex1 == "8")
                {
                    _spumPref2.GetComponent<SA_Unit>()._unitHP += 10;
                }
            }
        }
        if (name01.text == "�ٹ�")
        {
            sk001.sprite = Ch03;
            if (skillindex1 == "0")
            {
                Skill01.GetComponentInChildren<Button>().interactable = false;
            }
            else
            {
                _notice.SUB("�ٹ�!!");
                Skill01.GetComponentInChildren<Button>().interactable = false;
                if (skillindex1 == "1")
                {

                }
                if (skillindex1 == "2")
                {
                    _spumPref3.GetComponent<SA_Unit>()._unitAT += 10;
                }
                if (skillindex1 == "3")
                {

                }
                if (skillindex1 == "4")
                {
                    _spumPref3.GetComponent<SA_Unit>()._unitAP += 10;
                }
                if (skillindex1 == "5")
                {

                }
                if (skillindex1 == "6")
                {
                    _spumPref3.GetComponent<SA_Unit>()._unitMP += 10;
                }
                if (skillindex1 == "7")
                {

                }
                if (skillindex1 == "8")
                {
                    _spumPref3.GetComponent<SA_Unit>()._unitHP += 10;
                }
            }
        }
        if (name01.text == "�Ҷ�")
        {
            sk001.sprite = Ch04;
            if (skillindex1 == "0")
            {
                Skill01.GetComponentInChildren<Button>().interactable = false;
            }
            else
            {
                _notice.SUB("�Ҷ�!!");
                Skill01.GetComponentInChildren<Button>().interactable = false;
                if (skillindex1 == "9")
                {

                }
                if (skillindex1 == "10")
                {
                    _spumPref4.GetComponent<SA_Unit>()._unitAT += 10;
                }
                if (skillindex1 == "11")
                {

                }
                if (skillindex1 == "12")
                {
                    _spumPref4.GetComponent<SA_Unit>()._unitAP += 10;
                }
                if (skillindex1 == "13")
                {

                }
                if (skillindex1 == "14")
                {
                    _spumPref4.GetComponent<SA_Unit>()._unitMP += 10;
                }
                if (skillindex1 == "15")
                {

                }
                if (skillindex1 == "16")
                {
                    _spumPref4.GetComponent<SA_Unit>()._unitHP += 10;
                }
            }
        }
        if (name01.text == "�����")
        {
            sk001.sprite = Ch05;
            if (skillindex1 == "0")
            {
                Skill01.GetComponentInChildren<Button>().interactable = false;
            }
            else
            {
                _notice.SUB("�����!!");
                Skill01.GetComponentInChildren<Button>().interactable = false;
                if (skillindex1 == "17")
                {

                }
                if (skillindex1 == "18")
                {
                    _spumPref5.GetComponent<SA_Unit>()._unitAT += 10;
                }
                if (skillindex1 == "19")
                {

                }
                if (skillindex1 == "20")
                {
                    _spumPref5.GetComponent<SA_Unit>()._unitAP += 10;
                }
                if (skillindex1 == "21")
                {

                }
                if (skillindex1 == "22")
                {
                    _spumPref5.GetComponent<SA_Unit>()._unitMP += 10;
                }
                if (skillindex1 == "23")
                {

                }
                if (skillindex1 == "24")
                {
                    _spumPref5.GetComponent<SA_Unit>()._unitHP += 10;
                }
            }
        }
        if (name01.text == "��ġ")
        {
            sk001.sprite = Ch06;
            if (skillindex1 == "0")
            {
                Skill01.GetComponentInChildren<Button>().interactable = false;
            }
            else
            {
                _notice.SUB("��ġ!!");
                Skill01.GetComponentInChildren<Button>().interactable = false;
                if (skillindex1 == "17")
                {

                }
                if (skillindex1 == "18")
                {
                    _spumPref6.GetComponent<SA_Unit>()._unitAT += 10;
                }
                if (skillindex1 == "19")
                {

                }
                if (skillindex1 == "20")
                {
                    _spumPref6.GetComponent<SA_Unit>()._unitAP += 10;
                }
                if (skillindex1 == "21")
                {

                }
                if (skillindex1 == "22")
                {
                    _spumPref6.GetComponent<SA_Unit>()._unitMP += 10;
                }
                if (skillindex1 == "23")
                {

                }
                if (skillindex1 == "24")
                {
                    _spumPref6.GetComponent<SA_Unit>()._unitHP += 10;
                }
            }
        }
        if (name01.text == "����")
        {
            sk001.sprite = Ch07;
            if (skillindex1 == "0")
            {
                Skill01.GetComponentInChildren<Button>().interactable = false;
            }
            else
            {
                _notice.SUB("����!!");
                Skill01.GetComponentInChildren<Button>().interactable = false;
                if (skillindex1 == "17")
                {

                }
                if (skillindex1 == "18")
                {
                    _spumPref7.GetComponent<SA_Unit>()._unitAT += 10;
                }
                if (skillindex1 == "19")
                {

                }
                if (skillindex1 == "20")
                {
                    _spumPref7.GetComponent<SA_Unit>()._unitAP += 10;
                }
                if (skillindex1 == "21")
                {

                }
                if (skillindex1 == "22")
                {
                    _spumPref7.GetComponent<SA_Unit>()._unitMP += 10;
                }
                if (skillindex1 == "23")
                {

                }
                if (skillindex1 == "24")
                {
                    _spumPref7.GetComponent<SA_Unit>()._unitHP += 10;
                }
            }
        }
        if (name01.text == "���")
        {
            sk001.sprite = Ch08;
            if (skillindex1 == "0")
            {
                Skill01.GetComponentInChildren<Button>().interactable = false;
            }
            else
            {
                _notice.SUB("���!!");
                Skill01.GetComponentInChildren<Button>().interactable = false;
                if (skillindex1 == "17")
                {

                }
                if (skillindex1 == "18")
                {
                    _spumPref8.GetComponent<SA_Unit>()._unitAT += 10;
                }
                if (skillindex1 == "19")
                {

                }
                if (skillindex1 == "20")
                {
                    _spumPref8.GetComponent<SA_Unit>()._unitAP += 10;
                }
                if (skillindex1 == "21")
                {

                }
                if (skillindex1 == "22")
                {
                    _spumPref8.GetComponent<SA_Unit>()._unitMP += 10;
                }
                if (skillindex1 == "23")
                {

                }
                if (skillindex1 == "24")
                {
                    _spumPref8.GetComponent<SA_Unit>()._unitHP += 10;
                }
            }
        }
        if (name01.text == "�𵵸�")
        {
            sk001.sprite = Ch09;
            if (skillindex1 == "0")
            {
                Skill01.GetComponentInChildren<Button>().interactable = false;
            }
            else
            {
                _notice.SUB("�𵵸�!!");
                Skill01.GetComponentInChildren<Button>().interactable = false;
                if (skillindex1 == "17")
                {

                }
                if (skillindex1 == "18")
                {
                    _spumPref9.GetComponent<SA_Unit>()._unitAT += 10;
                }
                if (skillindex1 == "19")
                {

                }
                if (skillindex1 == "20")
                {
                    _spumPref9.GetComponent<SA_Unit>()._unitAP += 10;
                }
                if (skillindex1 == "21")
                {

                }
                if (skillindex1 == "22")
                {
                    _spumPref9.GetComponent<SA_Unit>()._unitMP += 10;
                }
                if (skillindex1 == "23")
                {

                }
                if (skillindex1 == "24")
                {
                    _spumPref9.GetComponent<SA_Unit>()._unitHP += 10;
                }
            }
        }
        if (name01.text == "���׸���")
        {
            sk001.sprite = Ch10;
            if (skillindex1 == "0")
            {
                Skill01.GetComponentInChildren<Button>().interactable = false;
            }
            else
            {
                _notice.SUB("���׸���!!");
                Skill01.GetComponentInChildren<Button>().interactable = false;
                if (skillindex1 == "25")
                {

                }
                if (skillindex1 == "26")
                {
                    _spumPref10.GetComponent<SA_Unit>()._unitAT += 10;
                }
                if (skillindex1 == "27")
                {

                }
                if (skillindex1 == "28")
                {
                    _spumPref10.GetComponent<SA_Unit>()._unitAP += 10;
                }
                if (skillindex1 == "29")
                {

                }
                if (skillindex1 == "30")
                {
                    _spumPref10.GetComponent<SA_Unit>()._unitMP += 10;
                }
                if (skillindex1 == "31")
                {

                }
                if (skillindex1 == "32")
                {
                    _spumPref10.GetComponent<SA_Unit>()._unitHP += 10;
                }
            }
        }
        if (name01.text == "����")
        {
            sk001.sprite = Ch11;
            if (skillindex1 == "0")
            {
                Skill01.GetComponentInChildren<Button>().interactable = false;
            }
            else
            {
                _notice.SUB("����!!");
                Skill01.GetComponentInChildren<Button>().interactable = false;
                if (skillindex1 == "25")
                {

                }
                if (skillindex1 == "26")
                {
                    _spumPref11.GetComponent<SA_Unit>()._unitAT += 10;
                }
                if (skillindex1 == "27")
                {

                }
                if (skillindex1 == "28")
                {
                    _spumPref11.GetComponent<SA_Unit>()._unitAP += 10;
                }
                if (skillindex1 == "29")
                {

                }
                if (skillindex1 == "30")
                {
                    _spumPref11.GetComponent<SA_Unit>()._unitMP += 10;
                }
                if (skillindex1 == "31")
                {

                }
                if (skillindex1 == "32")
                {
                    _spumPref11.GetComponent<SA_Unit>()._unitHP += 10;
                }
            }
        }
        if (name01.text == "����")
        {
            sk001.sprite = Ch12;
            if (skillindex1 == "0")
            {
                Skill01.GetComponentInChildren<Button>().interactable = false;
            }
            else
            {
                _notice.SUB("����!!");
                Skill01.GetComponentInChildren<Button>().interactable = false;
                if (skillindex1 == "25")
                {

                }
                if (skillindex1 == "26")
                {
                    _spumPref12.GetComponent<SA_Unit>()._unitAT += 10;
                }
                if (skillindex1 == "27")
                {

                }
                if (skillindex1 == "28")
                {
                    _spumPref12.GetComponent<SA_Unit>()._unitAP += 10;
                }
                if (skillindex1 == "29")
                {

                }
                if (skillindex1 == "30")
                {
                    _spumPref12.GetComponent<SA_Unit>()._unitMP += 10;
                }
                if (skillindex1 == "31")
                {

                }
                if (skillindex1 == "32")
                {
                    _spumPref12.GetComponent<SA_Unit>()._unitHP += 10;
                }
            }
        }
        if (name01.text == "�ǹ�")
        {
            sk001.sprite = Ch13;
            if (skillindex1 == "0")
            {
                Skill01.GetComponentInChildren<Button>().interactable = false;
            }
            else
            {
                _notice.SUB("�ǹ�!!");
                Skill01.GetComponentInChildren<Button>().interactable = false;
                if (skillindex1 == "25")
                {

                }
                if (skillindex1 == "26")
                {
                    _spumPref13.GetComponent<SA_Unit>()._unitAT += 10;
                }
                if (skillindex1 == "27")
                {

                }
                if (skillindex1 == "28")
                {
                    _spumPref13.GetComponent<SA_Unit>()._unitAP += 10;
                }
                if (skillindex1 == "29")
                {

                }
                if (skillindex1 == "30")
                {
                    _spumPref13.GetComponent<SA_Unit>()._unitMP += 10;
                }
                if (skillindex1 == "31")
                {

                }
                if (skillindex1 == "32")
                {
                    _spumPref13.GetComponent<SA_Unit>()._unitHP += 10;
                }
            }
        }
        if (name01.text == "�ó����")
        {
            sk001.sprite = Ch14;
            if (skillindex1 == "0")
            {
                Skill01.GetComponentInChildren<Button>().interactable = false;
            }
            else
            {
                _notice.SUB("�ó����!!");
                Skill01.GetComponentInChildren<Button>().interactable = false;
                if (skillindex1 == "25")
                {

                }
                if (skillindex1 == "26")
                {
                    _spumPref14.GetComponent<SA_Unit>()._unitAT += 10;
                }
                if (skillindex1 == "27")
                {

                }
                if (skillindex1 == "28")
                {
                    _spumPref14.GetComponent<SA_Unit>()._unitAP += 10;
                }
                if (skillindex1 == "29")
                {

                }
                if (skillindex1 == "30")
                {
                    _spumPref14.GetComponent<SA_Unit>()._unitMP += 10;
                }
                if (skillindex1 == "31")
                {

                }
                if (skillindex1 == "32")
                {
                    _spumPref14.GetComponent<SA_Unit>()._unitHP += 10;
                }
            }
        }

        //sk001.sprite = Skill01.GetComponentInChildren<Image>().sprite;

    }

    public void ActiveSkill02()
    {

        if (name01.text == "������")
        {
            sk001.sprite = Ch00;
            _notice.SUB("������!!");
            Skill02.GetComponentInChildren<Button>().interactable = false;
        }
        if (name01.text == "�ٿ�")
        {
            sk001.sprite = Ch01;
            _notice.SUB("�ٿ�!!");
            Skill02.GetComponentInChildren<Button>().interactable = false;
        }
        if (name01.text == "����")
        {
            sk001.sprite = Ch02;
            _notice.SUB("����!!");
            Skill02.GetComponentInChildren<Button>().interactable = false;
        }
        if (name01.text == "�ٹ�")
        {
            sk001.sprite = Ch03;
            _notice.SUB("�ٹ�!!");
            Skill02.GetComponentInChildren<Button>().interactable = false;
        }
        if (name01.text == "�Ҷ�")
        {
            sk001.sprite = Ch04;
            _notice.SUB("�Ҷ�!!");
            Skill02.GetComponentInChildren<Button>().interactable = false;
        }
        if (name01.text == "�����")
        {
            sk001.sprite = Ch05;
            _notice.SUB("�����!!");
            Skill02.GetComponentInChildren<Button>().interactable = false;
        }
        if (name01.text == "��ġ")
        {
            sk001.sprite = Ch06;
            _notice.SUB("��ġ!!");
            Skill02.GetComponentInChildren<Button>().interactable = false;
        }
        if (name01.text == "����")
        {
            sk001.sprite = Ch07;
            _notice.SUB("����!!");
            Skill02.GetComponentInChildren<Button>().interactable = false;
        }
        if (name01.text == "���")
        {
            sk001.sprite = Ch08;
            _notice.SUB("���!!");
            Skill02.GetComponentInChildren<Button>().interactable = false;
        }
        if (name01.text == "�𵵸�")
        {
            sk001.sprite = Ch09;
            _notice.SUB("�𵵸�!!");
            Skill02.GetComponentInChildren<Button>().interactable = false;
        }
        if (name01.text == "���׸���")
        {
            sk001.sprite = Ch10;
            _notice.SUB("���׸���!!");
            Skill02.GetComponentInChildren<Button>().interactable = false;
        }
        if (name01.text == "����")
        {
            sk001.sprite = Ch11;
            _notice.SUB("����!!");
            Skill02.GetComponentInChildren<Button>().interactable = false;
        }
        if (name01.text == "����")
        {
            sk001.sprite = Ch12;
            _notice.SUB("����!!");
            Skill02.GetComponentInChildren<Button>().interactable = false;
        }
        if (name01.text == "�ǹ�")
        {
            sk001.sprite = Ch13;
            _notice.SUB("�ǹ�!!");
            Skill02.GetComponentInChildren<Button>().interactable = false;
        }
        if (name01.text == "�ó����")
        {
            sk001.sprite = Ch14;
            _notice.SUB("�ó����!!");
            Skill02.GetComponentInChildren<Button>().interactable = false;
        }

    }

    public void ActiveSkill03()
    {

        if (name02.text == "������")
        {
            sk001.sprite = Ch00;
            _notice.SUB("������!!");
            Skill03.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "�ٿ�")
        {
            sk001.sprite = Ch01;
            _notice.SUB("�ٿ�!!");
            Skill03.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "����")
        {
            sk001.sprite = Ch02;
            _notice.SUB("����!!");
            Skill03.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "�ٹ�")
        {
            sk001.sprite = Ch03;
            _notice.SUB("�ٹ�!!");
            Skill03.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "�Ҷ�")
        {
            sk001.sprite = Ch04;
            _notice.SUB("�Ҷ�!!");
            Skill03.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "�����")
        {
            sk001.sprite = Ch05;
            _notice.SUB("�����!!");
            Skill03.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "��ġ")
        {
            sk001.sprite = Ch06;
            _notice.SUB("��ġ!!");
            Skill03.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "����")
        {
            sk001.sprite = Ch07;
            _notice.SUB("����!!");
            Skill03.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "���")
        {
            sk001.sprite = Ch08;
            _notice.SUB("���!!");
            Skill03.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "�𵵸�")
        {
            sk001.sprite = Ch09;
            _notice.SUB("�𵵸�!!");
            Skill03.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "���׸���")
        {
            sk001.sprite = Ch10;
            _notice.SUB("���׸���!!");
            Skill03.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "����")
        {
            sk001.sprite = Ch11;
            _notice.SUB("����!!");
            Skill03.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "����")
        {
            sk001.sprite = Ch12;
            _notice.SUB("����!!");
            Skill03.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "�ǹ�")
        {
            sk001.sprite = Ch13;
            _notice.SUB("�ǹ�!!");
            Skill03.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "�ó����")
        {
            sk001.sprite = Ch14;
            _notice.SUB("�ó����!!");
            Skill03.GetComponentInChildren<Button>().interactable = false;
        }

    }

    public void ActiveSkill04()
    {

        if (name02.text == "������")
        {
            sk001.sprite = Ch00;
            _notice.SUB("������!!");
            Skill04.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "�ٿ�")
        {
            sk001.sprite = Ch01;
            _notice.SUB("�ٿ�!!");
            Skill04.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "����")
        {
            sk001.sprite = Ch02;
            _notice.SUB("����!!");
            Skill04.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "�ٹ�")
        {
            sk001.sprite = Ch03;
            _notice.SUB("�ٹ�!!");
            Skill04.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "�Ҷ�")
        {
            sk001.sprite = Ch04;
            _notice.SUB("�Ҷ�!!");
            Skill04.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "�����")
        {
            sk001.sprite = Ch05;
            _notice.SUB("�����!!");
            Skill04.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "��ġ")
        {
            sk001.sprite = Ch06;
            _notice.SUB("��ġ!!");
            Skill04.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "����")
        {
            sk001.sprite = Ch07;
            _notice.SUB("����!!");
            Skill04.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "���")
        {
            sk001.sprite = Ch08;
            _notice.SUB("���!!");
            Skill04.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "�𵵸�")
        {
            sk001.sprite = Ch09;
            _notice.SUB("�𵵸�!!");
            Skill04.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "���׸���")
        {
            sk001.sprite = Ch10;
            _notice.SUB("���׸���!!");
            Skill04.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "����")
        {
            sk001.sprite = Ch11;
            _notice.SUB("����!!");
            Skill04.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "����")
        {
            sk001.sprite = Ch12;
            _notice.SUB("����!!");
            Skill04.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "�ǹ�")
        {
            sk001.sprite = Ch13;
            _notice.SUB("�ǹ�!!");
            Skill04.GetComponentInChildren<Button>().interactable = false;
        }
        if (name02.text == "�ó����")
        {
            sk001.sprite = Ch14;
            _notice.SUB("�ó����!!");
            Skill04.GetComponentInChildren<Button>().interactable = false;
        }

    }

    public void ActiveSkill05()
    {

        if (name03.text == "������")
        {
            sk001.sprite = Ch00;
            _notice.SUB("������!!");
            Skill05.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "�ٿ�")
        {
            sk001.sprite = Ch01;
            _notice.SUB("�ٿ�!!");
            Skill05.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "����")
        {
            sk001.sprite = Ch02;
            _notice.SUB("����!!");
            Skill05.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "�ٹ�")
        {
            sk001.sprite = Ch03;
            _notice.SUB("�ٹ�!!");
            Skill05.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "�Ҷ�")
        {
            sk001.sprite = Ch04;
            _notice.SUB("�Ҷ�!!");
            Skill05.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "�����")
        {
            sk001.sprite = Ch05;
            _notice.SUB("�����!!");
            Skill05.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "��ġ")
        {
            sk001.sprite = Ch06;
            _notice.SUB("��ġ!!");
            Skill05.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "����")
        {
            sk001.sprite = Ch07;
            _notice.SUB("����!!");
            Skill05.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "���")
        {
            sk001.sprite = Ch08;
            _notice.SUB("���!!");
            Skill05.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "�𵵸�")
        {
            sk001.sprite = Ch09;
            _notice.SUB("�𵵸�!!");
            Skill05.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "���׸���")
        {
            sk001.sprite = Ch10;
            _notice.SUB("���׸���!!");
            Skill05.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "����")
        {
            sk001.sprite = Ch11;
            _notice.SUB("����!!");
            Skill05.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "����")
        {
            sk001.sprite = Ch12;
            _notice.SUB("����!!");
            Skill05.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "�ǹ�")
        {
            sk001.sprite = Ch13;
            _notice.SUB("�ǹ�!!");
            Skill05.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "�ó����")
        {
            sk001.sprite = Ch14;
            _notice.SUB("�ó����!!");
            Skill05.GetComponentInChildren<Button>().interactable = false;
        }

    }
    public void ActiveSkill06()
    {

        if (name03.text == "������")
        {
            sk001.sprite = Ch00;
            _notice.SUB("������!!");
            Skill06.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "�ٿ�")
        {
            sk001.sprite = Ch01;
            _notice.SUB("�ٿ�!!");
            Skill06.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "����")
        {
            sk001.sprite = Ch02;
            _notice.SUB("����!!");
            Skill06.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "�ٹ�")
        {
            sk001.sprite = Ch03;
            _notice.SUB("�ٹ�!!");
            Skill06.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "�Ҷ�")
        {
            sk001.sprite = Ch04;
            _notice.SUB("�Ҷ�!!");
            Skill06.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "�����")
        {
            sk001.sprite = Ch05;
            _notice.SUB("�����!!");
            Skill06.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "��ġ")
        {
            sk001.sprite = Ch06;
            _notice.SUB("��ġ!!");
            Skill06.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "����")
        {
            sk001.sprite = Ch07;
            _notice.SUB("����!!");
            Skill06.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "���")
        {
            sk001.sprite = Ch08;
            _notice.SUB("���!!");
            Skill06.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "�𵵸�")
        {
            sk001.sprite = Ch09;
            _notice.SUB("�𵵸�!!");
            Skill06.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "���׸���")
        {
            sk001.sprite = Ch10;
            _notice.SUB("���׸���!!");
            Skill06.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "����")
        {
            sk001.sprite = Ch11;
            _notice.SUB("����!!");
            Skill06.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "����")
        {
            sk001.sprite = Ch12;
            _notice.SUB("����!!");
            Skill06.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "�ǹ�")
        {
            sk001.sprite = Ch13;
            _notice.SUB("�ǹ�!!");
            Skill06.GetComponentInChildren<Button>().interactable = false;
        }
        if (name03.text == "�ó����")
        {
            sk001.sprite = Ch14;
            _notice.SUB("�ó����!!");
            Skill06.GetComponentInChildren<Button>().interactable = false;
        }

    }
    public void ActiveSkill07()
    {

        if (name04.text == "������")
        {
            sk001.sprite = Ch00;
            _notice.SUB("������!!");
            Skill07.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "�ٿ�")
        {
            sk001.sprite = Ch01;
            _notice.SUB("�ٿ�!!");
            Skill07.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "����")
        {
            sk001.sprite = Ch02;
            _notice.SUB("����!!");
            Skill07.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "�ٹ�")
        {
            sk001.sprite = Ch03;
            _notice.SUB("�ٹ�!!");
            Skill07.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "�Ҷ�")
        {
            sk001.sprite = Ch04;
            _notice.SUB("�Ҷ�!!");
            Skill07.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "�����")
        {
            sk001.sprite = Ch05;
            _notice.SUB("�����!!");
            Skill07.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "��ġ")
        {
            sk001.sprite = Ch06;
            _notice.SUB("��ġ!!");
            Skill07.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "����")
        {
            sk001.sprite = Ch07;
            _notice.SUB("����!!");
            Skill07.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "���")
        {
            sk001.sprite = Ch08;
            _notice.SUB("���!!");
            Skill07.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "�𵵸�")
        {
            sk001.sprite = Ch09;
            _notice.SUB("�𵵸�!!");
            Skill07.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "���׸���")
        {
            sk001.sprite = Ch10;
            _notice.SUB("���׸���!!");
            Skill07.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "����")
        {
            sk001.sprite = Ch11;
            _notice.SUB("����!!");
            Skill07.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "����")
        {
            sk001.sprite = Ch12;
            _notice.SUB("����!!");
            Skill07.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "�ǹ�")
        {
            sk001.sprite = Ch13;
            _notice.SUB("�ǹ�!!");
            Skill07.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "�ó����")
        {
            sk001.sprite = Ch14;
            _notice.SUB("�ó����!!");
            Skill07.GetComponentInChildren<Button>().interactable = false;
        }

    }
    public void ActiveSkill08()
    {

        if (name04.text == "������")
        {
            sk001.sprite = Ch00;
            _notice.SUB("������!!");
            Skill08.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "�ٿ�")
        {
            sk001.sprite = Ch01;
            _notice.SUB("�ٿ�!!");
            Skill08.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "����")
        {
            sk001.sprite = Ch02;
            _notice.SUB("����!!");
            Skill08.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "�ٹ�")
        {
            sk001.sprite = Ch03;
            _notice.SUB("�ٹ�!!");
            Skill08.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "�Ҷ�")
        {
            sk001.sprite = Ch04;
            _notice.SUB("�Ҷ�!!");
            Skill08.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "�����")
        {
            sk001.sprite = Ch05;
            _notice.SUB("�����!!");
            Skill08.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "��ġ")
        {
            sk001.sprite = Ch06;
            _notice.SUB("��ġ!!");
            Skill08.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "����")
        {
            sk001.sprite = Ch07;
            _notice.SUB("����!!");
            Skill08.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "���")
        {
            sk001.sprite = Ch08;
            _notice.SUB("���!!");
            Skill08.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "�𵵸�")
        {
            sk001.sprite = Ch09;
            _notice.SUB("�𵵸�!!");
            Skill08.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "���׸���")
        {
            sk001.sprite = Ch10;
            _notice.SUB("���׸���!!");
            Skill08.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "����")
        {
            sk001.sprite = Ch11;
            _notice.SUB("����!!");
            Skill08.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "����")
        {
            sk001.sprite = Ch12;
            _notice.SUB("����!!");
            Skill08.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "�ǹ�")
        {
            sk001.sprite = Ch13;
            _notice.SUB("�ǹ�!!");
            Skill08.GetComponentInChildren<Button>().interactable = false;
        }
        if (name04.text == "�ó����")
        {
            sk001.sprite = Ch14;
            _notice.SUB("�ó����!!");
            Skill08.GetComponentInChildren<Button>().interactable = false;
        }
    }
}