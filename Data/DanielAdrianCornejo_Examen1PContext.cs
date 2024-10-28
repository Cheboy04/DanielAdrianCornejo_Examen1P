using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DanielAdrianCornejo_Examen1P.Models;

namespace DanielAdrianCornejo_Examen1P.Data
{
    public class DanielAdrianCornejo_Examen1PContext : DbContext
    {
        public DanielAdrianCornejo_Examen1PContext (DbContextOptions<DanielAdrianCornejo_Examen1PContext> options)
            : base(options)
        {
        }

        public DbSet<DanielAdrianCornejo_Examen1P.Models.DC_Carro> DC_Carro { get; set; } = default!;
    }
}
