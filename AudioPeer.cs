using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent (typeof (AudioSource))]
public class AudioPeer: MonoBehaviour {
	
	public static float[] samples = new float[512];
	public static float[] freqBand = new float[8]; 
	public int offsetSpeed = 20;
	int offset = 0, frames = 0;
	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		frames++;
		calcOffset (frames);
		GetSpectrumAudioSource ();
		MakeFrequencyBands (offset);
		if (frames == 20000)
			frames = 0;
	}

	void GetSpectrumAudioSource(){
		audioSource.GetSpectrumData(samples, 0, FFTWindow.Blackman);
	}

	void MakeFrequencyBands(int offset){
		int count = 0, max = 8;
		for (int i = 0; i < 8; i++) {
			float average = 0;
			int sampleCount = (int) Mathf.Pow(2, i) * 2;
			if (i == 7)
				sampleCount += 2;
			for (int j = 0; j < sampleCount; j++) {
				average += samples [count] * (count + 1);
				count++;
			}
			average /= count;
			int index = i + offset;
			if (index > 7)
				index -= max;
			freqBand [index] = average * 10;
		}
	}

	void calcOffset (int Frames){
		if (frames % offsetSpeed == 0)
			offset++;
		if (offset > 8)
			offset = 0;
	}

}
