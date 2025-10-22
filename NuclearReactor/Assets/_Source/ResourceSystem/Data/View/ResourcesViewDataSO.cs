using System.Collections.Generic;
using UnityEngine;

namespace ResourceSystem.Data
{
    [CreateAssetMenu(fileName = "New Resources View Data", menuName = "SO/New Resources View Data")]
    public class ResourcesViewDataSO : ScriptableObject
    {
        [field: SerializeField] public List<ResourceViewData> ResourcesViewData { get; private set; }
    }
}