using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedTimeSpawner : MonoBehaviour
{
    bool loop = false;
    [SerializeField] GameObject cubePrefab;

    PreTimerGUI _timer;

    // Start is called before the first frame update
    void Start()
    {
        _timer = GameObject.Find("Timer").GetComponent<PreTimerGUI>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (loop == false && _timer.timerFinished)
        {
            loop = true;
            StartCoroutine(SpawnLoop());
        }
    }

    IEnumerator SpawnLoop()
    {
        while(loop)
        {
            var cube = Instantiate(cubePrefab);
            cube.GetComponent<Cube>().element = (Cube.Element)UnityEngine.Random.Range(0, Enum.GetValues(typeof(Cube.Element)).Length);
            Destroy(cube, 10f);

            yield return new WaitForSeconds(0.5f);
        }
    }
}
