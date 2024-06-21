---
title: Full-text search
uid: sql_server_full_text_search
description: SQL server native full-text search
author: {github-id}
keywords: database
topic: howto
envir: onsite
# client:
---

# SQL server native full-text search

Full-text indexing is a database capability and needs to be supported and enabled in the database.

> [!TIP]
> Contact your database vendor for information on how to enable this on your database.

Service (formerly known as eJournal) has had this functionality available since version 4.7. From CRM 7, this functionality is now also available on some fields in Sales & Marketing Win and Web client.

If full-text search is enabled on the database, it will use special search syntax when searching for the following entities:

## In Service

* Request content (title and message text)
* Knowledge base FAQ articles
* Quick search field, when searching request titles

## In Sales & Marketing

All long text fields like appointment text, yellow notes, descriptions.

> [!NOTE]
> This is not a replacement for our full-text search since
 it only works on specific fields, as part of the structured search system (Find)

The new full-text search functionality works differently than ordinary (much slower) text search, and there are some differences in search behavior. Using the classic text search the database would match against any record that contains your text query anywhere. With the new full-text search capability, the text is portioned into words, and the words need to match – a part of a word will not match.

This table illustrates the different search behavior when searching for "enigma":

| Words in the database | Match classic text search | Match new full-text search |
|-----|-----|-----|
| Enigma | Yes | Yes |
| Enigmatic | Yes | No |
| Unenigmatic | Yes | No |

The speed of the search is highly dependent on the kind of search functionality you use.  In a database with a lot of requests and messages, a request content search can take several minutes to complete using the classic search functionality. With the new full-text search functionality enabled it usually takes less than a second to complete such a query.

To get full-text search capability, you need to enable the Microsoft Indexing Service on the MSSQL server.  If it’s not installed, you need to install it.

| Table | Fields |
|-------|--------|
| message | search_title, body, html_body |
| ticket | title |
| kb_entry | title, question, answer, keywords |
| text | text |

## Turn on full-text search on an existing database

**Dbsetup** will detect if full-text search is set up or not. If you have turned on the full-text search on an existing database, you have to do a rebuild of the database to get the functionality working.
