---
title: Full-text search
uid: netserver_fulltext_search
description: Changes in SuperOffice 7 - authentication
author: {github-id}
keywords: database
so.topic: reference
so.envir: onsite
# so.client:
---

# Full-text search

SQL Server 2005, 2008, 2012, and 2014 only. We plan to implement it on Oracle (no yet sure which versions).

This is enabled for text.text and some Service fields. It requires that these [enable fulltext search][1] is turned on when database is created (or later, but before you run ServerSetup/DbSetup)
It gives a lightning-fast search on all our long text fields (appointment text, yellow notes, descriptions)
DB-specific syntax in search fields

* SQL Server: "marek AND petter AND NOT nils" will find texts that contain the words ’marek’ and ’petter’, and do not contain the word ’nils’
* You write this search string directly in the corresponding text field in the Find dialog

This is not a replacement for our full-text search, since it only works on specific fields, as part of the "structured" search system (Find)

If you do not enable full-text search in the database, then this functionality will simply be unavailable; no error messages or other problems. Text searches will then be slow if you have millions of appointments

There is no indication in the GUI whether you have this or not.

<!-- Referenced links -->
[1]: http://technet.microsoft.com/en-us/library/ms403375(SQL.90).aspx
