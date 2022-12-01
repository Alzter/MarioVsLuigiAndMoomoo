using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VersionNamer : MonoBehaviour {
    void Start() {
        GetComponent<TMP_Text>().text = "Mod version: v" + Application.version + "\nGame version: v1.7.1.0-beta";
    }
}
