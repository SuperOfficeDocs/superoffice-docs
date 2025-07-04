---
uid: tutorial-itunes-like-activities
title: Tutorial - iTunes-like client for activities
description: In this tutorial, you will learn how to create a Windows application that retrieves a list of activities for the past 6 months of the logged-in user using the ActivityArchiveProvider.
keywords: iTunes, ActivityArchiveProvider
date: 03.21.2022
version: 10
content_type: tutorial
language: en
redirect_from: /en/diary/tutorials/itunes-like-activities/index
---

# Tutorial - iTunes-like client for activities

## Step 1: Introduction

This Windows application retrieves a list of activities for the past 6 months of the logged-in user. It also supports filtering the activities based on user input.

Steps 2 and 3 explain how to retrieve activity information using the Activity Archive Provider and convert the retrieved information into a format that can be displayed in a data grid.

The code segments use the **SuperOffice.CRM.ArchiveLists.ActivityArchiveProvider** to retrieve the activities.

## Step 2: Prepare parameters

Section 1 in the code shows how the parameters required by the `GetArchiveListByColumns` method are created:

* the columns to be included in the selection
* the search restrictions
* the order in which the results should be sorted
* the entities to be included in the search

[!code-csharp[CS](includes/itunes-setdatagrid.cs?range=1-45)]

Next, an `ArchiveAgent` object is created. Then the `GetArchiveListByColumns` method is invoked to get the activity information.

## Step 3: Convert

The next step is to convert the retrieved activity data into a format that can be displayed in a data grid.

[!code-csharp[CS](includes/itunes-setdatagrid.cs?range=46-102)]

Here, we have chosen to iterate over the retrieved `ArchiveListItem` collection and encapsulate those data into a custom object type called `ActivityData` which represents an activity object irrespective of the underlying generic activity type (Sale, Document, or Appointment).

First, we have created an array of type `ActivityData`, the type that is used to hold activity data. The `ArchiveListItems` collection is iterated and the data values are extracted for each `ArchiveListItem` and stored in a `ListDictionary`, which contains details of one activity at a time.

Then the `ActivityData` objects are created based on data in the `ListDictionary` and stored in the `ActivityData` array. The type of the activity is checked at the time of creating the `ActivityData` object and the entity-specific information such as the `SaleId`, `AppointmentId`, and `DocumentId` is assigned.

### ActivityData carrier

Have a look at the generic `ActivityData` class, which is used to hold activity data as mentioned in the previous section.

**Properties:**

* Date
* Id
* Description
* Activity Type (Document, Sale, or Appointment)
* The Name of the Project associated with an activity

[!code-csharp[CS](includes/itunes-activitydata.cs)]

## Step 4: Filter the grid

Once the data are retrieved we can filter the data according to the search text specified by the user.

```csharp
private void searchText()
{
  // iterate through the DataGridViewRow collection of the gridview
  foreach (System.Windows.Forms.DataGridViewRow datarow in this.grdActivityData.Rows)
  {
    //  checking the 'Description' column of the current row to see if it contains the search text
    if (datarow.Cells["Description"].Value.ToString().Contains(this.txtSearch.Text.Trim()))
    {
      // make the datarow visible if it contains the search text
      datarow.Visible = true;
    }
    else
    {
      this.grdActivityData.CurrentCell = null;
      datarow.Visible = false;
    }
  }
}
```

The `DataGridViewRow` collection of the data grid view is iterated for each activity data row and the Description column is checked to see if the description contains the search text. If the activity description does not contain the specified text the row is made invisible. This method is invoked in the `TextChanged` event of the search text box as shown below.

```csharp
using (SoSession newSession = SoSession.Authenticate("p", "p"))
{
  // populate the grid with all the activities for the given period
  this.setDataGrid();

  // filter the records
  this.searchText();
}
```

## Step 5: Summary

When we're done, it should look like this:

![iTunes tutorial result -screenshot][img1]

## See also

* [SuperOffice iCal Feed][1]

<!-- Referenced links -->
[1]: ../so-ical-feed/index.md

<!-- Referenced images -->
[img1]: media/image023.jpg
