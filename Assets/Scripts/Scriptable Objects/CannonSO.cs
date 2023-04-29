using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

[CreateAssetMenu(fileName = "Cannon", menuName = "Game/Cannon")]
public class CannonSO : ScriptableObject
{
    [SerializeField] private float powerSensitivity = 1f, angleSensitivity = 1f;
    
    [SerializeField]
    [Range(0f, 1f)]
    private float power = 0f;
    
    [SerializeField]
    [Range(-90f, 90f)]
    public float angleInDegrees = 90f;
    void OnEnable()
    {
        
    }

    public float GetPower()
    {
        return power;
    }

    public void AddPower(float power)
    {
        this.power = math.clamp(this.power + power, 0f, 1f);
    }
    
    public float GetAngleInDegrees()
    {
        return angleInDegrees;
    }

    public void AddAngleInDegrees(float angle)
    {
        this.angleInDegrees = math.clamp(this.angleInDegrees + angle, -90f, 90f);
    }

    private Vector2 getIndicatorDirection()
    {
        var xDir = - Mathf.Sin(angleInDegrees * Mathf.Deg2Rad);
        var yDir = Mathf.Cos(angleInDegrees * Mathf.Deg2Rad);
        return new Vector2(xDir, yDir);
    }

    
    // TODO: Add player controller mouse sensitivity 
    public void MouseInput(Vector2 mouseInput)
    {
        var indicatorDirection = getIndicatorDirection();
        // Debug.Log("Indicator Dir: x : " + indicatorDirection.x + " || y : " + indicatorDirection.y);
        // Debug.Log("Mouse Dir:     x : " + mouseInput.x + " || y : " + mouseInput.y);

        var powerIncrease = Vector2.Dot(mouseInput, indicatorDirection);
        AddPower(powerIncrease * powerSensitivity);

        var angleIncrease = Vector2.Dot(mouseInput, Vector2.Perpendicular(indicatorDirection));
        AddAngleInDegrees(angleIncrease * angleSensitivity);
    }
}
