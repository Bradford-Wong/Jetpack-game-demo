using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {
    public AudioClip pickupSound;
    public Meter meter;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D target){
        float crystalMultiplier = 0.5f;
        if (target.gameObject.tag == "Player")
        {
            if (pickupSound)
                AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            if (meter)
            {
                if (this.tag == "crystal")
                    meter.air += (meter.maxAir - meter.air) * crystalMultiplier;
                else if (this.tag == "artifact")
                    meter.air += meter.maxAir - meter.air;
            }
        }
			Destroy (gameObject);
	}
}
