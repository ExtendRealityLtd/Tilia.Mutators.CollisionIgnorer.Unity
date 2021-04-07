namespace Tilia.Mutators.CollisionIgnorer.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string project = "Mutators/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation + project;

        private const string package = "io.extendreality.tilia.mutators.collisionignorer.unity";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabCollisionIgnorer = "Mutators.CollisionIgnorer";

        [MenuItem(menuItemRoot + prefabCollisionIgnorer, false, priority)]
        private static void AddCollisionIgnorer()
        {
            string prefab = prefabCollisionIgnorer + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }
    }
}