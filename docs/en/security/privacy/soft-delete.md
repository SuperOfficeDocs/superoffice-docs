---
title: Soft delete
uid: soft_delete
description: Soft delete
author: Marek Vokáč, Eivind Fasting
date: 09.25.2024
keywords:
topic: article
---

# Soft delete

Soft delete means that instead of deleting a record physically from the database, it is marked as deleted instead. Rows that have NULL or our beginning-of-time value (which in SuperOffice is 1.1.1760) are considered active; rows that have a different date are considered deleted.

When a **contact** or **person** is deleted in SuperOffice it gets the **deletedDate** set, and when a **request** is deleted it sets the [status of the ticket to Deleted][5] and updates last_changed. This removes it from the UI and puts it in the [Recycle Bin][1]. What happens behind the scenes is that when the application code searches for a record in for example the person-table, this code will appendAND (deletedDate IS NULL OR deletedDate = 1.1.1760) to the query (for each table that has soft-delete). As a result, such rows disappear from the results and are never given back to the application – which in practice is the same as deleting them.

## GDPR

GDPR places limits on keeping irrelevant information, and soft-deleted records are no exception. Therefore, after a time – which will default to 14 days unless specifically set in [System preference][2] >> **Retain deleted data** – a periodic background process will *really* delete soft-deleted records that are older than the "retention time".

Directly dependent records such as email or phone are deleted. Other tables have independent reasons to exist: a meeting still happened, even if no longer have a valid person reference, so there we just zero the appointment.person_id.

For those using the APIs at any level, the interception code will change it into an Update automatically. Search for something through the API, and the filtering conditions will be appended. For those who work directly with the database, it's recommended switching to an API approach for this reason.

>[!TIP]
> If the incoming request includes select for deletedDate > 1.1.176, this will switch off the automatic filtering conditions for all tables in the query.

## Searching for soft-deleted records

In some scenarios it might be useful to search for information which has been soft-deleted. It exists 3 ArchiveProviders, for each of the 3 entitites, for this purpose:

* [RecycleContact][18]
* [RecyclePerson][19]
* [RecycleTicket][20]

## Database Mirroring and Travel

[Database Mirroring][3] and [Travel][4] will both replicate the soft delete as the **update** it really is. Mirroring will also replicate the deep delete that happens later, but Travel will not. The reason is that the deep delete, being a real consistency cleanup, needs to work with whatever is actually in the database. Only the code local to the receiving database can know that, so we use the same strategy as when replicating a Move/Merge operation. The initial operation (update deletedDate) is replicated; and the consequence in the form of a deep delete are **recreated** on the receiving database, after the proper interval, using whatever data is present at the time.

## Hard delete

As explained above the soft-delete does not actually remove the records from the database. Physical deletion happens after the retention time, and is described as a **hard-delete**.

### Hard-delete of Contact

