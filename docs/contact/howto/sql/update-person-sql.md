---
title: Update a person
uid: update_person_sql
description: How to update a person in the SuperOffice database with raq SQL
author: Bergfrid Skaara Dias
so.date: 11.02.2021
keywords: person, contact, update, API, SQL
so.topic: howto
---

# Update a person

## Phone numbers added

```SQL
INSERT INTO CRM."phone" ("phone_id", "owner_id", "ptype_idx", "search_phone", "phone", "rank", "description", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount", "validFrom", "validTo", "phoneNumber", "strippedPhoneNumber") VALUES (152, 74, 16385, 234523450, '2345 2345', 1, 'Direct Phone', 1164194208, 13, 0, 0, 0, 0, 2147483647, '', '')

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110408, 1164197808, 0, 4352, 13, 8, 152)

INSERT INTO CRM."freetextwords" ("freetextwords_id", "word") VALUES (466970406, '2345')

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (672533552, 466970406, 8, 152, 6, 74, 0)

INSERT INTO CRM."phone" ("phone_id", "owner_id", "ptype_idx", "search_phone", "phone", "rank", "description", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount", "validFrom", "validTo", "phoneNumber", "strippedPhoneNumber") VALUES (153, 74, 16389, 976676780, '976 67 678', 1, 'Mobile Phone', 1164194208, 13, 0, 0, 0, 0, 2147483647, '', '')

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110409, 1164197808, 0, 4352, 13, 8, 153)

INSERT INTO CRM."freetextwords" ("freetextwords_id", "word") VALUES (913376496, '678')

INSERT INTO CRM."freetextwords" ("freetextwords_id", "word") VALUES (1088781487, '976')

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (515406307, 913376496, 8, 153, 6, 74, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (2035637948, 1088781487, 8, 153, 6, 74, 0)
```

## Email address changed

```SQL
UPDATE CRM."email" SET "email_id" = 142, "contact_id" = 0, "person_id" = 74, "project_id" = 0, "reserved_id1" = 0, "reserved_id2" = 0, "protocol" = 'SMTP', "type" = 0, "description" = '', "email_address" = 'example@example.com', "rank" = 1, "registered" = 1027519266, "registered_associate_id" = 2, "updated" = 1164194208, "updated_associate_id" = 13, "updatedCount" = 0 WHERE "email_id" = 142

INSERT INTO CRM."freetextwords" ("freetextwords_id", "word") VALUES (376651026, 'EXAMPLE')

INSERT INTO CRM."freetextwords" ("freetextwords_id", "word") VALUES (1627065638, 'EXAMPLE.C')

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1770732636, 376651026, 55, 142, 6, 74, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1288312896, 1627065638, 55, 142, 6, 74, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1685914333, 1299, 55, 142, 6, 74, 0)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110410, 1164197808, 0, 4608, 13, 55, 142)
```

## Two person interests added

```SQL
INSERT INTO CRM."personinterest" ("personinterest_id", "person_id", "pinterest_idx", "startDate", "endDate", "flags", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (7, 74, 3, 0, 2147483647, 0, 1164194208, 13, 0, 0, 0)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110411, 1164197808, 0, 4352, 13, 15, 7)

INSERT INTO CRM."personinterest" ("personinterest_id", "person_id", "pinterest_idx", "startDate", "endDate", "flags", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (8, 74, 8, 0, 2147483647, 0, 1164194208, 13, 0, 0, 0)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110412, 1164197808, 0, 4352, 13, 15, 8)
```

## Person record

