---
title: foreign_keys
description: Foreign keys
author:
so.date:
keywords: database
so.topic: concept
---

# Foreign keys

This is a system designed to make it easy for 3rd parties to store keys in external systems.

The values are stored in the `ForeignKey` table, along with a pointer to the relevant entity (Contact, Person, Project record) that the foreign key identifies.

The values are identified by the `ForeingDevice` and `ForeignApp` tables.

## The tables

![x][img1]

The foreign key table can point to any record. There can be several different foreign keys registered on the same record, with different keys on different applications and devices.

`ForeignApp` defines an application. An application is present on one or more devices. If you’re not dealing with devices, then just repeat the application name, or use a blank string.

A `ForeignDevice` consists of one or more keys. Each key for a given device has its own name. The device record is intended to allow the same SuperOffice record to be mapped to different devices. For example, Company A might be stored as record 123 on my mobile phone, but as record 456 on your PocketPC.

Each `ForeignKey` can consist of several different record pointers. In the example above, we named the sub-key "ERP-id" but we could have added a second key called "ERP-name" without affecting the first key.

If the key value is particularly long, then the sequence ID on the foreignkey can be used to chain several values together into one long identifier.

## System integration

Often a system integration approach will use the **Number fields** (for example, `Contact.Number1` or `Project.Number`).

If the identifier is too complex or if there are more systems than there are number fields, then the Foreign Key system is worth checking out.

It is more complex than the number fields, but it is much more flexible.

## Example

We have an ERP system that we want to synchronize with SuperOffice.

First we need to create a foreign key application for the ERP system.

![x][img2]

* App\_id = 461
* name = "erp"

Then we create a dummy device - since the ERP system does not travel around on mobile phones.

![x][img3]

Finally we add a foreign key entry for the ERP ID for the contact

![x][img4]

We can retrieve the SuperOffice contact ID using the ERP ID 1234 like this:

```SQL
SELECT record_id FROM foreignkey
WHERE foreigndevice_id = 461 AND table_id = 5 AND subkey='erp-id' AND subvalue='1234'
```

We can find the ERP ID using the SuperOffice contact ID 56200 like this:

```SQL
SELECT subvalue FROM foreignkey
WHERE foreigndevice_id = 461 AND table_id = 5 AND record_id = 56200 AND subkey = 'erp-id'
```

## See also

* [foreignapp table][1]
* [foreigndevice table][2]
* [foreignkey table][3]

<!-- Referenced links -->
[1]: ../tables/foreignapp.md
[2]: ../tables/foreigndevice.md
[3]: ../tables/foreignkey.md

<!-- Referenced images -->
[img1]: media/foreign-keys.gif
[img2]: media/fk-app.gif
[img3]: media/fk-device.gif
[img4]: media/fk-value.gif
