---
title: itunes_like_activities
description: iTunes like client over all activities
author: {github-id}
so.date: 
keywords: diary
so.topic: tutorial
---

# iTunes-like client for activities

A Windows application that retrieves a list of activities for the past 6 months of the logged-in user using the `ActivityArchiveProvider`. The client should also be able to filter the activities based on input from the user.

When we're done, it should look like this:

![01][img1]

## Activity Grid

This section explains how to retrieve activity information using the Activity Archive Provider and convert the retrieved information into a format that can be displayed in a data grid.

[!code-csharp[CS](includes/itunes-setdatagrid.cs)]

The above code segment uses the **SuperOffice.CRM.ArchiveLists.ActivityArchiveProvider** to retrieve the activities registered within the last 6 months.

### Section 1 (prepare parameters)

Section 1 shows how the parameters required by the `GetArchiveListByColumns` method are created:

* the columns to be included in the selection
* the search restrictions
* the order in which the results to be sorted
* the entities to be included in the search

Next, an `IArchiveAgent` object is retrieved using the AgentFactory. Then the `GetArchiveListByColumns` method is invoked to get the activity information.

### Section 2 (convert)

The next step is to convert the retrieved activity data into a format that can be displayed in a data grid. Here, we have chosen to iterate over the retrieved `ArchiveListItem` collection and encapsulate those data into a custom object type called `ActivityData` which represents an activity object irrespective of the underlying generic activity type (Sale, Document, or Appointment).

First, we have created an array of type `ActivityData`, the type that is used to hold activity data. The `ArchiveListItems` collection is iterated and the data values are extracted for each `ArchiveListItem` and stored in a `ListDictionary`, which contains details of one activity at a time.

Then the `ActivityData` objects are created based on data in the `ListDictionary` and stored in the `ActivityData` array. The type of the activity is checked at the time of creating the `ActivityData` object and the entity-specific information such as the `SaleId`, `AppointmentId`, and `DocumentId` is assigned.

## ActivityData carrier

Have a look at the generic `ActivityData` class, which is used to hold activity data as mentioned in the previous section.

**Properties:**

* Date
* Id
* Description
* Activity Type (Document, Sale, or Appointment)
* the Name of the Project associated with an activity

[!code-csharp[CS](includes/itunes-activitydata.cs)]

## Filtering the grid

Once the data are retrieved we can filter the data according to the search text specified by the user.

[!code-csharp[CS](includes/itunes-searchtext.cs)]

The DataGridViewRow collection of the data grid view is iterated for each activity data row and the Description column is checked to see if the description contains the search text. If the activity description does not contain the specified text the row is made invisible.This method is invoked in the TextChanged event of the search text box as shown below.

```csharp
using (SoSession newSession = SoSession.Authenticate("p", "p"))
{
  // populate the grid with all the activities for the given period
  this.setDataGrid();

  // filter the records
  this.searchText();
}
```

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image023.jpg
