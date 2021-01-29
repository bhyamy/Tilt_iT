using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Documentation needs to be completed.
 *
 * Author: Yam
 * Date: 12/10/19
 * last update: -
 * By: -
 * Information updated: -
 */
public class LevelEnding : MonoBehaviour
{
    public GameObject endOfRoad;
    private bool ballInPlace;
    public float speed = 0.015f;
    public float cameraSpin = 0.1f;
    private Vector3 offset;

    private Vector3 location;
    public ParticleSystem particles;
    public GameObject levelWon;
    public bool doOneTime;
    
    // Start is called before the first frame update
    void Start()
    {
        endOfRoad = GameObject.Find("EndOfRoad");
        particles = endOfRoad.GetComponentInChildren<ParticleSystem>();
        particles.enableEmission = false;
        location = endOfRoad.transform.position + new Vector3 (0, 1f, 0);
        ballInPlace = false;
        offset = Camera.main.GetComponent<GameStart>().offset; 
        Destroy(Camera.main.GetComponent<GameStart>());
        doOneTime = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!ballInPlace) {
            particles.enableEmission = true;
            StartCoroutine(StopParticles(3f));
            transform.position = Vector3.MoveTowards(transform.position, location, speed);
            Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, location + offset, speed / 4);
            Camera.main.transform.RotateAround(location, Camera.main.transform.up, cameraSpin);
            if (transform.position == location) ballInPlace = true;
        } else {
            if (doOneTime) {
                endOfRoad.GetComponent<Holder>().music.enabled = false;
                endOfRoad.GetComponent<Holder>().levelWon.SetActive(true);
                endOfRoad.GetComponent<Holder>().scoreBar.SetActive(false);
                doOneTime = false;
            }
        }
    }

    IEnumerator StopParticles(float timeToShow) {
        yield return new WaitForSeconds(timeToShow);
        particles.enableEmission = false;
    }
}
