---
title: set_udef
description: Set a user-defined field
author:
so.date:
keywords:
so.topic: howto
---

# Set a user-defined field

We edit the user-defined fields on a contact like this:

![x][img1]

The resulting SQL is detailed in the following sections.

## Contact update

```SQL
UPDATE CRM."contact" SET "contact_id" = 29, "name" = 'Norsk Tele Kompetanse AS', "kananame" = '', "department" = 'Flooz', "number1" = 'NorskTel', "number2" = '10037', "associate_id" = 4, "country_id" = 578, "business_idx" = 5, "category_idx" = 3, "xstop" = 0, "nomailing" = 0, "registered" = 1027501190, "registered_associate_id" = 2, "updated" = 1164130627, "updated_associate_id" = 13, "text_id" = 0, "mother_id" = 0, "userdef_id" = 39, "orgNr" = '123456', "soundEx" = 'NRSKTLAKA', "source" = 0, "userdef2_id" = 39, "activeInterests" = 0, "updatedCount" = 0, "timeZoneId" = 0, "group_id" = 2 WHERE "contact_id" = 29
```

## Udef record update

```SQL
UPDATE CRM."udcontactsmall" SET "udcontactSmall_id" = 39, "long01" = 0, "long02" = 0, "long03" = 0, "long04" = 0, "long05" = 123, "long06" = 0, "long07" = 1, "long08" = 8, "long09" = 1, "long10" = 8, "long11" = 0, "long12" = 0, "long13" = 0, "long14" = 0, "long15" = 0, "long16" = 0, "long17" = 0, "long18" = 0, "long19" = 0, "long20" = 0, "long21" = 0, "long22" = 0, "long23" = 0, "long24" = 0, "long25" = 0, "long26" = 0, "long27" = 0, "long28" = 0, "long29" = 0, "long30" = 0, "long31" = 0, "long32" = 0, "long33" = 0, "long34" = 0, "long35" = 0, "long36" = 0, "long37" = 0, "long38" = 0, "long39" = 0, "long40" = 0, "long41" = 0, "long42" = 0, "long43" = 0, "long44" = 0, "long45" = 0, "long46" = 0, "long47" = 0, "long48" = 0, "long49" = 0, "long50" = 0, "long51" = 0, "long52" = 0, "long53" = 0, "long54" = 0, "long55" = 0, "long56" = 0, "long57" = 0, "long58" = 0, "long59" = 0, "long60" = 0, "string01" = '', "string02" = '', "string03" = '', "string04" = '', "string05" = 'short text ', "string06" = '19690619', "string07" = 'sing', "string08" = 'teach', "string09" = 'study', "string10" = '', "string11" = '', "string12" = '', "string13" = '', "string14" = '', "string15" = '', "string16" = '', "string17" = '', "string18" = '', "string19" = '', "string20" = '', "string21" = '', "string22" = '', "string23" = '', "string24" = '', "string25" = '', "string26" = '', "string27" = '', "string28" = '', "string29" = '', "string30" = '', "string31" = '', "string32" = '', "string33" = '', "string34" = '', "string35" = '', "string36" = '', "string37" = '', "string38" = '', "string39" = '', "string40" = '', "double01" = 0, "double02" = 0, "double03" = 0, "double04" = 0, "double05" = 1236.56, "double06" = 0, "double07" = 0, "double08" = 0, "double09" = 0, "double10" = 0 WHERE "udcontactSmall_id" = 1.926856019e-322

INSERT INTO CRM."udcontactlarge" ("udcontactLarge_id", "string41", "string42", "string43", "string44", "string45", "string46", "string47", "string48", "string49") VALUES (39, '', '', '', '', 'this is a much longer descriptive text.', '', '', '', '')
```

## Transaction logging

**Contact record:**

```SQL
INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110402, 1164134227, 0, 4608, 13, 5, 29)
```

**Udef small record - note field-level logging here:**

```SQL
INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110403, 1164134227, 1568, 8192, 13, 35, 39)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110404, 1164134227, 62, 8194, 13, 35, 39)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110405, 1164134227, 512, 8195, 13, 35, 39)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110406, 1164134228, 8, 4608, 13, 35, 39)
```

**Udef large record - no field level log here because it is a new record:**

```SQL
INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110407, 1164134228, 8, 4352, 13, 36, 39)
```

## Freetext indexing

**Contact record:**

```SQL
INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1928735794, 68, 5, 29, 5, 29, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1949775442, 70, 5, 29, 5, 29, 0)
```

**Udef small record - note new words being added:**

```SQL
INSERT INTO CRM."freetextwords" ("freetextwords_id", "word") VALUES (73139657, '19690619')

INSERT INTO CRM."freetextwords" ("freetextwords_id", "word") VALUES (1221404438, 'SING')

INSERT INTO CRM."freetextwords" ("freetextwords_id", "word") VALUES (728117192, 'STUDY')

INSERT INTO CRM."freetextwords" ("freetextwords_id", "word") VALUES (536094736, 'TEACH')

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1242986832, 73139657, 35, 39, 5, 29, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1577525604, 160967466, 35, 39, 5, 29, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1653948969, 1221404438, 35, 39, 5, 29, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1810500107, 728117192, 35, 39, 5, 29, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1569269302, 536094736, 35, 39, 5, 29, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1965175582, 1011251049, 35, 39, 5, 29, 0)
```

**Udef large record:**

```SQL
INSERT INTO CRM."freetextwords" ("freetextwords_id", "word") VALUES (1173105971, 'DESCRIPTI')

INSERT INTO CRM."freetextwords" ("freetextwords_id", "word") VALUES (399916436, 'LONGER')

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (1240007823, 1173105971, 36, 39, 5, 29, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (2066289220, 399916436, 36, 39, 5, 29, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (442177805, 1749643602, 36, 39, 5, 29, 0)

INSERT INTO CRM."freetextindex" ("freetextindex_id", "freetextwords_id", "table_id", "record_id", "ownertable_id", "ownerrecord_id", "infile") VALUES (661460847, 1011251049, 36, 39, 5, 29, 0)
```

## Check if any SAINT counters need to be changed

```SQL
SELECT t198a0.StatusDef_id, t198a0.isVisual, t198a0.needsUpdate, t198a0.rank, t198a0.deleted, t198a0.ownerTable, t198a0.dirtyOnChange, t198a0.defaultTask, t198a0.lastGenerated, t198a0.numMatches, t198a0.numNeedUpdate, t198a0.registered, t198a0.registered_associate_id, t198a0.updated, t198a0.updated_associate_id, t198a0.updatedCount, t199a0.StatusValue_id, t199a0.StatusDef_id, t199a0.contact_id, t199a0.person_id, t199a0.project_id, t199a0.extra1_id, t199a0.extra2_id, t199a0.isSignalled, t199a0.needsUpdate, t199a0.registered, t199a0.registered_associate_id, t199a0.updated, t199a0.updated_associate_id, t199a0.updatedCount FROM CRM."statusvalue" t199a0 (NOLOCK), CRM."statusdef" t198a0 (NOLOCK) WHERE t199a0."contact_id" = 29 AND t199a0."StatusDef_id" = t198a0."StatusDef_id" AND t199a0."needsUpdate" = 0 AND t198a0."needsUpdate" = 0 AND t198a0."dirtyOnChange" = 1
```

<!-- Referenced images -->
[img1]: media/contact-udef-update.png
