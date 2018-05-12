using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour {
	public AudioClip clip;
	public Items items;

	void OnTriggerEnter (Collider col)
		{
				Inventory.instance.Add(items);
				AudioSource.PlayClipAtPoint(clip, transform.position);
				Destroy(gameObject);
		}
}
