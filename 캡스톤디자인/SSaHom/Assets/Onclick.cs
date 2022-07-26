using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using UnityEngine;
using UnityEngine.UI;

public class Onclick : MonoBehaviour
{

    SA_Unit _unitST;

    public GameObject Skill01, Skill02, Skill03, Skill04, Skill05, Skill06, Skill07, Skill08;

    public GameObject Unit000;
    public GameObject Unit001;
    public GameObject Unit002;
    public GameObject Unit003;
    public GameObject Unit004;
    public GameObject Unit005;
    public GameObject Unit006;
    public GameObject Unit007;
    public GameObject Unit008;
    public GameObject Unit009;
    public GameObject Unit010;
    public GameObject Unit011;
    public GameObject Unit012;
    public GameObject Unit013;
    public GameObject Unit014;

    public GameObject button00;
    public GameObject button01;
    public GameObject button02;
    public GameObject button03;
    public GameObject button04;
    public GameObject button05;
    public GameObject button06;
    public GameObject button07;
    public GameObject button08;
    public GameObject button09;
    public GameObject button10;
    public GameObject button11;
    public GameObject button12;
    public GameObject button13;
    public GameObject button14;

    public GameObject button000;
    public GameObject button001;
    public GameObject button002;
    public GameObject button003;
    public GameObject button004;
    public GameObject button005;
    public GameObject button006;
    public GameObject button007;
    public GameObject button008;
    public GameObject button009;
    public GameObject button010;
    public GameObject button011;
    public GameObject button012;
    public GameObject button013;
    public GameObject button014;

    public GameObject introduce1;
    public GameObject introduce2;
    public GameObject introduce3;

    public GameObject pickclose;
    public GameObject enemy;
    public GameObject enemy1;
    public GameObject Clear;
    public GameObject Win;
    public GameObject Win1;
    public GameObject Over;
    public GameObject defeat;
    NoticeUI _notice;
    public GameObject SkillButton;

    private Text Score;
    private int score = 0;
    private int score1 = 0;

    public GameObject Monster1;
    public GameObject Monster2;
    public GameObject Monster3;
    public GameObject Monster4;
    public GameObject Monster5;
    public GameObject Monster6;
    public GameObject Monster7;
    public GameObject Monster8;

    public GameObject HealthBar0;
    public GameObject HealthBar1;
    public GameObject HealthBar2;
    public GameObject HealthBar3;
    public GameObject HealthBar4;
    public GameObject HealthBar5;
    public GameObject HealthBar6;
    public GameObject HealthBar7;
    public GameObject HealthBar8;
    public GameObject HealthBar9;
    public GameObject HealthBar10;
    public GameObject HealthBar11;
    public GameObject HealthBar12;
    public GameObject HealthBar13;
    public GameObject HealthBar14;
    public GameObject ManaBar0;
    public GameObject ManaBar1;
    public GameObject ManaBar2;
    public GameObject ManaBar3;
    public GameObject ManaBar4;
    public GameObject ManaBar5;
    public GameObject ManaBar6;
    public GameObject ManaBar7;
    public GameObject ManaBar8;
    public GameObject ManaBar9;
    public GameObject ManaBar10;
    public GameObject ManaBar11;
    public GameObject ManaBar12;
    public GameObject ManaBar13;
    public GameObject ManaBar14;

    public GameObject MonsterHealthBar0;
    public GameObject MonsterHealthBar1;
    public GameObject MonsterHealthBar2;
    public GameObject MonsterHealthBar3;
    public GameObject MonsterHealthBar4;
    public GameObject MonsterHealthBar5;
    public GameObject MonsterHealthBar6;
    public GameObject MonsterHealthBar7;
    //public GameObject MonsterManaBar0;
    //public GameObject MonsterManaBar1;
    //public GameObject MonsterManaBar2;
    //public GameObject MonsterManaBar3;

    private int Timer = 0;
    public GameObject Num_A;
    public GameObject Num_B;
    public GameObject Num_C;
    public GameObject Num_GO;
    float min = -3.0f;
    float max = 3.0f;
    float widthmin = -8.0f;
    float widthmax = 8.0f;
    float heightmin = -4.5f;
    float heighthmax = -0.5f;

    public GameObject Stage1;
    public GameObject Stage2;

    int stage;
    void Awake()
    {
        _notice = FindObjectOfType<NoticeUI>();
    }

    void Start()
    {
        SkillButton.SetActive(false);
        Timer = 0;
        //Num_A.SetActive(false);
        //Num_B.SetActive(false);
        //Num_C.SetActive(false);
        //Num_GO.SetActive(false);
        Score = GameObject.Find("myscore").GetComponent<Text>();

        int a = PlayerPrefs.GetInt("Small_Stage");
        if (a == 0)
        {
            if (Stage1.activeSelf == false)
            {
                Stage1.SetActive(true);
            }
            if (Stage2.activeSelf == true)
            {
                Stage2.SetActive(false);
            }

        }
        if (a == 1)
        {
            if (Stage1.activeSelf == true)
            {
                Stage1.SetActive(false);
            }
            if (Stage2.activeSelf == false)
            {
                Stage2.SetActive(true);
            }

        }

    }

    void Update()
    {


    }



    // Start is called before the first frame update
    public void Unit000Set()
    {
        PlayerPrefs.SetInt("Play_Id", 0);
        float randomX = Random.Range(widthmin, widthmax);
        float randomY = Random.Range(heightmin, heighthmax);

        int id = PlayerPrefs.GetInt("Play_Id");
        string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[0];
        character.SelectSingleNode("pickId").InnerText = id.ToString();
        xmlDoc.Save(path);

        Unit000.transform.position = new Vector3(randomX, randomY);
        Unit000.SetActive(true);
        button00.SetActive(false);
        button01.SetActive(false);
        button02.SetActive(false);
        button03.SetActive(false);
        button04.SetActive(false);
        button05.SetActive(true);
        button06.SetActive(true);
        button07.SetActive(true);
        button08.SetActive(true);
        button09.SetActive(true);
        //button000.SetActive(true);
        introduce1.SetActive(false);
        introduce2.SetActive(true);
    }
    public void Unit001Set()
    {
        PlayerPrefs.SetInt("Play_Id", 1);
        float randomX = Random.Range(widthmin, widthmax);
        float randomY = Random.Range(heightmin, heighthmax);

        int id = PlayerPrefs.GetInt("Play_Id");
        string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[0];
        character.SelectSingleNode("pickId").InnerText = id.ToString();
        xmlDoc.Save(path);

        Unit001.transform.position = new Vector3(randomX, randomY);
        Unit001.SetActive(true);
        button00.SetActive(false);
        button01.SetActive(false);
        button02.SetActive(false);
        button03.SetActive(false);
        button04.SetActive(false);
        button05.SetActive(true);
        button06.SetActive(true);
        button07.SetActive(true);
        button08.SetActive(true);
        button09.SetActive(true);
        //button001.SetActive(true);
        introduce1.SetActive(false);
        introduce2.SetActive(true);
    }
    public void Unit002Set()
    {
        PlayerPrefs.SetInt("Play_Id", 2);
        float randomX = Random.Range(widthmin, widthmax);
        float randomY = Random.Range(heightmin, heighthmax);

        int id = PlayerPrefs.GetInt("Play_Id");
        string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[0];
        character.SelectSingleNode("pickId").InnerText = id.ToString();
        xmlDoc.Save(path);

        Unit002.transform.position = new Vector3(randomX, randomY);
        Unit002.SetActive(true);
        button00.SetActive(false);
        button01.SetActive(false);
        button02.SetActive(false);
        button03.SetActive(false);
        button04.SetActive(false);
        button05.SetActive(true);
        button06.SetActive(true);
        button07.SetActive(true);
        button08.SetActive(true);
        button09.SetActive(true);
        //button002.SetActive(true);
        introduce1.SetActive(false);
        introduce2.SetActive(true);
    }
    public void Unit003Set()
    {
        PlayerPrefs.SetInt("Play_Id", 3);
        float randomX = Random.Range(widthmin, widthmax);
        float randomY = Random.Range(heightmin, heighthmax);

        int id = PlayerPrefs.GetInt("Play_Id");
        string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[0];
        character.SelectSingleNode("pickId").InnerText = id.ToString();
        xmlDoc.Save(path);

        Unit003.transform.position = new Vector3(randomX, randomY);
        Unit003.SetActive(true);
        button00.SetActive(false);
        button01.SetActive(false);
        button02.SetActive(false);
        button03.SetActive(false);
        button04.SetActive(false);
        button05.SetActive(true);
        button06.SetActive(true);
        button07.SetActive(true);
        button08.SetActive(true);
        button09.SetActive(true);
        //button003.SetActive(true);
        introduce1.SetActive(false);
        introduce2.SetActive(true);
    }
    public void Unit004Set()
    {
        PlayerPrefs.SetInt("Play_Id", 4);
        float randomX = Random.Range(widthmin, widthmax);
        float randomY = Random.Range(heightmin, heighthmax);

        int id = PlayerPrefs.GetInt("Play_Id");
        string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[0];
        character.SelectSingleNode("pickId").InnerText = id.ToString();
        xmlDoc.Save(path);

        Unit004.transform.position = new Vector3(randomX, randomY);
        Unit004.SetActive(true);
        button00.SetActive(false);
        button01.SetActive(false);
        button02.SetActive(false);
        button03.SetActive(false);
        button04.SetActive(false);
        button05.SetActive(true);
        button06.SetActive(true);
        button07.SetActive(true);
        button08.SetActive(true);
        button09.SetActive(true);
        //button004.SetActive(true);
        introduce1.SetActive(false);
        introduce2.SetActive(true);
    }

