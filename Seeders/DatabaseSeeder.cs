using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using Taller.Models;

namespace Taller.Seeders
{
    public class DatabaseSeeder
    {
        public static List<Propietario> GenerarPropietariosFalsos(int cantidadPropietario)
        {
            // var faker = new Faker<Propietario>()
            // .RuleFor(p => p.Id, f => f.IndexFaker)
            // .RuleFor(p => p.Nombre, f => f.Name.FirstName()) //P->Propietario y F-> Faker
            // .RuleFor(p => p.Apellido, f => f.Name.LastName())
            // .RuleFor(p => p.NumeroIdentificaion, f => f.Random.AlphaNumeric(10));
            // return faker.Generate(cantidadPropietario);
            var faker = new Faker<Propietario>()
            .RuleFor(p => p.Id, f => f.IndexFaker + 1)
            .RuleFor(p => p.Nombre, f => f.Name.FirstName())
            .RuleFor(p => p.Apellido, f => f.Name.LastName())
            .RuleFor(p => p.NumeroIdentificaion, f => f.Random.AlphaNumeric(10))
            .RuleFor(p => p.FotoPerfil, f => f.Internet.Avatar())
            .RuleFor(p => p.Direccion, f => f.Address.FullAddress())
            .RuleFor(p => p.Telefono, f => f.Phone.PhoneNumber())
            .RuleFor(p => p.Correo, f => f.Internet.Email())
            .RuleFor(p => p.ColorDePelo, f => f.Commerce.Color()); // Genera un color aleatorio .RuleFor(p => p.Vehiculos, f => new List<Vehiculo>()); // Asocia una lista vacía de Vehículos por ahora
            return faker.Generate(cantidadPropietario);
        }
    }
}