---
title: get_person_from_contact_sodatareader
description: Retrieve a list of people using SODataReader
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: sodatareader,person
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Retrieve a list of people using SODataReader

[!include[ALT](../../includes/note-using-sodatareader.md)]

[!code-csharp[CS](includes/get-persons-from-contact-sodatareader.cs)]

For us to get a list of persons for a given contact, we need the `contact` table and the `persons` table. In the above example, first, we have created 2 table info objects we need. Once we have the table info objects we can start building our select statement.

We start by specifying the return fields, the restriction we want (`Contact_Id = 21`) and then we join the 2 tables. Here we join the `contact` table and the `persons` table with contact ID.

Then we can order the results of our select statement, in this case by the `FirstName` in the ascending order. You can leave the ordering out if you prefer.

Now we can execute the reader and get our results to an `SoReader` object. Once you have the records in the reader, you can loop through the results and access individual fields returned. Here, we have concatenated the first name and the last name of the person records returned and assigned to a combo box.

<!-- Referenced links -->
[1]: ../../osql/so-data-reader.md
[2]: ../../osql/inded.md