    public void Unit005Set()
    {
        PlayerPrefs.SetInt("Play_Id", 5);
        float randomX = Random.Range(widthmin, widthmax);
        float randomY = Random.Range(heightmin, heighthmax);

        int id = PlayerPrefs.GetInt("Play_Id");
        string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[1];
        character.SelectSingleNode("pickId").InnerText = id.ToString();
        xmlDoc.Save(path);

        Unit005.transform.position = new Vector3(randomX, randomY);
        Unit005.SetActive(true);
        button05.SetActive(false);
        button06.SetActive(false);
        button07.SetActive(false);
        button08.SetActive(false);
        button09.SetActive(false);
        button10.SetActive(true);
        button11.SetActive(true);
        button12.SetActive(true);
        button13.SetActive(true);
        button14.SetActive(true);
        //button005.SetActive(true);
        introduce1.SetActive(false);
        introduce2.SetActive(false);
        introduce3.SetActive(true);
    }
    public void Unit006Set()
    {
        PlayerPrefs.SetInt("Play_Id", 6);
        float randomX = Random.Range(widthmin, widthmax);
        float randomY = Random.Range(heightmin, heighthmax);

        int id = PlayerPrefs.GetInt("Play_Id");
        string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[1];
        character.SelectSingleNode("pickId").InnerText = id.ToString();
        xmlDoc.Save(path);

        Unit006.transform.position = new Vector3(randomX, randomY);
        Unit006.SetActive(true);
        button05.SetActive(false);
        button06.SetActive(false);
        button07.SetActive(false);
        button08.SetActive(false);
        button09.SetActive(false);
        button10.SetActive(true);
        button11.SetActive(true);
        button12.SetActive(true);
        button13.SetActive(true);
        button14.SetActive(true);
        introduce2.SetActive(false);
        introduce3.SetActive(true);
    }
    public void Unit007Set()
    {
        PlayerPrefs.SetInt("Play_Id", 7);
        float randomX = Random.Range(widthmin, widthmax);
        float randomY = Random.Range(heightmin, heighthmax);

        int id = PlayerPrefs.GetInt("Play_Id");
        string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[1];
        character.SelectSingleNode("pickId").InnerText = id.ToString();
        xmlDoc.Save(path);

        Unit007.transform.position = new Vector3(randomX, randomY);
        Unit007.SetActive(true);
        button05.SetActive(false);
        button06.SetActive(false);
        button07.SetActive(false);
        button08.SetActive(false);
        button09.SetActive(false);
        button10.SetActive(true);
        button11.SetActive(true);
        button12.SetActive(true);
        button13.SetActive(true);
        button14.SetActive(true);
        introduce2.SetActive(false);
        introduce3.SetActive(true);
    }
    public void Unit008Set()
    {
        PlayerPrefs.SetInt("Play_Id", 8);
        float randomX = Random.Range(widthmin, widthmax);
        float randomY = Random.Range(heightmin, heighthmax);

        int id = PlayerPrefs.GetInt("Play_Id");
        string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[1];
        character.SelectSingleNode("pickId").InnerText = id.ToString();
        xmlDoc.Save(path);

        Unit008.transform.position = new Vector3(randomX, randomY);
        Unit008.SetActive(true);
        button05.SetActive(false);
        button06.SetActive(false);
        button07.SetActive(false);
        button08.SetActive(false);
        button09.SetActive(false);
        button10.SetActive(true);
        button11.SetActive(true);
        button12.SetActive(true);
        button13.SetActive(true);
        button14.SetActive(true);
        introduce2.SetActive(false);
        introduce3.SetActive(true);
    }
    public void Unit009Set()
    {
        PlayerPrefs.SetInt("Play_Id", 9);
        float randomX = Random.Range(widthmin, widthmax);
        float randomY = Random.Range(heightmin, heighthmax);

        int id = PlayerPrefs.GetInt("Play_Id");
        string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[1];
        character.SelectSingleNode("pickId").InnerText = id.ToString();
        xmlDoc.Save(path);

        Unit009.transform.position = new Vector3(randomX, randomY);
        Unit009.SetActive(true);
        button05.SetActive(false);
        button06.SetActive(false);
        button07.SetActive(false);
        button08.SetActive(false);
        button09.SetActive(false);
        button10.SetActive(true);
        button11.SetActive(true);
        button12.SetActive(true);
        button13.SetActive(true);
        button14.SetActive(true);
        introduce2.SetActive(false);
        introduce3.SetActive(true);
    }

    public void Unit010Set()
    {
        PlayerPrefs.SetInt("Play_Id", 10);
        float randomX = Random.Range(widthmin, widthmax);
        float randomY = Random.Range(heightmin, heighthmax);

        int id = PlayerPrefs.GetInt("Play_Id");
        string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[2];
        character.SelectSingleNode("pickId").InnerText = id.ToString();
        xmlDoc.Save(path);

        Unit010.transform.position = new Vector3(randomX, randomY);
        Unit010.SetActive(true);
        button10.SetActive(false);
        button11.SetActive(false);
        button12.SetActive(false);
        button13.SetActive(false);
        button14.SetActive(false);
        button000.SetActive(true);
        button001.SetActive(true);
        button002.SetActive(true);
        button003.SetActive(true);
        button004.SetActive(true);
        button005.SetActive(true);
        button006.SetActive(true);
        button007.SetActive(true);
        button008.SetActive(true);
        button009.SetActive(true);
        button010.SetActive(true);
        button011.SetActive(true);
        button012.SetActive(true);
        button013.SetActive(true);
        button014.SetActive(true);
        introduce3.SetActive(false);
    }

