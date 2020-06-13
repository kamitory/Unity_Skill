using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCube : MonoBehaviour
{
    //public GameObject m_goPrefab = null;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateCoroutine());
    }

    // Update is called once per frame
    IEnumerator CreateCoroutine()
    {
        while (true)
        {
            yield return null;
            GameObject t_object = ObjectPoolingManager.instance.GetQueue();
            t_object.transform.position = Vector3.zero;
        }
    }
}
