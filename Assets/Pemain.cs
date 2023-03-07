using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pemain : MonoBehaviour
{
    public Animator playerAnimator;
    public GameObject rawVideo;
    public Script gs;

    private void Start()
    {
        rawVideo.SetActive(false);
    }

    public void playerAttack()
    {
        playerAnimator.SetTrigger("isAttack");
    }

    public void invokeVideo()
    {
        Invoke("playVideo", 2.0f);
    }
    public void playVideo()
    {
        rawVideo.SetActive(true);
    }

    public void CallChangeSceneAfterSeconds()
    {
        StartCoroutine("WaitAndChange");
    }

    IEnumerator WaitAndChange()
    {
        yield return new WaitForSeconds(12.0f);
        gs.ChangeMyScene("Menu");
    }
}
