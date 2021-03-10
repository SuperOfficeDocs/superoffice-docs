// An information query to get the value of contact id 3 UDF,
// ContactInterestsUDField .

// ContactInterestsUDField is a UDF of type drop-down list and source is a builtin list:
//Contact interest

info = UDFHelper.Instance.GetUDFInfo(EUDefType.Contact, 3, "ContactInterestsUDField", UDFHelper.ListItemSource.ContactInterest);

 

// A search query to get all project ids where UDF Hoved is not null.

int[] hoveds = UDFHelper.Instance.UDFSearch(EUDefType.Project, "Hoved",
                            Type.Missing, UDFHelper.Operation.IsNotNull);

 

// An information query to get the Hoved UDF value of project id 2.

info = UDFHelper.Instance.GetUDFInfo(EUDefType.Project, 2, "Hoved");

Console.WriteLine(info.ToString());

 

// Here, UDFHelper is used to get all persons

// where the UDF 'Year employeed:' is Greater Than 2000

int[] peopleIds = UDFHelper.Instance.UDFSearch(EUDefType.Person,
                               "Year employeed:", 2000, UDFHelper.Operation.GreaterThan);

 

PersonRow[] perRows = new PersonRow[peopleIds.Length];

 

for (int i = 0; i < peopleIds.Length; i++)

{

    perRows[i] = new PersonRow.IdxPersonId(peopleIds[i]);

}

 

 

// An information queries for a contact with ID 1197 to get membership type

// from the Membership UDF, which is a UDF of a user-defined list type.

info = UDFHelper.Instance.GetUDFInfo(EUDefType.Contact, 1197, "Membership", UDFHelper.ListItemSource.UserDefined);

 

 

// For HIGH PERFORMANCE lookups, prefetch the FieldInfo objects

// needed to conduct many queries for the one or more UDFs.

UDFInfo creativeContact =
           UDFHelper.Instance.GetUDFInfo(EUDefType.Contact, "Creative contact:");


UDFInfo photographer    =
           UDFHelper.Instance.GetUDFInfo(EUDefType.Contact, "Photographer:");

 

UDFInfo projCoordinator =
           UDFHelper.Instance.GetUDFInfo(EUDefType.Contact, "Project coordinator:");

 

// Next, get the entities you want UDF values from

ContactRows.CustomSearch contactSearch = new ContactRows.CustomSearch();

ContactRows contacts = contactSearch.ToContactRows();

 

// Have a place to store some data.

List myContacts = newList();

 

// Now Loop over all contacts returned and get UDF values

for (int i = 0; i < contacts.Count; i++)

{

    ContactFields field = new ContactFields();

 

    //Write in general information from the ContactRow

    field.Name = contacts[i].Name;

    field.Identity = contacts[i].ContactId;

 

    // IMPORTANT!!! ***************************************

    // set the UDFInfo entityids so we know what contact we

    // want UDF values from.

    creativeContact.EntityId = contacts[i].ContactId;

    projCoordinator.EntityId = contacts[i].ContactId;

    photographer.EntityId    = contacts[i].ContactId;

 

    // GetUDFInfo takes in the struct with the FieldInfo objects

    // and contact id needed to conduct the query.

    // Returned is the same struct structure, but now populated with

    // the UDF values, as well as the UDF id.

    creativeContact = UDFHelper.Instance.GetUDFInfo(creativeContact);

    photographer    = UDFHelper.Instance.GetUDFInfo(photographer);

    projCoordinator = UDFHelper.Instance.GetUDFInfo(projCoordinator);

 

    //Next, simply store the values and add the container to the list

    field.CreativeContact = creativeContact.ToString();

    field.Photographer = photographer.ToString();

    field.ProjectCoordinator = projCoordinator.ToString();

 

    myContacts.Add(field);

}

 

 

// A data query that just returns an int array (always length of 2)

// that contains the entity and ud table row identity values.

// obj[0] = UDF Table row id,

// obj[1] = Entity Table row id,

object obj = UDFHelper.Instance.GetUDFData(3, info.UsrDefField, info.EntityField);

 

// A search query to find all contacts with a StartDate between two dates.

int[] a = UDFHelper.Instance.UDFSearch(EUDefType.Contact, "StartDate", newint[] { 1097107200, 1098144000 }, UDFHelper.Operation.Between);

 

int startDate = SuperOffice.Data.TimeConverter.DateTime2TimeTLocal(
                                                                            DateTime.Now.AddYears(-5));

int endDate = SuperOffice.Data.TimeConverter.DateTime2TimeTLocal(
                                                                            DateTime.Now);

int[] d = UDFHelper.Instance.UDFSearch(EUDefType.Person, "Year Employed:",
                          newint[] { startDate, endDate }, UDFHelper.Operation.Between);

 

// A search query to find all people ids who began working in the years listed.

int[] c = UDFHelper.Instance.UDFSearch(EUDefType.Person, "Year Employed:", newint[] { 2000, 2001, 2002 });

 

// A search query that returns all contact ids that are not a member.

// Membership is a checkbox UDF, where 1 is checked and 0 is unchecked.

int[] e = UDFHelper.Instance.UDFSearch(EUDefType.Contact, "Membership", 0);