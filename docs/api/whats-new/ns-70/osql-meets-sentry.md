---
title: whats_new_70_
description: NetServer 7.0
author: {github-id}
so.date: 11.05.2016
keywords: 
so.topic: reference
---

# OSQL meets Sentry

The SQL we generate may not be what you expected.

The previous example code generated... what?

```SQL
SELECT do_by, DATEPART(day, do_by) AS "dbd"
FROM crm7.appointment 
WHERE DATEPART(year, do_by) = 2010
```

...or...

```SQL
/* DateParts */ SELECT T0."do_by", 
DATEPART(day, T0."do_by") AS "dbd", 
T0."appointment_id", T0."type", 
T0."associate_id", T0."group_idx", 
T0."assignedBy", T0."registered", 
T0."registered_associate_id", 
T0."mother_id", T1."forAll", 
T1."forAssocId", T1."forGroupId" 
FROM CRM5."APPOINTMENT" T0  
INNER JOIN CRM5."VISIBLEFOR" T1 
ON (T0."appointment_id" = T1."appointmentId")
WHERE DATEPART(year, T0."do_by") = 2010
```

**Sentry** needs multiple fields to calculate rights. It can also restrict the query to filter out rows outright, in the database. This is done through a query interception deep down in NetServer, which gives each Sentry instance a chance to amend the OSQL before it goes to generation.

For example, `AppointmentSentry` adds join to `VisibleFor`, and fetches the fields it needs.
