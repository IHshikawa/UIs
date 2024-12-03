using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Gethorizontalleverangle : MonoBehaviour
{
    public GameObject ob;
    public TextMeshProUGUI textmesh;
    private Vector3 radians;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ob_position = ob.transform.localPosition; // 修正: localPosition
        radians.x = 0;
        radians.z = 0;

        // atan2を使用して安定した計算を行う
        radians.y = (float)(-1*(Math.Atan2(ob_position.z, ob_position.x) * 180 / Math.PI  + 180)) ;

        // Quaternion.Eulerを使って回転を適用
        this.transform.localRotation = Quaternion.Euler(radians); // 修正: localRotation

        // textに角度を表示
        textmesh.text = "Lever rad : \n     " + (-radians.y).ToString("F2");
    }
}
