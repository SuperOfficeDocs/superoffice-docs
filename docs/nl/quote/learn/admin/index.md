---
uid: help-nl-quote-admin
title: Offerte synchroniseren
description: SuperOffice Quote helpt u bij het maken, valideren en beheren van offertes en orders gedurende de gehele levenscyclus van de order.
author: SuperOffice RnD
date: 12.13.2023
keywords: offerte, synchroniseren, verkoop
topic: concept
audience: settings
audience_tooltip: Settings and maintenance
language: nl
---

# Offerte/Synchroniseren

SuperOffice Quote helpt u bij het maken, valideren en beheren van offertes en orders gedurende de gehele levenscyclus van de order. Het helpt u om nieuwe of bijgewerkte offertes sneller bij uw klanten te krijgen en de overgang van een lead naar een gesloten deal te versnellen.

> [!NOTE]
> Deze functie vereist een Sales Premium-gebruikersplan en de licentie voor Developer Tools.

Help uw collega's hun voorstellen sneller te verzenden en onnodige fouten te voorkomen door gebruik te maken van een geautomatiseerd offertesysteem. Bespaar tijd door uw offerte met één klik op de knop om te zetten in een opdrachtbevestiging.

![Het scherm Offerte in Verkoop met een offerte voor John Smith -screenshot][img1]

Het is voor u en uw collega's heel gemakkelijk om de producten voor een offerte uit de prijslijst te kiezen. U kunt verschillende versies van uw offerte naar uw klanten sturen en automatisch een vervolgactiviteit registreren. Het opzetten van een goed offertedocumentsjabloon is ook essentieel, zodat uw klanten ook informatie krijgen over producten en prijzen die in uw offerte zijn opgenomen.

## Het scherm

Op het scherm **Offerte/Synchroniseren** kunt u verbindingen en instellingen beheren voor ERP-systemen die zijn gekoppeld met SuperOffice CRM. Hier kunt u ook werken aan de prijslijsten en producten in de SuperOffice-database.

* [ERP-verbindingen][1] – Hier kunt u Quote Connectors en ERP-verbindingen configureren.
* [SuperOffice-producten][2] – Hier kunt u werken aan prijslijsten en producten die zijn opgeslagen in SuperOffice.
* [Instellingen][3] - Hier kunt u de instellingen voor offerten aanpassen en de velden configureren die voor producten worden weergegeven.
* [Sync][4] – Hier kunt u Sync Connectors en bijbehorende ERP-verbindingen configureren en toevoegen.

## Wat zijn Quote/Sync Connectors en ERP-verbindingen?

* Elke Quote Connector of Sync Connector is een DLL-bestand/webservice voor communicatiebeheer tussen SuperOffice en een ERP-systeem.
* Quote Connectors worden gebruikt om offerteprijzen te berekenen en om ordergegevens te verzenden naar het ERP-systeem wanneer een klant een offerte accepteert.
* Sync Connectors worden gebruikt om SuperOffice en het ERP-systeem te integreren, zodat bedrijven in SuperOffice kunnen worden gekoppeld/gesynchroniseerd met klanten en leveranciers in het ERP-systeem. Hetzelfde geldt voor personen en projecten.
* Een ERP-verbinding bestaat uit een Quote Connector of Sync Connector en configuratiegegevens (zoals client-gegevens (als het ERP-systeem wordt gebruikt door verschillende bedrijven) en verificatiegegevens voor het ERP-systeem).

## Hoe stel ik een ERP-verbinding in voor SuperOffice CRM for Web (online)?

[!include[How to set up ERP](includes/set-up-erp.md)]

## Gerelateerde inhoud

* [Prijslijsten aanpassen][5]
* [Productvelden configureren][6]
* [Producten toevoegen aan een prijslijst][7]
* [Productafbeelding toevoegen][8]

<!-- Referenced links -->
[1]: quotesync-tab-erp-connections.md
[2]: product/index.md
[3]: product/configure.md
[4]: sync/index.md
[5]: product/add-price-list.md
[6]: product/configure.md
[7]: product/add-product-to-price-list.md
[8]: product/select-product-image.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/quote/quote-management.png
