using System;
using System.Windows.Forms;
using User_Administration__For_Press_RFID_.Classes;
using User_Administration__For_Press_RFID_.Forms.MessageBoxes;
using VisualInspection.Utils.Net;

namespace User_Administration__For_Press_RFID_.Forms
{
    public partial class AddUsers : Form
    {
        MySQLDatabase mySQLDatabase;

        string ErrorTitle;
        private string[] Errors = new string[6];

        public AddUsers(MySQLDatabase MySQLDatabase)
        {
            InitializeComponent();

            mySQLDatabase = MySQLDatabase;

            Translator.LanguageChanged += Translate;
        }

        private void Translate(object sender, Language e)
        {
            if (Translator.Language == Language.CZ)
            {
                //-------------------------------------------------------------------
                //*************************Texty Obrazovky***************************
                //-------------------------------------------------------------------

                lblTextPersonalID.Text =            "Osobní Číslo";
                lblTextFirstName.Text =             "Jméno";
                lblTextLastName.Text =              "Příjmení";
                lblTextRFIFID.Text =                "Id Karty";
                lblTextPermissionGroupList.Text =   "Seznam Skupin Oprávnění";
                btnClearParameters.Text =           "Vyčistit Parametry";
                btnAddToDatabase.Text =             "Přidat do Databáze";

                //-------------------------------------------------------------------
                //*****************************Errory*********************************
                //-------------------------------------------------------------------

                ErrorTitle = "Chyba Uživatelského Vstupu";
                Errors[0] = "Osobní číslo musí být číslo!!!";
                Errors[1] = "Jméno může obsahovat pouze písmena. např. Jan, Jana";
                Errors[2] = "Příjmení může obsahovat pouze písmena. např. Novák, Nováková";
                Errors[3] = "Id přístupové karty není ve správném formátu HEX. např. 1D8CE6A";
                Errors[4] = "Uživatelská skupina musí být vyplněné!!!";

            }
            else if (Translator.Language == Language.ENG)
            {
                //-------------------------------------------------------------------
                //***************************Form Texts******************************
                //-------------------------------------------------------------------

                lblTextPersonalID.Text =            "Personal ID";
                lblTextFirstName.Text =             "First Name";
                lblTextLastName.Text =              "Last Name";
                lblTextRFIFID.Text =                "RFID Card ID";
                lblTextPermissionGroupList.Text =   "Permission Group List";
                btnClearParameters.Text =           "Clear Parameters";
                btnAddToDatabase.Text =             "Add to Database";

                //-------------------------------------------------------------------
                //*****************************Errors********************************
                //-------------------------------------------------------------------

                ErrorTitle = "User Input Error";
                Errors[0] = "Personal number must be number!!!";
                Errors[1] = "First name must contain only letters. e.g. John, Jane";
                Errors[2] = "Last name must contain only letters. e.g. Doe";
                Errors[3] = "Access card ID is not in a HEX format. e.g. 1D8CE6A";
                Errors[4] = "User permission group must be select!!!";

            }
        }

        private void AddUsers_VisibleChanged(object sender, EventArgs e)
        {
            LoadPermissions();
        }

        private void btnAddToDatabase_Click(object sender, EventArgs e)
        {
            if (CheckInputInfo() == false) return;

            UserNameAndID userNameAndID = new UserNameAndID(int.Parse(tbPersonalID.Text), tbFirstName.Text, tbLastName.Text);
            string RFIDID = tbRFIDID.Text;
            string PermissionGroup = lbPermissionGroupList.SelectedItem.ToString();

            UserInformations userInformations = new UserInformations(userNameAndID, RFIDID, PermissionGroup);

            if (mySQLDatabase.AddUserToDB(userInformations) == false) return;

            ClearParam();
            LoadPermissions();
        }

        private void btnClearParameters_Click(object sender, EventArgs e)
        {
            ClearParam();
            LoadPermissions();
        }

        private void LoadPermissions()
        {
            if (Visible && mySQLDatabase.Status == ClientStatus.Connected)
            {
                lbPermissionGroupList.Items.Clear();

                foreach (var PermissionGroup in mySQLDatabase.ReadPermissionGroupList())
                {
                    lbPermissionGroupList.Items.Add(PermissionGroup);
                }
            }
        }

        private bool CheckInputInfo()
        {
            if (TextBoxHelper.TbInputIsNumber(tbPersonalID) == false)
            {
                CustomMessageBox.ShowPopup(ErrorTitle, Errors[0]);
                return false;
            }
            if (TextBoxHelper.TbInputIsText(tbFirstName) == false)
            {
                CustomMessageBox.ShowPopup(ErrorTitle, Errors[1]);
                return false;
            }
            if (TextBoxHelper.TbInputIsText(tbLastName) == false)
            {
                CustomMessageBox.ShowPopup(ErrorTitle, Errors[2]);
                return false;
            }
            if (TextBoxHelper.TbInputIsHex(tbRFIDID) == false)
            {
                CustomMessageBox.ShowPopup(ErrorTitle, Errors[3]);
                return false;
            }
            if(lbPermissionGroupList.SelectedItem.ToString() == null || lbPermissionGroupList.SelectedItem.ToString() == "")
            {
                CustomMessageBox.ShowPopup(ErrorTitle, Errors[4]);
                return false;
            }
            return true;
        }

        private void ClearParam()
        {
            tbPersonalID.Text = "";
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbRFIDID.Text = "";
        }
    }
}
