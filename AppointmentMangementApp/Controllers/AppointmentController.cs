using AppointmentManagement.Models;
using AppointmentManagementApp.DAL.Interrfaces;
using AppointmentManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace AppointmentManagementApp.Controllers
{
    public class AppointmentController : ApiController
    {
        private readonly IAppointmentService _service;
        public AppointmentController(IAppointmentService service)
        {
            _service = service;
        }
        public AppointmentController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Appointment/CreateAppointment")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateAppointment([FromBody] Appointment model)
        {
            //write your code here
            throw new NotImplementedException(); 
        }


        [HttpPut]
        [Route("api/Appointment/UpdateAppointment")]
        public async Task<IHttpActionResult> UpdateAppointment([FromBody] Appointment model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpDelete]
        [Route("api/Appointment/DeleteAppointment")]
        public async Task<IHttpActionResult> DeleteAppointment(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Appointment/GetAppointmentById")]
        public async Task<IHttpActionResult> GetAppointmentById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Appointment/GetAllAppointments")]
        public async Task<IEnumerable<Appointment>> GetAllAppointments()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
