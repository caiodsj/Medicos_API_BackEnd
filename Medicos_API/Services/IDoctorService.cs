﻿using Medicos_API.DTOs;
using Medicos_API.Models;

namespace Medicos_API.Services
{
    public interface IDoctorService
    {
        Task<IEnumerable<Doctor>> GetAllDoctors();
        Task<Doctor> GetDoctorByCRM(string CRMrequest);
        Task<IEnumerable<Doctor>> GetAllDoctorsByState(string state);
        Task<Doctor> CreateDoctor(DoctorInsertDTO request);
        Task<Doctor> UpdateDoctor(int id, DoctorUpdateDTO request);
        Task DeleteDoctor(int id);
    }
}
