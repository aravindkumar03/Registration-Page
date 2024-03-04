using LoginForm.BO;
using LoginForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LoginForm.service
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

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
