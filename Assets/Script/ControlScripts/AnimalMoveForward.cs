using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMoveForward : MonoBehaviour
{
    private int[] _rotationAngles = { -90, 90, 180 };
    public float _speed;

    void Start()
    {
        //FixedRotate();
    }
    void Update()
    {
        MoveForward();
    }

    void FixedRotate()
    {
        int randomAngleY = Random.Range(0, _rotationAngles.Length);
        transform.localRotation = Quaternion.Euler(0, _rotationAngles[randomAngleY], 0);
    }

    void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
    }
}
