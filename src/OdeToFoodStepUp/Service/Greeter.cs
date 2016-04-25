using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace OdeToFoodStepUp.Service
{
    public class Greeter : IGreeter
    {
        private readonly IConfiguration configuration;

        public Greeter(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public string GetGreeting()
        {
            return configuration["greeting"];
        }
    }
}
