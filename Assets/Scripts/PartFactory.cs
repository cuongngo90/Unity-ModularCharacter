using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PartFactory : MonoBehaviour {

	public GameObject mainCharacter;
	public Transform part;
	private List<GameObject> list;
	// Use this for initialization
	void Start () {
        if (part != null)
            list = SkinnedMeshTools.AddSkinnedMeshTo(mainCharacter, part);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
