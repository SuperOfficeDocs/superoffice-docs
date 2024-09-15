---
uid: enum-shipmentaddrstatus
title: Enum values for ShipmentAddrStatus
description: Lists the enum values for ShipmentAddrStatus.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# ShipmentAddrStatus Enum

Status for sending to this particular recipient

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|Default value for empty rows|
|Ready|1|Ready for shipment|
|Duplicate|2|Blocked because it duplicates another shipment addr in the same batch|
|Blocked|3|Blocked because of nomailing flag|
|Sent|4|Sent|
|Bounced|5|Bounce received from transport channel|
|Opened|6|Recipient has opened the message, we know because of tracking|
|Clicked|7|Test recipient, will be deleted after sent (enum name is not correct, but that cant be changed now)|
|SoftBounced|8|Vacation notice, etc|
|NoSubscription|9|Recipient does not have subscription for shipmentType|
|Complained|10|Recipient sent a complaint|
|TooManyBounces|11|Recipient address has bounced too many times|

## Usage

* [s_shipment_addr](../s-shipment-addr.md).status - Addresses that are ready to be sent in a shipment.
