---
title: Get a list of people for a contact
uid: get_persons_from_contact_sql
description: How to get a list of people for a contact
author: Bergfrid Skaara Dias
so.date: 11.02.2021
keywords: person, contact, company, API
so.topic: howto
---

# Get a list of people for a contact

First, we need to find the `contact_id` for the contact.

Assuming we know the name of the contact:

```SQL
SELECT * FROM contact WHERE name = 'SuperOffice Corporation'
```

This gives us a `contact_id`.

| contact_id | name | department | associate_id | country_id | business_idx | ...|
|---|---|---|---|---|---|---|
| 81 | SuperOffice Corporation | CorpDep | 4 | 840 | 319 | |

We plug this into the next query, which gives us a list of people for that company:

```SQL
SELECT * FROM person WHERE contact_id = 81
```

| person_id | contact_id | rank | lastname | firstname | title | ... |
|---|---|---|---|---|---|---|
| 72 | 81 | 1 | Larsson | Gunnar | President | |
| 32419 | 81 | 2 | Petrillo | Jim | Tech support | |
| 41502 | 81 | 3 | Jangochian | Jeanne | Sales and accointing | |
| 136248 | 81 | 4 | Test | | | |
| 136262 | 81 | 5 | Amtest | | | |

We can join these two queries into one:

```SQL
SELECT * FROM person p, contact c 
WHERE c.name = 'My Favorite Company'
AND c.contact_id = p.contact_id
```

| person_id | contact_id | rank | lastname | firstname | >contact_id | name | department | ... |
|---|---|---|---|---|---|---|---|---|
| 72 | 81 | 1 | Larsson | Gunnar | 81 | SuperOffice Corporation | CorpDep | |
| 32419 | 81 | 2 | Petrillo | Jim | 81 | SuperOffice Corporation | CorpDep | |
| 41502 | 81 | 3 | Jangochian | Jeanne | 81 | SuperOffice Corporation | CorpDep | |
| 136248 | 81 | 4 | Test | | 81 | SuperOffice Corporation | CorpDep | |
| 136262 | 81 | 5 | Amtest | | 81 | SuperOffice Corporation | CorpDep | |
