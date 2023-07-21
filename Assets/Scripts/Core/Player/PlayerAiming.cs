using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerAiming : NetworkBehaviour
{
    [SerializeField] InputReader inputReader;
    [SerializeField] Transform turretTransform;

    private void LateUpdate()
    {
        if(!IsOwner) return;

    }

}
