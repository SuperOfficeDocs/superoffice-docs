---
uid: help-no-erp-add-connection
title: Legge til Sync Connector og ERP-kobling
description: Lær hvordan du installerer en sync-app, legger til en Sync Connector og oppretter ERP-koblinger for å aktivere synkronisering mellom SuperOffice CRM og et ERP-system.
keywords: sette opp ERP-synk, legge til Sync Connector, ERP-kobling, test ERP-kobling, ERP-forbindelse, connector, synk, ERP
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Innstillinger og vedlikehold
language: no
redirect_from:
  - /no/quote/learn/admin/sync/sync-add-erp-connection
  - /no/quote/learn/admin/sync/sync-connector-add
index: true
---

# Legge til Sync Connector og ERP-kobling

[!include[Requirement](../../includes/req-dev-tools.md)]

For å kunne synkronisere data mellom SuperOffice CRM og et ERP-system, må du først installere en sync-app. Deretter konfigurerer du en Sync Connector og én eller flere ERP-koblinger i Innstillinger og vedlikehold.

## 1. Installer sync-appen

Før du kan legge til en Sync Connector, må du ha en sync-app for ERP-systemet ditt.

1. Sjekk [SuperOffice App Store][7] for en standard sync-app som støtter ERP-systemet ditt.

    Hvis det ikke finnes noen standardapp, eller du trenger en tilpasset versjon, kan du få en [utviklet av en SuperOffice-partner][8] eller av ditt eget team.

1. Følg instruksjonene fra app-leverandøren for å installere og registrere connectoren.

## <a id="connector"></a>2. Legge til en Sync Connector

1. I **Innstillinger og vedlikehold**, velg <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Tilbud/Sync** i navigatoren.

1. Åpne fanen **Sync**.

1. Klikk på **Legg til** under listen **Sync Connectors**.

1. Angi navn og URL-adresse for connectoren.

1. Klikk på **OK**.

Sync Connectoren vises nå i listen.

![Sync-fanen i Innstillinger og vedlikehold med én Sync Connector -screenshot][img1]

## <a id="connection"></a>3. Legge til en ERP-kobling

1. Klikk på **Legg til** under listen **ERP-koblinger** i fanen **Sync**.

    Dialogboksen **Angi ny ERP-kobling** vises.

    ![Dialogboksen Angi ny ERP-kobling med eksempelinndata -screenshot][img2]

1. Skriv inn navnet på ERP-koblingen.

1. Velg ønsket Sync Connector fra listen.

1. Definer **synlighet**:

    * **Alle**: Alle brukere kan få tilgang til og bruke denne ERP-koblingen.
    * **Angitte brukere + grupper**: Kun valgte brukere og grupper har tilgang. Klikk på lenken for å åpne dialogboksen for tilgang.

        ![Dialogboks for konfigurasjon av synlighet med brukergrupper -screenshot][img3]

1. Fyll inn **konfigurasjonsfeltene**. Feltene varierer basert på den valgte connectoren og kan inkludere autentisering, filbaner, tallinnstillinger eller andre tekniske parametere.

1. Eventuelt kan du skrive inn en beskrivelse som forklarer formålet med koblingen.

1. Klikk på **Test ERP-koblingen**.

    Hvis testen mislykkes, må du kontrollere URL og konfigurasjonsfeltene. Rett opp eventuelle feil før du går videre.

1. Klikk på **OK** for å lagre koblingen. Den nye ERP-koblingen vises nå i listen.

    Hvis **OK**-knappen er grå, betyr det at testen ikke er fullført eller at obligatoriske felter mangler.

> [!NOTE]
> Før ERP-koblingen kan brukes, må du konfigurere synkroniseringsinnstillingene og aktivere koblingen. Se [Konfigurer ERP-kobling][1].

## Neste trinn

* [Konfigurer felttilordning og lister][1]
* [Angi standardverdier][3]
* [Velg rekkefølgen på ERP-feltene][4] som vises i ERP-fanen i SuperOffice CRM
* [Angi synkroniseringsprioritet][5]
* [Importer data fra ERP][6]

<!-- Referenced links -->
[1]: configure.md
[3]: configure.md#defaults
[4]: configure.md#rank
[5]: configure.md#priority
[6]: ../../admin/import/from-erp.md
[7]: https://online.superoffice.com/appstore/app/search?phrase=sync
[8]: ../../../en/developer-portal/custom-app/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/erp/sync-connectors-list.png
[img2]: ../../../media/loc/en/erp/define-erp-connection.png
[img3]: ../../../media/loc/en/erp/configure-scope.png
