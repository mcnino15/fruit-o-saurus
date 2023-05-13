using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruit : MonoBehaviour
{
    [SerializeField] GameObject [] fruitPrefab;

    [SerializeField] float secondSpawn = 0.5f;

    [SerializeField] float minTras;

    [SerializeField] float maxTras;
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(FruitSpawn()); 
    }

    IEnumerator FruitSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position= new Vector3 (wanted, transform.position.y);
            GameObject gameObject = Instantiate (fruitPrefab[Random.Range(0, fruitPrefab.Length)], position, Quaternion.identity); 
            yield return new WaitForSeconds(secondSpawn);
        }
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
