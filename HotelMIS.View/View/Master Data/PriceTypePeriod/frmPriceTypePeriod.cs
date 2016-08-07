using System.Windows.Forms;
using DevExpress.XtraEditors;
using HotelMIS.Model;
using System;
using DevExpress.Xpo;
using System.Collections.Generic;
using DevExpress.Data.Filtering;

namespace HotelMIS.View
{
    public partial class frmPriceTypePeriod : Form
    {
        private bool isValidForm = true;
        private List<ValidationClass> oErrorCollection;
        private NestedUnitOfWork nSession;
        private PriceTypePeriod oPriceTypePeriod;
        private UnitOfWork oSession;

        public frmPriceTypePeriod(UnitOfWork prmSession,PriceTypePeriod prmPriceTypePeriod)
        {
            InitializeComponent();
            oSession = prmSession;
            nSession = oSession.BeginNestedUnitOfWork();
            oPriceTypePeriod = nSession.GetNestedObject<PriceTypePeriod>(prmPriceTypePeriod);
            if (oPriceTypePeriod == null)
            {
                oPriceTypePeriod = new PriceTypePeriod(nSession);
            }
            bs.DataSource = oPriceTypePeriod;
            oErrorCollection = new List<ValidationClass>();
        }

        public frmPriceTypePeriod(UnitOfWork prmSession, PriceType prmPriceType)
        {
            InitializeComponent();
            oSession = prmSession;
            nSession = oSession.BeginNestedUnitOfWork();
            if (oPriceTypePeriod == null)
            {
                oPriceTypePeriod = new PriceTypePeriod(nSession);
            }
            bs.DataSource = oPriceTypePeriod;
            oPriceTypePeriod.PriceType = nSession.GetNestedObject(prmPriceType);
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

        private void ResetData()
        {
            if (nSession.IsNewObject(oPriceTypePeriod))
            {
                oPriceTypePeriod.StartDate = DateTime.Now;
                oPriceTypePeriod.UntilDate = DateTime.Now;
                oPriceTypePeriod.Price = 0;
            }
            else
            {
                oPriceTypePeriod.Reload();
            }
        }

        #region "Form Validation"

        private void CheckStartDate()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (deStartDate.DateTime == new DateTime())
            {
                oValidationClass.ErrorType = "Rule";
                oValidationClass.Description = "Start Date is required.";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void CheckCrossingDate()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (deStartDate.DateTime == new DateTime())
            {
                return;
            }
            XPCollection<PriceTypePeriod> xpColl = new XPCollection<PriceTypePeriod>(PersistentCriteriaEvaluationBehavior.InTransaction,oSession,GroupOperator.And(new BinaryOperator("Oid",oPriceTypePeriod.Oid,BinaryOperatorType.NotEqual),new NullOperator("UntilDate"),new BinaryOperator("PriceType.Oid",oPriceTypePeriod.PriceType.Oid)));
            if (xpColl.Count > 0)
            {
                oValidationClass.ErrorType = "Rule";
                oValidationClass.Description = "To input new record, must assure other records already set Until Date.";
                oErrorCollection.Add(oValidationClass);
            }
            if (nSession.FindObject<PriceTypePeriod>(PersistentCriteriaEvaluationBehavior.InTransaction,
                GroupOperator.And(new BinaryOperator("Oid", oPriceTypePeriod.Oid, BinaryOperatorType.NotEqual), new BinaryOperator("PriceType.Oid", oPriceTypePeriod.PriceType.Oid),
                new BinaryOperator("UntilDate", oPriceTypePeriod.StartDate, BinaryOperatorType.GreaterOrEqual))) != null)
            {
                oValidationClass.ErrorType = "Rule";
                oValidationClass.Description = "Date is crossing with another record.";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void CheckUntilDate()
        {
            ValidationClass oValidationClass = new ValidationClass();
            if (deUntilDate.DateTime == new DateTime())
            {
                return;
            }
            if (deUntilDate.DateTime < deStartDate.DateTime)
            {
                oValidationClass.ErrorType = "Rule";
                oValidationClass.Description = "Until Date must be greater than Start Date.";
                oErrorCollection.Add(oValidationClass);
            }
        }

        private void ValidateForm()
        {
            isValidForm = true;
            CheckStartDate();
            CheckUntilDate();
            CheckCrossingDate();

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