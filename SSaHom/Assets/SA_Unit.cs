using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using LitJson;
using System.Xml;
using System.IO;
using System.Text;


public class SA_Unit : MonoBehaviour
{
    int AD;
    int AP;
    int HP;
    int MP;
    public SPUM_Prefabs _spumPref;


    public enum UnitState
    {

        idle,

        run,

        attack,

        stun,

        skill,

        death

    }

    public UnitState _unitState = UnitState.idle;

    public SA_Unit _target;

    public float _unitHP;

    public float _unitMS;

    public float _unitFR;

    public float _unitAT;

    public float _unitAP;

    public float _unitAS;

    public float _unitAR;

    public float _unitMP;

    public Vector2 _tempDis;

    public Vector2 _dirVec;

    public float _findTimer;

    public float _attackTimer;


    public GameObject DamageText;
    public GameObject TextPos;

    public GameObject HealthBar;
    public GameObject BackgroundHealthBar;
    public GameObject ManaBar;
    public GameObject BackgroundManaBar;
    public float Health;
    public float Mana;

    public GameObject Effect;
    public GameObject Unit0;
    public GameObject Unit1;
    public GameObject Unit2;
    public GameObject Unit3;
    public GameObject Unit4;
    public GameObject Unit5;
    public GameObject Unit6;
    public GameObject Unit7;
    public GameObject Unit8;
    public GameObject Unit9;
    public GameObject Unit10;
    public GameObject Unit11;
    public GameObject Unit12;
    public GameObject Unit13;
    public GameObject Unit14;

    [SerializeField]
    private GameObject arrow;

    float FirstAt;
    float FirstAS;
    float FirstAt1;
    float AfterAt;
    float AfterAS;
    float AfterAt1;

    public AudioSource mySfx;

    public AudioClip AttackSfx;

    GameObject enemy;
    GameObject enemy1;

    public int a;
    //public AudioClip WalkSfx;
    // Start is called before the first frame update
    void Start()
    {

        LoadStatInfo();
        this.enemy = GameObject.Find("P2");
        this.enemy1 = GameObject.Find("P3");
    }

    // Update is called once per frame
    void Update()
    {
        CheckState();
        a = PlayerPrefs.GetInt("Small_Stage");
    }

    void SetInitState()
    {
        _unitState = UnitState.idle;
    }

    void CheckState()
    {
        switch (_unitState)
        {
            case UnitState.idle:
                FindTarget();
                break;

            case UnitState.run:
                FindTarget();
                DoMove();
                break;
            case UnitState.attack:
                CheckAttack();
                break;

            case UnitState.stun:
                break;
            case UnitState.skill:
                break;
            case UnitState.death:
                break;
        }
    }

    void SetState(UnitState state)
    {
        _unitState = state;
        switch (_unitState)
        {
            case UnitState.idle:
                _spumPref.PlayAnimation("0_idle");
                break;
            case UnitState.run:
                _spumPref.PlayAnimation("1_Run");
                break;
            case UnitState.attack:
                _attackTimer += Time.deltaTime;
                if (_attackTimer > _unitAS)
                {
                    DoAttack();
                    _attackTimer = 0;
                }
                break;

            case UnitState.stun:
                _spumPref.PlayAnimation("3_Debuff_Stun");
                StartCoroutine(Stun());
                break;
            case UnitState.skill:
                _spumPref.PlayAnimation("5_Skill_Normal");
                break;
            case UnitState.death:
                _spumPref.PlayAnimation("4_Death");
                break;
        }
    }



    void FindTarget()
    {
        _findTimer += Time.deltaTime;
        if (_findTimer > SoonsoonData.Instance.SAM._findTimer)
        {
            _target = SoonsoonData.Instance.SAM.GetTarget(this);
            if (_target != null) SetState(UnitState.run);
            else SetState(UnitState.idle);
            _findTimer = 0;
        }

    }

    void DoMove()
    {
        if (!CheckTarget()) return;
        CheckDistance();

        WalkSound();
        _dirVec = _tempDis.normalized;
        SetDirection();
        transform.position += (Vector3)_dirVec * _unitMS * Time.deltaTime;

    }

