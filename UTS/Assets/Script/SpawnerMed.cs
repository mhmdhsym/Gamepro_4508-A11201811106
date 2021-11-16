﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMed : MonoBehaviour
{
  public static SpawnerMed instance;

	public GameObject[] cars;
    // Start is called before the first frame update
    void Start()
    {
      if(instance==null)
      instance=this;
        StartCoroutine(SpawnItems(2f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnItems(float time)
  {
      yield return new WaitForSecondsRealtime(time);
      Vector2 pos=new Vector2(Random.Range(0,2),transform.position.y);
      Instantiate(cars[Random.Range(0,cars.Length)],pos, Quaternion.identity);
      StartCoroutine(SpawnItems(Random.Range(2f,3f)));
  }

  public void SpawnAgain()
  {
    StartCoroutine(SpawnItems(Random.Range(2f,3f)));
  }
}
