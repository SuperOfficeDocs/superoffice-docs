---
uid: help-sv-erp-add-connection
title: Lägga till Sync Connector och ERP-koppling
description: Lär dig hur du installerar en synk-app, lägger till en Sync Connector och skapar ERP-kopplingar för att aktivera synkronisering mellan SuperOffice CRM och ett ERP-system.
keywords: konfigurera ERP-synk, lägga till sync connector, lägga till ERP-koppling, testa ERP-koppling, ERP-koppling, synk, ERP
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Inställningar och underhåll
language: sv
redirect_from:
  - /sv/quote/learn/admin/sync/sync-add-erp-connection
  - /sv/quote/learn/admin/sync/sync-connector-add
index: true
---

# Lägga till Sync Connector och ERP-koppling

[!include[Requirement](../../includes/req-dev-tools.md)]

För att synkronisera data mellan SuperOffice CRM och ett ERP-system måste du först installera en synk-app. Därefter konfigurerar du en Sync Connector och en eller flera ERP-kopplingar i Inställningar och underhåll.

## 1. Installera synk-appen

Innan du kan lägga till en Sync Connector måste du ha en synk-app för ditt ERP-system.

1. Sök i [SuperOffice App Store][7] efter en standardapp som stöder ditt ERP-system.

    Om ingen standardapp finns tillgänglig, eller om du behöver en anpassad version, kan du få en [utvecklad av en SuperOffice-partner][8] eller av ditt interna team.

1. Följ leverantörens instruktioner för att installera och registrera connectorn.

## <a id="connector"></a>2. Lägga till en Sync Connector

1. I **Inställningar och underhåll**, välj <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Offert/Synk** i navigatorn.

1. Öppna fliken **Synk**.

1. Klicka på **Lägg till** längst ned i listan **Sync Connectors**.

1. Ange ett namn och connectorns URL.

1. Klicka på **OK**.

Sync Connector läggs till i listan.

![Synk-fliken i Inställningar och underhåll med en Sync Connector -screenshot][img1]

## <a id="connection"></a>3. Lägga till en ERP-koppling

1. Klicka på **Lägg till** längst ned i listan **ERP-kopplingar** i fliken **Synk**.

    Dialogrutan **Ange ny ERP-koppling** öppnas.

    ![Dialogrutan för att definiera ny ERP-koppling med exempeldata -screenshot][img2]

1. Ange ett namn för ERP-kopplingen.

1. Välj önskad Sync Connector i listan.

1. Ange **synlighet**:

    * **Alla**: Alla användare har åtkomst till denna ERP-koppling.
    * **Angivna användare + grupper**: Endast valda användare och grupper har åtkomst. Klicka på länken för att öppna dialogrutan och välja åtkomst.

        ![Dialogruta för att konfigurera synlighet med användargrupper -screenshot][img3]

1. Fyll i **konfigurationsfälten**. Dessa är specifika för den valda connectorn och kan inkludera autentisering, sökvägar, nummerformat eller andra tekniska värden.

1. Ange eventuellt en beskrivning som förklarar syftet med kopplingen.

1. Klicka på **Testa ERP-kopplingen**.

    Om testet misslyckas, kontrollera URL:en och inställningarna i konfigurationsfälten. Åtgärda felet innan du fortsätter.

1. Klicka på **OK** för att spara kopplingen. Den nya ERP-kopplingen visas i listan.

    Om **OK**-knappen är inaktiverad har testet inte genomförts eller obligatoriska fält saknas.

> [!NOTE]
> Innan ERP-kopplingen kan användas måste du konfigurera synkroniseringsinställningar och aktivera den. Se [Konfigurera ERP-koppling][1].

## Nästa steg

* [Konfigurera fälttilldelning och listor][1]
* [Ange standardvärden][3]
* [Välj ordningen på ERP-fälten][4] som visas på ERP-fliken i SuperOffice CRM
* [Ange synkprioritet][5]
* [Importera data från ERP][6]

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
