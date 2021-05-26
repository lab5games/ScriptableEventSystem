using UnityEngine;
using System.Collections.Generic;

namespace Lab5Games.Events
{
    public abstract class ScriptalbeEvent<T> : ScriptableObject
    {
        private readonly List<IScriptableEventListener<T>> eventListeners = new List<IScriptableEventListener<T>>();

        public void Raise(T item)
        {
            for(int i=eventListeners.Count-1; i>=0; i--)
            {
                eventListeners[i].OnEvent(item);
            }
        }

        public void RegisterListener(IScriptableEventListener<T> listener)
        {
            if(!eventListeners.Contains(listener))
            {
                eventListeners.Add(listener);
            }
        }

        public void UnregisterListener(IScriptableEventListener<T> listener)
        {
            if(eventListeners.Contains(listener))
            {
                eventListeners.Remove(listener);
            }
        }
    }
}
