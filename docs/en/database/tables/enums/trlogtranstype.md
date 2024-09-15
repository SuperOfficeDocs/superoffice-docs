---
uid: enum-trlogtranstype
title: Enum values for TrlogTransType
description: Lists the enum values for TrlogTransType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# TrlogTransType Enum

Type of event

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|Unknown - used when initializing|
|Insert|4352|A record has been inserted|
|Update|4608|A record has been updated|
|Delete|4864|A record has been deleted|
|UpdateOwner|5120|The owning associate_id of the target record has been updated, old value in PrevrecordId|
|OldUpdateContact|5376|(Obsolete) The contact_id of the target record has been updated, old value in PrevRecordId|
|OldUpdateProject|5632|(Obsolete) The project_id of the target record has been updated, old value in PrevRecordId|
|DeleteAreaUserInclusion|5888|A previously included (data inclusion) user has been removed from an area|
|DeleteAreaUserAssignment|6144|A previously assigned (login rights) user has been delete from an Area|
|PublishUdef|6400|A new layout for User-defined fields has been published|
|UpdateFieldPart1|8192|(Reserved) Bitmap of updated fields|
|UpdateFieldPart2|8193|(Reserved) Bitmap of updated fields|
|UpdateFieldPart3|8194|(Reserved) Bitmap of updated fields|
|UpdateFieldPart4|8195|(Reserved) Bitmap of updated fields|
|UpdateFieldPart5|8196|(Reserved) Bitmap of updated fields|
|UpdateFieldPart6|8197|(Reserved) Bitmap of updated fields|
|UpdateFieldPart7|8198|(Reserved) Bitmap of updated fields|
|UpdateFieldPart8|8199|(Reserved) Bitmap of updated fields|
|UpdateContact|10000|The contact_id of the target record has been changed, old value in PrevRecordId|
|UpdateProject|20000|The project_id of the target record has been updated, odl value in PrevRecordId|
|TruncateTable|21000|A TRUNCATE TABLE operation was performed against a table; no record of individual rows deleted exists but everything that WAS in the table is now gone for good|

## Usage

* [traveltransactionlog](../traveltransactionlog.md).type - Log of all updates made to the database, that need to be replicated.
