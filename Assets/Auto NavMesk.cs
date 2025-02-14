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

    // Start is called before the first frame update
    void Start()
    {
        navMeshSurface.BuildNavMesh();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RefreshMesh();
        }
    }

    void RefreshMesh()
    {
        navMeshSurface.BuildNavMesh();
    }
   
}
