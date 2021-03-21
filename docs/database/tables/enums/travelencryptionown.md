---
uid: enum-travelencryptionown
title: Enum values for TravelEncryptionOwn
description: Lists the enum values for TravelEncryptionOwn.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# TravelEncryptionOwn Enum

Use encrypted communication back to parent: 0 = no, 1 = serial no as key, 2 = target db tag as key (secure but lots of hassle for support)

* None = 0
* Serial = 1
* BF128 = 2

## Usage

* [travelcurrent](../travelcurrent.md).encryptedComm - Information about this database and its place in the hierarchy
