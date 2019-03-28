using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{

    public class Repository
    {
        

        public List<User> QueryGetUserList()
        {
            using (CompanyEntities db = new CompanyEntities())
            {
                IEnumerable<Users_SelectAll_Result> model = db.Users_SelectAll();

                List<User> lstUsers = new List<User>();
                

                foreach (var us in model)
                {
                    User user = new User();
                    user.UserID = us.UserID;
                    user.UserFirstName = us.UserFirstName;
                    user.UserLastName = us.UserLastName;
                    lstUsers.Add(user);
                }
                return lstUsers;
            }
                      
        }

        public void QuerySaveUser(User user)
        {
            using (CompanyEntities db = new CompanyEntities())
            {
                db.Users_Insert(user.UserFirstName, user.UserLastName);

            }
        }

        public void QueryEditUser(User user)
        {
            using (CompanyEntities db = new CompanyEntities())
            {
                db.Users_Update(user.UserID,user.UserFirstName, user.UserLastName);

            }
        }

        public void QueryDeleteUser(int UserID)
        {
            using (CompanyEntities db = new CompanyEntities())
            {
                db.Users_Delete(UserID);

            }
        }
    }
}
