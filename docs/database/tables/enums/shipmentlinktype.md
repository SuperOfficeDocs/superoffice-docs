---
uid: enum-shipmentlinktype
title: Enum values for ShipmentLinkType
description: Lists the enum values for ShipmentLinkType.
so.generated: true
keywords:
  - "database"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ShipmentLinkType Enum

If this is a link to a link or an image (gif/jpeg). See SpmLink::LinkType

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|Unknown - should not be used.|
|Link|1|Clicked a link in the shipment|
|Image|2|Viewed an image in the shipment|

## Usage

* [s_link_customer](../s-link-customer.md).link_type - A connection between a customer and a link. Registered customers are identified when clicking on a link
* [s_link_customer_statical](../s-link-customer-statical.md).link_type - A connection between a customer and a link. Registered customers are identified when clicking on a link
