---
title: search      
description: Search
author: SuperOfficeDevNet
so.date:
keywords: search
so.topic:
---

# Search

SuperOffice provides search capabilities via [Archive Providers][0]. A search is performed by querying an archive provider, which acts as a data source, that returns a set of data that matches a set specification of criterion.
## Criteria and restrictions

Documentation and the user interface will often talk about **criterion** and **criteria**. The corresponding concept in NetServer is known as an **archive-restriction.**

Both represent an object consisting of:

* A field name
* An operator appropriate to the field (equals, begins with, greater than, etc)
* Zero or more values for the operator to operate on

## A word about archives

Archives providers consist of lists of Persons, Activities, Projects, [and many more][1]. The archives providers contains a vast collection of data that are contextually specific to the archive provider called. For example, the available fields from the SimpleContact archive provider are only fields about contacts themselves. However, the ContactActivity archive provider exposes fields from not just the contact table itself but related table data, i.e. documents, appointments, mailings, etc.

A typical search performed by an archive provider is to return all the persons for a given contact. That is expressed as a request to the SimplePerson archive provider with a restriction where `contact_id = 123`.

[Find searches][2] are a different use of archives. The basic principles and technologies are the same, but Find searches use the same subsystem as the [SuperOffice Selection][3] feature.


<!-- Links -->

[0]: ../archive-providers/index.md
[1]: ../archive-providers/reference/index.md
[2]: find-selection/index.md
[3]: https://community.superoffice.com/en/customer/learn/standard/selections/
