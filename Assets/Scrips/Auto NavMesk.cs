using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Unity.AI.Navigation;

public class AutoNavMesk : MonoBehaviour
{

    private NavMeshSurface navMeshSurface;

    private void Awake()
    {
        navMeshSurface = GetComponent<NavMeshSurface>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) { navMeshSurface.BuildNavMesh(); }
        
        if (Input.GetKeyDown(KeyCode.F)) { navMeshSurface.RemoveData(); }
    }

   
       
    

    
   
}
