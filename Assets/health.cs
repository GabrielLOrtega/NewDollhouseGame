using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxHp = 100;
    private int _hp;

    [SerializeField] private Animator animator; // 👈 Add Animator reference

    public int MaxH => _maxHp;

    public int Hp
    {
        get => _hp;
        private set
        {
            bool isDamage = value < _hp;
            _hp = Mathf.Clamp(value, 0, _maxHp);

            if (isDamage)
            {
                Damaged?.Invoke(_hp);
            }
            else
            {
                Healed?.Invoke(_hp);
            }

            if (_hp <= 0)
            {
                died?.Invoke();
                TriggerLoseAnimation(); // 👈 Trigger animation
            }
        }
    }

    public UnityEvent<int> Healed;
    public UnityEvent<int> Damaged;
    public UnityEvent died;

    private void Awake()
    {
        _hp = _maxHp;
    }

    public void Damage(int amount) => Hp -= amount;

    public void Heal(int amount) => Hp += amount;

    public void HealFull() => Hp = _maxHp;

    public void Kill() => Hp = 0;

    public void Adjust(int value) => Hp = value;

    private void TriggerLoseAnimation()
    {
        if (animator != null)
        {
            animator.SetTrigger("Lose"); // 👈 Ensure "Lose" trigger exists in Animator
        }
    }
}