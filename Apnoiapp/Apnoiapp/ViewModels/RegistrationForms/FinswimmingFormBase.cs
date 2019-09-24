using Apnoiapp.Models;
using Apnoiapp.Models.Forms;

namespace Apnoiapp.ViewModels.RegistrationForms
{
    public class FinswimmingFormBase : BaseViewModel
    {
        public FinswimmingFormBase()
        {
            UserCategoryLabel = "Ingrese edad para asignar su Categoría";
            Switch50Bf = false;
            Switch50Sf = false;
            Switch50Ap = false;
            Switch100Bf = false;
            Switch100Sf = false;
            Switch200Bf = false;
            Switch200Sf = false;
            Switch400Sf = false;
            Switch800Sf = false;
            Switch4x50Sf = false;
            Switch4x100Sf = false;
        }

        private TournamentModel _tournamentModel { get; set; }

        public TournamentModel TournamentModel
        {
            get => _tournamentModel;
            set { _tournamentModel = value; OnPropertyChanged(); }
        }

        private UserModel _userModel { get; set; }

        public UserModel UserModel
        {
            get => _userModel;
            set { _userModel = value; OnPropertyChanged(); }
        }

        private string _userName { get; set; }

        public string UserName
        {
            get => _userName;
            set { _userName = value; OnPropertyChanged(); }
        }

        private string _userFatherName { get; set; }

        public string UserFatherName
        {
            get => _userFatherName;
            set { _userFatherName = value; OnPropertyChanged(); }
        }

        private string _userMatherName { get; set; }

        public string UserMatherName
        {
            get => _userMatherName;
            set { _userMatherName = value; OnPropertyChanged(); }
        }

        private string _userRut { get; set; }

        public string UserRut
        {
            get => _userRut;
            set { _userRut = value; OnPropertyChanged(); }
        }

        private string _userLicence { get; set; }

        public string UserLicence
        {
            get => _userLicence;
            set { _userLicence = value; OnPropertyChanged(); }
        }

        private string _userCategoryLabel { get; set; }

        public string UserCategoryLabel
        {
            get => _userCategoryLabel;
            set { _userCategoryLabel = value; OnPropertyChanged(); }
        }

        private string _userAge { get; set; }