    public void Unit011Set()
    {
        PlayerPrefs.SetInt("Play_Id", 11);
        float randomX = Random.Range(widthmin, widthmax);
        float randomY = Random.Range(heightmin, heighthmax);

        int id = PlayerPrefs.GetInt("Play_Id");
        string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[2];
        character.SelectSingleNode("pickId").InnerText = id.ToString();
        xmlDoc.Save(path);

        Unit011.transform.position = new Vector3(randomX, randomY);
        Unit011.SetActive(true);
        button10.SetActive(false);
        button11.SetActive(false);
        button12.SetActive(false);
        button13.SetActive(false);
        button14.SetActive(false);
        button000.SetActive(true);
        button001.SetActive(true);
        button002.SetActive(true);
        button003.SetActive(true);
        button004.SetActive(true);
        button005.SetActive(true);
        button006.SetActive(true);
        button007.SetActive(true);
        button008.SetActive(true);
        button009.SetActive(true);
        button010.SetActive(true);
        button011.SetActive(true);
        button012.SetActive(true);
        button013.SetActive(true);
        button014.SetActive(true);
        introduce3.SetActive(false);

    }

    public void Unit012Set()
    {
        PlayerPrefs.SetInt("Play_Id", 12);
        float randomX = Random.Range(widthmin, widthmax);
        float randomY = Random.Range(heightmin, heighthmax);

        int id = PlayerPrefs.GetInt("Play_Id");
        string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[2];
        character.SelectSingleNode("pickId").InnerText = id.ToString();
        xmlDoc.Save(path);

        Unit012.transform.position = new Vector3(randomX, randomY);
        Unit012.SetActive(true);
        button10.SetActive(false);
        button11.SetActive(false);
        button12.SetActive(false);
        button13.SetActive(false);
        button14.SetActive(false);
        button000.SetActive(true);
        button001.SetActive(true);
        button002.SetActive(true);
        button003.SetActive(true);
        button004.SetActive(true);
        button005.SetActive(true);
        button006.SetActive(true);
        button007.SetActive(true);
        button008.SetActive(true);
        button009.SetActive(true);
        button010.SetActive(true);
        button011.SetActive(true);
        button012.SetActive(true);
        button013.SetActive(true);
        button014.SetActive(true);
        introduce3.SetActive(false);
    }

    public void Unit013Set()
    {
        PlayerPrefs.SetInt("Play_Id", 13);
        float randomX = Random.Range(widthmin, widthmax);
        float randomY = Random.Range(heightmin, heighthmax);

        int id = PlayerPrefs.GetInt("Play_Id");
        string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[2];
        character.SelectSingleNode("pickId").InnerText = id.ToString();
        xmlDoc.Save(path);

        Unit013.transform.position = new Vector3(randomX, randomY);
        Unit013.SetActive(true);
        button10.SetActive(false);
        button11.SetActive(false);
        button12.SetActive(false);
        button13.SetActive(false);
        button14.SetActive(false);
        button000.SetActive(true);
        button001.SetActive(true);
        button002.SetActive(true);
        button003.SetActive(true);
        button004.SetActive(true);
        button005.SetActive(true);
        button006.SetActive(true);
        button007.SetActive(true);
        button008.SetActive(true);
        button009.SetActive(true);
        button010.SetActive(true);
        button011.SetActive(true);
        button012.SetActive(true);
        button013.SetActive(true);
        button014.SetActive(true);
        introduce3.SetActive(false);
    }

    public void Unit0014Set()
    {
        PlayerPrefs.SetInt("Play_Id", 14);
        float randomX = Random.Range(widthmin, widthmax);
        float randomY = Random.Range(heightmin, heighthmax);

        int id = PlayerPrefs.GetInt("Play_Id");
        string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[2];
        character.SelectSingleNode("pickId").InnerText = id.ToString();
        xmlDoc.Save(path);

        Unit014.transform.position = new Vector3(randomX, randomY);
        Unit014.SetActive(true);
        button10.SetActive(false);
        button11.SetActive(false);
        button12.SetActive(false);
        button13.SetActive(false);
        button14.SetActive(false);
        button000.SetActive(true);
        button001.SetActive(true);
        button002.SetActive(true);
        button003.SetActive(true);
        button004.SetActive(true);
        button005.SetActive(true);
        button006.SetActive(true);
        button007.SetActive(true);
        button008.SetActive(true);
        button009.SetActive(true);
        button010.SetActive(true);
        button011.SetActive(true);
        button012.SetActive(true);
        button013.SetActive(true);
        button014.SetActive(true);
        introduce3.SetActive(false);
    }

    public void Unit000Set1()
    {
        if(Unit000.activeSelf == true)
        {
            _notice.SUB("이미 선택된 용병 입니다.");
        }
        else if(Unit000.activeSelf == false)
        {
            float randomX = Random.Range(widthmin, widthmax);
            float randomY = Random.Range(heightmin, heighthmax);

            PlayerPrefs.SetInt("Play_Id", 0);
            int id = PlayerPrefs.GetInt("Play_Id");
            string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
            //TextAsset txtAsset = (TextAsset)Resources.Load(path);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(File.ReadAllText(path));
            //Debug.Log(txtAsset.text);
            XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
            XmlNode character = nodes[3];
            character.SelectSingleNode("pickId").InnerText = id.ToString();
            xmlDoc.Save(path);
            Unit000.transform.position = new Vector3(randomX, randomY);
            Unit000.SetActive(true);
            button000.SetActive(false);
            button001.SetActive(false);
            button002.SetActive(false);
            button003.SetActive(false);
            button004.SetActive(false);
            button005.SetActive(false);
            button006.SetActive(false);
            button007.SetActive(false);
            button008.SetActive(false);
            button009.SetActive(false);
            button010.SetActive(false);
            button011.SetActive(false);
            button012.SetActive(false);
            button013.SetActive(false);
            button014.SetActive(false);
        }
    }

    public void Unit001Set1()
    {
        if (Unit001.activeSelf == true)
        {
            _notice.SUB("이미 선택된 용병 입니다.");
        }
        else if (Unit001.activeSelf == false)
        {
            PlayerPrefs.SetInt("Play_Id", 1);
            float randomX = Random.Range(widthmin, widthmax);
            float randomY = Random.Range(heightmin, heighthmax);

            int id = PlayerPrefs.GetInt("Play_Id");
            string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
            //TextAsset txtAsset = (TextAsset)Resources.Load(path);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(File.ReadAllText(path));
            //Debug.Log(txtAsset.text);
            XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
            XmlNode character = nodes[3];
            character.SelectSingleNode("pickId").InnerText = id.ToString();
            xmlDoc.Save(path);

            Unit001.transform.position = new Vector3(randomX, randomY);
            Unit001.SetActive(true);
            button000.SetActive(false);
            button001.SetActive(false);
            button002.SetActive(false);
            button003.SetActive(false);
            button004.SetActive(false);
            button005.SetActive(false);
            button006.SetActive(false);
            button007.SetActive(false);
            button008.SetActive(false);
            button009.SetActive(false);
            button010.SetActive(false);
            button011.SetActive(false);
            button012.SetActive(false);
            button013.SetActive(false);
            button014.SetActive(false);
        }
    }

    public void Unit002Set1()
    {
        if (Unit002.activeSelf == true)
        {
            _notice.SUB("이미 선택된 용병 입니다.");
        }
        else if (Unit002.activeSelf == false)
        {
            PlayerPrefs.SetInt("Play_Id", 2);
            float randomX = Random.Range(widthmin, widthmax);
            float randomY = Random.Range(heightmin, heighthmax);

            int id = PlayerPrefs.GetInt("Play_Id");
            string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
            //TextAsset txtAsset = (TextAsset)Resources.Load(path);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(File.ReadAllText(path));
            //Debug.Log(txtAsset.text);
            XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
            XmlNode character = nodes[3];
            character.SelectSingleNode("pickId").InnerText = id.ToString();
            xmlDoc.Save(path);

            Unit002.transform.position = new Vector3(randomX, randomY);
            Unit002.SetActive(true);
            button000.SetActive(false);
            button001.SetActive(false);
            button002.SetActive(false);
            button003.SetActive(false);
            button004.SetActive(false);
            button005.SetActive(false);
            button006.SetActive(false);
            button007.SetActive(false);
            button008.SetActive(false);
            button009.SetActive(false);
            button010.SetActive(false);
            button011.SetActive(false);
            button012.SetActive(false);
            button013.SetActive(false);
            button014.SetActive(false);
        }
    }

