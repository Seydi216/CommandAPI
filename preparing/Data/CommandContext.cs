using Microsoft.EntityFrameworkCore;
using preparing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preparing.Data
{
    public class CommandContext: DbContext
    {
        public CommandContext(DbContextOptions<CommandContext> options)
            : base(options) {

        }
        public DbSet<Command> CommandItems { get; set; }
    }
}
