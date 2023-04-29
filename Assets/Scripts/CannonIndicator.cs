using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonIndicator : MonoBehaviour
{
    [SerializeField] private CannonSO cannonSo;
    [SerializeField] private GameObject valueBar;

    void Update()
    {
        var power = cannonSo.GetPower();
        valueBar.transform.localScale = new Vector3(1, power, 1);

    }
}
