using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class progress : MonoBehaviour {
    
    // Unity UI References
    public Slider slider;
    public Text displayText;
    Scene current_scene;
    private static float total_scenes = 6;
    private static int prog = 0;

    
    // Create a property to handle the slider's value
    private float currentValue = 0f;
    public float CurrentValue {
        get {
            return currentValue;
        }
        set {
            currentValue = get_scene_percent();
            slider.value = currentValue;
            displayText.text = (slider.value * 100).ToString("0.00") + "%";
        }
    }

    // Use this for initialization
    void Awake() {
        current_scene = SceneManager.GetActiveScene();
        CurrentValue = get_scene_percent();
    }

    public float get_scene_percent(){

        Debug.Log(current_scene.name);
        if(current_scene.name == "Reddit"){
            prog = Mathf.Max(prog,0);
        } else if(current_scene.name == "Message2"){
            prog = Mathf.Max(prog,2);
        }else if(current_scene.name == "Message1"){
            prog = Mathf.Max(prog,1);
        }else if(current_scene.name == "Message3"){
            prog = Mathf.Max(prog,3);
        }else if(current_scene.name == "Message4"){
            prog = Mathf.Max(prog,4);
        }else if(current_scene.name == "Message5"){
            prog = Mathf.Max(prog,5);
        }else if(current_scene.name == "Message6"){
            prog = Mathf.Max(prog,6);
        }
        return prog/total_scenes;
    }
    
    public void resetProgress() {
      prog = 0;
    }
}


