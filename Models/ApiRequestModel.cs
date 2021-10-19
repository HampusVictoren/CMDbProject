using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CMDb___project.Models
{
    public class ApiRequestModel
    {
        public static HttpClient ApiClient { get; set; }

        //public static void InitializeClient()
        //{
        //    ApiClient = new HttpClient();
        //    ApiClient.BaseAddress = new Uri(url);
        //    ApiClient.DefaultRequestHeaders.Accept.Clear();
        //    ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //    HttpResponseMessage response = awaitclient.GetAsync("api/Department/1");
        //    if (response.IsSuccessStatusCode)
        //    {
        //        Departmentdepartment = awaitresponse.Content.ReadAsAsync<Department>();
        //        Console.WriteLine("Id:{0}\tName:{1}", department.DepartmentId, department.DepartmentName);
        //        Console.WriteLine("No of Employee in Department: {0}", department.Employees.Count);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Internal server Error");
        //    }
        //}
    }
}
