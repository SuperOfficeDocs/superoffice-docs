---
title: Create a contact
uid: add_contact
description: Add a contact to the SuperOffice database using raw SQL
author: Bergfrid Skaara Dias
so.date: 11.04.2021
keywords: contact, company, SQL, API
so.topic: howto
---

# Create a contact

Adding a contact to the database - this is roughly what happens:

1. Get a contact ID from sequence.
2. Get address ID from sequence
3. Get travel transaction log IDs from sequence
4. Save the address with a pointer to the contact record.
5. Save the contact record with the given contact ID.
6. Add records to travel transaction log for the new contact and address records.

The reality is a bit more detailed. Below is a transcript of the database updates that occur when **OK** is clicked in the **Company** card.

> [!NOTE]
> Sequence ID picking is omitted for clarity.
>
> The ID and string values used here are just examples. The actual values on your database will be different.

## Address records

```SQL
INSERT INTO CRM."address" ("address_id", "owner_id", "atype_idx", "zipcode", "city", "state", "county", "address1", "address2", "address3", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount", "validFrom", "validTo") VALUES (243, 131, 1, '0124', 'OSLO', '', '', 'POBox 1884 Vika', '', '', 1163101620, 13, 0, 0, 0, 0, 2147483647)

INSERT INTO CRM."address" ("address_id", "owner_id", "atype_idx", "zipcode", "city", "state", "county", "address1", "address2", "address3", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount", "validFrom", "validTo") VALUES (244, 131, 2, '', '', '', '', 'Wergelandsvn 7', '', '', 1163101620, 13, 0, 0, 0, 0, 2147483647)
```

## Phone number record

```SQL
INSERT INTO CRM."phone" ("phone_id", "owner_id", "ptype_idx", "search_phone", "phone", "rank", "description", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount", "validFrom", "validTo", "phoneNumber", "strippedPhoneNumber") VALUES (151, 131, 1, 233540000, '2335 4000', 1, '', 1163101620, 13, 0, 0, 0, 0, 2147483647, '', '')
```

## URL record

```SQL
INSERT INTO CRM."url" ("url_id", "contact_id", "person_id", "project_id", "reserved_id1", "reserved_id2", "type", "description", "url_address1", "url_address2", "rank", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (6, 131, 0, 0, 0, 0, 0, '', 'http://devnet.superoffice.com/', '', 1, 1163101620, 13, 0, 0, 0)
```

## Contact interests record

```SQL
INSERT INTO CRM."contactinterest" ("contactinterest_id", "contact_id", "cinterest_idx", "startDate", "endDate", "flags", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (10, 131, 2, 0, 2147483647, 0, 1163101620, 13, 0, 0, 0)
```

## Contact record

```SQL
INSERT INTO CRM."contact" ("contact_id", "name", "kananame", "department", "number1", "number2", "associate_id", "country_id", "business_idx", "category_idx", "xstop", "nomailing", "registered", "registered_associate_id", "updated", "updated_associate_id", "text_id", "mother_id", "userdef_id", "orgNr", "soundEx", "source", "userdef2_id", "activeInterests", "updatedCount", "timeZoneId", "group_id") VALUES (131, 'SuperOffice R&D', '', 'Development', 'SORND', '10196', 13, 578, 4, 1, 0, 0, 1163101620, 13, 0, 0, 0, 0, 36, '007', 'SPRFSRT', 0, 36, 1, 0, 0, 1)
```

## User-defined-fields record

```SQL
INSERT INTO CRM."udcontactsmall" ("udcontactSmall_id", "long01", "long02", "long03", "long04", "long05", "long06", "long07", "long08", "long09", "long10", "long11", "long12", "long13", "long14", "long15", "long16", "long17", "long18", "long19", "long20", "long21", "long22", "long23", "long24", "long25", "long26", "long27", "long28", "long29", "long30", "long31", "long32", "long33", "long34", "long35", "long36", "long37", "long38", "long39", "long40", "long41", "long42", "long43", "long44", "long45", "long46", "long47", "long48", "long49", "long50", "long51", "long52", "long53", "long54", "long55", "long56", "long57", "long58", "long59", "long60", "string01", "string02", "string03", "string04", "string05", "string06", "string07", "string08", "string09", "string10", "string11", "string12", "string13", "string14", "string15", "string16", "string17", "string18", "string19", "string20", "string21", "string22", "string23", "string24", "string25", "string26", "string27", "string28", "string29", "string30", "string31", "string32", "string33", "string34", "string35", "string36", "string37", "string38", "string39", "string40", "double01", "double02", "double03", "double04", "double05", "double06", "double07", "double08", "double09", "double10") VALUES (36, 0, 0, 0, 0, 0, 1150675200, 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', '', '', '', 'SuperOffice', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)

INSERT INTO CRM."udcontactlarge" ("udcontactLarge_id", "string41", "string42", "string43", "string44", "string45", "string46", "string47", "string48", "string49") VALUES (36, '', '', '', '', 'defaultlongtext', '', '', '', '')
```

## Travel transaction logging

**The two address records:**

