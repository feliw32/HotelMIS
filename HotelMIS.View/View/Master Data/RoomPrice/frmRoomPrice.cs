using System;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using HotelMIS.Model;
using System.Collections.Generic;
using DevExpress.Data.Filtering;

namespace HotelMIS.View
{
    public partial class frmRoomPrice : Form
    {
        private bool isValidForm = true;
        private List<ValidationClass> oErrorCollection;
        private NestedUnitOfWork nSession;
        private RoomPrice oRoomPrice;
        private UnitOfWork oSession;

        public frmRoomPrice(UnitOfWork prmSession, RoomPrice prmRoomPrice)
        {
            InitializeComponent();
            oSession = prmSession;
            nSession = oSession.BeginNestedUnitOfWork();
            oRoomPrice = nSession.GetNestedObject<RoomPrice>(prmRoomPrice);
            if (oRoomPrice == null)
            {
                oRoomPrice = new RoomPrice(nSession);
            }
            bs.DataSource = oRoomPrice;
            LoadCombo();
            oErrorCollection = new List<ValidationClass>();
        }

        public frmRoomPrice(UnitOfWork prmSession, Room prmRoom)
        {
            InitializeComponent();
            oSession = prmSession;
            nSession = oSession.BeginNestedUnitOfWork();
            if (oRoomPrice == null)
            {
                oRoomPrice = new RoomPrice(nSession);
            }
            bs.DataSource = oRoomPrice;
            oRoomPrice.Room = nSession.GetNestedObject(prmRoom);
            LoadCombo();
            oErrorCollection = new List<ValidationClass>();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            nSession.Dispose();
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nSession.RollbackTransaction();
            ResetData();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nSession.RollbackTransaction();
            ResetData();
            this.Close();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (FormHelper.QuestionMessage("Are you sure want to save this data ?"))
                {
                    ValidateForm();
                    if (isValidForm)
                    {
                        bs.EndEdit();
                        nSession.CommitChanges();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                FormHelper.ErrorMessage(ex.Message);
            }
        }

        private void ClearComboSelection(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "btnDelete")
                switch (((LookUpEdit)sender).Name)
                {
                    case "luPriceType":
                        oRoomPrice.PriceType = null;
                        break;
                }
        }

        private void LoadCombo()
        {
            luPriceType.Properties.DataSource = oRoomPrice.AvailablePriceType;
        }

        private void ResetData()
        {
            if (nSession.IsNewObject(oRoomPrice))
            {
                oRoomPrice.PriceType = null;
            }
            else
            {
                oRoomPrice.Reload();
            }
        }

        #region "Form Validation"

        private void CheckPriceType()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if ((Guid)luPriceType.EditValue == new Guid())
            {
                oValidationClass.ErrorType = "Required";
                oValidationClass.Description = "Room Type is required";
                oErrorCollection.Add(oValidationClass);
            }
            if (nSession.FindObject<RoomPrice>(PersistentCriteriaEvaluationBehavior.InTransaction,
                GroupOperator.And(new BinaryOperator("Oid", oRoomPrice.Oid,BinaryOperatorType.NotEqual), new BinaryOperator("Room.Oid", oRoomPrice.Room.Oid), new BinaryOperator("PriceType.Oid", oRoomPrice.PriceTypeOid))) != null)
            {
                oValidationClass.ErrorType = "Duplicate";
                oValidationClass.Description = "Price Type must be unique.";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void ValidateForm()
        {
            isValidForm = true;
            CheckPriceType();

            if (oErrorCollection.Count > 0)
            {
                isValidForm = false;
                string errMesg = string.Empty;
                foreach (ValidationClass obj in oErrorCollection)
                {
                    errMesg += obj.ErrorType + " | " + obj.Description + "\r\n";
                }
                MessageBox.Show(errMesg);
                oErrorCollection.Clear();
            }
        }

        #endregion "Form Validation"
    }
}