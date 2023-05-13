using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpaw : MonoBehaviour
{
    [SerializeField] GameObject [] meteoPrefab;
    
    [SerializeField] float secondSpawn = 0.5f;

    [SerializeField] float minTras;

    [SerializeField] float maxTras;

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(MeteoSpawn()); 
    }
     IEnumerator MeteoSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position= new Vector3 (wanted, transform.position.y);
            GameObject gameObject = Instantiate (meteoPrefab[Random.Range(0, meteoPrefab.Length)], position, Quaternion.identity); 
            yield return new WaitForSeconds(secondSpawn);
        }
    }
   
}
