using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalManager : MonoBehaviour
{
    public Transform PosA;
    public Transform PosB;

    private void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Portal A"))
        {
            CharacterController cc = GetComponent<CharacterController>();
            
            cc.enabled = false;
            transform.position= PosB.transform.position;
            transform.rotation = new Quaternion(transform.rotation.x, PosB.rotation.y, transform.rotation.z, transform.rotation.w);

            cc.enabled = true;

        }

        if (col.CompareTag("Portal B"))
        {
            CharacterController cc = GetComponent<CharacterController>();

            cc.enabled = false;
            transform.position = PosA.transform.position;
            transform.rotation = new Quaternion(transform.rotation.x, PosA.rotation.y, transform.rotation.z, transform.rotation.w);

            cc.enabled = true;

        }
    }
}
