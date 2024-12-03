using UnityEngine;
using UnityEngine.UI;

public class ButtonSwitch_test : MonoBehaviour
{
    public GameObject cube;
    public Button buttonUp;
    public Button buttonDown;
    public Button buttonRight;
    public Button buttonLeft;
    
    private Vector3 cube_position;
    private bool isButtonUpPressed = false;
    private bool isButtonDownPressed = false;
    private bool isButtonRightPressed = false;
    private bool isButtonLeftPressed = false;

    void Start()
    {
        // 各ボタンのクリックイベントを設定
        buttonUp.onClick.AddListener(() => ToggleButtonState(ref isButtonUpPressed, "Up"));
        buttonDown.onClick.AddListener(() => ToggleButtonState(ref isButtonDownPressed, "Down"));
        buttonRight.onClick.AddListener(() => ToggleButtonState(ref isButtonRightPressed, "Right"));
        buttonLeft.onClick.AddListener(() => ToggleButtonState(ref isButtonLeftPressed, "Left"));
    }

    void ToggleButtonState(ref bool buttonState, string direction)
    {
        buttonState = !buttonState; // ボタンの状態をトグル
        if (buttonState)
        {
            Debug.Log($"{direction} button is pressed.");
        }
        else
        {
            Debug.Log($"{direction} button is released.");
        }
    }

    void Update()
    {
        cube_position = cube.transform.localPosition;

        if (isButtonUpPressed)
        {
            cube_position.y += 0.1f * Time.deltaTime;
        }
        if (isButtonDownPressed)
        {
            cube_position.y -= 0.1f * Time.deltaTime;
        }
        if (isButtonRightPressed)
        {
            cube_position.x += 0.1f * Time.deltaTime;
        }
        if (isButtonLeftPressed)
        {
            cube_position.x -= 0.1f * Time.deltaTime;
        }

        cube.transform.localPosition = cube_position;
    }
}
