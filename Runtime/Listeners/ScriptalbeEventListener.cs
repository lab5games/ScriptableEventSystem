using UnityEngine;
using UnityEngine.Events;

namespace Lab5Games.Events
{
    public interface IScriptableEventListener<T>
    {
        void OnEvent(T item);
    }

    public abstract class ScriptalbeEventListener<T, E, R> : MonoBehaviour, IScriptableEventListener<T> where E : ScriptalbeEvent<T> where R : UnityEvent<T>
    {
        [SerializeField] private E gameEvent;

        public E GameEvent
        {
            get { return gameEvent; }
            set { gameEvent = value; }
        }

        [SerializeField] private R response; 

        public R Response
        {
            get { return response; }
        }

        private void OnEnable()
        {
            if (GameEvent == null)
                return;

            GameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            if (GameEvent == null)
                return;

            GameEvent.UnregisterListener(this);
        }

        public virtual void OnEvent(T item)
        {
            if(response != null)
            {
                response.Invoke(item);
            }
        }
    }
}
