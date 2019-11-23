using System.Collections.Generic;

namespace SerializationSample
{
    public class Client
    {
        private ICollection<string> _allowedGrantTypes = new GrantTypeValidatingHashSet();

        // this works 
        // public GrantTypeValidatingHashSet AllowedGrantTypes { get; set; }

        // this works 
        // public ICollection<string> AllowedGrantTypes { get; set; } = new GrantTypeValidatingHashSet();

        // this errors
        public ICollection<string> AllowedGrantTypes
        {
            get { return _allowedGrantTypes; }
            set
            {
                _allowedGrantTypes = new GrantTypeValidatingHashSet(value);
            }
        }
    }
}