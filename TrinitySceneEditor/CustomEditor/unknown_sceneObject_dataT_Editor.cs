using System.ComponentModel;
using System.Drawing.Design;
using TrinitySceneEditor.CustomEditor;

namespace Titan.TrinityScene
{
    [Editor(typeof(unknown_sceneObject_dataT_Editor), typeof(UITypeEditor))]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public partial class unknown_sceneObject_dataT
    {
        public override string ToString()
        {
            return $"Unk1: {{{Unk1}}}; Unk2: {Unk2}";
        }
    }
}

namespace TrinitySceneEditor.CustomEditor
{
    class unknown_sceneObject_dataT_Editor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.None;
        }
    }
}
