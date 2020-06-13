using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoArrow : MonoBehaviour
{
    [SerializeField] GameObject m_goArrow = null;
    [SerializeField] Transform m_tfArrowSpawn = null;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject t_arrow = Instantiate(m_goArrow, m_tfArrowSpawn.position, Quaternion.identity);
            t_arrow.GetComponent<Rigidbody>().velocity = Vector3.up * 5f;
        }
        
    }
}
