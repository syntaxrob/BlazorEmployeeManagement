﻿using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _httpClient.GetJsonAsync<Employee[]>("api/employees");
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await _httpClient.GetJsonAsync<Employee>($"api/employees/{id}");
        }
    }
}
