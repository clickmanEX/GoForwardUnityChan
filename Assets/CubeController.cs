using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

    private float speed = -0.2f;
    private float deadLine = -10f;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(this.speed, 0, 0);
       
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        } 

	}

    //地面と他のCubePrefabと衝突した場合、音を再生する。
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "CubeTag" || other.gameObject.tag == "GroundTag")
        {
            this.GetComponent<AudioSource>().Play();
           
        }
        
    }
}
