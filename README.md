# Augmented-Reality-Visualizer
Visualizes an audio source by modulating cubes in augmented reality (made with Unity and Vuforia)


The analysis of the audio source happens in the AudioPeer.cs script using Unitys build in Furier-Analysis tool. The information is
then packed into eight frequency bands. The cubes scale is then modulated by this frequency information, this happens in the 
ParamCube.cs script.


The result looks like this:

![vid_20180603_131055](https://user-images.githubusercontent.com/38664240/40885943-ee1fed6a-672f-11e8-8b82-cfd8448ad7ad.gif)
