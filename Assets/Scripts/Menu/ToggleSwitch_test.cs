using UnityEngine;
using UnityEngine.UI;

public class ToggleSwitch_test : MonoBehaviour
{
    public GameObject cube;
    public Toggle toggleStop;
    public Toggle toggleUp;
    public Toggle toggleDown;
    public Toggle toggleRight;
    public Toggle toggleLeft;
    private Vector3 cube_position;

    void Start()
    {
        // Toggleの初期状態設定
        toggleStop.isOn = true;  // 起動時にToggleStopをONにする
        
        // Toggleの状態変化を検知するイベントを設定
        toggleStop.onValueChanged.AddListener((isOn) => OnToggleChanged(toggleStop, "Cube_Stop", isOn));
        toggleUp.onValueChanged.AddListener((isOn) => OnToggleChanged(toggleUp, "Cube_Up", isOn));
        toggleDown.onValueChanged.AddListener((isOn) => OnToggleChanged(toggleDown, "Cube_Down", isOn));
        toggleRight.onValueChanged.AddListener((isOn) => OnToggleChanged(toggleRight, "Cube_Right", isOn));
        toggleLeft.onValueChanged.AddListener((isOn) => OnToggleChanged(toggleLeft, "Cube_Left", isOn));
    }

    void OnToggleChanged(Toggle toggle, string toggleName, bool isOn)
    {
        if (isOn)
        {
            Debug.Log($"{toggleName} toggle is now ON.");
        }
        else
        {
            Debug.Log($"{toggleName} toggle is now OFF.");
        }
    }

    void Update()
    {
        cube_position = cube.transform.localPosition;

        if (toggleUp.isOn)
        {
            cube_position.y += 0.01f;
        }
        if (toggleDown.isOn)
        {
            cube_position.y -= 0.01f;
        }
        if (toggleRight.isOn)
        {
            cube_position.x += 0.01f;
        }
        if (toggleLeft.isOn)
        {
            cube_position.x -= 0.01f;
        }
        
        cube.transform.localPosition = cube_position;
    }
}
