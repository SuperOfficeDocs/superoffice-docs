---
uid: enum-shipmentaddrstatus
title: Enum values for ShipmentAddrStatus
description: Lists the enum values for ShipmentAddrStatus.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ShipmentAddrStatus Enum

Status for sending to this particular recipient

* Unknown = 0
* Ready = 1
* Duplicate = 2
* Blocked = 3
* Sent = 4
* Bounced = 5
* Opened = 6
* Clicked = 7
* SoftBounced = 8
* NoSubscription = 9
* Complained = 10
* TooManyBounces = 11

## Usage

* [s_shipment_addr](../s-shipment-addr.md).status - Addresses that are ready to be sent in a shipment.
