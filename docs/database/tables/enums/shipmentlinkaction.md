---
uid: enum-shipmentlinkaction
title: Enum values for ShipmentLinkAction
description: Lists the enum values for ShipmentLinkAction.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ShipmentLinkAction Enum

Bitmask defining what action should be taken

* None = 0
* SetPersonInterest = 1
* RemovePersonInterest = 2
* SetContactInterest = 4
* RemoveContactInterest = 8
* AddToSmSelection = 16
* RemoveFromSmSelection = 32
* AddToSmProject = 64
* RemoveFromSmProject = 128
* AddTask = 256
* AddRequest = 512
* AddToCsSelection = 1024
* RemoveFromCsSelection = 2048
* ExecuteScript = 4096

## Usage

* [s_link](../s-link.md).action_flags - Links in messages to measure success rate of a campaign.
