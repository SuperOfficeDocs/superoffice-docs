---
uid: help-sv-package-properties-service
title: Egenskaper för paket
description: Egenskaper för paket
keywords: paket egenskaper
author: SuperOffice Product and Engineering
date: 07.10.2025
version: 10.5
content_type: reference
audience: settings
audience_tooltip: Settings and maintenance
category: customization
index: true
language: sv
redirect_from: 
  - /no/admin/learn/screen/package-properties
  - /no/admin/learn/package-properties
  - /no/customization/admin/index
---

# Egenskaper för paket

På fliken **Paket** under <i class="ph ph-selection-all" aria-hidden="true"></i> **Systemdesign** kan du redigera ett pakets egenskaper och innehåll. Om det är ett olåst installerat paket kan du även specificera vad som ska installeras. Om paketet har skapats i det aktuella systemet kan du lägga till och ta bort objekt beroende på vad du vill inkludera i paketet. Om paketet har skapats i ett annat system men laddats upp till det aktuella systemet kan du välja vilka delar som ska installeras på denna skärm – förutsatt att paketet inte är låst.

* **Namn**: Namn på paketet.
* **Version av SuperOffice Service**: Paketet kan bara installeras i system med en senare version av SuperOffice Service än den som anges här.
* **Paketversion**: Paketets versionsnummer används när ett låst paket uppgraderas automatiskt.
* **Låst**: Om detta alternativ är markerat är objekten i paketet inte redigerbara.
* **Beskrivning**: Beskrivning av paketet.
* **Installationsskript**: Installationsskriptet körs när komponenterna i paketet installeras eller avinstalleras och hämtar information om vilka komponenter som är valda och vilka som var valda tidigare.
