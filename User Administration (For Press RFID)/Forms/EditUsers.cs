using System;
using System.Windows.Forms;
using User_Administration__For_Press_RFID_.Classes;
using User_Administration__For_Press_RFID_.Forms.MessageBoxes;
using VisualInspection.Utils.Net;

namespace User_Administration__For_Press_RFID_.Forms
{
    public partial class EditUsers : Form
    {
        MySQLDatabase mySQLDatabase;
        UserInformations UserInformations;
        UserInformations OldUserInformations;

        private string InputErrorTitle;
        private string ErrorTitle;
        private string[] Errors = new string[7];

        public EditUsers(MySQLDatabase MySQLDatabase)
        {
            InitializeComponent();

            mySQLDatabase = MySQLDatabase;

            Translator.LanguageChanged += Translate;

            EnableNewRfidID(false);
        }

        private void Translate(object sender, Language e)
        {
            if (Translator.Language == Language.CZ)
            {
                //-------------------------------------------------------------------
                //*************************Texty Obrazovky***************************
                //-------------------------------------------------------------------

                lblTextUserList.Text =          "Seznam Uživatelů";
                lblTextPersonalID.Text =        "Osobní Číslo";
                lblTextFirstName.Text =         "Jméno";
                lblTextLastName.Text =          "Příjmení";
                rdbNewRFIDID.Text =             "Nové RFID ID";
                rdbOldRFIDID.Text =             "Staré RFID ID";
                lblTextRFIDID.Text =            "Číslo karty";
                lblTextActualUserGroup.Text =   "Aktuální uživatelská skupina:";
                lblTextPermissionGroupList.Text = "Seznam Skupin Oprávnění";
                btnClearParameters.Text =       "Vyčistit Parametry";
                btnSaveUser.Text =              "Přidat do Databáze";

                //-------------------------------------------------------------------
                //*****************************Errory*********************************
                //-------------------------------------------------------------------

                InputErrorTitle = "Chyba Uživatelsého Vstupu";
                ErrorTitle = "Chyba";
                Errors[0] = "Osobní číslo musí být číslo!!!";
                Errors[1] = "Jméno může obsahovat pouze písmena. např. Jan, Jana";
                Errors[2] = "Příjmení může obsahovat pouze písmena. např. Novák, Nováková";
                Errors[3] = "Heslo musí být zadané!!!";
                Errors[4] = "Oprávnění uživatele musí být vyplněné!!!";
                Errors[6] = "Osobní číslo nemá správný formát.";

            }
            else if (Translator.Language == Language.ENG)
            {
                //-------------------------------------------------------------------
                //***************************Form Texts******************************
                //-------------------------------------------------------------------

                lblTextUserList.Text =          "Users List";
                lblTextPersonalID.Text =        "Personal ID";
                lblTextFirstName.Text =         "First Name";
                lblTextLastName.Text =          "Last Name";
                rdbNewRFIDID.Text =             "New RFID ID";
                rdbOldRFIDID.Text =             "Old RFID ID";
                lblTextRFIDID.Text =          "RFID Card ID";
                lblTextActualUserGroup.Text = "Actual User Group:";
                lblTextPermissionGroupList.Text = "Permission Group List";
                btnClearParameters.Text =       "Clear Parameters";
                btnSaveUser.Text =              "Add to Database";

                //-------------------------------------------------------------------
                //*****************************Errors********************************
                //-------------------------------------------------------------------

                InputErrorTitle = "User Input Error";
                ErrorTitle = "Error";
                Errors[0] = "Personal number must be number!!!";
                Errors[1] = "First name must contain only letters. e.g. John, Jane";
                Errors[2] = "Last name must contain only letters. e.g. Doe";
                Errors[3] = "New Card RFID must be in corect HEX format. e.g 1A2E3D7";
                Errors[4] = "User permission must not be empty!!!";
                Errors[6] = "Personal ID is in a wrong format.";
            }
        }

        private void EditUsers_VisibleChanged(object sender, EventArgs e)
        {
            LoadUsers();
            ClearParam();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbUsersList.Items.Count; i++)
            {
                if (StringHelper.SearchTextInString(lbUsersList.Items[i].ToString(), tbSearchUser.Text))
                {
                    lbUsersList.SelectedIndex = i;
                    return;
                }
            }
        }

