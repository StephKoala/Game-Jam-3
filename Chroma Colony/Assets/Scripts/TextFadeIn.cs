using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextFadeIn : MonoBehaviour {
    private TextMeshProUGUI textMesh;

    private float fadeInDuration = 0.5f;
    private float startAfter = 1.0f;
    private float startFadingTime;
    private float elapsedTime = 0f;

    private bool transitionCompleted = false;

    private void OnEnable() {
        textMesh = GetComponent<TextMeshProUGUI>();
        textMesh.alpha = 0f; 
        startFadingTime = Time.time + startAfter; // Set the start fading time to 1 second from now
    }

    private void Update() {
        if (!transitionCompleted) {
            if (Time.time >= startFadingTime) {
                elapsedTime += Time.deltaTime;
                float alpha = Mathf.Lerp(0f, 1f, elapsedTime / fadeInDuration);
                textMesh.alpha = alpha;

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
