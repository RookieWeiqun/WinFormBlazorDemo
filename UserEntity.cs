using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public class UserEntity
    {
        public UserEntity(string name ,string nick ,string role="管理员") {
            UserName= name;
            NickName = nick;
            RoleId= role;
        }
        public UserEntity() { }
        public string UserName { get; set; }
        public string NickName { get; set; }
        public string RoleId { get; set; }
    }
}
