using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlaybackControls : MonoBehaviour {
    public VideoPlayer videoPlayer;
    public int frameJump = 10;

    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    void Start () {
        videoPlayer.frame = 0;

    }

	void Update () {
        if (Input.GetKeyDown("space"))
            PlayPause();

        if (Input.GetKeyDown("right"))
            goToNextFrame();

        if (Input.GetKeyDown("left"))
            goToPreviousFrame();
    }

    public void PlayPause()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            

        }
        else
        {
            videoPlayer.Play();
        }
    }

    public void goToNextFrame()
    {
        videoPlayer.Play();
        if (videoPlayer.isPlaying)
        {
           // videoPlayer.Pause();

        }
        videoPlayer.frame = videoPlayer.frame += 10;
       // videoPlayer.Play();
        videoPlayer.Pause();
    }

    public void goToPreviousFrame()
    {
        videoPlayer.Play();
        if (videoPlayer.isPlaying)
        {
         //  videoPlayer.Pause();

        }
        videoPlayer.time = videoPlayer.time -= 10;
       // videoPlayer.Play();
        videoPlayer.Pause();
    }

}
