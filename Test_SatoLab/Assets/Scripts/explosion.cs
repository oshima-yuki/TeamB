using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    private Rigidbody rb;
    public float radius = 10.0f;
    public float power = 150.0f;
    public string Tagname;
    public float coefficient;   // 空気抵抗係数
    public float speed;         // 爆風の速さ

    void OnTriggerStay(Collider col)
    {
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);

        if (col.attachedRigidbody == null)
        {
            return;
        }

        foreach (Collider hit in colliders)
        {
            // 力を及ぼしたいオブジェクトにRigidbodyが付いていることが必要（ポイント）
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
            {
                // 風速計算
                var velocity = (col.transform.position - transform.position).normalized * speed;

                // 風力与える
                col.GetComponent<Rigidbody>().AddForce(coefficient * velocity);
            }
            
            
        }
    }
}
