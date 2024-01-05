using AppointmentManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AppointmentManagementApp.DAL.Services.Repository
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly DatabaseContext _dbContext;
        public AppointmentRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Appointment> CreateAppointment(Appointment model)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAppointmentById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Appointment> GetAllAppointments()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Appointment> GetAppointmentById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Appointment> UpdateAppointment(Appointment model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}