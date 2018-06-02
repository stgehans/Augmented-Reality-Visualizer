using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamCube : MonoBehaviour {

	public int band;
	public float startScaleX, startScaleY, startScaleZ, scaleMultiplierX, scaleMultiplierY, scaleMultiplierZ;
	int frames;

	void Start () {
	}

	void Update () {
		frames++;
		if (frames % 2 == 0) {
			transform.localScale = Vector3.Lerp (transform.localScale, new Vector3((AudioPeer.freqBand [band] * scaleMultiplierX) + startScaleX, (AudioPeer.freqBand [band] * scaleMultiplierY) + startScaleY, (AudioPeer.freqBand [band] * scaleMultiplierZ) + startScaleZ), 0.5f);
		}
	}
}
