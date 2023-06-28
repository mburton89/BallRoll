using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoGun : MonoBehaviour
{
    public GameObject tato;
    public Transform tatoSpawnPoint;
    public float launchSpeed;
    public AudioSource potatoShootSound;
    public Rigidbody fpsRigidBody;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Firetato();
        }
    }

    void Firetato() //Fires potato from launcher
    {
        //spawn and then launch game object from point of origin
        GameObject newTato = Instantiate(tato, tatoSpawnPoint.position, transform.rotation);
        print("fpsRigidBody.velocity" + fpsRigidBody.velocity);
        newTato.GetComponent<Rigidbody>().AddForce((tatoSpawnPoint.forward * launchSpeed) + (fpsRigidBody.velocity * 30));
        Destroy(newTato, 5);
        potatoShootSound.pitch = Random.Range(0.92f, 1.08f);
        //potatoShootSound.Play();
    }
}
