using UnityEngine;
using UnityEngine.Events;

namespace Lab5Games.Events
{
    [System.Serializable]
    public class UnityIntEvent : UnityEvent<int> { }

    [CreateAssetMenu(fileName = "New Int Event", menuName = "Lab5Games/Events/Int Event")]
    public class IntEvent : ScriptalbeEvent<int> { }
}
