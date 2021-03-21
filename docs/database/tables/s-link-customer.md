---
uid: table-s-link-customer
title: s\_link\_customer table
description: A connection between a customer and a link. Registered customers are identified when clicking on a link
so.generated: true
keywords:
  - "database"
  - "s_link_customer"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# s\_link\_customer Table (337)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|customer\_id|Connection to a customer that clicked on a link|FK [person](person.md)| |
|link\_id|Connection to a link that the customer clicked on|FK [s-link](s-link.md)| |
|shipment\_id|Which shipment the customer received.|FK [s-shipment](s-shipment.md)| |
|pressed|When the link was clicked.|DateTime|&#x25CF;|
|link\_type|If this is a link to a link or an image (gif/jpeg). See SpmLink::LinkType|Enum [shipmentlinktype](enums/shipmentlinktype.md)|&#x25CF;|
|page|Indicates the page number for this gif link|Int| |
|http\_user\_agent|The HTTP_USER_AGENT reported when the customer opened this link|String(1024)|&#x25CF;|


![s_link_customer table relationship diagram](./media/s_link_customer.png)

[!include[details](./includes/s-link-customer.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|customer\_id |FK |Index |
|link\_id |FK |Index |
|shipment\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

