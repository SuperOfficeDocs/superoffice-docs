---
uid: help-sv-quote-admin
title: Offertsynk
description: "SuperOffice Quote hjälper dig att skapa, validera och hantera offerter och order under hela orderns livscykel."
author: SuperOffice RnD
date: 12.13.2023
keywords: offert, synk, försäljning
topic: concept
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Offert/Synk

SuperOffice Quote hjälper dig att skapa, validera och hantera offerter och order under hela orderns livscykel. Det hjälper dig att få ut nya eller uppdaterade offerter till dina kunder snabbare och påskynda övergången från lead till en avslutad affär.

> [!NOTE]
> Denna funktion kräver en användarplan för Sales Premium och licens för Developer Tools.

Hjälp dina kollegor att skicka sina offerter snabbare och undvik onödiga fel genom att använda ett automatiserat offertsystem. Spara tid genom att konvertera ditt förslag till en orderbekräftelse med bara en knapptryckning.

![Offertskärmen i Försäljning som visar en offert för John Smith -screenshot][img1]

Det blir väldigt enkelt för dig och dina kollegor att välja produkter för ett förslag från prislistan. Du kan skicka olika versioner av ditt förslag till dina kunder och automatiskt registrera en händelseaktivitet. Att skapa en bra offertdokumentmall är också viktigt, så att dina kunder också får information om produkter och priser som läggs till i din offert.

## Skärmen

I fönstret **Offert/Synk**-kan du administrera kopplingar och inställningar för ERP-system som är kopplade till SuperOffice CRM. Här arbetar du också med prislistorna och produkterna i SuperOffice-databasen.

* [ERP-kopplingar][1] – Här kan du konfigurera och lägga till Quote Connectors och ERP-kopplingar.
* [SuperOffice-produkter][2] – Här kan du arbeta med prislistorna och produkterna som finns i SuperOffice.
* [Inställningar][3] – Här kan du anpassa inställningarna för offerterna och konfigurera fälten som visas för produkterna.
* [Synk][4] – Här kan du konfigurera och lägga till Sync Connectors och tillhörande ERP-kopplingar.

## Vad är Quote/Sync Connectors och ERP-kopplingar?

* Varje Quote Connector eller Sync Connector är en DLL-fil/web service som hanterar kommunikationen mellan SuperOffice och ett ERP-system.
* Quote Connectors används för att beräkna offertpriser och för att skicka orderdetaljer till ERP-systemet när kunden godkänner offerten.
* Sync Connectors används för att integrera SuperOffice och ERP-systemet så att företag i SuperOffice kan kopplas/synkroniseras med kunder och leverantörer i ERP-systemet. Detsamma gäller för kontakter och projekt.
* En ERP-koppling består av en Quote Connector eller Sync Connector och konfigurationsinformation (till exempel klientinformation om ERP-systemet används av flera företag) och autentiseringsinformation för ERP-systemet.

## Relaterat innehåll

* [Anpassa prislistor][5]
* [Konfigurera produktfält][6]
* [Lägga till produkt i prislista][7]
* [Lägga till en produktbild][8]

<!-- Referenced links -->
[1]: quotesync-tab-erp-connections.md
[2]: product/index.md
[3]: product/configure.md
[4]: ../../../erp/admin/index.md
[5]: product/add-price-list.md
[6]: product/configure.md
[7]: product/add-product-to-price-list.md
[8]: product/select-product-image.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/quote/quote-management.png
