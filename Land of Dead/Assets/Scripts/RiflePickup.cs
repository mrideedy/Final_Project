using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiflePickup : MonoBehaviour
{
    [Header("Rifle's")]
    public GameObject PlayerRifle;
    public GameObject PickupRifle;

    [Header("Rifle Assign Things")]
    public PlayerScript player;
    private float radius = 2.5f;

    private void Awake()
    {
        PlayerRifle.SetActive(false);
    }

    private void Update()
    {
        if(Vector3.Distance(PickupRifle.transform.position, player.transform.position) <= radius)
        {
            if(Input.GetKeyDown("f"))
            {
                PlayerRifle.SetActive(true);
                PickupRifle.SetActive(false);
                //sound

                //objective completed
            }
        }
    }
}
 