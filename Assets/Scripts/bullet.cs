﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    float speed = 3f;
    float TimetoDisable = 10f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SetDisable());
    }

    // Update is called once per frame      
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    IEnumerator SetDisable()
    {
        yield return new WaitForSeconds(TimetoDisable);
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(SetDisable());
        gameObject.SetActive(false);
    }
}
