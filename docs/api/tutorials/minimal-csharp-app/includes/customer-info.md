```csharp
namespace SuperOffice.DevNet.Online.SystemUser.PartnerDBLibrary.Models
{
    public class CustomerInfo
    {
        public int ID { get; set; }
        public int AssociateID { get; set; }
        public bool IsActive { get; set; }
        public string SystemUserToken { get; set; }
        public string ContextIdentifier { get; set; }
        public DateTime LastSync { get; set; }
    }
}
```