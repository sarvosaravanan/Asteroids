using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumySapwnManager : MonoBehaviour
{

    [SerializeField] GameObject[] enumys1;
    [SerializeField] GameObject[] enumys2;

    [SerializeField] Transform e1Point;
    [SerializeField] Transform e2Point;
   
    void Start()
    {
        StartCoroutine(EnumySpawn());
        StartCoroutine(EnumySpawn2());
        
    }

    
    void Update()
    {
        
    }
    IEnumerator EnumySpawn()
    {
        while(Application.isPlaying)
        {
            float delay = Random.Range(1.5f, 3.5f);
            yield return new WaitForSeconds(delay);

            e1Point.position = new Vector2(Random.Range(-10f, 11f), Random.Range(6.4f, 6.5f));

            GameObject g = Instantiate(enumys1[Random.Range(0, enumys1.Length)]);

            g.transform.position = e1Point.position;
            g.transform.rotation = e1Point.rotation;

        }
    }


    IEnumerator EnumySpawn2()
    {
        while (Application.isPlaying)
        {
            float delay = Random.Range(2.5f, 4.5f);
            yield return new WaitForSeconds(delay);

            e2Point.position = new Vector2(Random.Range(-10f, 11f), Random.Range(-6.4f,-6.5f));

            GameObject g = Instantiate(enumys2[Random.Range(0, enumys2.Length)]);

            g.transform.position = e2Point.position;
            g.transform.rotation = e2Point.rotation;

        }
    }
}
