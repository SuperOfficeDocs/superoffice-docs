---
uid: help-sv-quote-connector-setup
title: Konfigurera ERP-koppling för Quote Connector
description: Lär dig hur du konfigurerar en quote connector och skapar ERP-kopplingar för att aktivera produkt- och prisintegration i SuperOffice CRM.
keywords: konfigurera quote connector, lägga till quote connector, lägga till ERP-koppling, testa ERP-koppling, ERP-koppling, quote connector, connector, offert
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Inställningar och underhåll
language: sv
redirect_from: /sv/quote/learn/admin/erp-connection-add
index: true
---

# Konfigurera ERP-koppling för Quote Connector

För att aktivera offertfunktionen i SuperOffice CRM måste du skapa en **ERP-koppling** med hjälp av en tillgänglig **Quote Connector**. ERP-kopplingen avgör var produktdata och prislogik kommer från – antingen från ett externt ERP-system eller från SuperOffice:s inbyggda produktregister.

## 1. Skaffa quote connector-appen

Innan du kan använda en quote connector måste du installera rätt app för ditt ERP-system.

1. Gå till [SuperOffice App Store][4].

2. Sök efter en quote connector som stöder ditt ERP-system.

    * [Quote Connector-appar][3]
    * [Sync-appar (valfritt)][2]

3. Följ leverantörens instruktioner för att installera appen.

4. Kontakta leverantören om det krävs för att slutföra installationen.

## 2. Lägg till en ERP-koppling

När connectorn är tillgänglig måste du konfigurera en ERP-koppling för att aktivera den.

1. I **Inställningar och underhåll**, välj <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Offert/Sync** i navigatorn.

1. Öppna fliken **ERP-kopplingar**.

1. Klicka på **Lägg till**. Dialogrutan **Ange ny ERP-koppling** öppnas.

    ![Ange ny ERP-koppling -screenshot][img1]

1. Fyll i de obligatoriska fälten:

    * **Namn:** Internt namn på kopplingen
    * **Quote Connector:** Välj connectorn som ska användas
    * **Synlighet:** Välj vem som kan använda kopplingen (och dess prislista):
      * **Alla:** Tillgänglig för alla användare
      * **Angivna användare + grupper:** Endast valda användare och grupper har åtkomst. Klicka på länken för att öppna dialogrutan och välja åtkomst.
    * **ERP-koppling:** (vid behov) välj en ERP-koppling från sync-connectorn för systemet
    * **Konfigurationsfält:** Varierar beroende på connector och kan inkludera:
      * Autentiseringsuppgifter
      * Server- eller endpointinformation
      * Affärsregler som avrundning, rabattvalidering eller reservlogik

1. Fyll eventuellt i en **Beskrivning** för att förtydliga syftet med kopplingen.

1. Klicka på **Testa ERP-kopplingen** för att verifiera att kopplingen fungerar.

    > [!NOTE]
    > Testet måste lyckas innan du kan spara.

1. Klicka på **OK** för att spara ERP-kopplingen.

Den nya kopplingen visas nu i listan och är redo att användas för offerter.

## Ta bort eller återställa ERP-kopplingar

Så här tar du bort en ERP-koppling:

1. Markera kopplingen i listan och klicka på **Ta bort**.

Så här återställer du en borttagen koppling:

1. Markera **Borttagen** för att visa raderade kopplingar.
1. Välj den koppling du vill återställa.
1. Klicka på **Återskapa**.

<!-- Referenced links -->
[2]: https://online.superoffice.com/appstore/app/search?phrase=sync
[3]: https://online.superoffice.com/appstore/app/search?phrase=quote
[4]: https://online.superoffice.com/appstore

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/quote-erp-connection.png
