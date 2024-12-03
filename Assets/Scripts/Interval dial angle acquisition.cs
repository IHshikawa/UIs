using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Intervaldialangleacquisition : MonoBehaviour
{
    // 360度をN個のメモリに分けて動くダイヤル
    private int N, current_number;
    public GameObject Interval_dial;
    public GameObject grab_object;
    public TextMeshProUGUI textmesh;
    private Vector3 grab_localrad = Vector3.zero; // 持つオブジェクトの角度
    private float dial_angle; // ダイヤル本体のY軸角度

    // Start is called before the first frame update
    void Start()
    {
        N = 18; // メモリの数を初期化
    }

    // Update is called once per frame
    void Update()
    {
        // grabオブジェクトの角度をオイラー角で取得
        grab_localrad = grab_object.transform.localRotation.eulerAngles;

        // ダイヤルの角度をN分割して判定
        for (int i = 0; i < N; i++)
        {
            float lowerBound = i * (360f / N);
            float upperBound = (i + 1) * (360f / N);

            if (lowerBound <= grab_localrad.y && grab_localrad.y < upperBound)
            {
                dial_angle = lowerBound;
                current_number = i;
                break; // 一致したらループを抜ける
            }
        }

        // ダイヤルの回転を反映
        Interval_dial.transform.localRotation = Quaternion.Euler(0, dial_angle, 0);

        // テキストにY軸の回転角度と現在のダイヤル番号を表示
        textmesh.text = "Dial rad:\n     " + grab_localrad.y.ToString("F2") + "\n\nCurrent number: " + current_number;
    }
}

