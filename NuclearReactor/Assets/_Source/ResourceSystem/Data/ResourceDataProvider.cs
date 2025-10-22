namespace ResourceSystem.Data
{
    public static class ResourceDataProvider
    {
        public static bool TryGetResourceData(
            ResourceType resourceType,
            ResourcesViewDataSO resourcesViewDataSO,
            out ResourceViewData resourceViewData)
        {
            resourceViewData = null;
            foreach (var item in resourcesViewDataSO.ResourcesViewData)
            {
                if (resourceViewData.ResourceType == resourceType)
                {
                    resourceViewData = item;
                    return true;
                }
            }

            return false;
        }
    }
}