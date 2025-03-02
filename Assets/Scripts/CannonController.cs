using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    [SerializeField] private bool loaded = false;
    [SerializeField] private GameObject barrel;
    [SerializeField] private GameObject powerIndicator;
    [SerializeField] private CannonSO cannonSo;

    void Start()
    {
        
    }

    void Update()
    {
        updateBarrelRotation();
    }

    private void updateBarrelRotation()
    {
        var rot = cannonSo.angleInDegrees;
        barrel.transform.rotation = Quaternion.AngleAxis(rot, Vector3.forward);
    }
}
