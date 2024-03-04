using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using LoginForm.BO;
using LoginForm.Model;

namespace LoginForm.service
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class SaveData : System.Web.Services.WebService
    {

        //  string name, string address, string gender, string state, string phone, string courses, decimal total

        //public void SaveFormData(string name, string address, string gender, string state, string phone, decimal total, List<string> courses)
        //{

        //    var Form_data = new LoginData
        //    {

        //        Name = name,
        //        Address = address,
        //        Gender = gender,
        //        State = state,
        //        Phone = phone,
        //        Total = total,
        //        Courses = courses.ToList()

        //    };

        //    BusinessObject boObj = new BusinessObject();

        //    boObj.ProcessFormData(Form_data);

        //}






        [WebMethod]
        public int SaveFormData(LoginData obj)
        {

            //    var processedData = new
            //    {

            //       Name = objForm.Name,
            //       Address = objForm.Address,
            //       Gender = objForm.Gender,
            //       State = objForm.State,
            //       Phone = objForm.Phone,
            //       Courses = objForm.Courses,
            //       Total = objForm.Total

            //};

            // return new JavaScriptSerializer().Serialize(processedData);

            //JavaScriptSerializer serializer = new JavaScriptSerializer();
            //LoginData formData = serializer.Deserialize<LoginData>(objFormJson);

            //LoginData obj = new LoginData();
            //obj.Name = Name;
            //obj.Address = Address;
            //obj.Gender = objForm.Gender;
            //obj.State = objForm.State;
            //obj.Phone = objForm.Phone;
            //obj.Courses = objForm.Courses;
            //obj.Total = objForm.Total;
            //// Pass data to Business Object for processing
            BusinessObject bo = new BusinessObject();
            return bo.StoreData(obj);
        }
    }
}
