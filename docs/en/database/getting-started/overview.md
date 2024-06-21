---
title: Overview
uid: db_overview
description: An overview of the database
author: {github-id}
keywords: database
topic: concept
# envir:
# client:
---

# An overview of the database

The database has quite a few tables in it. About 456 tables in total. Nothing like a Siebel or SAP system, but still enough to be confusing at first look.

The main objects in the system are:

* Activities (`Appointment` table) - including the date and time the activity happened
* Companies (`Contact` table)
* Projects
* Users (`Associate` table)
* Tickets

In the database, these relationships are expressed using the following set of tables and fields.

![table structure][img1]

This gives us the following join conditions we can use:

```SQL
Appointment.contact_id = Contact.contact_id
Appointment.person_id = Person.person_id
Appointment.project_id = Project.project_id
Appointment.associate_id = Associate.associate_id
Person.contact_id = Contact.contact_id
Associate.person_id = Person.person_id
Ticket.cust_id = person.person_id
```

The `appointment` table contains foreign keys to all the other important tables, plus a date field (`ActiveDate`).

Because the people working for your customers are often important too, we keep track of them as well. We break 3rd normal form (a database design principle) by storing both the `contact_id` and the `person_id` in the appointment to make the database more efficient.

Also, in the future, we may break the Person-contact relation, allowing consumers to be registered: person records without a corresponding company.

Whenever a user enters an appointment, it will have a non-zero `associate_id`, an `activeDate`, and one of the other two IDs set (contact, or project). The person ID can be zero even if the user has set a contact (selected a company, but no person).

<!-- Referenced images -->
[img1]: media/so-table-structure.gif
