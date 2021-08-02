using UnityEngine;

namespace Lab5Games.Events
{
    public abstract class ScriptableEventRaiser<T, E> : MonoBehaviour where E : ScriptalbeEvent<T>
    {
        [SerializeField] protected E gameEvent;

        public virtual void Raise(T item)
        {
            gameEvent.Raise(item);
        }
    }
}
