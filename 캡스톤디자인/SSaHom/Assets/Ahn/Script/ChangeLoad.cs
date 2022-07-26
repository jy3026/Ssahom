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
            text0.text = "경 복 궁";
            L_Image0.sprite = Image0;
            if (PlayerPrefs.GetInt("Small_Stage") == 0)
            {
                textTip1.text = "정보 : 경복궁은 태조4년(1395년)에 창건되었어요!";
            }
            if (PlayerPrefs.GetInt("Small_Stage") == 1)
            {
                textTip1.text = "정보 : 경복은 왕과 백성들이 큰 복을 누리기를 축원한다는 의미에요!";
            }
            if (PlayerPrefs.GetInt("Small_Stage") == 2)
            {
                textTip1.text = "정보 : 경복궁은 일제 강점기에 훼손되어 현재 복원사업이 진행중이에요!";
            }
            if (PlayerPrefs.GetInt("Small_Stage") == 3)
            {
                textTip1.text = "정보 : 블라블라 1-2";
            }
            if (PlayerPrefs.GetInt("Small_Stage") == 4)
            {
                textTip1.text = "정보 : 블라블라 1-2";
            }
        }
        else if ((int)id / 5 == 1)
        {
            Debug.Log(id);
            L_Image0.sprite = Image1;
            text0.text = "창 경 궁";
            if (PlayerPrefs.GetInt("Small_Stage") == 0)
            {
                textTip1.text = "정보 : 창경궁은 조선 성종(1483년) 때에 건축되었어요!";
            }
            if (PlayerPrefs.GetInt("Small_Stage") == 1)
            {
                textTip1.text = "정보 : 창경궁은 세종대왕이 상왕인 태종을 모시기 위하여 지어졌어요!";
            }
            if (PlayerPrefs.GetInt("Small_Stage") == 2)
            {
                textTip1.text = "정보 : 창경궁의 원래 수강궁이라고 불렸어요!";
            }
            if (PlayerPrefs.GetInt("Small_Stage") == 3)
            {
                textTip1.text = "정보 : 영조가 사도세자를 뒤주에 가두어 죽인 곳이 바로 창경궁이에요.";
            }

            if (PlayerPrefs.GetInt("Small_Stage") == 4)
            {
                textTip1.text = "정보 : 블라블라 1-2";
            }
        }
        else if ((int)id / 5 == 2)
        {
            PlayerPrefs.GetInt("Stage");
            L_Image0.sprite = Image2;
            text0.text = "창 덕 궁";
        }
        else
        {
            PlayerPrefs.GetInt("Stage");
            L_Image0.sprite = Image3;
            text0.text = "종 묘";
        }

    }
}
