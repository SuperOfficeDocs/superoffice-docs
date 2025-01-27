---
uid: help-sv-superoffice-for-outlook-requirements
title: Krav
description: Krav och begränsningar ved SuperOffice for Outlook tillägget
keywords: SuperOffice for Outlook, Outlook, e-post
author: Frode B, Martin Pavlas
date: 01.27.2025
version_sofo: 2024.8.12
topic: reference
envir: cloud
client: online
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Krav

* Tillgängligt för både CRM Online och Onsite-kunder
  * Onsite: SuperOffice CRM Onsite 10.0.1 eller nyare (tillgänglig på internet med aktiverad REST API)
* Användare måste ha ett Microsoft 365-prenumeration och använda Microsoft 365-e-postkonto
* En kompatibel version av Outlook
* För mobiltelefoner: den senaste versionen av iOS eller Android och använd en app som stöder Outlook-tillägg

## Outlook-versioner

* Outlook på webben
* Outlook 2016 för Mac
* Outlook 2016 eller senare
* Outlook skrivbordsapp version 2001 eller nyare
* [Microsoft Outlook för iOS][2] på iOS 13
* [Microsoft Outlook för Android][3] på Android 10

## Begränsningar

SuperOffice for Outlook fungerar endast med huvudkontot. Delade brevlådor stöds inte.

Versioner tidigare än 2001 av Outlook skrivbordsapp fungerar inte i Skicka och Arkivera, eftersom de saknar API:er.

![Begränsningar i Outlook för SuperOffice -screenshot][img1]

## Krav för centraliserad distribution

Läs mer om kraven för [Centraliserad distribution][5] från Microsoft.

Om en uppdatering av tillägget avsevärt ökar omfattningen av dataåtkomst, måste du godkänna det igen innan uppdateringen distribueras.

<!-- Referenced links -->
[2]: https://apps.apple.com/us/app/microsoft-outlook/id951937596
[3]: https://play.google.com/store/apps/details?id=com.microsoft.office.outlook
[5]: https://aka.ms/centralized-deployment-guidance

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/email/outlook-api-limitation.png
