using DataAccess.Modles;
using DataAccess;

namespace Core
{
    public class logincheks
    {
        public bool LoginCheck( string password,string username)
        {
            bool check = false; 
            Access access = new Access();
            var userInfo = access.DBAccess();
            foreach(UserInfo user in userInfo)
            {
                if (user.UserName == username && user.Password == password)
                { 
                    check = true;                   
                }
            }
            return check;
        }
    }
}