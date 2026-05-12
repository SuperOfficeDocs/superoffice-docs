---
uid: help-sv-screen-chooser
title: Skärmväljare
description: Skärmväljare
keywords: Användargränssnitt, skärmväljare
author: digitaldiina
date: 05.11.2026
version: 11.11
content_type: concept
tier: core
language: sv
---

# Skärmväljare

[!include[Requirement](../../../includes/req-dev-tools-transition.md)]

En skärmväljare är ett skript som kan göra en omdirigering till en annan skärm än standardskärmen. Skriptet kan köra CRMScript-funktionen "setVariable("url", myUrl)" för att visa en annan URL än standardwebbadressen. Detta gäller t.ex. för att omdirigera från skärmen Visa ärende till en standardskärm och/eller utföra beräkningar i skriptet innan skärmen visas. Skärmväljarna är organiserade i en mappstruktur baserat på var i systemet de körs.

## Egenskaper för skärmväljare

Här kan du ange ett skript som kan dirigera om visningen till en annan skärmbild genom att köra CRMScript-funktionen "setVariable("url", myUrl)".
