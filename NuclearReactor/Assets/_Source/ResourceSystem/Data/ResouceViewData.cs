using UnityEngine;

namespace ResourceSystem.Data
{
    public class ResourceViewData
    {
        [field: SerializeField] public ResourceType ResourceType { get; private set; }
        [field: SerializeField] public Sprite ActiveStateIcon { get; private set; }
        [field: SerializeField] public Sprite DecayStateIcon { get; private set; }
    }
}