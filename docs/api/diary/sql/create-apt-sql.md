---
title: Create appointment
uid: create_appointment_sql
description: Create an appointment
author: Bergfrid Skaara Dias
so.date: 11.04.2021
keywords: diary, calendar, appointment, API
so.topic: howto
---

# Create appointment

1. Insert an appointment record.
2. Insert a text record for the appointment text.
3. Insert a VisibleFor record that points to the appointment record.

## Create the appointment

```SQL
INSERT INTO CRM."appointment" ("appointment_id", "contact_id", "person_id", "associate_id", "group_idx", "registered", "registered_associate_id", "done", "do_by", "leadtime", "task_idx", "priority_idx", "type", "status", "private", "alarm", "text_id", "project_id", "mother_id", "document_id", "color_index", "opportunity_id", "invitedPersonId", "activeDate", "endDate", "lagTime", "source", "userdef_id", "userdef2_id", "updated", "updated_associate_id", "updatedCount", "activeLinks", "recurrenceRuleId", "location", "alldayEvent", "freeBusy", "rejectCounter", "emailId", "rejectReason", "hasAlarm", "assignedBy") VALUES (738, 29, 74, 13, 1, 1164196048, 13, 0, 1164114540, 0, 8, 0, 1, 1, 0, 0, 388, 0, 0, 0, 0, 0, 149, 1164114540, 1164118140, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', 0, 0, 0, 0, '', 0, 0)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110418, 1164199648, 0, 4352, 13, 9, 738)
```

## Update affected SAINT counters

```SQL
UPDATE CRM."countervalue" SET "CounterValue_id" = 19344, "contact_id" = 29, "person_id" = 0, "project_id" = 0, "extra1_id" = 0, "extra2_id" = 0, "record_type" = 1, "direction" = 3, "intent_id" = 0, "sale_status" = 0, "amountClassId" = 0, "totalReg" = 2, "totalRegInPeriod" = 2, "notCompleted" = 2, "notCompletedInPeriod" = 2, "lastRegistered" = 1164114540, "lastCompleted" = 0, "lastDoBy" = 1164114540, "extra1_count" = 0, "extra2_count" = 0, "extra3_count" = 0, "extra4_count" = 0, "registered" = 0, "registered_associate_id" = 0, "updated" = 1164196049, "updated_associate_id" = 13, "updatedCount" = 0 WHERE "CounterValue_id" = 19344

UPDATE CRM."countervalue" SET "CounterValue_id" = 19348, "contact_id" = 29, "person_id" = 0, "project_id" = 0, "extra1_id" = 0, "extra2_id" = 0, "record_type" = 1, "direction" = 3, "intent_id" = 5, "sale_status" = 0, "amountClassId" = 0, "totalReg" = 1, "totalRegInPeriod" = 1, "notCompleted" = 1, "notCompletedInPeriod" = 1, "lastRegistered" = 1164114540, "lastCompleted" = 0, "lastDoBy" = 1164114540, "extra1_count" = 0, "extra2_count" = 0, "extra3_count" = 0, "extra4_count" = 0, "registered" = 0, "registered_associate_id" = 0, "updated" = 1164196049, "updated_associate_id" = 13, "updatedCount" = 0 WHERE "CounterValue_id" = 19348

UPDATE CRM."countervalue" SET "CounterValue_id" = 19533, "contact_id" = 29, "person_id" = 0, "project_id" = 0, "extra1_id" = 0, "extra2_id" = 0, "record_type" = 10, "direction" = 3, "intent_id" = 0, "sale_status" = 0, "amountClassId" = 0, "totalReg" = 6, "totalRegInPeriod" = 6, "notCompleted" = 5, "notCompletedInPeriod" = 5, "lastRegistered" = 1164114540, "lastCompleted" = 1163783238, "lastDoBy" = 1164114540, "extra1_count" = 0, "extra2_count" = 0, "extra3_count" = 0, "extra4_count" = 0, "registered" = 0, "registered_associate_id" = 0, "updated" = 1164196049, "updated_associate_id" = 13, "updatedCount" = 0 WHERE "CounterValue_id" = 19533

UPDATE CRM."countervalue" SET "CounterValue_id" = 19537, "contact_id" = 29, "person_id" = 0, "project_id" = 0, "extra1_id" = 0, "extra2_id" = 0, "record_type" = 10, "direction" = 3, "intent_id" = 5, "sale_status" = 0, "amountClassId" = 0, "totalReg" = 1, "totalRegInPeriod" = 1, "notCompleted" = 1, "notCompletedInPeriod" = 1, "lastRegistered" = 1164114540, "lastCompleted" = 0, "lastDoBy" = 1164114540, "extra1_count" = 0, "extra2_count" = 0, "extra3_count" = 0, "extra4_count" = 0, "registered" = 0, "registered_associate_id" = 0, "updated" = 1164196049, "updated_associate_id" = 13, "updatedCount" = 0 WHERE "CounterValue_id" = 19537
```

## Add the text record

```SQL
INSERT INTO CRM."text" ("text_id", "type", "owner_id", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount", "text", "lcid", "seqno") VALUES (388, 4, 738, 1164196049, 13, 0, 0, 0, 'A nice toasted bagel with lox and cream-cheese.', 1044, 0)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110419, 1164199649, 0, 4352, 13, 18, 388)

DELETE FROM CRM."freetextindex" WHERE "table_id" = 18 AND "record_id" = 388

INSERT INTO CRM."freetextwords" ("freetextwords_id", "word") VALUES (1662277039, 'BAGEL')

INSERT INTO CRM."freetextwords" ("freetextwords_id", "word") VALUES (994575658, 'CHEESE')

INSERT INTO CRM."freetextwords" ("freetextwords_id", "word") VALUES (1982075453, 'CREAM')

INSERT INTO CRM."freetextwords" ("freetextwords_id", "word") VALUES (566186505, 'LOX')

INSERT INTO CRM."freetextwords" ("freetextwords_id", "word") VALUES (125524443, 'NICE')

INSERT INTO CRM."freetextwords" ("freetextwords_id", "word") VALUES (2062571956, 'TOASTED')

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1163465720, 199, 18, 388, 9, 738, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (960242617, 1662277039, 18, 388, 9, 738, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (408489531, 994575658, 18, 388, 9, 738, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (104022427, 1982075453, 18, 388, 9, 738, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1403285959, 566186505, 18, 388, 9, 738, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (342101549, 125524443, 18, 388, 9, 738, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (895819198, 2062571956, 18, 388, 9, 738, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1131576383, 1208, 18, 388, 9, 738, 0)
```

## Add the visible-for record for the appointment

```SQL
INSERT INTO CRM."visiblefor" ("VisibleFor_id", "tableId", "recordId", "forAll", "forGroupId", "forAssocId", "encryptedCheck", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (914, 9, 738, 1, 0, 0, 'hQMC78oTMlGiFhgQyTEIuYatA57qbFEo', 1164196049, 13, 0, 0, 0)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110420, 1164199649, 0, 4352, 13, 196, 914)
```
