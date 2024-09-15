---
uid: enum-erpactortype
title: Enum values for ErpActorType
description: Lists the enum values for ErpActorType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# ErpActorType Enum

The actor type within the ERP system of this synchronized record

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|Unknown - used when initializing|
|Customer|1|Erp Customer|
|Supplier|2|Supplier or Vendor|
|Partner|3|Both customer and supplier|
|Person|4|Contact person|
|Project|5|Project|
|Employee|6|Employee, often mapped to associate|
|Sale|7|Sale|

## Usage

* [ErpConnectionActorType](../erpconnectionactortype.md).ActorTypeErp - Data about the configuration of one Erp Actor on one ErpConnection
* [ErpExternalKey](../erpexternalkey.md).ActorType - The external (ERP-facing) key related to a synchronized record / connection
