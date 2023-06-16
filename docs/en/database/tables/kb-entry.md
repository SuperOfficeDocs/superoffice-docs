---
uid: table-kb_entry
title: kb_entry table
description: This table contains FAQ entries.
so.generated: true
keywords: database table kb_entry
so.topic: reference
so.envir: onsite, online
---

# kb\_entry Table (282)

This table contains FAQ entries.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|category\_id|The id of the category in which this entry is located.|FK [kb_category](kb-category.md)| |
|title|The title of this entry.|String(255)|&#x25CF;|
|question|The question for this entry.|Clob|&#x25CF;|
|answer|The answer for this entry.|Clob|&#x25CF;|
|keywords|The keywords for this entry|String(255)|&#x25CF;|
|access\_level|The access level for this entry (enum).|access_level|&#x25CF;|
|created\_by|The id of the user who owns this entry.|FK [ejuser](ejuser.md)|&#x25CF;|
|sort\_order|A scrictly ascending number indicating the sort-order when listing entries.|Int| |
|last\_changed|When the entry was last changed.|DateTime|&#x25CF;|
|read\_count|The number of times someone has read this entry from the customer frontend.|Int| |
|score|The accumulated score (0..100) for this entry.|Int|&#x25CF;|
|score\_weight|The number of votes behind the accumulated score.|Int|&#x25CF;|
|flags|A bitmap field.|UInt|&#x25CF;|
|status|The status for this entry (enum).|status|&#x25CF;|
|expire\_date|The date until which this entry is valid.|DateTime|&#x25CF;|
|workflow\_phase|The workflow phase this entry is in|FK [kb_workflow](kb-workflow.md)| |
|dbi\_agent\_id|Integration agent (eJournal)|FK [dbi_agent](dbi-agent.md)| |
|dbi\_key|The primary key for the integrated entry in the external datasource.|String(255)| |
|dbi\_last\_syncronized|Last external syncronization.|DateTime| |
|dbi\_last\_modified|When the entry was last modified.|DateTime| |


![kb_entry table relationship diagram](./media/kb_entry.png)

[!include[details](./includes/kb-entry.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|category\_id |FK |Index |
|created\_by |FK |Index |
|sort\_order |Int |Index |
|workflow\_phase |FK |Index |
|dbi\_agent\_id |FK |Index |
|dbi\_key |String(255) |Index |
|dbi\_last\_syncronized |DateTime |Index |
|dbi\_last\_modified |DateTime |Index |
|title, question, answer, keywords |String(255), Clob, Clob, String(255) |Full text |

## Relationships

| Table|  Description |
|------|-------------|
|[dbi\_agent](dbi-agent.md)  |DBI agent settings |
|[ejuser](ejuser.md)  |This table contains entries for the users of the system. |
|[kb\_attachment](kb-attachment.md)  |This table connects FAQ entries to attachments. |
|[kb\_category](kb-category.md)  |Knowledge base folder hierarchy |
|[kb\_entry\_comment](kb-entry-comment.md)  |Comments to entries in the knowledge base, typically made by customers |
|[kb\_entry\_keyword](kb-entry-keyword.md)  |This table contains all keywords for the faq entries |
|[kb\_entry\_log](kb-entry-log.md)  |Who and when, if somebody edits a knowledge base entry |
|[kb\_group\_entry](kb-group-entry.md)  |This table contains group entries for FAQ groups. |
|[kb\_http\_link](kb-http-link.md)  |This table contains URL&amp;apos;s associated with a single FAQ entry. |
|[kb\_solution\_finder\_entry](kb-solution-finder-entry.md)  |Knowledge base problem solving wizard, items in a category linking to a knowledge base entry |
|[kb\_workflow](kb-workflow.md)  |Knowledge base workflow steps |
|[word\_relations](word-relations.md)  |This table shows which word are used in which FAQ entry, and how many times            they are used in each |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

