---
title: System integration
uid: foreign_keys_integration
description: Foreign keys integration
author:
so.date:
keywords: database
so.topic: concept
---

# System integration

Often a system integration approach will use the **Number fields** (for example, `Contact.Number1` or `Project.Number`).

If the identifier is too complex or if there are more systems than there are number fields, then the Foreign Key system is worth checking out.

It is more complex than the number fields, but it is much more flexible.

## Example

We have an ERP system that we want to synchronize with SuperOffice.

First, we need to create a foreign key application for the ERP system.

![x][img2]

* `App_id` = 461
* `name` = "erp"

Then we create a dummy device - since the ERP system does not travel around on mobile phones.

![x][img3]

Finally, we add a foreign key entry for the ERP ID for the contact

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

<!-- Referenced images -->
[img2]: media/fk-app.gif
[img3]: media/fk-device.gif
[img4]: media/fk-value.gif
