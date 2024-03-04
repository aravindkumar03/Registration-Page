using LoginForm.DAO;
using LoginForm.Model;
using System;
using System.Collections.Generic;

namespace LoginForm.BO
{
    public class BusinessObject
    {
        //public void ProcessFormData(LoginData robj)
        //{
        //    // Perform any necessary business logic here

        //    // Pass data to Data Access Object (DAO) to save into database
        //    Console.WriteLine(robj.Name,robj.Address,robj.Gender,robj.State,robj.Phone,robj.Total,robj.Courses);

        //  // StoreData(robj.Name, robj.Address, robj.Gender, robj.State, robj.Phone, robj.Total, robj.Courses);

        //    StoreData(robj);
        //}


        //public void StoreData(string name, string address, string gender, string state, string phone,  decimal total , List<string> courses) 
        //{
        //    DataAccessLayer dao = new DataAccessLayer();
        //    dao.SaveFormData(name,address,gender,state,phone,total,courses);

        //}

        public int StoreData(LoginData obj)
        {
            DataAccessLayer dao = new DataAccessLayer();
            return dao.SaveFormData(obj);
        }

    }
}
