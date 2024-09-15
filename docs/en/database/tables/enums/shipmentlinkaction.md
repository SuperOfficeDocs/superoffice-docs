---
uid: enum-shipmentlinkaction
title: Enum values for ShipmentLinkAction
description: Lists the enum values for ShipmentLinkAction.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# ShipmentLinkAction Enum

Bitmask defining what action should be taken

| Name | Value | Description |
|------|-------|-------------|
|None|0|No action|
|SetPersonInterest|1|Set an interest on the recipient-who-is-a-person|
|RemovePersonInterest|2|Remove an interest from the recipient-who-is-a-person|
|SetContactInterest|4|Set an interest on the recipient-who-is-a-contact|
|RemoveContactInterest|8|Remove an interest from the recipient-who-is-a-contact|
|AddToSmSelection|16|Add person id of recipient to a static S&M selection|
|RemoveFromSmSelection|32|Remove person id of recipient from a static S&M selection|
|AddToSmProject|64|Add person id of recipient as a member of an S&M project|
|RemoveFromSmProject|128|Remove person id of recipient as a member of an S&M project|
|AddTask|256|Add a task in an S&M diary|
|AddRequest|512|Add a request (ticket) in CS|
|AddToCsSelection|1024|Add person to a Customer Support selection|
|RemoveFromCsSelection|2048|Remove person from a Customer Service selection|
|ExecuteScript|4096|Execute an ejScript|

## Usage

* [s_link](../s-link.md).action_flags - Links in messages to measure success rate of a campaign.
