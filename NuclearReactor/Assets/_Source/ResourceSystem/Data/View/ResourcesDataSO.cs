using System.Collections.Generic;
using UnityEngine;

namespace ResourceSystem.Data
{
    [CreateAssetMenu(fileName = "New Resources Data", menuName = "SO/New Resources Data")]
    public class ResourcesDataSO : ScriptableObject
    {
        [field: SerializeField] public List<ResourceData> ResourcesViewData { get; private set; }
    }
}

