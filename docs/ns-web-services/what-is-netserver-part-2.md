---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: what_is_netserver_part_2       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: What is NetServer, part 2 # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates             # Your GitHub alias.
so.date: 10.23.2006
keywords:
so.topic: article        # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# What is NetServer, part 2

In the first of this three article series, I discussed NetServer from the birds eye view. I covered the conceptual overview of NetServer as a whole, as well as explained NetServer Services in-depth. In this article, I will move lower in the framework and discuss the Relational Database and High-Level Database objects (Entities and Rows, respectfully).

![x][img1]

## Relational Database Layer

As I discussed in the previous article, Entities is the layer at which all database entities are exposed. Conceptually, these are the NetServer business objects, such as Contact, Address, and Appointment. When you need to work with people models, for example, you get or create a Person entity. When you need to work with projects, you get or create a Project entity.

Entities are objects that may contain property values that are fetched by more than just the primary object table. In the case of a Person entity, the primary object table being the Person table. A Person.Contact property is a class object that is structured and populated in such a way that take into account settings from more tables than just the Person table.

There are three types of entity types: one entity, entity collections, and entity lists.

Entity are logical real-world objects that make up the business models, such as Contact, Person, Appointment, and so forth. Entity collections are simply collections of the business models, such as ContactCollection, PersonCollection, and AppointmentCollection. Entity lists are similar to entity models, but instead of collections or row objects as properties, list items contain real data values for each property.

The following code demonstrates one way to iterate over the appointments of a person. The Person class is first instantiated by using the inner index searcher class, IdxPersonId. This inner index class is the equivalent of a pseudo method, Person.GetPersonById(...). Every entity object contains at least one inner Idx fetcher class. Each Idx fetcher is also exposed as a static **GetFromIdx** method, i.e. Person.GetFromIdxPersonId.

In the iteration, for every appointment in the Person.Appointments collection, if the appointment type equals type inDiary, meaning the appointment is in the persons diary (calendar), then we will write out some details of the appointment to the console window.

```csharp
using (SoSession session = SoSession.Authenticate("JR", ""))
{
    Person person = new Person.IdxPersonId(7);

    foreach (Appointment apt in person.Appointments)
    {
        //Show Diary Appointments
        if (apt.Type == AppointmentType.inDiary)
        {
            Console.WriteLine(string.Format("ID: {0}\tTask Name: {1}\tStatus: {2}\tDue Date: {3}",
               apt.AppointmentId, apt.Task.Name, apt.Status.ToString(),
               apt.DoBy.ToString()));
         }
    }
}
```

Notice how easy it is to access all of the appointments and appointment information belonging to a person. There is no need to write complex SQL queries that join multiple other tables and establishing criteria, to gain access all of the details pertaining to the appointment. All complex properties of the appointment are easily accessible.

Its also important to note that the value of many entity properties are retrieved from the database when the property is accessed, not when the object itself is initialized. This is sometimes referred to as lazy fetching.

The following code demonstrates again how to leverage an entities inner Index class to fetch the business object - in this case a Contact. Notice how easy it is to logically drill down into the entity and intuitively access the data it contains. Once again, no complex SQL query is required to access the properties of the Contact object.

```csharp
Contact contact = new Contact.IdxContactId(7);

PersonCollection people = contact.Persons;

foreach (Person person in people)
{
    Debug.Assert(person.Contact.Name == contact.Name);
}
```

## Entity Property Types

Whether programming with system data types, or class object data types, properties are just data types. In this section though, I think it is important to note the property data types you are likely to encounter from NetServer Entities. Many of the business object properties bridge the divide between Entity objects and Row objects, and share the same properties.

In many cases, entity properties are intrinsic data types, such as integers and strings. This is the case when working with Entity lists. Other entity properties are entity collections, such as the Contact.Persons property which is of type PersonCollection.

Another common type found in entity properties is of type Row. For example, the Contact.Business property is actually a Row object, of type BusinessRow. Entity properties of type XRow, where X is the name of the property, are similar to that of ADO.NET DataRows. These data types are discussed more in the Row Layer section below.

Each entity object also has a Row property, and this is a direct link to the corresponding HDB Row object. The type is explained in detail in the following section.

The final entity property type you will encounter, which is also categorically in the Rows layer, is a TableInfo type. Every entity type has a TableInfo property that describes the schema of the base entity object. TableInfo discussed more in the Row Layer section.

![x][img2]

## High-Level Database Layer (Rows)

HDB rows are very similar to that of ADO.NET DataTable and DataRow objects. The NetServer DataTable equivalent is a rows collection, such as PersonRows, whereas the DataRow equivalent is a single row object, such as PersonRow.

Rows can represent one or more rows from a database table. Additionally, for every table in a SuperOffice database, there is a corresponding Row and Rows object.

Unlike entity models, where an entity property may contain data fetched from other tables, Row types only contain foriegn key ID values that point to the data details in another table.

Each row contains a TableInfo property. TableInfo types are a schema type that contains all of the information pertaining to the schema of the table field layout.

