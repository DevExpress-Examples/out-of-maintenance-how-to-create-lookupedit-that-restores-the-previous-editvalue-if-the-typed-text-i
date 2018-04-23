using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Registrator;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;

namespace Sample
{
    [UserRepositoryItem("RegisterCustomLookUpEdit")]
    public class RepositoryItemCustomLookUpEdit : RepositoryItemLookUpEdit
    {
        static RepositoryItemCustomLookUpEdit() { RegisterCustomLookUpEdit(); }
        public RepositoryItemCustomLookUpEdit() { }
        public const string CustomLookUpEditName = "CustomLookUpEdit";
        public override string EditorTypeName { get { return CustomLookUpEditName; } }
        public static void RegisterCustomLookUpEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomLookUpEditName,
              typeof(CustomLookUpEdit), typeof(RepositoryItemCustomLookUpEdit),
              typeof(LookUpEditViewInfo), new ButtonEditPainter(), true));
        }
    }


    public class CustomLookUpEdit : LookUpEdit
    {
        static CustomLookUpEdit() { RepositoryItemCustomLookUpEdit.RegisterCustomLookUpEdit(); }
        public CustomLookUpEdit() : base() { }
        protected object beforeSearchEditValue;
        public override string EditorTypeName { get { return RepositoryItemCustomLookUpEdit.CustomLookUpEditName; } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomLookUpEdit Properties { get { return base.Properties as RepositoryItemCustomLookUpEdit; } }

        protected override void ProcessFindItem(KeyPressHelper helper, char pressedKey)
        {
            if (helper.PrevText == "" && helper.Text != "")
                beforeSearchEditValue = EditValue;
            base.ProcessFindItem(helper, pressedKey);
            if (helper.PrevText != "" && helper.Text == "")
                EditValue = beforeSearchEditValue;
        }
    }

}
