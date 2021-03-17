---
title: get_persons_from_contact_sql
description: Get a list of people for a contact
author:
so.date:
keywords:
so.topic: howto
---

# Get a list of people for a contact

First, we need to find the `contact_id` for the contact.

Assuming we know the name of the contact:

```SQL
SELECT * FROM contact WHERE name = 'SuperOffice Corporation'
```

This gives us a `contact_id`.

![SELECT contact][img1]

We plug this into the next query, which gives us a list of people for that company:

```SQL
SELECT * FROM person WHERE contact_id = 81
```

![SELECT person][img2]

We can join these two queries into one:

```SQL
SELECT * FROM person p, contact c 
WHERE c.name = 'My Favorite Company'
AND c.contact_id = p.contact_id
```

![x][img3]

<!-- Referenced images -->
[img1]: media/select-contact.gif
[img2]: media/select-person.gif
[img3]: media/select-contact-person.gif
