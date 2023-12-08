using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject objectPrefab;
    public float minTime;
    public float maxTime;
    public float timeDestroy;
    private Vector2 screenBounds;

    void Start () {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }
    private void spawnEnemy(){
        GameObject a = Instantiate(objectPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), Random.Range(-screenBounds.y, screenBounds.y));
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