    bool CheckDistance() //공격범위 내에 적이 안들어오면 타겟에게 다가가는 코드
    {

        _tempDis = (Vector3)(_target.transform.localPosition - transform.position);

        float tDis = _tempDis.sqrMagnitude;

        if (tDis <= _unitAR * _unitAR)
        {

            SetState(UnitState.attack); //얘 왜 자꾸 무한반복?

            return true;

        }
        else
        {
            if (!CheckTarget()) SetState(UnitState.idle);
            else SetState(UnitState.run);

            return false;
        }
    }

    void CheckAttack()
    {
        if (!CheckTarget())
        {
            SetState(UnitState.idle);
            return;
        }
        if (!CheckDistance()) return; //여기서 체크디스펜스로 넘어가면 attack부분무한반복

        _attackTimer += Time.deltaTime;
        if (_attackTimer > _unitAS)
        {
            DoAttack();
            _attackTimer = 0;
        }
    }

    void DoAttack()
    {
        _spumPref.PlayAnimation("2_Attack_Normal");

        _target.GetComponent<SA_Unit>().GetDamage(_unitAT);

        GetMana();
        AttackSound();
        if (arrow != null) { 
            CastSpell();
        }
    }

    void SetDirection()
    {
        if (_dirVec.x >= 0)
        {
            _spumPref._anim.transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            _spumPref._anim.transform.localScale = new Vector3(1, 1, 1);
        }
    }

    bool CheckTarget()
    {
        bool value = true;
        if (_target == null) return false;
        if (_target._unitState == UnitState.death) return false;
        if (!_target.gameObject.activeInHierarchy) return false;
        if (!value)
        {
            SetState(UnitState.idle);
        }

        return value;
        /*if (_target == null) return false;
        if (_target._unitState == UnitState.death) return false;
        if (_target.gameObject == null) return false;
        if (!_target.gameObject.activeInHierarchy) return false;

        SetState(UnitState.idle);
        return true;*/

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tTag = "";
        switch (gameObject.tag)
        {
            case "P1":
                if (a == 0)
                {
                    tTag = "P2";
                }
                else if (a == 1)
                {
                    tTag = "P3";
                }
                //tTag = "P3";
                break;

            case "P2": tTag = "P1";
                break;

            case "P3":
                tTag = "P1";
                break;
        }

        if (collision.gameObject.CompareTag(tTag))
        {
            Debug.Log("with Target");
        }
        else if (collision.gameObject.CompareTag(gameObject.tag))
        {
            Debug.Log("Stop");
            SetState(UnitState.idle);
        }
    }

    public void GetDamage(float damage)
    {
        GameObject dmgText = Instantiate(DamageText, TextPos.transform.position, Quaternion.identity);
        dmgText.GetComponent<Text>().text = damage.ToString();
        Health -= damage;
        HealthBar.GetComponent<Image>().fillAmount = Health / _unitHP;


        if (HealthBar.GetComponent<Image>().fillAmount <= 0)
        {
            HealthBar.GetComponent<Image>().fillAmount = 0;
            SetDeath();
        }
        Destroy(dmgText, 0.1f);
    }

    public void GetMana()
    {
        Mana = ((_unitMP * 10) / 100);
        ManaBar.GetComponent<Image>().fillAmount += (Mana / 10);

        if (ManaBar.GetComponent<Image>().fillAmount >= 1)
        {
            ManaBar.GetComponent<Image>().fillAmount = 0;
            SetSkill();
        }
    }

    public void SetDeath()
    {
        //Destroy(HealthBar);
        //Destroy(BackgroundHealthBar);
        //Destroy(ManaBar);
        //Destroy(BackgroundManaBar);
        Destroy(gameObject.GetComponent<Rigidbody2D>());
        Destroy(gameObject.GetComponent<CapsuleCollider2D>());
        SetState(UnitState.death);

    }

