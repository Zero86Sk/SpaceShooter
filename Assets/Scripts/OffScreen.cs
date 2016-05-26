using UnityEngine;
using System.Collections;

public class OffScreen : MonoBehaviour {

    public GameObject destroyTarget = null;

    void OnBecameInvisible ()
    {
        if (destroyTarget == null)
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(destroyTarget);
        }
        //Debug.Log(destroyTarget + " destroyed!");
    }
}
