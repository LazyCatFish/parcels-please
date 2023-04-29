using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

[CreateAssetMenu(fileName = "Cannon", menuName = "Game/Cannon")]
public class CannonSO : ScriptableObject
{
    [SerializeField]
    [Range(0f, 1f)]
    private float power = 0f;
    
    [SerializeField]
    [Range(-90f, 90f)]
    public float angleInDegrees = 90f;
    void OnEnable()
    {
        
    }

    public float getPower()
    {
        return power;
    }

    public void setPower(float power)
    {
        this.power = math.clamp(power, 0f, 1f);
    }
    
    public float getAngleInDegrees()
    {
        return angleInDegrees;
    }

    public void setAngleInDegrees(float angle)
    {
        this.angleInDegrees = math.clamp(angle, -90f, 90f);
    }
}
