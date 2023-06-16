---
uid: enum-travelencryptionchild
title: Enum values for TravelEncryptionChild
description: Lists the enum values for TravelEncryptionChild.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# TravelEncryptionChild Enum

Use encrypted communication for this traveller: 0 = no, 1 = serial no as key, 2 = target db tag as key (secure but lots of hassle for support)

| Name | Value | Description |
|------|-------|-------------|
|None|0|Transmitted travel data are not encrypted (only ZIPed)|
|Serial|1|Transmitted travel data are encrypted using licence serial no. as key|
|BF128|2|Transmitted travel data are encrypted using a 128-bit key unique to each database|

## Usage

* [traveller](../traveller.md).encryptedComm - Associates traveling out from this database
