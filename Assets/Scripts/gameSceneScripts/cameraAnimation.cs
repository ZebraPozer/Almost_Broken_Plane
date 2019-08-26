using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraAnimation : MonoBehaviour
{
    public Animator camAnim;
    public void cameraShakeAnimation()
        {
        camAnim.SetTrigger("ShakeCamreAnimation");
        }
}
