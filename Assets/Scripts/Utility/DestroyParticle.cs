using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticle : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 1f);    //asl�nda destroy etmek yerine disabled yaparsak daha az ram yer
    }
}
