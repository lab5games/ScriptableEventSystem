using UnityEngine;
using UnityEngine.Events;

namespace Lab5Games.Events
{
    [System.Serializable]
    public struct Void { }

    [System.Serializable]
    public class UnityVoidEvent : UnityEvent<Void> { }

    [CreateAssetMenu(fileName ="New Void Event", menuName ="Lab5Games/Events/Void Event")]
    public class VoidEvent : ScriptalbeEvent<Void>
    {
        readonly Void data = new Void();

        public void Raise() => Raise(data);
    }
}
