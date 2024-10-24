<!-- markdownlint-disable-file MD041 -->
The next step is to convert the retrieved activity data into a format that can be displayed in a data grid.

[!code-csharp[CS](../itunes-setdatagrid.cs?range=46-102)]

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

[!code-csharp[CS](../itunes-activitydata.cs)]
