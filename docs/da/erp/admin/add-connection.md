---
uid: help-da-erp-add-connection
title: Tilføj en Sync Connector og ERP-forbindelse
description: Lær, hvordan du installerer en sync-app, tilføjer en Sync Connector og opretter ERP-forbindelser for at aktivere synkronisering mellem SuperOffice CRM og et ERP-system.
keywords: opsæt ERP-synk, tilføj Sync Connector, Sync Connector, tilføj ERP-forbindelse, test ERP-forbindelse, ERP-forbindelse, connector, synk, ERP
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Indstillinger og vedligeholdelse
language: da
redirect_from:
  - /da/quote/learn/admin/sync/sync-add-erp-connection
  - /da/quote/learn/admin/sync/sync-connector-add
index: true
---

# Tilføj en Sync Connector og ERP-link

[!include[Requirement](../../includes/req-dev-tools.md)]

For at synkronisere data mellem SuperOffice CRM og et ERP-system skal du først installere en sync-app. Derefter skal du i Indstillinger og vedligeholdelse konfigurere en Sync Connector og et eller flere ERP-links.

## 1. Installer sync-appen

Før du kan tilføje en Sync Connector, skal du have en sync-app til dit ERP-system.

1. Tjek [SuperOffice App Store][7] for en standard sync-app, der understøtter dit ERP-system.

    Hvis der ikke findes en standardapp, eller hvis du har brug for en tilpasset løsning, kan du få en [udviklet af en SuperOffice-partner][8] eller dit eget team.

1. Følg app-udbyderens instruktioner for at installere og registrere connectoren.

## <a id="connector"></a>2. Tilføj en Sync Connector

1. I **Indstillinger og vedligeholdelse**, vælg <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Tilbud/Sync** i navigatoren.

1. Åbn fanen **Sync**.

1. Klik på **Tilføj** under **Sync Connectors**-listen.

1. Indtast navn og connector-URL.

1. Klik på **OK**.

Sync connectoren tilføjes til listen.

![Sync-fanen i Indstillinger og vedligeholdelse med én Sync Connector -screenshot][img1]

## <a id="connection"></a>3. Tilføj et ERP-link

1. I fanen **Sync**, klik på **Tilføj** under **ERP-links**-listen.

    Dialogboksen **Angiv nyt ERP-link** åbnes.

    ![Dialogboks til oprettelse af ERP-link med eksempeldata -screenshot][img2]

1. Indtast et navn til ERP-linket.

1. Vælg den Sync Connector, der skal bruges, fra listen.

1. Definér **synlighed**:

    * **Alle**: Alle brugere kan tilgå og bruge dette ERP-link.
    * **Angivne brugere + grupper**: Kun valgte brugere og grupper har adgang. Klik på linket for at åbne dialogen og vælge adgang.

        ![Dialogboks til konfiguration af område med brugergruppevalg -screenshot][img3]

1. Udfyld **konfigurationsfelterne**. Disse afhænger af den valgte connector og kan inkludere autentificering, stier, talværdier eller andre tekniske oplysninger.

1. Tilføj eventuelt en beskrivelse for at forklare formålet med linket.

1. Klik på **Test ERP-link**.

    Hvis testen mislykkes, kontroller connectorens URL og konfigurationsfelterne. Du skal rette fejlen, før du kan fortsætte.

1. Klik på **OK** for at gemme linket. Den nye ERP-link vises i listen.

    Hvis knappen **OK** er nedtonet, betyder det, at testen ikke er bestået, eller at påkrævede felter mangler.

> [!NOTE]
> Før ERP-linket kan bruges, skal du konfigurere synkroniseringsindstillinger og aktivere linket. Se [Konfigurer ERP-link][1].

## Næste trin

* [Konfigurer felttilknytning og lister][1]
* [Angiv standardværdier][3]
* [Vælg rækkefølgen for ERP-felterne][4], der vises i ERP-fanen i SuperOffice CRM
* [Angiv synkroniseringsprioritet][5]
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
