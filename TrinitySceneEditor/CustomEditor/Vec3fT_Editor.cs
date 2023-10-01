using System.ComponentModel;
using System.Drawing.Design;
using TrinitySceneEditor.CustomEditor;

[Editor(typeof(Vec3fT_Editor), typeof(UITypeEditor))]
[TypeConverter(typeof(ExpandableObjectConverter))]
public partial class Vec3fT
{
    public override string ToString()
    {
        return $"X: {X}; Y: {Y}; Z:{Z}";
    }
}

namespace TrinitySceneEditor.CustomEditor
{
    class Vec3fT_Editor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.None;
        }
    }
}
