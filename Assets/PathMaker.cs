using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathMaker : MonoBehaviour {

    private int counter = 0;
    public float moveSpeed = 5f;
    public Transform floorPrefab;
    public Transform pathmakerSpherePrefab;
    float randomValue;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;

	
	// Update is called once per frame
	void Update () {
        if (counter < 50)
        {
            randomValue = Random.Range(0f, 1f);

            if (randomValue < 0.25f)
            {
                pathmakerSpherePrefab.transform.Rotate(0f, 90f, 0f);
            }
            else if (randomValue >= 0.25f && randomValue <= 0.5f)
            {
                pathmakerSpherePrefab.transform.Rotate(0f, -90f, 0f);
            }
            else if (randomValue >= 0.99f && randomValue <= 1f)
            {
                Instantiate(pathmakerSpherePrefab);
            }
            else
            {
                float spawn = Random.Range(0f, 3f);
                if (spawn <= 1f)
                {
                    Instantiate(spawn1, transform.position, transform.rotation);

                }
                else if (spawn < 1f && spawn <= 2f)

                {
                    Instantiate(spawn2, transform.position, transform.rotation);
                }

                else
                {
                    Instantiate(spawn3, transform.position, transform.rotation);
                }

            }

            transform.Translate(0f, 0f, moveSpeed * Time.deltaTime);

            counter += 1;

        }
        else if (counter > 50)
        {
            Destroy(gameObject);
        }
    }
}
