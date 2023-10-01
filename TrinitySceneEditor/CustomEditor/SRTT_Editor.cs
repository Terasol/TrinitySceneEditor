using System.ComponentModel;
using System.Drawing.Design;
using TrinitySceneEditor.CustomEditor;

[Editor(typeof(SRTT_Editor), typeof(UITypeEditor))]
[TypeConverter(typeof(ExpandableObjectConverter))]
public partial class SRTT
{
    public override string ToString()
    {
        return $"S: {{{Scale}}}; R: {{{Rotation}}}; T:{{{Translation}}}";
    }
}

namespace TrinitySceneEditor.CustomEditor
{
    class SRTT_Editor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.None;
        }
    }
}
