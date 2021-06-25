using UnityEngine;
using UnityEngine.Events;

namespace Lab5Games.Events
{
    [System.Serializable]
    public class UnityBooleanEvent : UnityEvent<bool> { }

    [CreateAssetMenu(fileName = "New Boolean Event", menuName = "Lab5Games/Events/Boolean Event")]
    public class BooleanEvent : ScriptalbeEvent<bool> { }
}
