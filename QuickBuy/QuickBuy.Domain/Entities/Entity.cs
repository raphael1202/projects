using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public abstract class Entity
    {
        public List<string> _validationMessages { get; set; }

        private List<string> ValidationMessage
        {
            get { return _validationMessages ?? (_validationMessages = new List<string>()); }
        }

        protected void ClearMessages()
        {
            ValidationMessage.Clear();
        }

        protected void AddValidation(string message)
        {
            ValidationMessage.Add(message);
        }

        public abstract void Validate();
        public bool IsValid
        {
            get { return !ValidationMessage.Any(); }
        }
    }
}