        public string UserAge
        {
            get => _userAge;
            set
            {
                //Set all switch value => false 
                Switch50Bf = false;
                Switch50Sf = false;
                Switch50Ap = false;
                Switch100Bf = false;
                Switch100Sf = false;
                Switch200Bf = false;
                Switch200Sf = false;
                Switch400Sf = false;
                Switch800Sf = false;
                Switch4x50Sf = false;
                Switch4x100Sf = false;

                //Show labels and user set switch value on every age change
                var Age = value != null && value != "" ? int.Parse(value) : 0;
                if (Age > 7 && Age <= 11) // je
                {
                    UserCategoryLabel = "Junior E";
                    Switch50BfIsVisible = true;
                    Switch50SfIsVisible = false;
                    Switch50ApIsVisible = false;
                    Switch100BfIsVisible = true;
                    Switch100SfIsVisible = false;
                    Switch200BfIsVisible = false;
                    Switch200SfIsVisible = false;
                    Switch400SfIsVisible = false;
                    Switch800SfIsVisible = false;
                    Switch4x50SfIsVisible = false;
                    Switch4x100SfIsVisible = false;
                }
                else if (Age > 11 && Age <= 13) // jD
                {
                    UserCategoryLabel = "Junior D";
                    Switch50BfIsVisible = true;
                    Switch50SfIsVisible = false;
                    Switch50ApIsVisible = false;
                    Switch100BfIsVisible = true;
                    Switch100SfIsVisible = false;
                    Switch200BfIsVisible = false;
                    Switch200SfIsVisible = false;
                    Switch400SfIsVisible = false;
                    Switch800SfIsVisible = false;
                    Switch4x50SfIsVisible = false;
                    Switch4x100SfIsVisible = false;
                }
                else if (Age > 13 && Age <= 15) //JC 
                {
                    UserCategoryLabel = "Junior C";
                    Switch50BfIsVisible = true;
                    Switch50SfIsVisible = true;
                    Switch50ApIsVisible = false;
                    Switch100BfIsVisible = true;
                    Switch100SfIsVisible = false;
                    Switch200BfIsVisible = true;
                    Switch200SfIsVisible = false;
                    Switch400SfIsVisible = false;
                    Switch800SfIsVisible = false;
                    Switch4x50SfIsVisible = false;
                    Switch4x100SfIsVisible = false;
                }
                else if (Age > 15 && Age <= 17) // JB
                {
                    UserCategoryLabel = "Junior B";
                    Switch50BfIsVisible = true;
                    Switch50SfIsVisible = true;
                    Switch50ApIsVisible = true;
                    Switch100BfIsVisible = true;
                    Switch100SfIsVisible = true;
                    Switch200BfIsVisible = true;
                    Switch200SfIsVisible = true;
                    Switch400SfIsVisible = true;
                    Switch800SfIsVisible = true;
                    Switch4x50SfIsVisible = true;
                    Switch4x100SfIsVisible = true;
                }

                else if (Age > 17 && Age <= 24) //TC
                {
                    UserCategoryLabel = "Todo Competidor";
                    Switch50BfIsVisible = true;
                    Switch50SfIsVisible = true;
                    Switch50ApIsVisible = true;
                    Switch100BfIsVisible = true;
                    Switch100SfIsVisible = true;
                    Switch200BfIsVisible = true;
                    Switch200SfIsVisible = true;
                    Switch400SfIsVisible = true;
                    Switch800SfIsVisible = true;
                    Switch4x50SfIsVisible = true;
                    Switch4x100SfIsVisible = true;
                }
                else if (Age > 24 && Age <= 34)
                {
                    UserCategoryLabel = "Master V0";
                    Switch50BfIsVisible = true;
                    Switch50SfIsVisible = true;
                    Switch50ApIsVisible = true;
                    Switch100BfIsVisible = true;
                    Switch100SfIsVisible = true;
                    Switch200BfIsVisible = true;
                    Switch200SfIsVisible = false;
                    Switch400SfIsVisible = false;
                    Switch800SfIsVisible = false;
                    Switch4x50SfIsVisible = true;
                    Switch4x100SfIsVisible = false;
                }
                else if (Age > 35 && Age <= 44)
                {
                    UserCategoryLabel = "Master V1";
                    Switch50BfIsVisible = true;
                    Switch50SfIsVisible = false;
                    Switch50ApIsVisible = false;
                    Switch100BfIsVisible = true;
                    Switch100SfIsVisible = false;
                    Switch200BfIsVisible = false;
                    Switch200SfIsVisible = false;
                    Switch400SfIsVisible = false;
                    Switch800SfIsVisible = false;
                    Switch4x50SfIsVisible = false;
                    Switch4x100SfIsVisible = false;
                }
                else if (Age > 44)
                {
                    UserCategoryLabel = "Master V2";
                    Switch50BfIsVisible = true;
                    Switch50SfIsVisible = false;
                    Switch50ApIsVisible = false;
                    Switch100BfIsVisible = true;
                    Switch100SfIsVisible = false;
                    Switch200BfIsVisible = false;
                    Switch200SfIsVisible = false;
                    Switch400SfIsVisible = false;
                    Switch800SfIsVisible = false;
                    Switch4x50SfIsVisible = false;
                    Switch4x100SfIsVisible = false;
                }
                else
                {
                    UserCategoryLabel = "Ingrese edad para asignar su Categoría";
                    Switch50BfIsVisible = false;
                    Switch50SfIsVisible = false;
                    Switch50ApIsVisible = false;
                    Switch100BfIsVisible = false;
                    Switch100SfIsVisible = false;
                    Switch200BfIsVisible = false;
                    Switch200SfIsVisible = false;
                    Switch400SfIsVisible = false;
                    Switch800SfIsVisible = false;
                    Switch4x50SfIsVisible = false;
                    Switch4x100SfIsVisible = false;
                }
                _userAge = value;
                OnPropertyChanged();
            }
        }

        private string _userShirtSize { get; set; }

        public string UserShirtSize
        {
            get => _userShirtSize;
            set { _userShirtSize = value; OnPropertyChanged(); }
        }

        private bool _switchLicenceIsEnabled { get; set; }

        public bool SwitchLicenceIsEnabled
        {
            get => _switchLicenceIsEnabled;
            set { _switchLicenceIsEnabled = value; OnPropertyChanged(); }
        }

        private bool _switch50Ap { get; set; }

        public bool Switch50Ap
        {
            get => _switch50Ap;
            set { _switch50Ap = value; OnPropertyChanged(); }
        }

        private bool _switch50Sf { get; set; }

        public bool Switch50Sf
        {
            get => _switch50Sf;
            set { _switch50Sf = value; OnPropertyChanged(); }
        }

