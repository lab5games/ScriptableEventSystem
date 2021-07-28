using UnityEngine;
using UnityEngine.Events;

namespace Lab5Games.Events
{
    [System.Serializable]
    public class UnityVec3Event : UnityEvent<Vector3> { }

    [CreateAssetMenu(fileName = "New Vec3 Event", menuName = "Lab5Games/Events/Vec3 Event")]
    public class Vec3Event : ScriptalbeEvent<Vector3> { }
}