The TableInfo property contains properties for the table name and definition, the database name, and a useful method to lookup fields by field name, called FindField. The TableInfo object is similar to an ADO.NET DataTable.Columns property, in that it exposes all of the columns as FieldInfo objects through the TableInfo.All property. TableInfo.All returns an array of FieldInfo objects, one for each column in the table. For example, with the PersonRow object, the PersonRow.TableInfo.All property details all of the columns available in the Person table. The result of running the following code would write out all 42 column names to the debug window. With each FieldInfo object, there are properties for the fields data type, the parent table, and many useful Argument methods, such as Between, GreaterThan, LessThan, and Like, to test the value of the field in the current row.

**Accesssing all columns of a PersonRow object:**

```csharp
PersonRow person = new PersonRow.IdxPersonId(7);

FieldInfo [] fields = person.TableInfo.All;

foreach (FieldInfo fld in fields)
{
    Debug.WriteLine(fld.Name);
}
```

In contrast to the limited number of inner index fetcher classes for a single Row object, the Rows object expose many Idx fields to conduct useful queries.

**Code demonstrating available inner index classes of the PersonRows class:**

![x][img3]

Below, we see again how easy it is to use the inner index classes as fetcher objects. The code demonstrates how to use the inner IdxContactId class to establish the criteria for the records returned in the result set. In this example, we see that passing in a value of 3 will limit the number of PersonRow objects in the PersonRows object to only the records in the database where the contact\_id field is the value 3.

**How the inner index class IdxContactId fetches a collection of PersonRow, PersonRows:**

```csharp
PersonRows people = new PersonRows.IdxContactId(3);

foreach (PersonRow personRow in people)

{
    Debug.Assert(personRow.ContactId == 3);
}
```

As seen in Entities, each inner Idx fetcher class has a cooresponding static helper method, i.e. PersonRows.GetFromIdxName.

### Custom Search Queries

Both entity and row types contain an inner class called CustomSearch. CustomSearch queries allow you to go above and beyond that of index queries, as seen in Figures One and Two. NetServer provides the ability to append additional criteria to a given object or collection search by setting the Restriction property. Even greater query capability is available by including other TableInfo objects for join selections on the JoinRestriction property.

For example, Figure Four demonstrates a simple custom search. The results of the custom search are predicable; the people object will be a PersonCollection containing all of the people in the Person table. This means that for each row in the Person table, there will be one Person in the PersonCollection.

**Simple Custom Search:**

```csharp
PersonCollection.CustomSearch peopleSearch = new PersonCollection.CustomSearch();

PersonCollection people = peopleSearch.ToPersonCollection();
```

What if you wanted to see all Person entities who were born after January 1, 1970. The following code demonstrates a custom search to implement such a query.

**Custom search to return all person rows with a birthday greater than January 1, 1970:**

```csharp
PersonCollection.CustomSearch peopleSearch = new PersonCollection.CustomSearch();

peopleSearch.Restriction = peopleSearch.TableInfo.DayOfBirth.GreaterThan(S.Parameter(newDateTime(1970, 1, 1)));

PersonCollection people = peopleSearch.ToPersonCollection();
```

Notice that the Restriction property accepts an Argument object as a type. Ok, so this is not explicitly shown by looking at the above code, but that is what implicitly gets set in the Restriction. Encapsulated in the architecture, Restriction inherits from the type QueryElement, as does Argument. Other types, such as GreaterThan, LessThan, Equal, Like, ultimately end up inheriting from QueryElement. Internally, custom search functionality is handled using the Visitor pattern, but that is far beyond the scope of this article and will not be discussed here. Luckily, we as developers using NetServer do not need to know exactly how this is implemented. All we need to know is that, in order for us to define our desired results, all we need to do is stick to using the properties exposed by the custom search object TableInfo property to establish criteria.

Lets take the custom search one step further and set the criteria to return only the people from the contact with a contact\_id value of 3, and those who were born after January 1, 1970.

**Custom search for people who are a member of a Contact where contact\_id is 3, and those who were born after January 1, 1970:**

```csharp
PersonCollection.CustomSearch peopleSearch = new PersonCollection.CustomSearch();

peopleSearch.Restriction =
                    peopleSearch.TableInfo.ContactId.Equal(S.Parameter(3)).And(
                    peopleSearch.TableInfo.DayOfBirth.GreaterThan(S.Parameter(newDateTime(1970, 1, 1))));

PersonCollection people = peopleSearch.ToPersonCollection();
```

Notice how the Argument can contain more than one type of Argument to send to the underlying query. In this case, it leverages the Restriction And method to append a new Argument to the search query. Restriction also contains an Or method, to append OR statements to the query criteria.

## Entities / rows performance

The following figure displays a summary of performance using the different objects available to extract data from the database using Entities and Rows. The test database was a small one, with only 39 contacts. Using performance counters, the test included retrieving all contacts as a ContactCollection, ContactList, and ContactRows. ContactRows, being the lowest layer used, clearly out performed the other two queries with an average of 9.1 milliseconds. The ContactCollection query finished a little while later, at an average of 25.8 milliseconds. The ContactList trailed far behind the other two, with an average search time of 212.4 milliseconds.

**Performance testing:**

![x][img4]

## Conclusion

As you can see, there is a vast difference between the different approaches. Be aware though that just because one took longer to complete than the other, it does not mean it should not be used. Each query type has its place in the development world when used judiciously.

<!-- Referenced images -->
[img1]: media/netserverhilevelview.png
[img2]: media/persontableinfo.gif
[img3]: media/personrowsobject.gif
[img4]: media/contactchart.png
