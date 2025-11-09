using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class health : MonoBehaviour
{
    [SerializeField]
    private int _maxHp = 100;
    private int _Hp;

    public int MaxH => _maxHp;

    public int Hp
    {
        get => _Hp;
        private set
        {
            var isDamage = value < Hp;
            _hp = Mathf.Clamp(value, min0, _maxHp);
            if (isDamage)
            {
                Damaged?.Invoke(_hp);

            }
        } else{
            Healed?.Invoke(_Hp);
        }
        if(_hp<=0){
        died?.invoke();
    }

    public UnityEvent<int> Healed;
    public UnityEvent<int> Damaged;
    public UnityEvent died;
   

  private void Awake()
    {
        _hp = _maxHp;
    }
    public void Damage(int amount) => Hp -= amount;
   
    public void Heal (int amount)
    {
        Hp += amount;
    }
    public void Healful()
    {
        Hp =_maxHp
    }
    public void Kill()
    {
        Hp = 0;
    }
    public void adjust(int value)
    {
        Hp = vaule
    }
}

