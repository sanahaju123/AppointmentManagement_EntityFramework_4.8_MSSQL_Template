using AppointmentManagementApp.DAL.Interrfaces;
using AppointmentManagementApp.DAL.Services.Repository;
using AppointmentManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AppointmentManagementApp.DAL.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _repository;

        public AppointmentService(IAppointmentRepository repository)
        {
            _repository = repository;
        }

        public Task<Appointment> CreateAppointment(Appointment model)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAppointmentById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Appointment> GetAllAppointments()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Appointment> GetAppointmentById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Appointment> UpdateAppointment(Appointment model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}