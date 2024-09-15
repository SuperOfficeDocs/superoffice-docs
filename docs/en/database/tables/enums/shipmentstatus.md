---
uid: enum-shipmentstatus
title: Enum values for ShipmentStatus
description: Lists the enum values for ShipmentStatus.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# ShipmentStatus Enum

Sending/stopped/failed etc.

| Name | Value | Description |
|------|-------|-------------|
|None|0|Initial status, shipment is left alone, can be used for working with shipment|
|Ok|1|Finished, no errors.|
|Canceled|2|Stopped by user.|
|Waiting|3|Ready for execution, in the queue.|
|Started|4|Executing (sending).|
|StatusFailed|5|Finished, had some errors.|
|Retry|6|Retrying the addresses which did not work|
|Populating|7|Between waiting and starting. Used when we populate the recipient lists.|
|Deleted|8|Deleted|
|AwaitPopulate|9|Awaiting ejournalCron to start populate|
|PopulatingOnly|10|eJournalCron has started populateOnly after someone saved choose recipients screen.|
|PopulateAborted|11|eJournalCron has started populating, but by user request it is canceled. Now we finish populating, and then set status back to none.|
|PopulateError|12||
|TooManyRecipients|13||

## Usage

* [s_shipment](../s-shipment.md).status - Contains info about one shipment. The addresses are stored in s_shipment_addr