    public void SetSkill()
    {
        if(Unit0 != null)
        {
            Vector3 a = new Vector3(0, 0.5f , 0);
            Instantiate(Effect,_target.transform.position +a , Quaternion.identity);
            _target.GetComponent<SA_Unit>().GetDamage(_unitAT*2);
        }
        if (Unit1 != null)
        {
            Vector3 a = new Vector3(0, 0.5f, 0);
            Instantiate(Effect, _target.transform.position +a, Quaternion.identity);
            _target.GetComponent<SA_Unit>().GetDamage(_unitAT * 2);
        }
        if (Unit2 != null)
        {
            Vector3 a = new Vector3(0.2f, 0.5f, 0);
            Instantiate(Effect, this.transform.position + a, Quaternion.identity);
            FirstAt = _unitAT;
            _unitAT = _unitAT * 2;
            StartCoroutine(Upat());
        }
        if (Unit3 != null)
        {
            Vector3 a = new Vector3(0, 1, 0);
            Instantiate(Effect, _target.transform.position + a, Quaternion.identity);
            _target.GetComponent<SA_Unit>().GetDamage(_unitAT * 2);
        }
        if (Unit4 != null)
        {
            Vector3 a = new Vector3(0, 2, 0);
            Instantiate(Effect, _target.transform.position + a, Quaternion.identity);
            _target.GetComponent<SA_Unit>().GetDamage(_unitAT * 2);
        }
        if (Unit5 != null)
        {
            Vector3 a = new Vector3(0, 0.5f, 0);
            Instantiate(Effect, this.transform.position + a, Quaternion.identity);
            Health += _unitAP * 3;

        }
        if (Unit6 != null)
        {
            Vector3 a = new Vector3(0, 1, 0);
            Instantiate(Effect, this.transform.position + a, Quaternion.identity);
            _target.SetState(UnitState.stun);
        }
        if (Unit7 != null)
        {
            Vector3 a = new Vector3(0, 0.6f, 0);
            Instantiate(Effect, this.transform.position+ a, Quaternion.identity);
            _target.GetComponent<SA_Unit>().GetDamage((_unitHP - Health) / 10);

        }
        if (Unit8 != null)
        {
            Vector3 a = new Vector3(0, 0.5f, 0);
            Instantiate(Effect, _target.transform.position+a, Quaternion.identity);
            _target.GetComponent<SA_Unit>().GetDamage(50);
            AfterAt = _target._unitAT;
            _target._unitAT = _target._unitAT / 2;
            StartCoroutine(Afat());
        }
        if (Unit9 != null)
        {
            Vector3 a = new Vector3(0, 1.2f , 0);
            Instantiate(Effect, this.transform.position+a, Quaternion.identity);
            _target.GetComponent<SA_Unit>().GetDamage(_unitAP * 2);

        }
        if (Unit10 != null)
        {
            Vector3 a = new Vector3(0, 1, 0);
            Instantiate(Effect, Unit10.transform.position + a, Quaternion.identity);
            GameObject.Find("Unit000").GetComponent<SA_Unit>().Health += Unit10.GetComponent<SA_Unit>()._unitMP * 10;
            GameObject.Find("Unit001").GetComponent<SA_Unit>().Health += Unit10.GetComponent<SA_Unit>()._unitMP * 10;
            GameObject.Find("Unit002").GetComponent<SA_Unit>().Health += Unit10.GetComponent<SA_Unit>()._unitMP * 10;
            GameObject.Find("Unit003").GetComponent<SA_Unit>().Health += Unit10.GetComponent<SA_Unit>()._unitMP * 10;
            GameObject.Find("Unit004").GetComponent<SA_Unit>().Health += Unit10.GetComponent<SA_Unit>()._unitMP * 10;
            GameObject.Find("Unit005").GetComponent<SA_Unit>().Health += Unit10.GetComponent<SA_Unit>()._unitMP * 10;
            GameObject.Find("Unit006").GetComponent<SA_Unit>().Health += Unit10.GetComponent<SA_Unit>()._unitMP * 10;
            GameObject.Find("Unit007").GetComponent<SA_Unit>().Health += Unit10.GetComponent<SA_Unit>()._unitMP * 10;
            GameObject.Find("Unit008").GetComponent<SA_Unit>().Health += Unit10.GetComponent<SA_Unit>()._unitMP * 10;
            GameObject.Find("Unit009").GetComponent<SA_Unit>().Health += Unit10.GetComponent<SA_Unit>()._unitMP * 10;
            GameObject.Find("Unit0010").GetComponent<SA_Unit>().Health += Unit10.GetComponent<SA_Unit>()._unitMP * 10;
            GameObject.Find("Unit0011").GetComponent<SA_Unit>().Health += Unit10.GetComponent<SA_Unit>()._unitMP * 10;
            GameObject.Find("Unit0012").GetComponent<SA_Unit>().Health += Unit10.GetComponent<SA_Unit>()._unitMP * 10;
            GameObject.Find("Unit0013").GetComponent<SA_Unit>().Health += Unit10.GetComponent<SA_Unit>()._unitMP * 10;
            GameObject.Find("Unit0014").GetComponent<SA_Unit>().Health += Unit10.GetComponent<SA_Unit>()._unitMP * 10;

        }
        if (Unit11 != null)
        {
            Vector3 a = new Vector3(0, 1, 0);
            Instantiate(Effect, _target.transform.position +a, Quaternion.identity);
            _target.GetComponent<SA_Unit>().GetDamage(_unitAP * 3);
        }
        if (Unit12 != null)
        {
            Vector3 a = new Vector3(0, 1, 0);
            Instantiate(Effect, _target.transform.position +a, Quaternion.identity);
            FirstAt1 = _unitAT;
            _unitAT = _unitAT + 10;
            StartCoroutine(Afat1());
        }
        if (Unit13 != null)
        {
            Vector3 a = new Vector3(0, 2, 0);
            Instantiate(Effect, this.transform.position+a, Quaternion.identity);
            FirstAS = _unitAS;
            _unitAS = _unitAS / 2;
            StartCoroutine(ASUp());
        }
        if (Unit14 != null)
        {
            Vector3 a = new Vector3(0, 1, 0);
            Instantiate(Effect, _target.transform.position+a, Quaternion.identity);
            AfterAS = _target._unitAS;
            _target._unitAS = _target._unitAS * 2;
            StartCoroutine(ASdown());
        }

    }