    public void Unit003Set1()
    {
        if (Unit003.activeSelf == true)
        {
            _notice.SUB("이미 선택된 용병 입니다.");
        }
        else if (Unit003.activeSelf == false)
        {
            float randomX = Random.Range(widthmin, widthmax);
            float randomY = Random.Range(heightmin, heighthmax);

            PlayerPrefs.SetInt("Play_Id", 3);

            int id = PlayerPrefs.GetInt("Play_Id");
            string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
            //TextAsset txtAsset = (TextAsset)Resources.Load(path);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(File.ReadAllText(path));
            //Debug.Log(txtAsset.text);
            XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
            XmlNode character = nodes[3];
            character.SelectSingleNode("pickId").InnerText = id.ToString();
            xmlDoc.Save(path);
            Unit003.transform.position = new Vector3(randomX, randomY);
            Unit003.SetActive(true);
            button000.SetActive(false);
            button001.SetActive(false);
            button002.SetActive(false);
            button003.SetActive(false);
            button004.SetActive(false);
            button005.SetActive(false);
            button006.SetActive(false);
            button007.SetActive(false);
            button008.SetActive(false);
            button009.SetActive(false);
            button010.SetActive(false);
            button011.SetActive(false);
            button012.SetActive(false);
            button013.SetActive(false);
            button014.SetActive(false);
        }
    }

    public void Unit004Set1()
    {
        if (Unit004.activeSelf == true)
        {
            _notice.SUB("이미 선택된 용병 입니다.");
        }
        else if (Unit004.activeSelf == false)
        {
            float randomX = Random.Range(widthmin, widthmax);
            float randomY = Random.Range(heightmin, heighthmax);

            PlayerPrefs.SetInt("Play_Id", 4);

            int id = PlayerPrefs.GetInt("Play_Id");
            string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
            //TextAsset txtAsset = (TextAsset)Resources.Load(path);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(File.ReadAllText(path));
            //Debug.Log(txtAsset.text);
            XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
            XmlNode character = nodes[3];
            character.SelectSingleNode("pickId").InnerText = id.ToString();
            xmlDoc.Save(path);
            Unit004.transform.position = new Vector3(randomX, randomY);
            Unit004.SetActive(true);
            button000.SetActive(false);
            button001.SetActive(false);
            button002.SetActive(false);
            button003.SetActive(false);
            button004.SetActive(false);
            button005.SetActive(false);
            button006.SetActive(false);
            button007.SetActive(false);
            button008.SetActive(false);
            button009.SetActive(false);
            button010.SetActive(false);
            button011.SetActive(false);
            button012.SetActive(false);
            button013.SetActive(false);
            button014.SetActive(false);
        }
    }

    public void Unit005Set1()
    {
        if (Unit005.activeSelf == true)
        {
            _notice.SUB("이미 선택된 용병 입니다.");
        }
        else if (Unit005.activeSelf == false)
        {
            float randomX = Random.Range(widthmin, widthmax);
            float randomY = Random.Range(heightmin, heighthmax);

            PlayerPrefs.SetInt("Play_Id", 5);

            int id = PlayerPrefs.GetInt("Play_Id");
            string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
            //TextAsset txtAsset = (TextAsset)Resources.Load(path);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(File.ReadAllText(path));
            //Debug.Log(txtAsset.text);
            XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
            XmlNode character = nodes[3];
            character.SelectSingleNode("pickId").InnerText = id.ToString();
            xmlDoc.Save(path);
            Unit005.transform.position = new Vector3(randomX, randomY);
            Unit005.SetActive(true);
            button000.SetActive(false);
            button001.SetActive(false);
            button002.SetActive(false);
            button003.SetActive(false);
            button004.SetActive(false);
            button005.SetActive(false);
            button006.SetActive(false);
            button007.SetActive(false);
            button008.SetActive(false);
            button009.SetActive(false);
            button010.SetActive(false);
            button011.SetActive(false);
            button012.SetActive(false);
            button013.SetActive(false);
            button014.SetActive(false);
        }
    }

    public void Unit006Set1()
    {
        if (Unit006.activeSelf == true)
        {
            _notice.SUB("이미 선택된 용병 입니다.");
        }
        else if (Unit006.activeSelf == false)
        {
            float randomX = Random.Range(widthmin, widthmax);
            float randomY = Random.Range(heightmin, heighthmax);

            PlayerPrefs.SetInt("Play_Id", 6);
            int id = PlayerPrefs.GetInt("Play_Id");
            string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
            //TextAsset txtAsset = (TextAsset)Resources.Load(path);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(File.ReadAllText(path));
            //Debug.Log(txtAsset.text);
            XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
            XmlNode character = nodes[3];
            character.SelectSingleNode("pickId").InnerText = id.ToString();
            xmlDoc.Save(path);
            Unit006.transform.position = new Vector3(randomX, randomY);
            Unit006.SetActive(true);
            button000.SetActive(false);
            button001.SetActive(false);
            button002.SetActive(false);
            button003.SetActive(false);
            button004.SetActive(false);
            button005.SetActive(false);
            button006.SetActive(false);
            button007.SetActive(false);
            button008.SetActive(false);
            button009.SetActive(false);
            button010.SetActive(false);
            button011.SetActive(false);
            button012.SetActive(false);
            button013.SetActive(false);
            button014.SetActive(false);
        }
    }

    public void Unit007Set1()
    {
        if (Unit007.activeSelf == true)
        {
            _notice.SUB("이미 선택된 용병 입니다.");
        }
        else if (Unit007.activeSelf == false)
        {
            float randomX = Random.Range(widthmin, widthmax);
            float randomY = Random.Range(heightmin, heighthmax);

            PlayerPrefs.SetInt("Play_Id", 7);
            int id = PlayerPrefs.GetInt("Play_Id");
            string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
            //TextAsset txtAsset = (TextAsset)Resources.Load(path);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(File.ReadAllText(path));
            //Debug.Log(txtAsset.text);
            XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
            XmlNode character = nodes[3];
            character.SelectSingleNode("pickId").InnerText = id.ToString();
            xmlDoc.Save(path);
            Unit007.transform.position = new Vector3(randomX, randomY);
            Unit007.SetActive(true);
            button000.SetActive(false);
            button001.SetActive(false);
            button002.SetActive(false);
            button003.SetActive(false);
            button004.SetActive(false);
            button005.SetActive(false);
            button006.SetActive(false);
            button007.SetActive(false);
            button008.SetActive(false);
            button009.SetActive(false);
            button010.SetActive(false);
            button011.SetActive(false);
            button012.SetActive(false);
            button013.SetActive(false);
            button014.SetActive(false);
        }
    }

    public void Unit008Set1()
    {
        if (Unit008.activeSelf == true)
        {
            _notice.SUB("이미 선택된 용병 입니다.");
        }
        else if (Unit008.activeSelf == false)
        {
            float randomX = Random.Range(widthmin, widthmax);
            float randomY = Random.Range(heightmin, heighthmax);

            PlayerPrefs.SetInt("Play_Id", 8);
            int id = PlayerPrefs.GetInt("Play_Id");
            string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
            //TextAsset txtAsset = (TextAsset)Resources.Load(path);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(File.ReadAllText(path));
            //Debug.Log(txtAsset.text);
            XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
            XmlNode character = nodes[3];
            character.SelectSingleNode("pickId").InnerText = id.ToString();
            xmlDoc.Save(path);
            Unit008.transform.position = new Vector3(randomX, randomY);
            Unit008.SetActive(true);
            button000.SetActive(false);
            button001.SetActive(false);
            button002.SetActive(false);
            button003.SetActive(false);
            button004.SetActive(false);
            button005.SetActive(false);
            button006.SetActive(false);
            button007.SetActive(false);
            button008.SetActive(false);
            button009.SetActive(false);
            button010.SetActive(false);
            button011.SetActive(false);
            button012.SetActive(false);
            button013.SetActive(false);
            button014.SetActive(false);
        }
    }

