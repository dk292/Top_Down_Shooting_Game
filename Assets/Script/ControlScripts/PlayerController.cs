using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Movement Variables
    public float _horizontalInput;
    public float _verticalInput;
    private float _boundaryX = 25;
    private float _boundaryZ = 20;
    private float _minimumBoundaryZ = -7;
    public float _speed;

    Vector3 foodPosition = new Vector3(0, 0, 1);

    //Getting Prefabs
    public GameObject _projectilePrefab1;
    public GameObject _projectilePrefab2;
    public GameObject _projectilePrefab3;

    //Sound Variable
    public AudioSource shootEffect;
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }
    void Update()
    {
        PlayerMovement();
        FiringProjectile();
    }

    void PlayerMovement()
    {
        if (transform.position.x < -_boundaryX)
        {
            transform.position = new Vector3(-_boundaryX, transform.position.y, transform.position.z);
        }

        if (transform.position.x > _boundaryX)
        {
            transform.position = new Vector3(_boundaryX, transform.position.y, transform.position.z);
        }
        if (transform.position.z < _minimumBoundaryZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, _minimumBoundaryZ);
        }

        if (transform.position.z > _boundaryZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, _boundaryZ);
        }

        // Horizontal Movement
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * _horizontalInput * Time.deltaTime * _speed);
        //Vertical Movement
        _verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * _verticalInput * Time.deltaTime * _speed);
    }

    void FiringProjectile()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shootEffect.Play();
            Instantiate(_projectilePrefab1, transform.position + foodPosition, Quaternion.identity);
            Instantiate(_projectilePrefab2, transform.position + foodPosition, Quaternion.identity);
            Instantiate(_projectilePrefab3, transform.position + foodPosition, Quaternion.identity);
        }
    }
}
