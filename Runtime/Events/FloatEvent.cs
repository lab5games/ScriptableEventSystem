using UnityEngine;
using UnityEngine.Events;

namespace Lab5Games.Events
{
    [System.Serializable]
    public class UnityFloatEvent : UnityEvent<float> { }

    [CreateAssetMenu(fileName = "New Float Event", menuName = "Lab5Games/Events/Float Event")]
    public class FloatEvent : ScriptalbeEvent<float> { }
}
