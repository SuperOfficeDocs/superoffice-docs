---
uid: help-nl-quote-connector-setup
title: ERP-verbinding instellen voor quote connector
description: Leer hoe u een quote connector configureert en ERP-verbindingen maakt om product- en prijsintegratie in SuperOffice CRM mogelijk te maken.
keywords: quote connector instellen, quote connector toevoegen, ERP-verbinding toevoegen, ERP-verbinding testen, ERP-verbinding, quote verbinding, quote connector, connector, offerte
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Instellingen en onderhoud
language: nl
redirect_from: /nl/quote/learn/admin/erp-connection-add
index: true
---

# ERP-verbinding instellen voor quote connector

Om offertes in SuperOffice CRM mogelijk te maken, moet u een **ERP-verbinding** maken via een beschikbare **quote connector**. De ERP-verbinding bepaalt waar de productgegevens en prijslogica vandaan komen — uit een extern ERP-systeem of het ingebouwde productregister van SuperOffice.

## 1. De quote connector-app verkrijgen

Voordat u een quote connector kunt gebruiken, moet u de juiste app voor uw ERP-systeem installeren.

1. Ga naar de [SuperOffice App Store][4].

2. Zoek een quote connector die uw ERP-systeem ondersteunt.

    * [Quote connector-apps][3]
    * [Sync-apps (optioneel)][2]

3. Volg de instructies van de provider om de app te installeren.

4. Neem indien nodig contact op met de app-provider om de installatie te voltooien.

## 2. Een ERP-verbinding toevoegen

Zodra de connector beschikbaar is, moet u een ERP-verbinding configureren om deze te activeren.

1. I Instellingen en onderhoud, ga naar <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Offerte/Sync** in de navigator.

1. Open het tabblad **ERP-verbindingen**.

1. Klik op **Toevoegen**. Het dialoogvenster **Nieuwe ERP-verbinding definiëren** verschijnt.

    ![Nieuwe ERP-verbinding definiëren -screenshot][img1]

1. Vul de vereiste velden in:

    * **Naam:** Interne naam voor deze verbinding
    * **Quote Connector:** Selecteer de connector die u wilt gebruiken
    * **Bereik:** Kies wie de verbinding en prijslijsten mag gebruiken:
      * **Alles:** Beschikbaar voor alle gebruikers
      * **Specifieke gebruikers en groepen:** Alleen geselecteerde gebruikers en groepen hebben toegang. Klik op de link om de dialoog voor toegang te openen.
    * **ERP-verbinding:** (indien van toepassing) selecteer een ERP-verbinding uit de synchronisatieconnector
    * **Configuratievelden:** Deze verschillen per connector en kunnen omvatten:
      * Verificatiegegevens
      * Server- of eindpuntinformatie
      * Bedrijfsregels zoals afronding, kortingsvalidatie of fallbacklogica

1. Vul eventueel een **beschrijving** in om het doel van de verbinding toe te lichten.

1. Klik op **ERP-verbinding testen** om te controleren of de verbinding werkt.

    > [!NOTE]
    > De test moet succesvol zijn voordat u kunt opslaan.

1. Klik op **OK** om de ERP-verbinding op te slaan.

De nieuwe verbinding verschijnt nu in de lijst en is klaar voor gebruik bij offertes.

## ERP-verbindingen verwijderen of herstellen

Een ERP-verbinding verwijderen:

1. Selecteer de verbinding in de lijst en klik op **Verwijderen**.

Een verwijderde ERP-verbinding herstellen:

1. Vink **Verwijderd** aan om verwijderde verbindingen weer te geven.
1. Selecteer de verbinding die u wilt herstellen.
1. Klik op **Herstellen**.

<!-- Referenced links -->
[2]: https://online.superoffice.com/appstore/app/search?phrase=sync
[3]: https://online.superoffice.com/appstore/app/search?phrase=quote
[4]: https://online.superoffice.com/appstore

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/quote-erp-connection.png
