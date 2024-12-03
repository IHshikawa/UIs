using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialangleacquisition : MonoBehaviour
{
    public GameObject dial;
    public TextMeshProUGUI textmesh;
    private Vector3 dial_localrad = Vector3.zero; // 修正: Vector3.zeroで初期化

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Quaternionからオイラー角を取得
        dial_localrad = dial.transform.localRotation.eulerAngles;
        
        // テキストにY軸の回転角度を表示
        textmesh.text = "Dial rad : \n     " + dial_localrad.y.ToString("F2"); // 小数点2桁で表示
    }
}
