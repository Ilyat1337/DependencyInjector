using System;

namespace DependencyInjector
{
    class ConfigurationException : Exception
    {
        private readonly string message;

        public override string Message
        {
            get { return message; }
        }

        public ConfigurationException(string message)
        {
            this.message = message;
        }
    }
}
