---
title: Person name formatter
uid: globalization_personnameformatter
description: Localization, class PersonNameFormatter
author: {github-id}
so.date: 05.08.2018
so.topic: reference
keywords:
---

# Person name formatter

The `PersonNameFormatter` class, located is designed to format the names of person that exists in the database or a name that we specify. This class contains the following methods.

## Primary methods

| Name | Description |
|---|---|
| GetFormalName | Get the formal name for a person, as used in labels. |
| GetFullName   | Get the person's full name. |

## Additional methods

| Name | Description |
|---|---|
| GetAssociateNameFormatStylePreference | Get the `NameFormatStylePreference` for associates; fallback to person preference, ultimately to First/Last name. |
| GetNameFormatStylePreference | Get the name formatting preference for persons. |
| TryGetNameParts | Tries to extract the name into parts based on database preferences. |

`GetFormalName` method is an extension method used to get the formal name of a person. It is used as an extension to the `Person` and `PersonRow` data types, and depending on circumstances is optionally used as a static method.

Because user SAL0 is associated with the country Norway, and Norway does not use a title as part of the formal name, Kent's title of Dr and Mr. are both are ignored in output.

```csharp
using SuperOffice.CRM.Globalization;
using SuperOffice.CRM.Security;
using SuperOffice.CRM.Entities;
using SuperOffice;
using(SoSession session = SoSession.Authenticate("SAL0", ""))
{
  // retrieve a person entity through a person ID
  Person person = Person.GetFromIdxPersonId(59);
  PersonRow personRow = PersonRow.GetFromIdxPersonId(60);

  // format the name of the retrieved person according to the name format 
  // of the country the person belongs to
  string formatedName1 = PersonNameFormatter.GetFormalName(person);
  string formatedName2 = PersonNameFormatter.GetFormalName(personRow);

  // or use the extension method on the person directly
  string formatedName3 = person.GetFormalName();
  string formatedName4 = personRow.GetFormalName();

  // outputs:
  // Kent Larsen Karlsen
  // Kjell Kristiansen
}
```

A name format is determined by the `AddressFormat` `ExtraFlags` property. When set, the title is added to the name. However, the people with ID 59 and 60 are Norwegian, and therefore the `AddressFormat` in that case specifies that that title should not appear with the name. To help clarify, the example below changes the person's country of origin, and then performs the same logic.

```csharp
using SuperOffice.CRM.Globalization;
using SuperOffice.CRM.Security;
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession session = SoSession.Authenticate("SAL0", ""))
{
  // retrieve a person entity through a person ID
  Person formatPerson = Person.GetFromIdxPersonId(59);

  //get the country of the new country lest take Germany
  CountryRow newCountry = CountryRow.GetFromIdxCountryId(276);

  //assign it to the country property of the person entity
  formatPerson.Country = newCountry;

  //save the person entity
  formatPerson.Save();

  //we have to retrieve it again so that the new changes are visible
  formatPerson = Person.GetFromIdxPersonId(59);

  //now lets format the name and see what happens
  string formatedName = PersonNameFormatter.GetFormalName(formatPerson);

  // output:
  // Mr Kent Larsen Karlsen\nDr
}
```

With the person's country of origin changed to Germany, now the Mr. prefix is output in front of the name and the Dr title at the end of the name separated by a new line character. When assigned to the text property of a label control, the Dr title appears on a new line after the name.

**GetFullName** has several overloads to format a person's fullname according to a specified style, or according to the style stored in user preferences cache. If the user preference cache is not present, the preferences are retrieved from the database and then stored in cache for subsequent requests.

The following example demonstrates how to use both extension methods and the PersonNameFormatter on a **Person** and **PersonRow**.

```csharp
using SuperOffice.CRM.Globalization;
using SuperOffice.CRM.Security;
using SuperOffice.CRM.Entities;
using SuperOffice;
using(SoSession session = SoSession.Authenticate("SAL0", ""))
{
  // retrieve a person entity through a person ID
  Person    person    = Person.GetFromIdxPersonId(59);
  PersonRow personRow = PersonRow.GetFromIdxPersonId(59);

  // extension method usage
  var formattedNamea = person.GetFullName();
  var formattedNameb = personRow.GetFullName(PersonNameFormatter.NameFormatStylePreference.LastNameFirstName);

  //retrieve the full name of the person according to the style stored
  //in the user Preference cache if not in the cache will be pulled
  //from the DB
  string formatedName1 = PersonNameFormatter.GetFullName(person);
  string formatedName2 = PersonNameFormatter.GetFullName(personRow);
  string formatedName3 = PersonNameFormatter.GetFullName(person,
        PersonNameFormatter.NameFormatStylePreference.LastNameFirstName);
  string formatedName4 = PersonNameFormatter.GetFullName(personRow,
        PersonNameFormatter.NameFormatStylePreference.FirstNameOnly);
  string formatedName5 = PersonNameFormatter.GetFullName("Kent", "Larsen", "Karlsen");
  string formatedName6 = PersonNameFormatter.GetFullName("Kent", "Larsen", "Karlsen",
        PersonNameFormatter.NameFormatStylePreference.LastNameOnly);

  // outputs:
  // 1: Kent Larsen Karlsen
  // 2: Kent Larsen Karlsen
  // 3: Larsen Karlsen, Kent
  // 4: Kent
  // 5: Kent Larsen Karlsen
  // 6: Larsen Karlsen
}
```

## Conclusion

Using `PersonNameFormatter` is useful when working with `Person` and `PersonRow`, and makes it easy to get targeting information without having to roll your own name formatter.
