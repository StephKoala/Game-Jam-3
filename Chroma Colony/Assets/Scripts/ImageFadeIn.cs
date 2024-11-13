using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFadeIn : MonoBehaviour {
    private Image image;

    private float fadeInDuration = 0.75f;
    private float startAfter = 0.4f;
    private float startFadingTime;
    private float elapsedTime = 0f;

    private bool transitionCompleted = false;

    private void OnEnable() {
        image = GetComponent<Image>();
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0f); 
        startFadingTime = Time.time + startAfter; // Set the start fading time to 1 second from now
    }

    private void Update() {
        if (!transitionCompleted) {
            if (Time.time >= startFadingTime) {
                elapsedTime += Time.deltaTime;
                float alpha = Mathf.Lerp(0f, 1f, elapsedTime / fadeInDuration);
                image.color = new Color(image.color.r, image.color.g, image.color.b, alpha);

                if (elapsedTime >= fadeInDuration) {
                    // Fade in complete
                    elapsedTime = 0f;
                    transitionCompleted = true;
                }
            }
        }

    }

    public void EnableTransition() {
        transitionCompleted = false;
    }
}
