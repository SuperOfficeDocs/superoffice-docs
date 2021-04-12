using SuperOffice.CRM.Entities;
using SuperOffice;
using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  //create a contact entity and assign some of its properties with data
  Contact myContact = Contact.CreateNew();
  myContact.SetDefaults();
  myContact.Name = "ABC Company";

  //add two elements to the URL's collection since we are going to add two URLs
  myContact.Urls.AddNew();
  myContact.Urls.AddNew();
  myContact.Urls[0].UrlAddress1 = "ABCCompany.com";
  myContact.Urls[0].Rank = 1;
  myContact.Urls[1].UrlAddress1 = "ABCCompanyServices.com";
  myContact.Urls[1].Rank = 2;
  myContact.PostalAddress.Address1 = "P.O.Box 345";
  myContact.PostalAddress.Address2 = "Kalbakken";
  myContact.PostalAddress.Zipcode = "0901";
  myContact.PostalAddress.City = "OSLO";

  //create a project entity and assign some of its properties with data
  Project myProject = Project.CreateNew();
  myProject.SetDefaults();
  myProject.Name = "ABC Company Project";

  //create two ProjectMember instances and assign them with person
  ProjectMember memberOne = ProjectMember.CreateNew();
  memberOne.SetDefaults();
  memberOne.Person = Person.GetFromIdxPersonId(24);
  ProjectMember memberTwo = ProjectMember.CreateNew();
  memberTwo.SetDefaults();
  memberTwo.Person = Person.GetFromIdxPersonId(25);

  //here we add the two created project member to the members collection of the project entity
  myProject.Members.Add(memberOne);
  myProject.Members.Add(memberTwo);

  //create a sale entity and assign the above created entities to the respective properties
  Sale mySale = Sale.CreateNew();
  mySale.SetDefaults();
  mySale.Contact = myContact;
  mySale.Project = myProject;
  mySale.Save();
}