using UnityEngine;

namespace ResourceSystem.Data
{
    public class ResourceViewService : ScriptableObject
    {
        #region Singleton

        private static ResourceViewService instance;

        public static ResourceViewService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ResourceViewService();
                }

                return instance;
            }// Hello World
        }
        #endregion

        private const string DATA_PATH = "ResourcesViewDataSO";
        private readonly ResourcesViewDataSO _viewData;

        public ResourceViewService()
        {
            _viewData = Resources.Load(DATA_PATH) as ResourcesViewDataSO; //ToDo Move to load service
        }

        public bool TryGetActiveIcon(ResourceType resourceType, out Sprite icon)
        {
            icon = null;
            if (ResourceDataProvider.TryGetResourceData(resourceType, _viewData,
                    out ResourceViewData resourceViewData))
            {
                icon = resourceViewData.ActiveStateIcon;
                return true;
            }
            return false;
        }
        public bool TryGetDecayIcon(ResourceType resourceType, out Sprite icon)
        {
            icon = null;
            if (ResourceDataProvider.TryGetResourceData(resourceType, _viewData,
                    out ResourceViewData resourceViewData))
            {
                icon = resourceViewData.DecayStateIcon;
                return true;
            }
            return false;
        }

    }
}