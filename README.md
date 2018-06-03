# Augmented-Reality-Visualizer
Visualizes an audio source by modulating cubes in augmented reality (made with Unity and Vuforia)


The analysis of the audio source happens in the AudioPeer.cs script using Unitys build in furier analysis. The information is
then packed into eight frequency bands. The cubes scale is then modulated by this frequency information, this happens in the 
ParamCube.cs script.
