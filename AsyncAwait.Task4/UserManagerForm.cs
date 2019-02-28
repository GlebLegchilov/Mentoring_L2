using AsyncAwait.Task4.Models;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait.Task4
{
    public partial class UserManagerForm : Form
    {
        private const char Separator = '-';

        private UserManager _userManager = new UserManager();
        private User _selectedUser;

        public UserManagerForm()
        {
            InitializeComponent();
            InitializeUserListBoxAsync();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            var newUser = new User()
            {
                Name = userNameAddTextBox.Text,
                SecondName = userSecondNameAddTextBox.Text,
                Age = int.Parse(userAgeAddTextBox.Text)
            };
            var addUserTask = _userManager.AddUserAsync(newUser);
            UpdateUserList(addUserTask);
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            var newUser = new User()
            {
                Id = _selectedUser.Id,
                Name = userNameInfoTextBox.Text,
                SecondName = userSecondNameInfoTextBox.Text,
                Age = int.Parse(userAgeInfoTextBox.Text)
            };
            var updateUserTask = _userManager.UpdateUserAsync(newUser);
            UpdateUserList(updateUserTask);
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            var deleteUserTask =_userManager.DeleteUserAsync(_selectedUser.Id);
            UpdateUserList(deleteUserTask);
        }

        private void usersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usersListBox.SelectedItem == null)
            {
                return;
            }

            var userData = usersListBox.SelectedItem.ToString().Split(Separator);
            _selectedUser = new User() {
                Id = int.Parse(userData[0]),
                Name = userData[1],
                SecondName = userData[2],
                Age = int.Parse(userData[3])
            };
            UpdateUserInfoZone(_selectedUser);
            deleteUserButton.Enabled = true;
            editUserButton.Enabled = true;

        }

        private async void InitializeUserListBoxAsync()
        {
            var getAllTask = await _userManager.GetAllUsersAsync();
            usersListBox.Items.Clear();
            usersListBox.Items.AddRange(getAllTask
                .Select(
                    user => new StringBuilder()
                        .Append(user.Id.ToString())
                        .Append(Separator)
                        .Append(user.Name.TrimEnd())
                        .Append(Separator)
                        .Append(user.SecondName.TrimEnd())
                        .Append(Separator)
                        .Append(user.Age.ToString())
                        .ToString())
                .ToArray());
        }

        private async void UpdateUserList(Task tascForWait)
        {
            await tascForWait;
            InitializeUserListBoxAsync();
            deleteUserButton.Enabled = false;
            editUserButton.Enabled = false;
            CleanUserInfoZone();

        }

        private void UpdateUserInfoZone(User user)
        {
            userNameInfoTextBox.Text = user.Name;
            userSecondNameInfoTextBox.Text = user.SecondName;
            userAgeInfoTextBox.Text = user.Age.ToString();
        }

        private void CleanUserInfoZone()
        {
            userNameInfoTextBox.Text = string.Empty;
            userSecondNameInfoTextBox.Text = string.Empty;
            userAgeInfoTextBox.Text = string.Empty;
        }

        private void userNameAddTextBox_TextChanged(object sender, EventArgs e)
        {
            if(userNameAddTextBox.Text.Contains(Separator))
            {
                userNameAddTextBox.Text = string.Empty;
            }
        }

        private void userSecondNameAddTextBox_TextChanged(object sender, EventArgs e)
        {
            if (userSecondNameAddTextBox.Text.Contains(Separator))
            {
                userSecondNameAddTextBox.Text = string.Empty;
            }
        }

        private void userAgeAddTextBox_TextChanged(object sender, EventArgs e)
        {
            if (userAgeAddTextBox.Text.Contains(Separator))
            {
                userAgeAddTextBox.Text = string.Empty;
            }
        }
    }
}
