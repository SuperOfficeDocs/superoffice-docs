---
uid: enum-travelencryptionown
title: Enum values for TravelEncryptionOwn
description: Lists the enum values for TravelEncryptionOwn.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# TravelEncryptionOwn Enum

Use encrypted communication back to parent: 0 = no, 1 = serial no as key, 2 = target db tag as key (secure but lots of hassle for support)

| Name | Value | Description |
|------|-------|-------------|
|None|0|Received travel data are not encrypted (only ZIPed)|
|Serial|1|Received travel data are encrypted using licence serial number as key|
|BF128|2|Received travel data are ancrypted unsing a 128-bit key|

## Usage

* [travelcurrent](../travelcurrent.md).encryptedComm - Information about this database and its place in the hierarchy
