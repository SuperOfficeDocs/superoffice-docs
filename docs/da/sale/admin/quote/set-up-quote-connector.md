---
uid: help-da-quote-connector-setup
title: Konfigurer ERP-link for Quote Connector
description: Lær, hvordan du konfigurerer en quote connector og opretter ERP-links for at aktivere produkt- og prisintegration i SuperOffice CRM.
keywords: konfigurere quote connector, tilføj quote connector, tilføj ERP-link, test ERP-link, ERP-link, quote connector, connector, tilbud
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Indstillinger og vedligeholdelse
language: da
redirect_from: /da/quote/learn/admin/erp-connection-add
index: true
---

# Konfigurer ERP-link for Quote Connector

For at aktivere tilbud i SuperOffice CRM skal du oprette et **ERP-link** ved hjælp af en tilgængelig **Quote Connector**. ERP-linket bestemmer, hvor produktdata og prislogik kommer fra – enten fra et eksternt ERP-system eller fra SuperOffice's indbyggede produktregister.

## 1. Hent quote connector-appen

Før du kan bruge en quote connector, skal du installere den korrekte app til dit ERP-system.

1. Gå til [SuperOffice App Store][4].

2. Søg efter en quote connector, der understøtter dit ERP-system.

    * [Quote Connector-apps][3]
    * [Sync-apps (valgfrit)][2]

3. Følg udbyderens instruktioner for at installere appen.

4. Kontakt eventuelt app-udbyderen for at fuldføre konfigurationen.

## 2. Tilføj et ERP-link

Når connectoren er tilgængelig, skal du konfigurere et ERP-link for at aktivere det.

1. I **Indstillinger og vedligeholdelse**, vælg <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Tilbud/Sync** i navigatoren.

1. Gå til fanen **ERP-links**.

1. Klik på **Tilføj**. Dialogboksen **Angiv nyt ERP-link** åbnes.

    ![Angiv nyt ERP-link -screenshot][img1]

1. Udfyld de nødvendige felter:

    * **Navn:** Internt navn for dette link
    * **Quote Connector:** Vælg den connector, der skal bruges
    * **Synlighed:** Vælg, hvem der må bruge linket (og prislisten):
      * **Alle:** Tilgængelig for alle brugere
      * **Angivne brugere + grupper:** Kun valgte brugere og grupper har adgang. Klik på linket for at åbne dialogen og vælge adgang.
    * **ERP-link:** (hvis relevant) vælg et ERP-link fra sync-connectoren til dette system
    * **Konfigurationsfelt:** Varierer afhængigt af connector og kan inkludere:
      * Oplysninger om godkendelse
      * Server- eller endpoint-information
      * Forretningsregler som afrunding, validering af rabat eller fallback-logik

1. Angiv eventuelt en **Beskrivelse** for at forklare formålet med ERP-linket.

1. Klik på **Test ERP-linket** for at kontrollere, at det fungerer.

    > [!NOTE]
    > Testen skal være bestået, før du kan gemme.

1. Klik på **OK** for at gemme ERP-linket.

Det nye link vises nu på listen og er klar til brug i prislister og tilbud.

## Slet eller gendan ERP-links

Sådan sletter du et ERP-link:

1. Vælg linket på listen, og klik på **Slet**.

Sådan gendanner du et slettet ERP-link:

1. Marker afkrydsningsfeltet **Slettet** for at få vist fjernede links.
1. Vælg det ønskede link.
1. Klik på **Gendan**.

<!-- Referenced links -->
[2]: https://online.superoffice.com/appstore/app/search?phrase=sync
[3]: https://online.superoffice.com/appstore/app/search?phrase=quote
[4]: https://online.superoffice.com/appstore

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/quote-erp-connection.png
