using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        transform.Translate(Vector3.back * _moveSpeed * Time.deltaTime);
    }
}