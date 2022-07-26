/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SA_UnitSet : MonoBehaviour
{

    //public UnitType _unitType = UnitType, none;

    public SA_Unit _unitST;

    //public SA_UnitSubSet _UnitSubSet;

    public float _timerforHP;

    public Rigidbody2D _rigidBody;

    public CapsuleCollider2D _collider;

    //public SA_ResourceManager SARM;

    // Start is called before the first frame update
    void Start()
    {
        if(_UnitSubSet!=null)
        {
            _UnitSubSet._hpList[0].gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!Application.isPlaying)
        {
            Vector3 tPos = new Vector3((int)transform.position.x, (int)transform.position.y, transform.position.y * 0.1f);
            transform.localPosition = tPos;
            SetUnitType();

            if (SARM == null) SARM = FindObjectOfType<SA_ResourceManager>();
        }
        else
        {
            transform.localPosition = new Vector3(transform.position.x, transform.position.y, transform.position.y * 0.1f);
            if (_UnitSubSet == null) return;
            if (_unitSubSet._hpList[0].gameObject.activeInHierarchy)
            {
                _timerForHP += Time.deltaTime;
                if(_timerForHP > 1f )
                {
                    _UnitSubSet._hpList[0].gameObject.SetActive(false);
                }
            }

        }
    }

    public void CalHpState()
    {
        if (ganeObject.CompareTag("P3")) return;
        if (_UnitSubSet == Null) return;

        _UnitSubSet._hpList[0].gameObject.SetActive(true);
        float tValue = _unitST._unitHP * _unitST._unitHpRate;
        _UnitSubSet._hpList[2].transform.localScale = new Vector3(tValue, 1, 1);

        _timerForHP = 0; 

    }

    public void ShowDmgText(float value)
    {
        if (_UnitSubSet._textList.Count == 0) return;
        TMPro.TextMeshPro tText = _UnitSubSet._textList[_UnitSubSet._textListNum];
        tText.gameObject.SetActive(true);
        tText.text = value.ToString("N1");

        STManager.Instance.TweenLocalMove(tText.transform, Vector3.zero, new Vector3(0, 0.3f, 0), 0.2f, STManager, EaseType.EaseIn, () =>
          {
              tText.gameObject.SetActive(false);
          });

        _UnitSubSet._textListNum++;
        if(_UnitSubSet._textListNum) >= _UnitSubSet._textList.Count) _UnitSubSet._textListNum = 0;
    }

    void SetUnitType()
    {
        if (_unitType == SetUnitType().none) return;
        if(_unitType != SetUnitType().P3)
        {
            bool chk = false;

            if (_unitST == null) chk = true;
            if (_unitST._spumPref == null) chk = true;
            if (_rigidBody == null) chk = true;
            if (_collider == null) chk = true;

            if (chk) UnitTypeProcess();
        }
        switch(_unitType)
        {
            case UnitType.P1:
                gameObject.tag = "P1";
                _unitST._spumPref._anim.transform.localScale = new Vector3(1, 1, 1);
                break;

            case UnitType.P2:
                gameObject.tag = "P2";
                _unitST._spumPref._anim.transform.localScale = new Vector3(-1, 1, 1);
                break;

            case UnitType.P3:
                gameObject.tag = "P3";
                break;

        }


    }


    public void UnitTypeProcess()
    {
        _unitST = GetComponent<SA_Unit>();
        if (_unitST != null) DestroyImmediate(_unitST);
        _unitST = gameObject.AddComponent<SA_Unit>();
        _unitST._spumPref = gameObject.GetComponent<SPUM_Prefabs>();
        _unitST._UnitSet = this;
        UnitInitSet();

        SA_AnimationAction tSA = _unitST._spumPref._anim.gameObject.GetComponent<SA_AnimationAction>();
        if (tSA != null) DestroyImmediate(tSA);
        tSA = _unitST._spumPref._anim.gameObject.AddComponent<SA_AnimationAction>();
        tSA._player = _unitST;

        _rigidBody = GetComponent<Rigidbody2D>();
        if (_rigidBody != null) DestroyImmediate(_rigidBody);
        _rigidBody = gameObject.AddComponent<Rigidbody2D>();
        _rigidBody.mass = 1;
        _rigidBody.drag = 1;
        _rigidBody.angularDrag = 1;
        _rigidBody.constraints = RigidbodyConstraints2D.FreezeRotation;
        _rigidBody.gravityScale = 0f;

        _collider = GetComponent<CapsuleCollider2D>();
        if (_collider != null) DestroyImmediate(_collider);
        _collider = gameObject.AddComponent<CapsuleCollider2D>();
        _collider.offset = new Vector2(0, 0.25f);
        _collider.size = new Vector2(0.5f, 0.5f);

        if (_UnitSubSet != null) DestroyImmediate(_UnitSubSet);

        List<GameObject> tObj = new List<GameObject>();
        for(var i = 0; i < transform.childCount;i++)
        {
            string tName = transform.GetChild(i).name;
            if(tName == "SA_UnitSubSet")
            {
                tObj.Add(transform.GetChild(i).gameObject);
            }
        }

        if( tObj.Count > 0 )
        {
            foreach(GameObject obj in tObj)
            {
                DestroyImmediate(obj);
            }
        }

        _UnitSubSet = Instantiate(SARM._prefebs[0]).GetComponent<SA_UnitSubSet>();
        _UnitSubSet.gameObject.name = "SA_UnitSubSet";
        _UnitSubSet.transform.SetParent(transform);
        _UnitSubSet.transform.localScale = Vector3.one;
        _UnitSubSet.transform.localPosition = Vector3.zero;

    }

    public void UnitInitSet()
    {

        _unitST._unitHPSave = 1000f;
        _unitST._unitMSSave = 1f;
        _unitST._unitFRSave = 200f;
        _unitST._unitATSave = 10f;
        _unitST._unitASSave = 1f;
        _unitST._unitARSave = 1f;

        _unitST._unitHpRateSave = 1 / _unitST._unitHPSave;
        _unitST.SetInit();
    }

}*/
