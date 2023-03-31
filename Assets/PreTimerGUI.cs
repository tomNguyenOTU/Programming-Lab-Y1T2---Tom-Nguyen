using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreTimerGUI : MonoBehaviour
{
    FixedTimeSpawner _spawn;
    [SerializeField] int timer;
    Text _text;

    public bool timerFinished = false;

    private void Start()
    {
        _spawn = GameObject.Find("Spawner").GetComponent<FixedTimeSpawner>();
        _text = GameObject.Find("TimerText").GetComponent<Text>();

        _text.text = timer.ToString();
        StartCoroutine(PreTimer());
    }

    private IEnumerator PreTimer()
    {
        while (timer > 0)
        {
            yield return new WaitForSeconds(1);
            timer -= 1;
            _text.text = timer.ToString();
        }

        _text.gameObject.SetActive(false);
        timerFinished = true;
    }
}