When a hard-delete occurs there is a lot of information that gets edited based on the [Relation Action](#relation-action)

| Table                  | Field                       | Relation Action         | Notes                                                   |
|------------------------|-----------------------------|-------------------------|---------------------------------------------------------|
| address                | owner_id (atype_idx = 1)    | DeleteRecord            |                                                         |
| address                | owner_id (atype_idx = 2)    | DeleteRecord            |                                                         |
| appointment            | contact_id                  | ZeroForeignKey          |                                                         |
| chat_session           | contact_id                  | ZeroForeignKey          |                                                         |
| company_domain         | company_id                  | DeleteRecord            |                                                         |
| contact                | mother_id                   | ZeroForeignKey          |                                                         |
| contactinterest        | contact_id                  | DeleteRecord            |                                                         |
| countervalue           | contact_id                  | Ignore                  | will be regenerated away                                |
| email                  | contact_id                  | DeleteRecord            |                                                         |
| email_item             | contact_id                  | ZeroForeignKey          |                                                         |
| form_submission        | contact_id                  | ZeroForeignKey          |                                                         |
| invoice                | company_id                  | ZeroForeignKey          |                                                         |
| invoice_sum            | company_id                  | ZeroForeignKey          |                                                         |
| ownercontactlink       | contact_id                  | Ignore                  | contact records are never deleted; deleting is a mistake |
| person                 | contact_id                  | ZeroForeignKey          | contact -> person cascade is handled elsewhere          |
| phone                  | owner_id (ptype_idx = 1)    | DeleteRecord            |                                                         |
| phone                  | owner_id (ptype_idx = 3)    | DeleteRecord            |                                                         |
| projectmember          | contact_id                  | ZeroForeignKey          |                                                         |
| s_shipment_addr        | contact_id                  | DeleteRecord            |                                                         |
| sale                   | contact_id                  | ZeroForeignKey          |                                                         |
| salehist               | contact_id                  | ZeroForeignKey          |                                                         |
| salestakeholder        | contact_id                  | ZeroForeignKey          | on person delete, but contact maps to just zero         |
| satellite              | contact_id                  | Ignore                  | contact records are never deleted; deleting is a mistake |
| selectionmember        | contact_id                  | ZeroForeignKey          | extra pass later to delete c=0, p=0 records             |
| sl_vendor              | contact_id                  | Ignore                  | contact records are never deleted; deleting is a mistake |
| statusvalue            | contact_id                  | DeleteRecord            |                                                         |
| text                   | owner_id (type = 1)         | DeleteRecord            |                                                         |
| text                   | owner_id (type = 10)        | DeleteRecord            |                                                         |
| url                    | contact_id                  | DeleteRecord            |                                                         |
| binaryobjectlink       | ownertable                  | DeleteRecord            |                                                         |
| dataright              | tableid                     | Ignore                  |                                                         |
| favourite              | table_id                    | DeleteRecord            |                                                         |
| foreignkey             | table_id                    | DeleteRecord            |                                                         |
| freetextindex          | ownertable_id               | Ignore                  |                                                         |
| freetextindex          | table_id                    | Ignore                  |                                                         |
| history                | table_id                    | DeleteRecord            |                                                         |
| importobject           | tableid                     | Ignore                  |                                                         |
| mergemovelog           | tablenumber                 | DeleteRecord            |                                                         |
| relations              | destination_table           | DeleteRecord            |                                                         |
| relations              | source_table                | DeleteRecord            |                                                         |
| relationtarget         | destination_table           | Ignore                  |                                                         |
| relationtarget         | source_table                | Ignore                  |                                                         |
| traveltransactionlog   | tablenumber                 | Ignore                  |                                                         |

>[!NOTE]
> CustomFields and ExtraTables also gets cleaned up.

### Hard-delete of Person

When a hard-delete occurs there is a lot of information that gets edited based on the [Relation Action](#relation-action)

| Table                  | Field                        | Relation Action   | Notes                                     |
|------------------------|------------------------------|-------------------|-------------------------------------------|
| address                | owner_id (atype_idx = 16387)  | DeleteRecord      | person parent                             |
| address                | owner_id (atype_idx = 1)      | DeleteRecord      | contact parent                            |
| address                | owner_id (atype_idx = 2)      | DeleteRecord      | contact parent                            |
| appointment            | invitedpersonid               | ZeroForeignKey    |                                           |
| appointment            | person_id                     | ZeroForeignKey    |                                           |
| associate              | person_id                     | Ignore            |                                           |
| chat_session           | customer_id                   | ZeroForeignKey    |                                           |
| consentperson          | person_id                     | DeleteRecord      |                                           |
| contact                | supportpersonid               | ZeroForeignKey    |                                           |
| countervalue           | person_id                     | Ignore            |                                           |
| credentials            | personid                      | DeleteRecord      |                                           |
| ej_message             | customer_id                   | ZeroForeignKey    |                                           |
| email                  | person_id                     | DeleteRecord      |                                           |
| email                  | contact_id                    | DeleteRecord      | contact parent                            |
| email_item             | person_id                     | DeleteRecord      |                                           |
| form_submission        | person_id                     | ZeroForeignKey    |                                           |
| invoice                | customer_id                   | ZeroForeignKey    |                                           |
| invoice_sum            | customer_id                   | ZeroForeignKey    |                                           |
| kb_entry_comment       | customer_id                   | ZeroForeignKey    |                                           |
| login_customer         | customer_id                   | DeleteRecord      |                                           |
| message_customers      | customer_id                   | DeleteRecord      |                                           |
| personinterest         | person_id                     | DeleteRecord      |                                           |
| phone                  | owner_id (ptype_idx = 1)      | DeleteRecord      | contact parent                            |
| phone                  | owner_id (ptype_idx = 3)      | DeleteRecord      | contact parent (no value '2' exists)      |
| phone                  | owner_id (ptype_idx = 16385)  | DeleteRecord      |                                           |
| phone                  | owner_id (ptype_idx = 16387)  | DeleteRecord      |                                           |
| phone                  | owner_id (ptype_idx = 16388)  | DeleteRecord      |                                           |
| phone                  | owner_id (ptype_idx = 16389)  | DeleteRecord      |                                           |
| phone                  | owner_id (ptype_idx = 16390)  | DeleteRecord      |                                           |
| projectmember          | person_id                     | DeleteRecord      |                                           |
| s_bounce_shipment      | customer_id                   | DeleteRecord      |                                           |
| s_link_customer        | customer_id                   | DeleteRecord      |                                           |
| s_list_customer        | customer_id                   | DeleteRecord      |                                           |
| s_sent_message         | customer_id                   | DeleteRecord      |                                           |
| s_shipment_addr        | customer_id                   | DeleteRecord      |                                           |
| sale                   | person_id                     | ZeroForeignKey    |                                           |
| salehist               | person_id                     | ZeroForeignKey    |                                           |
| salestakeholder        | person_id                     | DeleteRecord      |                                           |
| selectionmember        | person_id                     | DeleteRecord      |                                           |
| shipmenttypereservation| person_id                     | DeleteRecord      |                                           |
| sms                    | customer_id                   | DeleteRecord      |                                           |
| statusvalue            | person_id                     | DeleteRecord      |                                           |
| temporarykey           | person_id                     | DeleteRecord      |                                           |
| text                   | owner_id (type = 2)           | DeleteRecord      |                                           |
| text                   | owner_id (type = 3)           | DeleteRecord      |                                           |
| ticket                 | cust_id                       | ZeroForeignKey    |                                           |
| ticket_customers       | customer_id                   | DeleteRecord      |                                           |
| ticket_log_action      | customer_id                   | ZeroForeignKey    |                                           |
| url                    | person_id                     | DeleteRecord      |                                           |
| url                    | contact_id                    | DeleteRecord      | contact parent                            |
| user_candidate         | person_id                     | DeleteRecord      |                                           |
| binaryobjectlink       | ownertable                    | DeleteRecord      |                                           |
| dataright              | tableid                       | Ignore            |                                           |
| favourite              | table_id                      | DeleteRecord      |                                           |
| foreignkey             | table_id                      | DeleteRecord      |                                           |
| freetextindex          | ownertable_id                 | Ignore            |                                           |
| freetextindex          | table_id                      | Ignore            |                                           |
| history                | table_id                      | DeleteRecord      |                                           |
| importobject           | tableid                       | Ignore            |                                           |
| mergemovelog           | tablenumber                   | DeleteRecord      |                                           |
| relations              | destination_table             | DeleteRecord      |                                           |
| relations              | source_table                  | DeleteRecord      |                                           |
| relationtarget         | destination_table             | Ignore            |                                           |
| relationtarget         | source_table                  | Ignore            |                                           |
| traveltransactionlog   | tablenumber                   | Ignore            |                                           |

>[!NOTE]
> CustomFields and ExtraTables also gets cleaned up.

### Hard-delete Request

The following tables are affected by a hard-delete of a request

* [TICKET][6]
* [EJ_MESSAGE][7]
* [TICKET_LOG][8]
* [TICKET_LOG_ACTION][9]
* [TICKET_LOG_CHANGE][10]
* [TICKET_CUSTOMERS][11]
* [FAVOURITE][12]
* [MESSAGE_HEADER][13]
* [TICKET_ATTACHMENT][14]
* [ATTACHMENT][15]
* [INVOICE_ENTRY][16]
* [MESSAGE_CUSTOMERS][17]

## Relation Action

| Relation Action   | Description                                                                 |
|-------------------|-----------------------------------------------------------------------------|
| DeleteRecord      | Deletes the entire record from the table when the condition is met.          |
| ZeroForeignKey    | Sets the foreign key to `0` instead of deleting the record.                  |
| Ignore            | Takes no action on the record; it remains unaffected.                       |

## Summary

For the person, contact and ticket tables, a delete through any API becomes an update to a date field; and any select automatically gets conditions that make such rows disappear. A background process will periodically clean up soft-deleted records that are too old.

For users, it means that delete operations can be undone. For DBAs, the deep delete means a more consistent database.

<!--Reference links-->
[1]: ../../learn/basics/deleting-elements.md#restore
[2]: ../../admin/preferences/learn/global-preferences/system.md
[3]: ../../mirroring/overview.md
[4]: ../../travel/index.md
[5]: ../../database/tables/enums/ticketbasestatus.md
[6]: ../../database/tables/ticket.md
[7]: ../../database/tables/ej-message.md
[8]: ../../database/tables/ticket-log.md
[9]: ../../database/tables/ticket-log-action.md
[10]: ../../database/tables/ticket-log-action.md
[11]: ../../database/tables/ticket-customers.md
[12]: ../../database/tables/favourite.md
[13]: ../../database/tables/message-header.md
[14]: ../../database/tables/ticket-attachment.md
[15]: ../../database/tables/attachment.md
[16]: ../../database/tables/invoice-entry.md
[17]: ../../database/tables/message-customers.md
[18]: ../../api/archive-providers/reference/recyclecontact.md
[19]: ../../api/archive-providers/reference/recycleperson.md
[20]: ../../api/archive-providers/reference/recycleticket.md
[21]: .
