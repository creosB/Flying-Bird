using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpawner : MonoBehaviour
{

    public PlayerScript PlayerRefference = null;
    public GameObject Pipes = null;
    public float Height = 0.0f;
    public float RepeatTime = 1.0f;


    private void Start()
    {
        StartCoroutine(PipesSpawnerTimer());
    }

    // every 1 sec it will spawn
    public IEnumerator PipesSpawnerTimer()
    {
        while (!PlayerRefference.PlayerIsDead)
        {
            // it will spawn new vector 3 between random height at location
            Instantiate(Pipes, new Vector3(3, Random.Range(-Height,Height),0), Quaternion.identity);
            yield return new WaitForSeconds(RepeatTime);
        }
        
    }
}
