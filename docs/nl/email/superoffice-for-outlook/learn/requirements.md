---
uid: help-nl-superoffice-for-outlook-requirements
title: Vereisten
description: Vereisten en beperkingen of SuperOffice voor Outlook invoegtoepassing
keywords: SuperOffice voor Outlook, Outlook, e-mail
author: Frode B, Martin Pavlas
date: 01.27.2025
version_sofo: 2024.8.12
topic: reference
envir: cloud
client: online
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Vereisten

* Beschikbaar voor zowel CRM Online- als Onsite-klanten
  * Onsite: SuperOffice CRM Onsite 10.0.1 of nieuwer (beschikbaar op internet met REST API ingeschakeld)
* Gebruikers moeten een Microsoft 365-abonnement hebben en een Microsoft 365-mailaccount gebruiken
* Een compatibele versie van Outlook
* Voor mobiele telefoons: de nieuwste versie van iOS of Android en gebruik een app die Outlook-invoegtoepassings ondersteunt

## Outlook-versies

* Outlook op het web
* Outlook 2016 voor Mac
* Outlook 2016 of nieuwer
* Outlook desktop-app versie 2001 of nieuwer
* [Microsoft Outlook voor iOS][2] op iOS 13
* [Microsoft Outlook voor Android][3] op Android 10

## Beperkingen

SuperOffice voor Outlook werkt alleen met het hoofdaccount. Gedeelde mailboxen worden niet ondersteund.

Versies ouder dan 2001 van de Outlook-desktop-app werken niet met Verzenden en Archiveren, omdat ze geen API's hebben.

![Beperkingen in Outlook voor SuperOffice -screenshot][img1]

## Vereisten voor gecentraliseerde implementatie

Lees meer over de vereisten voor [Gecentraliseerde implementatie][5] van Microsoft.

Als een invoegtoepassing-update de reikwijdte van de toegang tot gegevens aanzienlijk vergroot, moet u deze opnieuw goedkeuren voordat de update wordt geïmplementeerd.

<!-- Referenced links -->
[2]: https://apps.apple.com/us/app/microsoft-outlook/id951937596
[3]: https://play.google.com/store/apps/details?id=com.microsoft.office.outlook
[5]: https://aka.ms/centralized-deployment-guidance

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/email/outlook-api-limitation.png
