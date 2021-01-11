---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: soundx       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Soundex comes to NetServer # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Marek Vokáč             # Your GitHub alias.
so.date: 05.07.2012
keywords:
so.topic: article          # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Soundex comes to NetServer

As you may or may not know, we have a "sounds-like" algorithm in the SuperOffice products. It's our adaptation of a fairly well-known algorithm called [Metaphone][1], which takes a string of arbitrary length and returns a transformed version of a fixed, shorter length. The transformation is such that strings that sound similar (are phonetically approximately equal) will result in identical transformed strings.

We apply this algorithm to contact.name, project.name and selection.name, and store the resulting string in the soundEx field in each of those tables. The application is done transparently by both NetServer and the C++ code, so unless you're messing with our database on your own, it should be up to date.

You can use this to search for entities with similar names - that's what the CRM client does when it says "Oh, the company you're adding sounds like one you've got before"; this simply means that we got an exact match for the soundEx string.

So far so good - but the database servers (SQL Server, Oracle, Sybase, DB/2) all have their own implementations of a similar algorithm. And this is interesting because it can be applied to WHERE statements as a function, on any string field, not just where someone (us) planned for it.

In 7.1 we've added support for this function in NetServer, so you can access it in your custom SQL. As an example of what it might be good for, I wrote a little utility that helps us combine duplicate persons that arise when a sales rep registers a person for our Online product, and the automated sync later on adds the person as spelled in the Online database. Those spellings - by the sales rep, and by the person, may not always be the same, and so we end up with two records that **sound much the same but are not identical**. A job for Soundex!

```csharp
PersonTableInfo p1 = TablesInfo.GetPersonTableInfo();
PersonTableInfo p2 = TablesInfo.GetPersonTableInfo();

ContactTableInfo c1 = TablesInfo.GetContactTableInfo();

Select s = S.NewSelect("Find duplicates");

  s.JoinRestriction.InnerJoin(p1.ContactId.Equal(p2.ContactId),  
    S.ArgumentFunctions.Soundex(p1.Firstname).Equal(S.ArgumentFunctions.Soundex(p2.Firstname))
    .And(S.ArgumentFunctions.Soundex(p1.Lastname).Equal(S.ArgumentFunctions.Soundex(p2.Lastname))));

s.RestrictionAnd(p1.PersonId.UnEqual(p2.PersonId));
```

Here we're looking for person records that belong to the same contact, have similar-sounding first and last names, and are not the same record (important detail...). Suppose we want to fetch these candidates as Row objects...

```csharp
s.ReturnFields.Add(p1, p2, c1);

using (var qeh = new QueryExecutionHelper(s))
{
  while (qeh.Reader.Read())
  {
    PersonRow personOne = PersonRow.GetFromReader(qeh.Reader, p1);
    PersonRow personTwo = PersonRow.GetFromReader(qeh.Reader, p2);
    ContactRow contact = ContactRow.GetFromReader(qeh.Reader, c1);
  }
}
```

Note that the Soundex algorithm can be implemented differently by each database - so while this code will work on all of the databases we support, it may not give the exact same results. And you should never store the output from Soundex anywhere for later use because the algorithms might change, the database might move to another server - who knows. But using it **within a single SQL statement** should work just fine.

You could of course fetch all Person records and process them through the Metaphone algorithm in NetServer; that would give you a predictable result, independent of the database. It would also run orders of magnitude slower since you'd be doing the processing outside the database. Your mileage may vary - but as a rule, keeping processing inside the database is good, that is what it's for.

<!-- Referenced links -->
[1]: https://en.wikipedia.org/wiki/Metaphone
