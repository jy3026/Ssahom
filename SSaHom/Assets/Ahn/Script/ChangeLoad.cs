using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using LitJson;

public class ChangeLoad : MonoBehaviour
{
    public Sprite Image0;
    public Sprite Image1;
    public Sprite Image2;
    public Sprite Image3;
    public Sprite Image4;
    public TextAsset dataToolTipList;
    public GameObject changeLoad;
    public Text text0;
    public Text textTip1;
    public Image L_Image0, L_Image1, L_Image2, L_Image3, L_Image4;

    // Start is called before the first frame update
    void Start()
    {
        StageLoadUI();
    }
    void Awake()
    {
        changeLoad = GameObject.Find("ChangeLoad");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void StageLoadUI()
    {
        int id = PlayerPrefs.GetInt("Stage");
        if ((int)id / 5 == 0)
        {
            Debug.Log(id);
            text0.text = "�� �� ��";
            L_Image0.sprite = Image0;
            if (PlayerPrefs.GetInt("Small_Stage") == 0)
            {
                textTip1.text = "���� : �溹���� ����4��(1395��)�� â�ǵǾ����!";
            }
            if (PlayerPrefs.GetInt("Small_Stage") == 1)
            {
                textTip1.text = "���� : �溹�� �հ� �鼺���� ū ���� �����⸦ ����Ѵٴ� �ǹ̿���!";
            }
            if (PlayerPrefs.GetInt("Small_Stage") == 2)
            {
                textTip1.text = "���� : �溹���� ���� �����⿡ �ѼյǾ� ���� ��������� �������̿���!";
            }
            if (PlayerPrefs.GetInt("Small_Stage") == 3)
            {
                textTip1.text = "���� : ����� 1-2";
            }
            if (PlayerPrefs.GetInt("Small_Stage") == 4)
            {
                textTip1.text = "���� : ����� 1-2";
            }
        }
        else if ((int)id / 5 == 1)
        {
            Debug.Log(id);
            L_Image0.sprite = Image1;
            text0.text = "â �� ��";
            if (PlayerPrefs.GetInt("Small_Stage") == 0)
            {
                textTip1.text = "���� : â����� ���� ����(1483��) ���� ����Ǿ����!";
            }
            if (PlayerPrefs.GetInt("Small_Stage") == 1)
            {
                textTip1.text = "���� : â����� ��������� ����� ������ ��ñ� ���Ͽ� ���������!";
            }
            if (PlayerPrefs.GetInt("Small_Stage") == 2)
            {
                textTip1.text = "���� : â����� ���� �������̶�� �ҷȾ��!";
            }
            if (PlayerPrefs.GetInt("Small_Stage") == 3)
            {
                textTip1.text = "���� : ������ �絵���ڸ� ���ֿ� ���ξ� ���� ���� �ٷ� â����̿���.";
            }

            if (PlayerPrefs.GetInt("Small_Stage") == 4)
            {
                textTip1.text = "���� : ����� 1-2";
            }
        }
        else if ((int)id / 5 == 2)
        {
            PlayerPrefs.GetInt("Stage");
            L_Image0.sprite = Image2;
            text0.text = "â �� ��";
        }
        else
        {
            PlayerPrefs.GetInt("Stage");
            L_Image0.sprite = Image3;
            text0.text = "�� ��";
        }

    }
}
