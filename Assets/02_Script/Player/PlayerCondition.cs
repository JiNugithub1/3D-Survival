using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable
{
    void TakePhysicalDamage(int damage);
}
public class PlayerCondition : MonoBehaviour, IDamagable
{
    public UICondition uicondition;

    Condition health { get { return uicondition.health; } }
    Condition hunger { get { return uicondition.hunger; } }
    Condition stamina { get { return uicondition.stamina; } }

    public float noHungerHealthDecay;

    public event Action onTakeDamage;
    void Update()
    {
        hunger.Subtract(hunger.passiveValue * Time.deltaTime);
        stamina.Add(stamina.passiveValue * Time.deltaTime);

        if (hunger.curValue == 0f)
        {
            health.Subtract(noHungerHealthDecay * Time.deltaTime);
        }
        if (health.curValue == 0f)
        {
            Die();
        }
    }

    public void Heal(float amout)
    {
        health.Add(amout);
    }
    public void Eat(float amout)
    {
        hunger.Add(amout);
    }
    public void SpeedUp(float amount, float duration) // 코루틴을 호출하여 아이템의 스피드를 올려준다.
    {
        StartCoroutine(SpeedUpCoroutine(amount, duration));
    }
    private IEnumerator SpeedUpCoroutine(float amount, float duration)
    {
        PlayerController controller = GetComponent<PlayerController>();
        if (controller == null)
            yield break;

        // 속도 증가
        controller.moveSpeed += amount;
        Debug.Log(controller.moveSpeed);

        yield return new WaitForSeconds(duration);

        // 속도 원래대로 복구
        controller.moveSpeed -= amount;
    }
    public void Die()
    {
        Debug.Log("Die");
    }
    

    public void TakePhysicalDamage(int damage)
    {
        health.Subtract(damage);
        onTakeDamage?.Invoke();

    }
}
