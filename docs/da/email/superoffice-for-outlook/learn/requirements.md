---
uid: help-da-superoffice-for-outlook-requirements
title: Krav
description: Krav og begrensninger til SuperOffice for Outlook tilføjelsesprogrammet.
keywords: SuperOffice for Outlook, Outlook, email
author: Frode B, Martin Pavlas
date: 01.27.2025
version_sofo: 2024.8.12
topic: reference
envir: cloud
client: online
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Krav

* Tilgjengelig for både CRM Online og Onsite-kunder
  * Onsite: SuperOffice CRM Onsite 10.0.1 eller nyere (tilgjengelig på internett med REST API aktivert)
* Brukere må ha et Microsoft 365-abonnement og bruke Microsoft 365-postkonto
* En kompatibel versjon av Outlook
* For mobiltelefoner: den nyeste versjonen av iOS eller Android og bruk en app som støtter Outlook-tillegg

## Outlook-versjoner

* Outlook på nettet
* Outlook 2016 for Mac
* Outlook 2016 eller nyere
* Outlook skrivebordsapp versjon 2001 eller nyere
* [Microsoft Outlook for iOS][2] på iOS 13
* [Microsoft Outlook for Android][3] på Android 10

## Begrensninger

SuperOffice for Outlook fungerer kun med hovedkontoen. Delte postbokser støttes ikke.

Versjoner tidligere enn 2001 av Outlook skrivebordsapp fungerer ikke i Send og Arkiver, fordi de mangler API-er.

![Begrensninger i Outlook for SuperOffice -screenshot][img1]

## Krav til sentralisert distribusjon

Lær mer om kravene til [Sentralisert distribusjon][5] fra Microsoft.

Hvis en tilleggsoppdatering betydelig øker omfanget av dataadgang, må du godkjenne det på nytt før oppdateringen distribueres.

<!-- Referenced links -->
[2]: https://apps.apple.com/us/app/microsoft-outlook/id951937596
[3]: https://play.google.com/store/apps/details?id=com.microsoft.office.outlook
[5]: https://aka.ms/centralized-deployment-guidance

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/email/outlook-api-limitation.png
