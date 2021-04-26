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
            return 0;
        } else if(current_scene.name == "Snapchat" || current_scene.name == "Snapchat1a"){
            return 1/total_scenes;
        }else if(current_scene.name == "Instagram"){
            return 2/total_scenes;
        }else if(current_scene.name == "Reddit2"){
            return 3/total_scenes;
        }else if(current_scene.name == "Snapchat2" || current_scene.name == "Snapchat2a"){
            return 4/total_scenes;
        }else if(current_scene.name == "Instagram2"){
            return 5/total_scenes;
        }
        return 0;
    }
}


