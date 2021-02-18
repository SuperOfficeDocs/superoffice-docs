---
# Mandatory fields.
title: activity_archive_filters 
description: How to use ActivityArchive filters
author: {github-id}             # Your GitHub alias.
keywords: 
so.topic: howto                # article, howto, reference, concept, guide
so.date:
so.category: 
so.area: api-services

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to use ActivityArchive filters

The following example shows the use of ActivityArchive filters. Unlike other archives, the `ActivityArchive` allows us to take columns from multiple archives.

[!code-csharp[CS](includes/iarchiveagent-contact.cs)]

As we can see, `GetArchiveListByColumns()` requires 7 parameters to be passed into it. These are explained in detail on the [IArchiveProvider][1] page. Below we touch on what's different.

## archiveProviderName

`ContactActivityArchiveProvider.ProviderName`

## archiveColumns

`{ "contact/name", "associate/fullName", "person/fullName", "saleId", "currency" }`

>[!NOTE]
> The ActivityArchive allows us to take columns from multiple archives. Here we retrieve the name of the contact from the `Contact` entity, the full name of the associate from the `Associate` entity, the full name of the person from the `Person` entity, and `SaleId` and `Currency` from the `Sale` entity. These retrieves would be impossible if we were to have an Appointment column or a Document column.

## archiveSrtOrd

Here we are sporting by the `saleId` with the highest ID first in the list. Any row that doesn’t have a `saleId` will be sorted as value 0 and would be shown at the end of the list.

## archiveRest

What we have done here is set the restriction, as ContactID, which is obtained from the `Contact` entity, should equal to the specified value (68). This means that we are retrieving all the Appointments, Documents, and Sales records that have the `contactId` as "68".

## desiredEntities

The entities correspond to checkboxes in the Archive GUI. If we remove "document" from this list, the `Document` records are never fetched from the database and the `Documents` rows will disappear from the results.

Once all parameters have been created, we may use them with the `GetArchiveListByColumns` method, which returns an array of `ArchiveListItem`.

The next step we need to do is to loop through the above array just like we did in the [first example][1].

## Output

```text
person/fullName  contact/name    associate/fullName   currency    saleId
0-Feil           Software AS     Brede Bredesen       SEK         [I:19]
0-Feil           Software AS     Arne Arnesen         SEK         [I:10]0-Feil           Software AS     Arne Arnesen         NOK         [I:9]
0-Feil           Software AS     Arne Arnesen         NOK         [I:8]
0-Feil           Software AS     Arne Arnesen         SEK         [I:7]
```

<!-- Referenced links -->
[1]: iarchiveagent.md
