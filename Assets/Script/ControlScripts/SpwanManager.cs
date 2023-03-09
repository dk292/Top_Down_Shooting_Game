using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    // Variable for spawning animal
    public GameObject[] _animalPrefabs;
    public float _maximumRangeX;
    public float _minimumRangeX;
    public float _maximunRangeZ;
    public float _minimunRangeZ;

    public float rotationYAxis;
    // Variables for invoking function at specific time
    private float _startDelay = 2;
    private float _spwanInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RandomlySpwan", _startDelay, _spwanInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void RandomlySpwan()
    {
        Vector3 spwanPos = new Vector3(Random.Range(_minimumRangeX, _maximumRangeX), 0, Random.Range(_minimunRangeZ, _maximunRangeZ));
        int prefabIndex = Random.Range(0, _animalPrefabs.Length);
        Instantiate(_animalPrefabs[prefabIndex], spwanPos, Quaternion.Euler(0, rotationYAxis, 0));

    }
}
