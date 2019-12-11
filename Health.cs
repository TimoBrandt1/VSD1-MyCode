using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float AmountOfHealth;//1 health is a half hearth

    public float TakeDamage(float amount)
    {
        AmountOfHealth -= amount;
        return AmountOfHealth;
    }

    public float GetHealth() { return AmountOfHealth; }
}
