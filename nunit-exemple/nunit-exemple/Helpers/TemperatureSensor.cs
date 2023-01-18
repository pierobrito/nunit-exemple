using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunit_exemple.Helpers
{
    public class TemperatureSensor
    {
        bool _isInitialized;

        public void Initialize()
        {
            // Initialize hardware interface
            _isInitialized = true;
        }
        /// <summary>
        /// Simulate read Temperature
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public int ReadCurrentTemperature()
        {
            if (!_isInitialized)
            {
                throw new InvalidOperationException("Cannot read temperature before initializing.");
            }
          
            return 42;
        }
    }
}
