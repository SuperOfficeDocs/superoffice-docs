---
uid: table-s_link_customer
title: s_link_customer table
description: A connection between a customer and a link. Registered customers are identified when clicking on a link
so.generated: true
keywords: database table s_link_customer
so.topic: reference
so.envir: onsite, online
---

# s\_link\_customer Table (337)

A connection between a customer and a link. Registered customers are identified when clicking on a link

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|customer\_id|Connection to a customer that clicked on a link|FK [person](person.md)| |
|link\_id|Connection to a link that the customer clicked on|FK [s_link](s-link.md)| |
|shipment\_id|Which shipment the customer received.|FK [s_shipment](s-shipment.md)| |
|pressed|When the link was clicked.|DateTime|&#x25CF;|
|link\_type|If this is a link to a link or an image (gif/jpeg). See SpmLink::LinkType|Enum [ShipmentLinkType](enums/shipmentlinktype.md)|&#x25CF;|
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
|shipment\_id, customer\_id |FK, FK |Index |
|link\_type, shipment\_id |Enum, FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[person](person.md)  |Persons in a company or an organizations. All associates have a corresponding person record |
|[s\_link](s-link.md)  |Links in messages to measure success rate of a campaign. |
|[s\_shipment](s-shipment.md)  |Contains info about one shipment. The addresses are stored in s_shipment_addr |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

