using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnAndDespawnCups : MonoBehaviour
{
    public GameObject cub;

    private Button _button;

    void Awake()
    {
        _button = GetComponent<Button>();
    }
}
