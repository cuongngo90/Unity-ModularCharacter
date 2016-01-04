using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[HideInInspector]
public class PartBuilder : MonoBehaviour {
    [SerializeField]
    private GameObject characterPrefab;

    [SerializeField]
    private GameObject mainBonesPrefab;

    [SerializeField]
    private List<GameObject> modularParts;

    public void BuildAllPart()
    {
        if (modularParts.Count > 0)
        {
            foreach (var part in modularParts)
            {
                GameObject dummyPart = Instantiate(mainBonesPrefab);
                dummyPart.name = part.name;

                ActiveOnlyMe(part.name);
                SkinnedMeshTools.AddSkinnedMeshTo(characterPrefab, dummyPart.transform, false);
                ActiveOnlyMe(part.name, false);
            }
        }
    }

    private void ActiveOnlyMe(string name, bool isActive = true)
    {
        GameObject me = characterPrefab.transform.FindChild(name).gameObject;

        if (me != null)
        {
            me.SetActive(isActive);
        }
    }
}
