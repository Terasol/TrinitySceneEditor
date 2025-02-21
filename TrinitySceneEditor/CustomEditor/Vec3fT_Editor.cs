using System.ComponentModel;
using System.Drawing.Design;
using TrinitySceneEditor;
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
namespace gfl.math.fb
{
    [Editor(typeof(Vec3fT_Editor), typeof(UITypeEditor))]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public partial class Vector3fT
    {
        public override string ToString()
        {
            return $"X: {X}; Y: {Y}; Z:{Z}";
        }
    }
    [Editor(typeof(Vec3fT_Editor), typeof(UITypeEditor))]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public partial class Vector3frotT
    {
        public override string ToString()
        {
            if (Settings.Convert_Rad_to_Degree)
                return $"X: {TrinitySceneEditor.Math.ConvertRadiansToDegrees(X)}; Y: {TrinitySceneEditor.Math.ConvertRadiansToDegrees(Y)}; Z:{TrinitySceneEditor.Math.ConvertRadiansToDegrees(Z)}";
            else
                return $"X: {X}; Y: {Y}; Z:{Z}";
        }
    }
}
namespace TrinitySceneEditor.CustomEditor
{
    class Vec3fT_Editor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext? context) => UITypeEditorEditStyle.None;
    }
}
