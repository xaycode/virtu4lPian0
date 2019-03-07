using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class suara : MonoBehaviour
{
	public void Mainkan()
	{
		StartCoroutine (Mulai ());
	}
	
	IEnumerator Mulai ()
	{
		GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (GetComponent<AudioSource> ().clip.length);
	}
}