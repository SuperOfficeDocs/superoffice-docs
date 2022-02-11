---
title: NetServer Nested Persist
uid: nested_persist
description: The Nested Persist concept is a concept that allows for multiple related objects to be saved within the same transaction.
author: Tony Yates
so.date: 06.12.2009
keywords: NetServer
so.topic: concept
---

# NetServer Nested Persist

The Nested Persist concept is a concept that allows for multiple related objects to be saved within the same transaction. All objects participating in this coordinated save needs to implement the INestedPersist Interface.

## INestedPersist

The members of the INestedPersist interface can be divided into three categories:

* Members exposed to the user of INestedPersist implementations
* Members supporting internal save process
* Members supporting relations between INestedPersist implementation

## Members exposed to the user

These members are typically exposed as public members on the class implementing INestedPersist and can be called by anybody using the object.

| Member | Description |
|---|---|
| Save() | Save all the contained objects to the database. |
| IsDirty | Is the object dirty? |
| IsMarkedForDelete | Gets or sets a value indicating whether this instance is marked for delete. |
| IsDeleted | Gets a value indicating whether this instance is deleted. |
| IsSaving | Is the nested persist in a saving state, hence disable Sentry when reading IDs |

Implementations typically also implement the property `IsNew`, which will typically be true if the object was never persisted to the database.

The `Delete()` method found on many implementations of INestedPersist is not part of the INestedPersist interface. It simply deletes the object from the database immediately. Later implementation introduced the property `IsMarkedForDelete`. Setting this property to true will result in the actual `Save()` operation to delete the object as part of the save transaction.

## Members supporting internal save process

These members represent the 6-step save process that all objects participating in a save operations follow. The role of this save operation is to implement support for the following:

* Obtain IDs as necessary from the Sequence mechanism
* Assign IDs on the primary key and foreign keys as needed to establish relations
* Save the data to the database.

The save operation goes through the following process:

1. `OnPreIdUpdate` is called on all members. This is to support a scenario where for example a note is added to a contact. A foreign key to the text record needs to be set on the contact. If this is the only modification to the contact row, it needs to be modified for the Contact to understand that it needs to be saved. Rows not modified are never saved. Hence, by assigning the value '-1' as a foreign key to the Note, the contact row is marked as dirty and consequently behaves the right way through the rest of the save process.

2. The second step in the save process is to request all objects involved in the save process if they need a primary key (for example, the object is going to be inserted into the database).

3. After `PKContainer` is populated with all objects in need of a primary key, ranges of primary keys are obtained from the sequence system as needed. All objects are again called with `OnPrimaryKeyUpdate` to retrieve the new primary key.

4. When all primary keys are obtained the "fake IDs'" can be replaced with the new IDs obtained from the sequence system.

5. The fifth step allows for all the objects participating in the save to amend themselves to the `BatchSave` object. The BatchSave object will then hold all the objects (rows) that need to be persisted to the database. This `BatSave` will then be passed on to the SQL command object and an `ExecuteNonReader` will be performed.

6. Finally, all objects participating in the save operation will be informed about the results of the save operation.

| Member | Description |
|---|---|
| OnPreIdUpdate() | Allow for "fake IDs" to be forced upon related objects. |
| OnPrimaryKeyRequest(PKContainer) | Allow the object to add itself to a collection of requests for primary keys. |
| OnPrimaryKeyUpdate(PKContainer) | Update primary key. |
| OnIdUpdate() | Update related objects with correct IDs to make sure that relations are consistent before saving to the database. |
| OnSave(BatchSave) | Add the object to the collection of objects that are to be saved within the transaction. |
| OnSaved(Boolean) | Called after the save operation was completed. A boolean value is passed to notify whether or not the save operation succeeded. The complete save operation is rolled back if the Save operation failed. |

## Members Supporting Relations Between INestedPersist Implementation

The most important member among these is SetSaveOwner(). This represents the concept of delegating the save operation to a parent. A typical example of this can be saving the note on a contact. Saving the note itself will not result in the contacts foreign key to the text record itself being updated. Hence, when save is called on the text row holding the note, the save is delegated to the contact. The contact will then execute the save process on all its members, including the note text record.

| Member | Description |
|---|---|
| SetSaveOwner(INestedPersist) | Force the save operation to be handled by someone else. |
| OnElementIdUpdate | Event raised when the item receives a primary key |
| OnElementSaved | Event raised when the item is saved to the database. |

## Save process

The following diagram describes the overall save process in further detail:

![Nested persist][img1]

## INestedPersist implementations

There are several implementations of the INestedPersist interface:

* NestedPersist: This is the default implementation.

* NestedPersistFacade: This implementation simplify support for implementing a container that holds many objects that needs to participate in a nested persist operation.

* NestedCollectionPersist: This is the default implementation for making a collection of INestedPersist implementations.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/nestedpersist.png
