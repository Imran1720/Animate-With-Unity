using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject uiPannel;

    private void Start()
    {
        uiPannel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            UpdateUIVisibility();
        }
    }

    public void UpdateUIVisibility()
    {
        uiPannel.SetActive(!uiPannel.activeInHierarchy);
    }
}
