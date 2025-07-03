---
uid: help-no-quote-connector-setup
title: Konfigurere ERP-kobling for Quote Connector
description: Lær hvordan du konfigurerer en quote connector og oppretter ERP-koblinger for å aktivere produkt- og prisintegrasjon i SuperOffice CRM.
keywords: konfigurere quote connector, legge til quote connector, legge til ERP-kobling, teste ERP-kobling, ERP-kobling, quote connector, connector, tilbud
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Innstillinger og vedlikehold
language: no
redirect_from: /no/quote/learn/admin/erp-connection-add
index: true
---

# Konfigurere ERP-kobling for Quote Connector

For å aktivere tilbud i SuperOffice CRM, må du opprette en **ERP-kobling** ved hjelp av en tilgjengelig **Quote Connector**. ERP-koblingen bestemmer hvor produktdata og prislogikk kommer fra – enten fra et eksternt ERP-system eller fra SuperOffice sitt innebygde produktregister.

## 1. Skaff deg Quote Connector-appen

Før du kan bruke en quote connector, må du installere riktig app for ERP-systemet ditt.

1. Gå til [SuperOffice App Store][4].

2. Søk etter en quote connector som støtter ERP-systemet ditt.

    * [Quote Connector-apper][3]
    * [Sync-apper (valgfritt)][2]

3. Følg leverandørens instruksjoner for å installere appen.

4. Kontakt eventuelt app-leverandøren for å fullføre oppsettet.

## 2. Legge til en ERP-kobling

Når connectoren er tilgjengelig, må du konfigurere en ERP-kobling for å aktivere den.

1. I **Innstillinger og vedlikehold**, velg <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Tilbud/Sync** i navigatoren.

1. Gå til fanen **ERP-koblinger**.

1. Klikk på **Legg til**. Dialogboksen **Angi ny ERP-kobling** åpnes.

    ![Angi ERP-kobling -screenshot][img1]

1. Fyll ut de påkrevde feltene:

    * **Navn:** Internt navn på denne koblingen
    * **Quote Connector:** Velg connectoren som skal brukes
    * **Synlighet:** Velg hvem som kan bruke koblingen (og prisliste):
      * **Alle:** Tilgjengelig for alle brukere
      * **Angitte brukere og grupper:** Kun valgte brukere og grupper har tilgang. Klikk på lenken for å åpne dialogboksen for tilgang.
    * **ERP-kobling:** (hvis aktuelt) velg en ERP-kobling fra sync-connectoren for dette ERP systemet
    * **Konfigurasjonsfelt:** Varierer avhengig av connector og kan inkludere:
      * Autentiseringsinformasjon
      * Server- eller endepunktinformasjon
      * Forretningsregler som avrunding, rabattvalidering eller fallback-logikk

1. Skriv eventuelt inn en **beskrivelse** for å tydeliggjøre koblingens formål.

1. Klikk på **Test ERP-kobling** for å verifisere at den fungerer.

    > [!NOTE]
    > Testen må være vellykket før du kan lagre.

1. Klikk på **OK** for å lagre ERP-koblingen.

Den nye koblingen vises nå i listen og er klar til bruk i tilbudsfunksjonaliteten.

## Slette eller gjenopprette ERP-koblinger

Slik sletter du en ERP-kobling:

1. Velg koblingen i listen og klikk på **Slett**.

Slik gjenoppretter du en slettet kobling:

1. Merk av for **Slettet** for å vise fjernede koblinger.
1. Velg ønsket kobling.
1. Klikk på **Gjenopprett**.

<!-- Referenced links -->
[2]: https://online.superoffice.com/appstore/app/search?phrase=sync
[3]: https://online.superoffice.com/appstore/app/search?phrase=quote
[4]: https://online.superoffice.com/appstore

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/quote-erp-connection.png
