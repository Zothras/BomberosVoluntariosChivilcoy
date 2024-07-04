using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using Vista.Data;
using Vista.Data.Enums;
using Vista.Data.Models.Personales;
using Vista.Data.Models.Salidas.Componentes;

namespace Vista.Services
{
    public interface IMovilService
    {

    }

    public class MovilService : IMovilService
    {
        private readonly BomberosDbContext _context;

        public MovilService(BomberosDbContext context)
        {
            _context = context;
        }
    }
}