    IEnumerator Upat()
    {
        yield return new WaitForSeconds(2.0f);
        _unitAT = FirstAt;
    }
    IEnumerator Afat()
    {
        yield return new WaitForSeconds(2.0f);
        _target._unitAT = AfterAt;
    }
    IEnumerator Afat1()
    {
        yield return new WaitForSeconds(2.0f);
        _target._unitAT = AfterAt1;
    }

    IEnumerator ASdown()
    {
        yield return new WaitForSeconds(1.0f);
        _target._unitAS = AfterAS;
    }

    IEnumerator ASUp()
    {
        yield return new WaitForSeconds(0.5f);
        _unitAS = FirstAS;
    }
    IEnumerator Stun()
    {
        yield return new WaitForSeconds(1.0f);
        SetState(UnitState.idle);
    }

    public void CastSpell()
    {
        Instantiate(arrow, transform.position, Quaternion.identity);
    }

    public void AttackSound()
    {
        mySfx.PlayOneShot(AttackSfx);
    }

    public void WalkSound()
    {
        //mySfx.PlayOneShot(WalkSfx);
    }

  
    public void LoadStatInfo()
    {
        int id = PlayerPrefs.GetInt("Play_Id");
        string path = Path.Combine(Application.streamingAssetsPath, "StatDataTest.xml");
        //TextAsset txtAsset = (TextAsset)Resources.Load(path);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(File.ReadAllText(path));
        //Debug.Log(txtAsset.text);
        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");
        XmlNode character = nodes[id];
        this.AD = int.Parse(character.SelectSingleNode("ad").InnerText);
        // a = int.Parse(character.SelectSingleNode("ad").InnerText);
        //character.SelectSingleNode("ad").InnerText = a.ToString();
        this.AP = int.Parse(character.SelectSingleNode("ap").InnerText);
        //character.SelectSingleNode("ap").InnerText = b.ToString();
        this.HP = int.Parse(character.SelectSingleNode("hp").InnerText);
        //character.SelectSingleNode("hp").InnerText = c.ToString();
        this.MP = int.Parse(character.SelectSingleNode("mp").InnerText);
        //character.SelectSingleNode("mp").InnerText = d.ToString();
        switch(id)
        {
            case 0:
                GameObject.Find("Unit000").GetComponent<SA_Unit>()._unitAT = AD;
                GameObject.Find("Unit000").GetComponent<SA_Unit>()._unitAP = AP;
                GameObject.Find("Unit000").GetComponent<SA_Unit>()._unitHP = HP * 100;
                GameObject.Find("Unit000").GetComponent<SA_Unit>()._unitMP = MP;
                GameObject.Find("Unit000").GetComponent<SA_Unit>().Health = HP * 100;

                break;
            case 1:
                GameObject.Find("Unit001").GetComponent<SA_Unit>()._unitAT = AD;
                GameObject.Find("Unit001").GetComponent<SA_Unit>()._unitAP = AP;
                GameObject.Find("Unit001").GetComponent<SA_Unit>()._unitHP = HP * 100;
                GameObject.Find("Unit001").GetComponent<SA_Unit>()._unitMP = MP;
                GameObject.Find("Unit001").GetComponent<SA_Unit>().Health = HP * 100;
                break;
            case 2:
                GameObject.Find("Unit002").GetComponent<SA_Unit>()._unitAT = AD;
                GameObject.Find("Unit002").GetComponent<SA_Unit>()._unitAP = AP;
                GameObject.Find("Unit002").GetComponent<SA_Unit>()._unitHP = HP * 100;
                GameObject.Find("Unit002").GetComponent<SA_Unit>()._unitMP = MP;
                GameObject.Find("Unit002").GetComponent<SA_Unit>().Health = HP * 100;
                break;
            case 3:
                GameObject.Find("Unit003").GetComponent<SA_Unit>()._unitAT = AD;
                GameObject.Find("Unit003").GetComponent<SA_Unit>()._unitAP = AP;
                GameObject.Find("Unit003").GetComponent<SA_Unit>()._unitHP = HP * 100;
                GameObject.Find("Unit003").GetComponent<SA_Unit>()._unitMP = MP;
                GameObject.Find("Unit003").GetComponent<SA_Unit>().Health = HP * 100;
                break;
            case 4:
                GameObject.Find("Unit004").GetComponent<SA_Unit>()._unitAT = AD;
                GameObject.Find("Unit004").GetComponent<SA_Unit>()._unitAP = AP;
                GameObject.Find("Unit004").GetComponent<SA_Unit>()._unitHP = HP * 100;
                GameObject.Find("Unit004").GetComponent<SA_Unit>()._unitMP = MP;
                GameObject.Find("Unit004").GetComponent<SA_Unit>().Health = HP * 100;
                break;
            case 5:
                GameObject.Find("Unit005").GetComponent<SA_Unit>()._unitAT = AD;
                GameObject.Find("Unit005").GetComponent<SA_Unit>()._unitAP = AP;
                GameObject.Find("Unit005").GetComponent<SA_Unit>()._unitHP = HP * 100;
                GameObject.Find("Unit005").GetComponent<SA_Unit>()._unitMP = MP;
                GameObject.Find("Unit005").GetComponent<SA_Unit>().Health = HP * 100;
                break;
            case 6:
                GameObject.Find("Unit006").GetComponent<SA_Unit>()._unitAT = AD;
                GameObject.Find("Unit006").GetComponent<SA_Unit>()._unitAP = AP;
                GameObject.Find("Unit006").GetComponent<SA_Unit>()._unitHP = HP * 100;
                GameObject.Find("Unit006").GetComponent<SA_Unit>()._unitMP = MP;
                GameObject.Find("Unit006").GetComponent<SA_Unit>().Health = HP * 100;
                break;
            case 7:
                GameObject.Find("Unit007").GetComponent<SA_Unit>()._unitAT = AD;
                GameObject.Find("Unit007").GetComponent<SA_Unit>()._unitAP = AP;
                GameObject.Find("Unit007").GetComponent<SA_Unit>()._unitHP = HP * 100;
                GameObject.Find("Unit007").GetComponent<SA_Unit>()._unitMP = MP;
                GameObject.Find("Unit007").GetComponent<SA_Unit>().Health = HP * 100;
                break;
            case 8:
                GameObject.Find("Unit008").GetComponent<SA_Unit>()._unitAT = AD;
                GameObject.Find("Unit008").GetComponent<SA_Unit>()._unitAP = AP;
                GameObject.Find("Unit008").GetComponent<SA_Unit>()._unitHP = HP * 100;
                GameObject.Find("Unit008").GetComponent<SA_Unit>()._unitMP = MP;
                GameObject.Find("Unit008").GetComponent<SA_Unit>().Health = HP * 100;
                break;
            case 9:
                GameObject.Find("Unit009").GetComponent<SA_Unit>()._unitAT = AD;
                GameObject.Find("Unit009").GetComponent<SA_Unit>()._unitAP = AP;
                GameObject.Find("Unit009").GetComponent<SA_Unit>()._unitHP = HP * 100;
                GameObject.Find("Unit009").GetComponent<SA_Unit>()._unitMP = MP;
                GameObject.Find("Unit009").GetComponent<SA_Unit>().Health = HP * 100;
                break;
            case 10:
                GameObject.Find("Unit0010").GetComponent<SA_Unit>()._unitAT = AD;
                GameObject.Find("Unit0010").GetComponent<SA_Unit>()._unitAP = AP;
                GameObject.Find("Unit0010").GetComponent<SA_Unit>()._unitHP = HP * 100;
                GameObject.Find("Unit0010").GetComponent<SA_Unit>()._unitMP = MP;
                GameObject.Find("Unit0010").GetComponent<SA_Unit>().Health = HP * 100;
                break;
            case 11:
                GameObject.Find("Unit0011").GetComponent<SA_Unit>()._unitAT = AD;
                GameObject.Find("Unit0011").GetComponent<SA_Unit>()._unitAP = AP;
                GameObject.Find("Unit0011").GetComponent<SA_Unit>()._unitHP = HP * 100;
                GameObject.Find("Unit0011").GetComponent<SA_Unit>()._unitMP = MP;
                GameObject.Find("Unit0011").GetComponent<SA_Unit>().Health = HP * 100;
                break;
            case 12:
                GameObject.Find("Unit0012").GetComponent<SA_Unit>()._unitAT = AD;
                GameObject.Find("Unit0012").GetComponent<SA_Unit>()._unitAP = AP;
                GameObject.Find("Unit0012").GetComponent<SA_Unit>()._unitHP = HP * 100;
                GameObject.Find("Unit0012").GetComponent<SA_Unit>()._unitMP = MP;
                GameObject.Find("Unit0012").GetComponent<SA_Unit>().Health = HP * 100;
                break;
            case 13:
                GameObject.Find("Unit0013").GetComponent<SA_Unit>()._unitAT = AD;
                GameObject.Find("Unit0013").GetComponent<SA_Unit>()._unitAP = AP;
                GameObject.Find("Unit0013").GetComponent<SA_Unit>()._unitHP = HP * 100;
                GameObject.Find("Unit0013").GetComponent<SA_Unit>()._unitMP = MP;
                GameObject.Find("Unit0013").GetComponent<SA_Unit>().Health = HP * 100;
                break;
            case 14:
                GameObject.Find("Unit0014").GetComponent<SA_Unit>()._unitAT = AD;
                GameObject.Find("Unit0014").GetComponent<SA_Unit>()._unitAP = AP;
                GameObject.Find("Unit0014").GetComponent<SA_Unit>()._unitHP = HP * 100;
                GameObject.Find("Unit0014").GetComponent<SA_Unit>()._unitMP = MP;
                GameObject.Find("Unit0014").GetComponent<SA_Unit>().Health = HP * 100;
                break;

        }


    }
}
