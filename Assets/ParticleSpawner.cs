using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{

    public GameObject particle;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 0); // Set the spawn position
        Quaternion spawnRotation = Quaternion.Euler(-90, 0, 0); // Set the spawn rotation
        Vector3 initialScale = new Vector3(0.01f, 0.01f, 0.01f); // Default scale if you want all to be the same

        Instantiate(particle, spawnPosition, spawnRotation);
        particle.transform.localScale = initialScale;
    }
}