    public void Unit009Set1()
    {
        if (Unit009.activeSelf == true)
        {
            _notice.SUB("이미 선택된 용병 입니다.");
        }
        else if (Unit009.activeSelf == false)
        {
            float randomX = Random.Range(widthmin, widthmax);
            float randomY = Random.Range(heightmin, heighthmax);

            PlayerPrefs.SetInt("Play_Id", 9);
            int id = PlayerPrefs.GetInt("Play_Id");
            string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
            //TextAsset txtAsset = (TextAsset)Resources.Load(path);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(File.ReadAllText(path));
            //Debug.Log(txtAsset.text);
            XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
            XmlNode character = nodes[3];
            character.SelectSingleNode("pickId").InnerText = id.ToString();
            xmlDoc.Save(path);
            Unit009.transform.position = new Vector3(randomX, randomY);
            Unit009.SetActive(true);
            button000.SetActive(false);
            button001.SetActive(false);
            button002.SetActive(false);
            button003.SetActive(false);
            button004.SetActive(false);
            button005.SetActive(false);
            button006.SetActive(false);
            button007.SetActive(false);
            button008.SetActive(false);
            button009.SetActive(false);
            button010.SetActive(false);
            button011.SetActive(false);
            button012.SetActive(false);
            button013.SetActive(false);
            button014.SetActive(false);
        }
    }

    public void Unit010Set1()
    {
        if (Unit010.activeSelf == true)
        {
            _notice.SUB("이미 선택된 용병 입니다.");
        }
        else if (Unit010.activeSelf == false)
        {
            float randomX = Random.Range(widthmin, widthmax);
            float randomY = Random.Range(heightmin, heighthmax);

            PlayerPrefs.SetInt("Play_Id", 10);
            int id = PlayerPrefs.GetInt("Play_Id");
            string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
            //TextAsset txtAsset = (TextAsset)Resources.Load(path);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(File.ReadAllText(path));
            //Debug.Log(txtAsset.text);
            XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
            XmlNode character = nodes[3];
            character.SelectSingleNode("pickId").InnerText = id.ToString();
            xmlDoc.Save(path);
            Unit010.transform.position = new Vector3(randomX, randomY);
            Unit010.SetActive(true);
            button000.SetActive(false);
            button001.SetActive(false);
            button002.SetActive(false);
            button003.SetActive(false);
            button004.SetActive(false);
            button005.SetActive(false);
            button006.SetActive(false);
            button007.SetActive(false);
            button008.SetActive(false);
            button009.SetActive(false);
            button010.SetActive(false);
            button011.SetActive(false);
            button012.SetActive(false);
            button013.SetActive(false);
            button014.SetActive(false);
        }

    }
    public void Unit011Set1()
    {
        if (Unit011.activeSelf == true)
        {
            _notice.SUB("이미 선택된 용병 입니다.");
        }
        else if (Unit011.activeSelf == false)
        {
            float randomX = Random.Range(widthmin, widthmax);
            float randomY = Random.Range(heightmin, heighthmax);

            PlayerPrefs.SetInt("Play_Id", 11);
            int id = PlayerPrefs.GetInt("Play_Id");
            string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
            //TextAsset txtAsset = (TextAsset)Resources.Load(path);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(File.ReadAllText(path));
            //Debug.Log(txtAsset.text);
            XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
            XmlNode character = nodes[3];
            character.SelectSingleNode("pickId").InnerText = id.ToString();
            xmlDoc.Save(path);
            Unit011.transform.position = new Vector3(randomX, randomY);
            Unit011.SetActive(true);
            button000.SetActive(false);
            button001.SetActive(false);
            button002.SetActive(false);
            button003.SetActive(false);
            button004.SetActive(false);
            button005.SetActive(false);
            button006.SetActive(false);
            button007.SetActive(false);
            button008.SetActive(false);
            button009.SetActive(false);
            button010.SetActive(false);
            button011.SetActive(false);
            button012.SetActive(false);
            button013.SetActive(false);
            button014.SetActive(false);
        }

    }

    public void Unit012Set1()
    {
        if (Unit012.activeSelf == true)
        {
            _notice.SUB("이미 선택된 용병 입니다.");
        }
        else if (Unit012.activeSelf == false)
        {
            float randomX = Random.Range(widthmin, widthmax);
            float randomY = Random.Range(heightmin, heighthmax);

            PlayerPrefs.SetInt("Play_Id", 12);
            int id = PlayerPrefs.GetInt("Play_Id");
            string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
            //TextAsset txtAsset = (TextAsset)Resources.Load(path);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(File.ReadAllText(path));
            //Debug.Log(txtAsset.text);
            XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
            XmlNode character = nodes[3];
            character.SelectSingleNode("pickId").InnerText = id.ToString();
            xmlDoc.Save(path);
            Unit012.transform.position = new Vector3(randomX, randomY);
            Unit012.SetActive(true);
            button000.SetActive(false);
            button001.SetActive(false);
            button002.SetActive(false);
            button003.SetActive(false);
            button004.SetActive(false);
            button005.SetActive(false);
            button006.SetActive(false);
            button007.SetActive(false);
            button008.SetActive(false);
            button009.SetActive(false);
            button010.SetActive(false);
            button011.SetActive(false);
            button012.SetActive(false);
            button013.SetActive(false);
            button014.SetActive(false);
        }

    }

    public void Unit014Set1()
    {
        if (Unit014.activeSelf == true)
        {
            _notice.SUB("이미 선택된 용병 입니다.");
        }
        else if (Unit014.activeSelf == false)
        {
            float randomX = Random.Range(widthmin, widthmax);
            float randomY = Random.Range(heightmin, heighthmax);

            PlayerPrefs.SetInt("Play_Id", 14);
            int id = PlayerPrefs.GetInt("Play_Id");
            string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
            //TextAsset txtAsset = (TextAsset)Resources.Load(path);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(File.ReadAllText(path));
            //Debug.Log(txtAsset.text);
            XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
            XmlNode character = nodes[3];
            character.SelectSingleNode("pickId").InnerText = id.ToString();
            xmlDoc.Save(path);
            Unit014.transform.position = new Vector3(randomX, randomY);
            Unit014.SetActive(true);
            button000.SetActive(false);
            button001.SetActive(false);
            button002.SetActive(false);
            button003.SetActive(false);
            button004.SetActive(false);
            button005.SetActive(false);
            button006.SetActive(false);
            button007.SetActive(false);
            button008.SetActive(false);
            button009.SetActive(false);
            button010.SetActive(false);
            button011.SetActive(false);
            button012.SetActive(false);
            button013.SetActive(false);
            button014.SetActive(false);
        }

    }

    public void Unit013Set1()
    {
        if (Unit013.activeSelf == true)
        {
            _notice.SUB("이미 선택된 용병 입니다.");
        }
        else if (Unit013.activeSelf == false)
        {
            float randomX = Random.Range(widthmin, widthmax);
            float randomY = Random.Range(heightmin, heighthmax);

            PlayerPrefs.SetInt("Play_Id", 13);
            int id = PlayerPrefs.GetInt("Play_Id");
            string path = Path.Combine(Application.streamingAssetsPath, "PickId.xml");
            //TextAsset txtAsset = (TextAsset)Resources.Load(path);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(File.ReadAllText(path));
            //Debug.Log(txtAsset.text);
            XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
            XmlNode character = nodes[3];
            character.SelectSingleNode("pickId").InnerText = id.ToString();
            xmlDoc.Save(path);
            Unit013.transform.position = new Vector3(randomX, randomY);
            Unit013.SetActive(true);
            button000.SetActive(false);
            button001.SetActive(false);
            button002.SetActive(false);
            button003.SetActive(false);
            button004.SetActive(false);
            button005.SetActive(false);
            button006.SetActive(false);
            button007.SetActive(false);
            button008.SetActive(false);
            button009.SetActive(false);
            button010.SetActive(false);
            button011.SetActive(false);
            button012.SetActive(false);
            button013.SetActive(false);
            button014.SetActive(false);
        }

    }

