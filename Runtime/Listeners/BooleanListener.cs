using UnityEngine;
using UnityEngine.Events;

namespace Lab5Games.Events
{
    public class BooleanListener : ScriptalbeEventListener<bool, BooleanEvent, UnityBooleanEvent>
    {
        public override void OnEvent(bool item)
        {
            base.OnEvent(item);
        }
    }
}
