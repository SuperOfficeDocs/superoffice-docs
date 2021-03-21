---
uid: enum-shipmentstatus
title: Enum values for ShipmentStatus
description: Lists the enum values for ShipmentStatus.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ShipmentStatus Enum

Sending/stopped/failed etc.

* None = 0
* Ok = 1
* Canceled = 2
* Waiting = 3
* Started = 4
* StatusFailed = 5
* Retry = 6
* Populating = 7
* Deleted = 8
* AwaitPopulate = 9
* PopulatingOnly = 10
* PopulateAborted = 11
* PopulateError = 12
* TooManyRecipients = 13

## Usage

* [s_shipment](../s-shipment.md).status - Contains info about one shipment. The addresses are stored in s_shipment_addr
