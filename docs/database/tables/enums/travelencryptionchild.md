---
uid: enum-travelencryptionchild
title: Enum values for TravelEncryptionChild
description: Lists the enum values for TravelEncryptionChild.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# TravelEncryptionChild Enum

Use encrypted communication for this traveller: 0 = no, 1 = serial no as key, 2 = target db tag as key (secure but lots of hassle for support)

* None = 0
* Serial = 1
* BF128 = 2

## Usage

* [traveller](../traveller.md).encryptedComm - Associates traveling out from this database
