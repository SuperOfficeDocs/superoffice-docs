---
uid: help-no-superoffice-for-outlook-requirements
title: Krav
description: Krav og kjente begrensninger for SuperOffice for Outlook-tillegget
keywords: SuperOffice for Outlook, Outlook, e-post
author: Frode B, Martin Pavlas
date: 10.29.2024
version_sofo: 2024.8.12
topic: reference
envir: cloud
client: online
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Krav

* Tilgjengelig for både CRM Online og Onsite-kunder
  * Onsite: SuperOffice CRM Onsite 10.0.1 eller nyere (tilgjengelig på internett med REST API aktivert)
* Brukere må ha et Microsoft 365-abonnement og bruke Microsoft 365-e-postkonto
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

Den nåværende versjonen av tillegg (via Microsoft AppSource) støtter ikke mobiltelefoner (mobilenhetens API).

For å få versjonen som har støtte for mobile enheter, bruk en av disse alternativene:

* Alternativ a: [sentralisert distribusjon][1]
* Alternativ b: [bruk pilotversjonen][4]

## Krav til sentralisert distribusjon

Lær mer om kravene til [sentralisert distribusjon][5] fra Microsoft.

Hvis en oppdatering betydelig øker omfanget av dataadgang, må du godkjenne tillegget på nytt før oppdateringen distribueres.

<!-- Referenced links -->
[1]: ../../../../en/email/superoffice-for-outlook/it/deploy.md
[2]: https://apps.apple.com/us/app/microsoft-outlook/id951937596
[3]: https://play.google.com/store/apps/details?id=com.microsoft.office.outlook
[4]: https://community.superoffice.com/en/forums/pilot-program/superoffice-for-outlook/how-to-deploy-superoffice-for-outlook-during-pilot/
[5]: https://aka.ms/centralized-deployment-guidance

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/email/outlook-api-limitation.png
