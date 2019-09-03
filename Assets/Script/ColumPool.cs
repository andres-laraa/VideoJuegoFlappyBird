using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumPool : MonoBehaviour {

    public int columnPollSize = 5;
    public GameObject columnPrefab;

    public float columnMin = -2.9f;
    public float columnMax = 1.4f;
    private float spawnXPosition = 10f  ;


    private GameObject[] columns;
    private Vector2 objectPoolPosition = new Vector2(-14, 0);

    private float timeSinceLastSpawned;
    public float spawRate;

    private int currentColumn;
	// Use this for initialization
	void Start () {

        columns = new GameObject[columnPollSize];
        for(int i=0; i<columnPollSize; i++)
        {
            columns[i] = Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
        timeSinceLastSpawned += Time.deltaTime;
        if(!GameController.instance.gameOver && timeSinceLastSpawned >= spawRate)
        {
            timeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range(columnMin, columnMax);

            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentColumn++;
            if(currentColumn >= columnPollSize)
            {
                currentColumn = 0;
            }
        }
	}
}
