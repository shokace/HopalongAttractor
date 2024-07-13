using System.Collections;
using UnityEngine;
using Unity.Jobs;

public class PlaneSpawner : MonoBehaviour
{
    public GameObject particlePrefab;

    public Vector3 spawnPosition = new Vector3(0, 0, 0); // Set the spawn position
    public Quaternion spawnRotation = Quaternion.Euler(-90, 0, 0); // Set the spawn rotation

    Mutators mutator = new Mutators();

    public class Mutators
    {
        private float A;
        private float B;
        private float C;

        private const float MUT = 1.0001f;
        private const float MAX = 50.0f;

        public Mutators()
        {
            A = 1;
            B = 1;
            C = 1;
        }

        public void ModifyMutators()
        {
            if (A * MUT >= MAX || B * MUT >= MAX || C * MUT >= MAX)
            {
                A = 2;
                B = 1;
                C = 3;
            }
            else
            {
                A *= MUT;
                B *= MUT;
                C *= MUT;
            }
        }

        public float getA() { return A; }
        public float getB() { return B; }
        public float getC() { return C; }
    }

    void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {
        float x = 1.0f, y = 1.0f;

        while (true) // This will continuously spawn new batches
        {
            yield return StartCoroutine(RunOrbit(x, y, mutator));
            mutator.ModifyMutators();
        }
    }

    IEnumerator RunOrbit(float x, float y, Mutators mutator)
    {
        int n = 1000;
        float[] value = new float[] { x, y };
        float a = mutator.getA();
        float b = mutator.getB();
        float c = mutator.getC();
        for (int i = 0; i < n; i++)
        {
            float currentX = value[0];
            float currentY = value[1];

            float deltaX = Mathf.Sqrt(Mathf.Abs(b * currentX - c)) * Mathf.Sign(currentX);
            float deltaY = a - currentX;

            value[0] = currentY - deltaX;
            value[1] = deltaY;

            Vector3 position = new Vector3(value[0], value[1], 0);
            Instantiate(particlePrefab, position, spawnRotation);

            if (i % 10 == 0) // Yield every 10 iterations to keep the frame rate smoother
                yield return null;
        }
    }
}

