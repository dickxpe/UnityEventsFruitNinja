using System.Collections.Generic;
using UltEvents;
using UnityEditor.Embree;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    List<GameObject> prefabs;

    [SerializeField]
    Transform parentToSpawnFrom;

    [SerializeField]
    float scaleFactor = 1f;


    [System.Serializable]
    public class GameObjectEvent : UltEvent<GameObject> { }


    [System.Serializable]
    public class RigidBodyEvent : UltEvent<Rigidbody> { }

    public GameObjectEvent onSpawnedGameObject;

    public RigidBodyEvent onSpawnedRigidBody;

    public void Spawn()
    {
        if (prefabs.Count > 0)
        {
            int i = Random.Range(0, prefabs.Count);
            GameObject go = Instantiate(prefabs[i], parentToSpawnFrom);
            go.transform.localScale *= scaleFactor;
            onSpawnedGameObject.Invoke(go);
            Rigidbody rb = go.GetComponent<Rigidbody>();
            if (rb)
            {
                onSpawnedRigidBody.Invoke(rb);
            }
        }
    }

}
