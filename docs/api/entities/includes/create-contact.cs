using SuperOffice.CRM.Entities;

//Anonymous user has no righst to check out this stuff!
SuperOffice.SoSession session = SuperOffice.SoSession.Authenticate("Sal1", "" );
Contact contact = Contact.CreateNew();

// Verify flags on RDB
Assert.IsTrue( contact.IsNew, "The contact is new" );
Assert.IsTrue( !contact.IsDirty, "The contact is not dirty" );
Assert.IsTrue( !contact.IsDeleted, "The contact is not deleted" );

// Set properties on entity
contact.ActiveInterests = 2;
contact.Row.BusinessIdx = 1;
contact.Row.CategoryIdx = 1;
contact.Row.CountryId = 47;
contact.Name = "Geir er tøff AS";
contact.Department = "Søndre avdeling (lukket)";
contact.PostalAddress.Address1 = "Adresse1 Gaten 23";
contact.PostalAddress.Address2 = "Adresse 2 gata 54";
contact.PostalAddress.Address3 = "Adresse 33 street";
contact.PostalAddress.Zipcode = "0123";

// Verify flags on RDB
Assert.IsTrue( contact.IsNew, "The contact is new" );
Assert.IsTrue( contact.IsDirty, "The contact is dirty" );
Assert.IsTrue( !contact.IsDeleted, "The contact is not deleted" );

contact.Save();