```SQL
UPDATE CRM."person" SET "person_id" = 74, "contact_id" = 29, "rank" = 2, "lastname" = 'Narvestad', "firstname" = 'Njål', "mrmrs" = '', "title" = 'General Manager', "text_id" = 0, "position_idx" = 4, "year_of_birth" = 0, "month_of_birth" = 0, "day_of_birth" = 0, "phone_present" = 0, "userdef_id" = 89, "registered" = 1027514205, "registered_associate_id" = 2, "updated" = 1164194208, "updated_associate_id" = 13, "person_number" = '10076', "kanalname" = '', "kanafname" = '', "post1" = '', "post2" = '', "post3" = '', "usepersonaddress" = 0, "middleName" = '', "source" = 0, "nomailing" = 0, "country_id" = 578, "userdef2_id" = 0, "retired" = 0, "activeInterests" = 2, "updatedCount" = 0, "timeZoneId" = 0, "associate_id" = 0, "group_id" = 0, "salutation" = '', "department" = '', "initials" = 'N', "gender" = 0, "business_idx" = 0, "category_idx" = 0 WHERE "person_id" = 74

DELETE FROM CRM."freetextindex" WHERE "table_id" = 6 AND "record_id" = 74

INSERT INTO CRM."freetextwords" ("freetextwords_id", "word") VALUES (451491707, 'GENERAL')

INSERT INTO CRM."freetextwords" ("freetextwords_id", "word") VALUES (736302701, 'MANAGER')

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1194731310, 428, 6, 74, 6, 74, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1252336271, 451491707, 6, 74, 6, 74, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (226107062, 736302701, 6, 74, 6, 74, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (687820923, 429, 6, 74, 6, 74, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1704529033, 430, 6, 74, 6, 74, 0)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110413, 1164197809, 0, 4608, 13, 6, 74)
```

## Person udef field changed

```SQL
INSERT INTO CRM."udpersonsmall" ("udpersonSmall_id", "long01", "long02", "long03", "long04", "long05", "long06", "long07", "long08", "long09", "long10", "long11", "long12", "long13", "long14", "long15", "long16", "long17", "long18", "long19", "long20", "long21", "long22", "long23", "long24", "long25", "long26", "long27", "long28", "long29", "long30", "long31", "long32", "long33", "long34", "long35", "long36", "long37", "long38", "long39", "long40", "long41", "long42", "long43", "long44", "long45", "long46", "long47", "long48", "long49", "long50", "long51", "long52", "long53", "long54", "long55", "long56", "long57", "long58", "long59", "long60", "string01", "string02", "string03", "string04", "string05", "string06", "string07", "string08", "string09", "string10", "string11", "string12", "string13", "string14", "string15", "string16", "string17", "string18", "string19", "string20", "string21", "string22", "string23", "string24", "string25", "string26", "string27", "string28", "string29", "string30", "string31", "string32", "string33", "string34", "string35", "string36", "string37", "string38", "string39", "string40", "double01", "double02", "double03", "double04", "double05", "double06", "double07", "double08", "double09", "double10") VALUES (89, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', '', '', '', 'required text', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110414, 1164197809, 7, 4352, 13, 140, 89)

DELETE FROM CRM."freetextindex" WHERE "table_id" = 140 AND "record_id" = 89

INSERT INTO CRM."freetextwords" ("freetextwords_id", "word") VALUES (2131786154, 'REQUIRED')

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (881488048, 2131786154, 140, 89, 6, 74, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1393689661, 1011251049, 140, 89, 6, 74, 0)
```

## Save the picture that was added

```SQL
INSERT INTO CRM."binaryobject" ("BinaryObject_id", "conceptualType", "mimeType", "description", "originalSize", "blobSize", "isZipped", "isEncrypted", "extraInfo", "binaryData", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (624, 'PersonImage', 'image/jpeg', 'Njål Narvestad', 1333, 1333, 0, 0, '', (blobdata), 1164194209, 13, 0, 0, 0)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110415, 1164197809, 0, 4352, 13, 205, 624)

INSERT INTO CRM."binaryobjectlink" ("BinaryObjectLink_id", "binaryObjectId", "ownerTable", "ownerRecord", "linkComment", "linkType", "rank", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (267, 624, 6, 74, '', 1, 1, 1164194209, 13, 0, 0, 0)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110416, 1164197809, 0, 4352, 13, 206, 267)
```
