using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMoveForward : MonoBehaviour
{
    // all rotation
    public float _rotationSpeed;
    public float _rotationYAxis;
    public float _eularRotationY;


    // For movemnt
    public float _movementSpeed;
    public float _positionZAxis;
    public float _positionXAxis;


    // Update is called once per frame
    void Update()
    {
        FixedRotation();
        ProjectileRotation();
        ProjectileMovement();
    }

    void FixedRotation()
    {
        transform.localRotation = Quaternion.Euler(0, _eularRotationY, 0);

    }

    void ProjectileMovement()
    {
        //transform.position += new Vector3(_positionXAxis, 0, _positionZAxis) * Time.deltaTime * _movementSpeed;
        transform.Translate(Vector3.forward * Time.deltaTime * _movementSpeed);
    }

    void ProjectileRotation()
    {
        transform.Rotate(new Vector3(0, _rotationYAxis, 0) * Time.deltaTime * _rotationSpeed);

    }
}
