using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    [SerializeField]
    Vector2 SpaceShipMovement;
    [SerializeField]
    float SpaceShipMovementSpeed;

    void Update()
    {
        SpaceShipMovement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) ;
        gameObject.transform.position += new Vector3(SpaceShipMovement.x*Time.deltaTime,SpaceShipMovement.y*Time.deltaTime,0)*SpaceShipMovementSpeed ;
    }
}
