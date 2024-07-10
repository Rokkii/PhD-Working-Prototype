using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadTacticalPlay : MonoBehaviour
{
    [SerializeField] GameObject initial;
    [SerializeField] List<string> crouchers;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        if (initial != null)
        {
            // Get all npc movements
            foreach(npcMovement npc in initial.GetComponentsInChildren<npcMovement>())
            {
                // Find player name
                Transform finalPos = transform.Find(npc.transform.parent.name).Find(npc.transform.name);
                    //findChild(getRootName(npc.transform));
                // Move npc to new position
                npc.objectMovingTo = finalPos.gameObject;

                if (crouchers.Contains(npc.transform.name))
                    npc.playerCrouched = true;
                else
                    npc.playerCrouched = false;
            }
        }
    }

    private Transform findChild(string name)
    {
        string[] names = name.Split("_@_");
        Transform parent = transform.Find(names[0]);
        Transform result = parent.Find(names[1]);
        return result;
    }

    private string getRootName(Transform t)
    {
        Transform temp = t;
        Transform result = t;
        print(temp.name);
        while(temp.name != "Teammates" && temp.name != "Opponents")
        {
            result = temp;
            temp = temp.parent;
        }
        return temp.name+"_@_"+result.name;
    }
}