        private void btnClearParameters_Click(object sender, EventArgs e)
        {
            LoadUsers();
            ClearParam();
        }

        private void lbUsersList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbUsersList.SelectedItem == null || lbUsersList.SelectedItem.ToString() == "") return;

            ClearParam();
            EnableNewRfidID(false);


            string[] IDAndName = lbUsersList.SelectedItem.ToString().Split(" | ");

            if (StringHelper.CheckIfTextIsNumber(IDAndName[0]) == false)
            {
                CustomMessageBox.ShowPopup(ErrorTitle, Errors[6]);
                return;
            }

            UserInformations = mySQLDatabase.ReadUserInformation(int.Parse(IDAndName[0]));

            tbPersonalID.Text = UserInformations.NameAndID.ID.ToString();
            tbFirstName.Text = UserInformations.NameAndID.FirstName;
            tbLastName.Text = UserInformations.NameAndID.LastName;
            lblActualUserGroup.Text = UserInformations.PermissionGroup;

            LoadPermissions();

            lbPermissionGroupList.Items.Remove(UserInformations.PermissionGroup);

            OldUserInformations = UserInformations;
        }

        private void rbdPasswordSel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNewRFIDID.Checked == false && rdbOldRFIDID.Checked) EnableNewRfidID(false);
            else EnableNewRfidID(true);
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (CheckInputInfo() == false) return;

            UserNameAndID userNameAndID = new UserNameAndID(int.Parse(tbPersonalID.Text), tbFirstName.Text, tbLastName.Text);
            string password;

            if (rdbNewRFIDID.Checked)
            {
                password = PasswordHasher.HashPassword(tbRFIDID.Text);
            }
            else
            {
                //password = OldUserInformations.Password;
            }

            //UserInformations = new UserInformations(userNameAndID, password, perPick.GetPickedPermissions());

            //mySQLDatabase.UpdateUserInformations(UserInformations, OldUserInformations);

            LoadUsers();
            ClearParam();
            //perPick.Reset();
        }

        private void LoadUsers()
        {
            if (Visible && mySQLDatabase.Status == ClientStatus.Connected)
            {
                lbUsersList.Items.Clear();
                LoadPermissions();

                foreach (var UserName in mySQLDatabase.ReadNamesAndIDs())
                {
                    lbUsersList.Items.Add(UserName.ID.ToString() + " | " + UserName.FirstName + " " + UserName.LastName);
                }
            }
        }

        private bool CheckInputInfo()
        {
            if (TextBoxHelper.TbInputIsNumber(tbPersonalID) == false)
            {
                CustomMessageBox.ShowPopup(InputErrorTitle, Errors[0]);
                return false;
            }
            if (TextBoxHelper.TbInputIsText(tbFirstName) == false)
            {
                CustomMessageBox.ShowPopup(InputErrorTitle, Errors[1]);
                return false;
            }
            if (TextBoxHelper.TbInputIsText(tbLastName) == false)
            {
                CustomMessageBox.ShowPopup(InputErrorTitle, Errors[2]);
                return false;
            }
            if (rdbNewRFIDID.Checked)
            {
                if (TextBoxHelper.TbInputIsHex(tbRFIDID))
                {
                    CustomMessageBox.ShowPopup(InputErrorTitle, Errors[3]);
                    return false;
                }
            }
            if (lbUsersList.SelectedItems.ToString() == null || lbUsersList.SelectedItem.ToString() == "")
            {
                CustomMessageBox.ShowPopup(InputErrorTitle, Errors[4]);
                return false;
            }
            return true;
        }

        private void EnableNewRfidID(bool Enable)
        {
            tbRFIDID.ReadOnly = !Enable;

            if (Enable)
            {
                tlp1.Visible = true;
            }
            else
            {
                tlp1.Visible = false;
            }
        }

        private void ClearParam()
        {
            tbPersonalID.Text = "";
            tbFirstName.Text = "";
            tbLastName.Text = "";
            rdbOldRFIDID.Checked = true;
            tbRFIDID.Text = "";
            lblActualUserGroup.Text = "";
            UserInformations = null;
            OldUserInformations = null;
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
    }
}