    public void Close()
    {
        
        


       if(Unit000.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit000.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit001.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit001.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit002.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit002.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit003.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit003.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit004.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit004.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit005.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit005.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit006.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit006.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit007.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit007.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit008.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit008.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit009.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit009.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit010.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit010.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit011.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit011.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit012.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit012.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit013.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit013.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit014.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit014.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }


        StartCoroutine(this.LoadingEnd());

    }

    public void Close1()
    {




        if (Unit000.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit000.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit001.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit001.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit002.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit002.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit003.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit003.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit004.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit004.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit005.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit005.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit006.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit006.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit007.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit007.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit008.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit008.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit009.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit009.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit010.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit010.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit011.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit011.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit012.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit012.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit013.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit013.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }
        if (Unit014.GetComponent<SA_Unit>().gameObject.activeSelf == false)
        {
            Unit014.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.death;
        }


        StartCoroutine(this.LoadingEnd1());

    }

    public void ReSelect()
    {
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
        button05.SetActive(false);
        button06.SetActive(false);
        button07.SetActive(false);
        button08.SetActive(false);
        button09.SetActive(false);
        button10.SetActive(false);
        button11.SetActive(false);
        button12.SetActive(false);
        button13.SetActive(false);
        button14.SetActive(false);
        button00.SetActive(true);
        button01.SetActive(true);
        button02.SetActive(true);
        button03.SetActive(true);
        button04.SetActive(true);
        button000.SetActive(false);
        button001.SetActive(false);
        button002.SetActive(false);
        button003.SetActive(false);
        button004.SetActive(false);
        button005.SetActive(false);
        button006.SetActive(false);
        button007.SetActive(false);
        button008.SetActive(false);
        button009.SetActive(false);
        button010.SetActive(false);
        button011.SetActive(false);
        button012.SetActive(false);
        button013.SetActive(false);
        button014.SetActive(false);
        
        
        introduce3.SetActive(false);
        introduce2.SetActive(false);
        introduce1.SetActive(true);

    }

