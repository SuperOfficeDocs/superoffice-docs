---
title: activity_links
description: Activity links sub-object on models
author:
so.date:
keywords: appointment,document,sale
so.topic: concept
---

# Activity links sub-object on models

Appointments, documents, sales can link to each other

The system uses the relation table (originally used only for person/contact relations).

This replaced the old single-value `DocumentLink` property that `Appointment` and `Sale` used to have before SuperOffice 6.

The system uses the relation table to allow many-to-many links between all activities.

![x][img1]

This appointment is saved with `appointment_id = 24`

![x][img2]

To find all the links from this appointment:

```SQL
select * from relations where source_table=9 and source_record=24
```

![x][img3]

These links are all defined by `reldef_id` = 8 (appointment), 9 (document), and 10 (sale), which looks like this:

```SQL
Select * from relationdefinition
```

![x][img4]

> [!NOTE]
> A relationship definition can apply to more than one table.

In this case, the link can be to appointments, documents, or sales:

```SQL
Select * from relationtarget where reldef_id in (8, 9, 10)
```

![x][img5]

To summarize in diagram form:

![x][img6]

## See also

* [relationdefinition table][1]
* [relations table][2]
* relationship table
* [relationtarget table][4]

<!-- Referenced links -->
[1]: ../../../../database/docs/tables/relationdefinition.md
[2]: ../../../../database/docs/tables/relations.md
[4]: ../../../../database/docs/tables/relationtarget.md

<!-- Referenced images -->
[img1]: media/screencap4.png
[img2]: media/links-appointment-record.png
[img3]: media/links-relations.png
[img4]: media/links-reldeflist.png
[img5]: media/links-reldef.png
[img6]: media/link-diagram.png
