using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class chage_Scene : MonoBehaviour
{

    public void change_sene(string scenename) {
        Application.LoadLevel(scenename);
    }
}