        private bool _switch50Bf { get; set; }

        public bool Switch50Bf
        {
            get => _switch50Bf;
            set { _switch50Bf = value; OnPropertyChanged(); }
        }

        private bool _switch100Bf { get; set; }

        public bool Switch100Bf
        {
            get => _switch100Bf;
            set { _switch100Bf = value; OnPropertyChanged(); }
        }

        private bool _switch100Sf { get; set; }

        public bool Switch100Sf
        {
            get => _switch100Sf;
            set { _switch100Sf = value; OnPropertyChanged(); }
        }

        private bool _switch200Bf { get; set; }

        public bool Switch200Bf
        {
            get => _switch200Bf;
            set { _switch200Bf = value; OnPropertyChanged(); }
        }

        private bool _switch200Sf { get; set; }

        public bool Switch200Sf
        {
            get => _switch200Sf;
            set { _switch200Sf = value; OnPropertyChanged(); }
        }

        private bool _switch400Sf { get; set; }

        public bool Switch400Sf
        {
            get => _switch400Sf;
            set { _switch400Sf = value; OnPropertyChanged(); }
        }

        private bool _switch800Sf { get; set; }

        public bool Switch800Sf
        {
            get => _switch800Sf;
            set { _switch800Sf = value; OnPropertyChanged(); }
        }

        private bool _switch4x50Sf { get; set; }

        public bool Switch4x50Sf
        {
            get => _switch4x50Sf;
            set { _switch4x50Sf = value; OnPropertyChanged(); }
        }

        private bool _switch4x100Sf { get; set; }

        public bool Switch4x100Sf
        {
            get => _switch4x100Sf;
            set { _switch4x100Sf = value; OnPropertyChanged(); }
        }

        private bool _switch50ApIsVisible { get; set; }

        public bool Switch50ApIsVisible
        {
            get => _switch50ApIsVisible;
            set { _switch50ApIsVisible = value; OnPropertyChanged(); }
        }

        private bool _switch50SfIsVisible { get; set; }

        public bool Switch50SfIsVisible
        {
            get => _switch50SfIsVisible;
            set { _switch50SfIsVisible = value; OnPropertyChanged(); }
        }

        private bool _switch50BfIsVisible { get; set; }

        public bool Switch50BfIsVisible
        {
            get => _switch50BfIsVisible;
            set { _switch50BfIsVisible = value; OnPropertyChanged(); }
        }

        private bool _switch100BfIsVisible { get; set; }

        public bool Switch100BfIsVisible
        {
            get => _switch100BfIsVisible;
            set { _switch100BfIsVisible = value; OnPropertyChanged(); }
        }

        private bool _switch100SfIsVisible { get; set; }

        public bool Switch100SfIsVisible
        {
            get => _switch100SfIsVisible;
            set { _switch100SfIsVisible = value; OnPropertyChanged(); }
        }

        private bool _switch200BfIsVisible { get; set; }

        public bool Switch200BfIsVisible
        {
            get => _switch200BfIsVisible;
            set { _switch200BfIsVisible = value; OnPropertyChanged(); }
        }

        private bool _switch200SfIsVisible { get; set; }

        public bool Switch200SfIsVisible
        {
            get => _switch200SfIsVisible;
            set { _switch200SfIsVisible = value; OnPropertyChanged(); }
        }

        private bool _switch400SfIsVisible { get; set; }

        public bool Switch400SfIsVisible
        {
            get => _switch400SfIsVisible;
            set { _switch400SfIsVisible = value; OnPropertyChanged(); }
        }

        private bool _switch800SfIsVisible { get; set; }

        public bool Switch800SfIsVisible
        {
            get => _switch800SfIsVisible;
            set { _switch800SfIsVisible = value; OnPropertyChanged(); }
        }

        private bool _switch4x50SfIsVisible { get; set; }

        public bool Switch4x50SfIsVisible
        {
            get => _switch4x50SfIsVisible;
            set { _switch4x50SfIsVisible = value; OnPropertyChanged(); }
        }

        private bool _switch4x100SfIsVisible { get; set; }

        public bool Switch4x100SfIsVisible
        {
            get => _switch4x100SfIsVisible;
            set { _switch4x100SfIsVisible = value; OnPropertyChanged(); }
        }

        private bool _loadingIsVisible { get; set; }

        public bool LoadingIsVisible
        {
            get => _loadingIsVisible;
            set { _loadingIsVisible = value; OnPropertyChanged(); }
        }
    }
}
