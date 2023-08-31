using Titan.TrinityScene;

namespace TrinitySceneEditor
{
    public class EntryFileMapping
    {
        public SceneFile SceneFile { get; }
        public SceneEntryT SceneEntryT { get; }

        public EntryFileMapping(SceneFile sceneFile, SceneEntryT sceneEntryT)
        {
            SceneFile = sceneFile;
            SceneEntryT = sceneEntryT;
        }
    }
}
