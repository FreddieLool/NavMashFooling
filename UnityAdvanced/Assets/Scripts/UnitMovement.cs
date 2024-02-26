using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Movement", menuName = "ScriptableObjects/MovementSpeed", order = 0)]

public class UnitMovement : ScriptableObject
{
    [SerializeField] private float speed;
    


    public float GetCharacterSpeed()
    {
        return speed;
    }
}
