---
title: search      
description: Search
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic:
---

# Search

A search is when we are trying to retrieve a set of data that matches our specifications. We can pass our specifications as a set of restrictions to the search.

## Criteria and restrictions

Documentation and the user interface will often talk about **criterion** and **criteria**. The corresponding concept in NetServer is known as an **archive-restriction.**

Both represent an object consisting of:

* A field name
* An operator appropriate to the field (equals, begins with, greater than, etc)
* Zero or more values for the operator to operate on

## A word about archives

Archives consist of lists of Persons, Activities, Projects, and many more. The Archives contains a vast collection of data that are either Contact specific or Project specific.

A typical archive would be all the persons for a given contact. That can be expressed as a request to the person archive for all persons where `contact_id = 123`.

Searches are different use of archives. The basic principles and technologies are the same. Searches use more general restrictions such as `person/firstname = John`.

The search and the person archive would just be two different search requests to the same person archive.
