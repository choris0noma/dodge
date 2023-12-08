using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombSpawn : MonoBehaviour {
    public GameObject bomb;
    public float minTime;
    public float maxTime;
    private Vector2 screenBounds;

    void Start () {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }
    private void spawnEnemy(){
        GameObject b = Instantiate(bomb) as GameObject;
        b.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), Random.Range(-screenBounds.y, screenBounds.y));
    }
    IEnumerator asteroidWave(){
        while(true){
            yield return new WaitForSeconds(Random.Range(minTime, maxTime));
            spawnEnemy();
        }
    }
}