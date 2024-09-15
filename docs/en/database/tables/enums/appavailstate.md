---
uid: enum-appavailstate
title: Enum values for AppAvailState
description: Lists the enum values for AppAvailState.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# AppAvailState Enum

When should this application be available from SO: 0=always, 1=on central db, 2=on travel db,4 on satellite. The value 5 (1+4) indicates that this application is available when logged in to a central or satellite db

| Name | Value | Description |
|------|-------|-------------|
|Always|0|This application is always available|
|CentralDb|1|This application is only available on the Central database|
|SatelliteDb|2|This application is only available on a Satellite database|
|TravelDb|4|This application is only available on a Travel database|
|SalesMarketingWeb|8|This application is available on Sales Marketing Web|
|SalesMarketingPocket|16|This application is available on Sales Marketing Pocket|

## Usage

* [ExtApp](../extapp.md).availableInState - ExtApp list table. Applications startable from SuperOffice