```SQL
INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110212, 1163105220, 0, 4352, 13, 7, 243)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110213, 1163105220, 0, 4352, 13, 7, 244)
```

**Phone number record:**

```SQL
INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110214, 1163105220, 0, 4352, 13, 8, 151)
```

**URL record:**

```SQL
INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110215, 1163105220, 0, 4352, 13, 54, 6)
```

**Contact interests:**

```SQL
INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110216, 1163105220, 0, 4352, 13, 14, 10)
```

**Contact record:**

```SQL
INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110217, 1163105220, 0, 4352, 13, 5, 131)
```

**User-defined fields:**

```SQL
INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110218, 1163105228, 8, 4352, 13, 35, 36)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110219, 1163105228, 8, 4352, 13, 36, 36)
```

## Free-text indexing

> [!NOTE]
> The words used have all been used before, so the free-text indexer just inserts pointers to the records (`table_id`+`record_id`) where the particular word (`freetextwords_id`) occurs. The words themselves don't have to be added to the `freetextwords` table again.

**Address words:**

```SQL
INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (889677172, 805378603, 7, 243, 5, 131, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (663574121, 2092898914, 7, 243, 5, 131, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (274754590, 998770297, 7, 243, 5, 131, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1172455398, 1344303835, 7, 244, 5, 131, 0)
```

**Phone number words ("2335" and "4000"):**

```SQL
INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1701134483, 1241728039, 8, 151, 5, 131, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (820668762, 1678537267, 8, 151, 5, 131, 0)
```

**URL words:**

```SQL
INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (211157580, 1107787665, 54, 6, 5, 131, 0)
INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1686723241, 1291936150, 54, 6, 5, 131, 0)
```

**Contact words:**

```SQL
INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (760619278, 161, 5, 131, 5, 131, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (828988083, 1961654487, 5, 131, 5, 131, 0)
```

## Create SAINT counter records

```SQL
INSERT INTO CRM."countervalue" ("CounterValue_id", "contact_id", "person_id", "project_id", "extra1_id", "extra2_id", "record_type", "direction", "intent_id", "sale_status", "amountClassId", "totalReg", "totalRegInPeriod", "notCompleted", "notCompletedInPeriod", "lastRegistered", "lastCompleted", "lastDoBy", "extra1_count", "extra2_count", "extra3_count", "extra4_count", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (42121, 131, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1163101621, 13, 0, 0, 0)

INSERT INTO CRM."countervalue" ("CounterValue_id", "contact_id", "person_id", "project_id", "extra1_id", "extra2_id", "record_type", "direction", "intent_id", "sale_status", "amountClassId", "totalReg", "totalRegInPeriod", "notCompleted", "notCompletedInPeriod", "lastRegistered", "lastCompleted", "lastDoBy", "extra1_count", "extra2_count", "extra3_count", "extra4_count", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (42122, 131, 0, 0, 0, 0, 1, 1, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1163101621, 13, 0, 0, 0)

INSERT INTO CRM."countervalue" ("CounterValue_id", "contact_id", "person_id", "project_id", "extra1_id", "extra2_id", "record_type", "direction", "intent_id", "sale_status", "amountClassId", "totalReg", "totalRegInPeriod", "notCompleted", "notCompletedInPeriod", "lastRegistered", "lastCompleted", "lastDoBy", "extra1_count", "extra2_count", "extra3_count", "extra4_count", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (42123, 131, 0, 0, 0, 0, 1, 1, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1163101621, 13, 0, 0, 0)

INSERT INTO CRM."countervalue" ("CounterValue_id", "contact_id", "person_id", "project_id", "extra1_id", "extra2_id", "record_type", "direction", "intent_id", "sale_status", "amountClassId", "totalReg", "totalRegInPeriod", "notCompleted", "notCompletedInPeriod", "lastRegistered", "lastCompleted", "lastDoBy", "extra1_count", "extra2_count", "extra3_count", "extra4_count", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (42124, 131, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1163101621, 13, 0, 0, 0)

INSERT INTO CRM."countervalue" ("CounterValue_id", "contact_id", "person_id", "project_id", "extra1_id", "extra2_id", "record_type", "direction", "intent_id", "sale_status", "amountClassId", "totalReg", "totalRegInPeriod", "notCompleted", "notCompletedInPeriod", "lastRegistered", "lastCompleted", "lastDoBy", "extra1_count", "extra2_count", "extra3_count", "extra4_count", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (42125, 131, 0, 0, 0, 0, 1, 1, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1163101621, 13, 0, 0, 0)

... about 90 records inserted ...

INSERT INTO CRM."countervalue" ("CounterValue_id", "contact_id", "person_id", "project_id", "extra1_id", "extra2_id", "record_type", "direction", "intent_id", "sale_status", "amountClassId", "totalReg", "totalRegInPeriod", "notCompleted", "notCompletedInPeriod", "lastRegistered", "lastCompleted", "lastDoBy", "extra1_count", "extra2_count", "extra3_count", "extra4_count", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (42350, 131, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1163101627, 13, 0, 0, 0)
```
