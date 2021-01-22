---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: db_overview       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: An overview of the database # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
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

```sql
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

Also, at some point in the future, we may break the Person-contact relation, allowing consumers to be registered: person records without a corresponding company.

Whenever a user enters an appointment, it will have a non-zero `associate_id`, an `activeDate`, and one of the other two IDs set (contact, or project). The person ID can be zero even if the user has set a contact (selected a company, but no person).

<!-- Referenced images -->
[img1]: media/so-table-structure.gif