    public void NextRound()
    {
        pickclose.SetActive(true);
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
        enemy.SetActive(false);
        enemy1.SetActive(false);
        button05.SetActive(false);
        button06.SetActive(false);
        button07.SetActive(false);
        button08.SetActive(false);
        button09.SetActive(false);
        button10.SetActive(false);
        button11.SetActive(false);
        button12.SetActive(false);
        button13.SetActive(false);
        button14.SetActive(false);
        button00.SetActive(true);
        button01.SetActive(true);
        button02.SetActive(true);
        button03.SetActive(true);
        button04.SetActive(true);
        button000.SetActive(false);
        button001.SetActive(false);
        button002.SetActive(false);
        button003.SetActive(false);
        button004.SetActive(false);
        button005.SetActive(false);
        button006.SetActive(false);
        button007.SetActive(false);
        button008.SetActive(false);
        button009.SetActive(false);
        button010.SetActive(false);
        button011.SetActive(false);
        button012.SetActive(false);
        button013.SetActive(false);
        button014.SetActive(false);


        introduce3.SetActive(false);
        introduce2.SetActive(false);
        introduce1.SetActive(true);
        Clear.SetActive(false);
        SkillButton.SetActive(false);
        Skill01.GetComponentInChildren<Button>().interactable = true;
        Skill02.GetComponentInChildren<Button>().interactable = true;
        Skill03.GetComponentInChildren<Button>().interactable = true;
        Skill04.GetComponentInChildren<Button>().interactable = true;
        Skill05.GetComponentInChildren<Button>().interactable = true;
        Skill06.GetComponentInChildren<Button>().interactable = true;
        Skill07.GetComponentInChildren<Button>().interactable = true;
        Skill08.GetComponentInChildren<Button>().interactable = true;
        Unit000.GetComponent<SA_Unit>().Health = Unit000.GetComponent<SA_Unit>()._unitHP;
        Unit001.GetComponent<SA_Unit>().Health = Unit001.GetComponent<SA_Unit>()._unitHP;
        Unit002.GetComponent<SA_Unit>().Health = Unit002.GetComponent<SA_Unit>()._unitHP;
        Unit003.GetComponent<SA_Unit>().Health = Unit003.GetComponent<SA_Unit>()._unitHP;
        Unit004.GetComponent<SA_Unit>().Health = Unit004.GetComponent<SA_Unit>()._unitHP;
        Unit005.GetComponent<SA_Unit>().Health = Unit005.GetComponent<SA_Unit>()._unitHP;
        Unit006.GetComponent<SA_Unit>().Health = Unit006.GetComponent<SA_Unit>()._unitHP;
        Unit007.GetComponent<SA_Unit>().Health = Unit007.GetComponent<SA_Unit>()._unitHP;
        Unit008.GetComponent<SA_Unit>().Health = Unit008.GetComponent<SA_Unit>()._unitHP;
        Unit009.GetComponent<SA_Unit>().Health = Unit009.GetComponent<SA_Unit>()._unitHP;
        Unit010.GetComponent<SA_Unit>().Health = Unit010.GetComponent<SA_Unit>()._unitHP;
        Unit011.GetComponent<SA_Unit>().Health = Unit011.GetComponent<SA_Unit>()._unitHP;
        Unit012.GetComponent<SA_Unit>().Health = Unit012.GetComponent<SA_Unit>()._unitHP;
        Unit013.GetComponent<SA_Unit>().Health = Unit013.GetComponent<SA_Unit>()._unitHP;
        Unit014.GetComponent<SA_Unit>().Health = Unit014.GetComponent<SA_Unit>()._unitHP;
        Unit000.GetComponent<SA_Unit>().Mana = Unit000.GetComponent<SA_Unit>()._unitMP;
        Unit001.GetComponent<SA_Unit>().Mana = Unit001.GetComponent<SA_Unit>()._unitMP;
        Unit002.GetComponent<SA_Unit>().Mana = Unit002.GetComponent<SA_Unit>()._unitMP;
        Unit003.GetComponent<SA_Unit>().Mana = Unit003.GetComponent<SA_Unit>()._unitMP;
        Unit004.GetComponent<SA_Unit>().Mana = Unit004.GetComponent<SA_Unit>()._unitMP;
        Unit005.GetComponent<SA_Unit>().Mana = Unit005.GetComponent<SA_Unit>()._unitMP;
        Unit006.GetComponent<SA_Unit>().Mana = Unit006.GetComponent<SA_Unit>()._unitMP;
        Unit007.GetComponent<SA_Unit>().Mana = Unit007.GetComponent<SA_Unit>()._unitMP;
        Unit008.GetComponent<SA_Unit>().Mana = Unit008.GetComponent<SA_Unit>()._unitMP;
        Unit009.GetComponent<SA_Unit>().Mana = Unit009.GetComponent<SA_Unit>()._unitMP;
        Unit010.GetComponent<SA_Unit>().Mana = Unit010.GetComponent<SA_Unit>()._unitMP;
        Unit011.GetComponent<SA_Unit>().Mana = Unit011.GetComponent<SA_Unit>()._unitMP;
        Unit012.GetComponent<SA_Unit>().Mana = Unit012.GetComponent<SA_Unit>()._unitMP;
        Unit013.GetComponent<SA_Unit>().Mana = Unit013.GetComponent<SA_Unit>()._unitMP;
        Unit014.GetComponent<SA_Unit>().Mana = Unit014.GetComponent<SA_Unit>()._unitMP;
        Unit000.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit001.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit002.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit003.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit004.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit005.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit006.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit007.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit008.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit009.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit010.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit011.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit012.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit013.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit014.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        HealthBar0.GetComponent<Image>().fillAmount = 1;
        HealthBar1.GetComponent<Image>().fillAmount = 1;
        HealthBar2.GetComponent<Image>().fillAmount = 1;
        HealthBar3.GetComponent<Image>().fillAmount = 1;
        HealthBar4.GetComponent<Image>().fillAmount = 1;
        HealthBar5.GetComponent<Image>().fillAmount = 1;
        HealthBar6.GetComponent<Image>().fillAmount = 1;
        HealthBar7.GetComponent<Image>().fillAmount = 1;
        HealthBar8.GetComponent<Image>().fillAmount = 1;
        HealthBar9.GetComponent<Image>().fillAmount = 1;
        HealthBar10.GetComponent<Image>().fillAmount = 1;
        HealthBar11.GetComponent<Image>().fillAmount = 1;
        HealthBar12.GetComponent<Image>().fillAmount = 1;
        HealthBar13.GetComponent<Image>().fillAmount = 1;
        HealthBar14.GetComponent<Image>().fillAmount = 1;
        ManaBar0.GetComponent<Image>().fillAmount = 0;
        ManaBar1.GetComponent<Image>().fillAmount = 0;
        ManaBar2.GetComponent<Image>().fillAmount = 0;
        ManaBar3.GetComponent<Image>().fillAmount = 0;
        ManaBar4.GetComponent<Image>().fillAmount = 0;
        ManaBar5.GetComponent<Image>().fillAmount = 0;
        ManaBar6.GetComponent<Image>().fillAmount = 0;
        ManaBar7.GetComponent<Image>().fillAmount = 0;
        ManaBar8.GetComponent<Image>().fillAmount = 0;
        ManaBar9.GetComponent<Image>().fillAmount = 0;
        ManaBar10.GetComponent<Image>().fillAmount = 0;
        ManaBar11.GetComponent<Image>().fillAmount = 0;
        ManaBar12.GetComponent<Image>().fillAmount = 0;
        ManaBar13.GetComponent<Image>().fillAmount = 0;
        ManaBar14.GetComponent<Image>().fillAmount = 0;

        Monster1.GetComponent<SA_Unit>().Health = Monster1.GetComponent<SA_Unit>()._unitHP;
        Monster2.GetComponent<SA_Unit>().Health = Monster2.GetComponent<SA_Unit>()._unitHP;
        Monster3.GetComponent<SA_Unit>().Health = Monster3.GetComponent<SA_Unit>()._unitHP;
        Monster4.GetComponent<SA_Unit>().Health = Monster4.GetComponent<SA_Unit>()._unitHP;
        Monster5.GetComponent<SA_Unit>().Health = Monster5.GetComponent<SA_Unit>()._unitHP;
        Monster6.GetComponent<SA_Unit>().Health = Monster6.GetComponent<SA_Unit>()._unitHP;
        Monster7.GetComponent<SA_Unit>().Health = Monster7.GetComponent<SA_Unit>()._unitHP;
        Monster8.GetComponent<SA_Unit>().Health = Monster8.GetComponent<SA_Unit>()._unitHP;
        Monster1.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Monster2.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Monster3.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Monster4.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Monster5.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Monster6.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Monster7.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Monster8.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        MonsterHealthBar0.GetComponent<Image>().fillAmount = 1;
        MonsterHealthBar1.GetComponent<Image>().fillAmount = 1;
        MonsterHealthBar2.GetComponent<Image>().fillAmount = 1;
        MonsterHealthBar3.GetComponent<Image>().fillAmount = 1;
        MonsterHealthBar4.GetComponent<Image>().fillAmount = 1;
        MonsterHealthBar5.GetComponent<Image>().fillAmount = 1;
        MonsterHealthBar6.GetComponent<Image>().fillAmount = 1;
        MonsterHealthBar7.GetComponent<Image>().fillAmount = 1;
        //MonsterManaBar0.GetComponent<Image>().fillAmount = 0;
        //MonsterManaBar1.GetComponent<Image>().fillAmount = 0;
        //MonsterManaBar2.GetComponent<Image>().fillAmount = 0;
        //MonsterManaBar3.GetComponent<Image>().fillAmount = 0;



        score += 1;
        Score.text = ""+ score + ":" + score1 ;

        if (score >= 2)
        {
            int coin = PlayerPrefs.GetInt("coin", 0);
            int stage = PlayerPrefs.GetInt("SStage");
            if (stage <= 0)
            {
                stage += 1;
                coin += 1000;
                Win.SetActive(true);
            }
            else
            {
                coin += 100;
                Win1.SetActive(true);
            }
            int stage1 = PlayerPrefs.GetInt("Small_Stage");

            if(stage1 == 1)
            { 
                if (stage == 1)
                {
                    stage += 1;
                    coin += 1000;
                    Win.SetActive(true);
                }
            }

            PlayerPrefs.SetInt("SStage", stage);
            
            
            PlayerPrefs.SetInt("coin", coin);

            
            pickclose.SetActive(false);
        }
    }
    // Update is called once per frame
    public void falseRound()
    {
        pickclose.SetActive(true);
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
        enemy.SetActive(false);
        enemy1.SetActive(false);
        button05.SetActive(false);
        button06.SetActive(false);
        button07.SetActive(false);
        button08.SetActive(false);
        button09.SetActive(false);
        button10.SetActive(false);
        button11.SetActive(false);
        button12.SetActive(false);
        button13.SetActive(false);
        button14.SetActive(false);
        button00.SetActive(true);
        button01.SetActive(true);
        button02.SetActive(true);
        button03.SetActive(true);
        button04.SetActive(true);
        button000.SetActive(false);
        button001.SetActive(false);
        button002.SetActive(false);
        button003.SetActive(false);
        button004.SetActive(false);
        button005.SetActive(false);
        button006.SetActive(false);
        button007.SetActive(false);
        button008.SetActive(false);
        button009.SetActive(false);
        button010.SetActive(false);
        button011.SetActive(false);
        button012.SetActive(false);
        button013.SetActive(false);
        button014.SetActive(false);

        SkillButton.SetActive(false);
        introduce3.SetActive(false);
        introduce2.SetActive(false);
        introduce1.SetActive(true);
        Over.SetActive(false);

        Unit000.GetComponent<SA_Unit>().Health = Unit000.GetComponent<SA_Unit>()._unitHP;
        Unit001.GetComponent<SA_Unit>().Health = Unit001.GetComponent<SA_Unit>()._unitHP;
        Unit002.GetComponent<SA_Unit>().Health = Unit002.GetComponent<SA_Unit>()._unitHP;
        Unit003.GetComponent<SA_Unit>().Health = Unit003.GetComponent<SA_Unit>()._unitHP;
        Unit004.GetComponent<SA_Unit>().Health = Unit004.GetComponent<SA_Unit>()._unitHP;
        Unit005.GetComponent<SA_Unit>().Health = Unit005.GetComponent<SA_Unit>()._unitHP;
        Unit006.GetComponent<SA_Unit>().Health = Unit006.GetComponent<SA_Unit>()._unitHP;
        Unit007.GetComponent<SA_Unit>().Health = Unit007.GetComponent<SA_Unit>()._unitHP;
        Unit008.GetComponent<SA_Unit>().Health = Unit008.GetComponent<SA_Unit>()._unitHP;
        Unit009.GetComponent<SA_Unit>().Health = Unit009.GetComponent<SA_Unit>()._unitHP;
        Unit010.GetComponent<SA_Unit>().Health = Unit010.GetComponent<SA_Unit>()._unitHP;
        Unit011.GetComponent<SA_Unit>().Health = Unit011.GetComponent<SA_Unit>()._unitHP;
        Unit012.GetComponent<SA_Unit>().Health = Unit012.GetComponent<SA_Unit>()._unitHP;
        Unit013.GetComponent<SA_Unit>().Health = Unit013.GetComponent<SA_Unit>()._unitHP;
        Unit014.GetComponent<SA_Unit>().Health = Unit014.GetComponent<SA_Unit>()._unitHP;
        Unit000.GetComponent<SA_Unit>().Mana = Unit000.GetComponent<SA_Unit>()._unitMP;
        Unit001.GetComponent<SA_Unit>().Mana = Unit001.GetComponent<SA_Unit>()._unitMP;
        Unit002.GetComponent<SA_Unit>().Mana = Unit002.GetComponent<SA_Unit>()._unitMP;
        Unit003.GetComponent<SA_Unit>().Mana = Unit003.GetComponent<SA_Unit>()._unitMP;
        Unit004.GetComponent<SA_Unit>().Mana = Unit004.GetComponent<SA_Unit>()._unitMP;
        Unit005.GetComponent<SA_Unit>().Mana = Unit005.GetComponent<SA_Unit>()._unitMP;
        Unit006.GetComponent<SA_Unit>().Mana = Unit006.GetComponent<SA_Unit>()._unitMP;
        Unit007.GetComponent<SA_Unit>().Mana = Unit007.GetComponent<SA_Unit>()._unitMP;
        Unit008.GetComponent<SA_Unit>().Mana = Unit008.GetComponent<SA_Unit>()._unitMP;
        Unit009.GetComponent<SA_Unit>().Mana = Unit009.GetComponent<SA_Unit>()._unitMP;
        Unit010.GetComponent<SA_Unit>().Mana = Unit010.GetComponent<SA_Unit>()._unitMP;
        Unit011.GetComponent<SA_Unit>().Mana = Unit011.GetComponent<SA_Unit>()._unitMP;
        Unit012.GetComponent<SA_Unit>().Mana = Unit012.GetComponent<SA_Unit>()._unitMP;
        Unit013.GetComponent<SA_Unit>().Mana = Unit013.GetComponent<SA_Unit>()._unitMP;
        Unit014.GetComponent<SA_Unit>().Mana = Unit014.GetComponent<SA_Unit>()._unitMP;
        Unit000.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit001.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit002.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit003.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit004.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit005.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit006.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit007.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit008.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit009.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit010.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit011.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit012.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit013.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Unit014.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        HealthBar0.GetComponent<Image>().fillAmount = 1;
        HealthBar1.GetComponent<Image>().fillAmount = 1;
        HealthBar2.GetComponent<Image>().fillAmount = 1;
        HealthBar3.GetComponent<Image>().fillAmount = 1;
        HealthBar4.GetComponent<Image>().fillAmount = 1;
        HealthBar5.GetComponent<Image>().fillAmount = 1;
        HealthBar6.GetComponent<Image>().fillAmount = 1;
        HealthBar7.GetComponent<Image>().fillAmount = 1;
        HealthBar8.GetComponent<Image>().fillAmount = 1;
        HealthBar9.GetComponent<Image>().fillAmount = 1;
        HealthBar10.GetComponent<Image>().fillAmount = 1;
        HealthBar11.GetComponent<Image>().fillAmount = 1;
        HealthBar12.GetComponent<Image>().fillAmount = 1;
        HealthBar13.GetComponent<Image>().fillAmount = 1;
        HealthBar14.GetComponent<Image>().fillAmount = 1;
        ManaBar0.GetComponent<Image>().fillAmount = 0;
        ManaBar1.GetComponent<Image>().fillAmount = 0;
        ManaBar2.GetComponent<Image>().fillAmount = 0;
        ManaBar3.GetComponent<Image>().fillAmount = 0;
        ManaBar4.GetComponent<Image>().fillAmount = 0;
        ManaBar5.GetComponent<Image>().fillAmount = 0;
        ManaBar6.GetComponent<Image>().fillAmount = 0;
        ManaBar7.GetComponent<Image>().fillAmount = 0;
        ManaBar8.GetComponent<Image>().fillAmount = 0;
        ManaBar9.GetComponent<Image>().fillAmount = 0;
        ManaBar10.GetComponent<Image>().fillAmount = 0;
        ManaBar11.GetComponent<Image>().fillAmount = 0;
        ManaBar12.GetComponent<Image>().fillAmount = 0;
        ManaBar13.GetComponent<Image>().fillAmount = 0;
        ManaBar14.GetComponent<Image>().fillAmount = 0;

        Monster1.GetComponent<SA_Unit>().Health = Monster1.GetComponent<SA_Unit>()._unitHP;
        Monster2.GetComponent<SA_Unit>().Health = Monster2.GetComponent<SA_Unit>()._unitHP;
        Monster3.GetComponent<SA_Unit>().Health = Monster3.GetComponent<SA_Unit>()._unitHP;
        Monster4.GetComponent<SA_Unit>().Health = Monster4.GetComponent<SA_Unit>()._unitHP;
        Monster5.GetComponent<SA_Unit>().Health = Monster5.GetComponent<SA_Unit>()._unitHP;
        Monster6.GetComponent<SA_Unit>().Health = Monster6.GetComponent<SA_Unit>()._unitHP;
        Monster7.GetComponent<SA_Unit>().Health = Monster7.GetComponent<SA_Unit>()._unitHP;
        Monster8.GetComponent<SA_Unit>().Health = Monster8.GetComponent<SA_Unit>()._unitHP;
        Monster1.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Monster2.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Monster3.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Monster4.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Monster5.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Monster6.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Monster7.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        Monster8.GetComponent<SA_Unit>()._unitState = SA_Unit.UnitState.idle;
        MonsterHealthBar0.GetComponent<Image>().fillAmount = 1;
        MonsterHealthBar1.GetComponent<Image>().fillAmount = 1;
        MonsterHealthBar2.GetComponent<Image>().fillAmount = 1;
        MonsterHealthBar3.GetComponent<Image>().fillAmount = 1;
        MonsterHealthBar4.GetComponent<Image>().fillAmount = 1;
        MonsterHealthBar5.GetComponent<Image>().fillAmount = 1;
        MonsterHealthBar6.GetComponent<Image>().fillAmount = 1;
        MonsterHealthBar7.GetComponent<Image>().fillAmount = 1;
        //MonsterManaBar0.GetComponent<Image>().fillAmount = 0;
        //MonsterManaBar1.GetComponent<Image>().fillAmount = 0;
        //MonsterManaBar2.GetComponent<Image>().fillAmount = 0;
        //MonsterManaBar3.GetComponent<Image>().fillAmount = 0;

        score1 += 1;
        Score.text = score + ":" + score1;

        if (score1 >= 2)
        {
            defeat.SetActive(true);
            pickclose.SetActive(false);
        }
    }




    IEnumerator LoadingEnd()
    {
        Num_A.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        Num_A.SetActive(false);
        Num_B.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        Num_B.SetActive(false);
        Num_C.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        Num_C.SetActive(false);
        Num_GO.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        Num_GO.SetActive(false);
        pickclose.SetActive(false);
        enemy.SetActive(true);
        SkillButton.SetActive(true);
    }

    IEnumerator LoadingEnd1()
    {
        Num_A.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        Num_A.SetActive(false);
        Num_B.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        Num_B.SetActive(false);
        Num_C.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        Num_C.SetActive(false);
        Num_GO.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        Num_GO.SetActive(false);
        pickclose.SetActive(false);
        enemy1.SetActive(true);
        SkillButton.SetActive(true);
    }
}
