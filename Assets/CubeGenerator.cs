﻿using UnityEngine;
using System.Collections;

public class CubeGenerator : MonoBehaviour {

    public GameObject cubePrefab;
    private float delta = 1.0f;
    private float span = 1.0f;
    private float genPos = 12;
    private float offsetY = 0.3f;
    private float spaceY = 6.9f;
    private float offsetX = 0.5f;
    private float spaceX = 0.4f;
    private int maxBlocknum = 4;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.delta += Time.deltaTime;

        if(this.delta > this.span)
        {
            this.delta = 0;
            int n = Random.Range(1, maxBlocknum + 1);

            for(int i =0; i < n; i++)
            {
                GameObject go = Instantiate(cubePrefab) as GameObject;
                go.transform.position = new Vector2(this.genPos, this.offsetY + i * this.spaceY);
            }

            this.span = this.offsetX + this.spaceX * n;
        }
	
	}
}
