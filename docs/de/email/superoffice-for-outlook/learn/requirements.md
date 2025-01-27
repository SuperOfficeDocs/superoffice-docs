---
uid: help-de-superoffice-for-outlook-requirements
title: Anforderungen
description: Anforderungen für und Einschränkungen in SuperOffice für Outlook Add-In.
keywords: SuperOffice for Outlook, Outlook, email
author: Frode B, Martin Pavlas
date: 01.27.2025
version_sofo: 2024.8.12
topic: reference
envir: cloud
client: online
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Anforderungen

* Verfügbar für sowohl CRM Online- als auch Onsite-Kunden
  * Onsite: SuperOffice CRM Onsite 10.0.1 oder neuer (verfügbar im Internet mit aktivierter REST-API)
* Benutzer müssen ein Microsoft 365-Abonnement haben und ein Microsoft 365-Mailkonto verwenden
* Eine kompatible Version von Outlook
* Für Mobiltelefone: die neueste Version von iOS oder Android und eine App verwenden, die Outlook-Add-Ins unterstützt

## Outlook-Versionen

* Outlook im Web
* Outlook 2016 für Mac
* Outlook 2016 oder neuer
* Outlook-Desktop-App Version 2001 oder neuer
* [Microsoft Outlook für iOS][2] auf iOS 13
* [Microsoft Outlook für Android][3] auf Android 10

## Einschränkungen

SuperOffice für Outlook funktioniert nur mit dem Hauptkonto. Geteilte Postfächer werden nicht unterstützt.

Versionen vor 2001 der Outlook-Desktop-App funktionieren nicht in Senden und Archivieren, da ihnen APIs fehlen.

![Einschränkungen in Outlook für SuperOffice -screenshot][img1]

## Anforderungen für zentrale Bereitstellung

Erfahren Sie mehr über die Anforderungen für [Zentrale Bereitstellung][5] von Microsoft.

Wenn ein Add-In-Update den Umfang des Datenzugriffs erheblich erweitert, müssen Sie es vor der Bereitstellung erneut genehmigen.

<!-- Referenced links -->
[2]: https://apps.apple.com/us/app/microsoft-outlook/id951937596
[3]: https://play.google.com/store/apps/details?id=com.microsoft.office.outlook
[5]: https://aka.ms/centralized-deployment-guidance

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/email/outlook-api-limitation.png
