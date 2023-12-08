using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketSpawnRL : MonoBehaviour {
    public GameObject missle;
    public float xMinus;
    public float rotate;
    public float minTime;
    public float maxTime;
    public float timeDestroy;
    private Vector2 screenBounds;

    void Start () {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }
    private void spawnEnemy(){
        GameObject a = Instantiate(missle) as GameObject;
        a.transform.position = new Vector2(screenBounds.x - xMinus, Random.Range(-screenBounds.y, screenBounds.y));
        a.transform.Rotate(0f, 0f, rotate);
        var saved = a;
        Destroy(saved, timeDestroy);
    }
    IEnumerator asteroidWave(){
        while(true){
            yield return new WaitForSeconds(Random.Range(minTime, maxTime));
            spawnEnemy();
        }
    }
} 

