---
uid: help-sv-erp-admin
title: Hantera ERP-synkronisering
description: Introduktion till att konfigurera synkronisering mellan SuperOffice CRM och externa ERP-system.
keywords: ERP-flik, ERP-system, ERP-aktör, Sync Connector, ERP-koppling, synk, connector, anslutning, Offert/Synk-fönstret, ERP
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: concept
license: development-tools
audience: settings
audience_tooltip: Inställningar och underhåll
language: sv
redirect_from: /sv/quote/learn/admin/sync/index
index: true
---

# Hantera ERP-synkronisering

Fliken **Synk** i fönstret Offert/Synk under **Inställningar och underhåll** visar Sync Connectors och ERP-kopplingar som möjliggör integration mellan SuperOffice CRM och externa ERP-system.

[!include[Requirement](../../includes/req-dev-tools.md)]

## Terminologi

| Term | Beskrivning |
|---|---|
| **Sync Connector** | Integrationskomponenten som kopplar SuperOffice CRM till ett externt ERP-system. Varje connector är kopplad till ett specifikt ERP-system. |
| **ERP-koppling** | En konfiguration som använder en Sync Connector för att definiera vad som ska synkroniseras, hur autentisering sker och vilken ERP-klient som ska användas. Du kan ha flera anslutningar per connector. |
| **ERP-aktör** | En post i ERP-systemet som kan kopplas till ett objekt i SuperOffice CRM. |
| **CRM-objekt** | En post i SuperOffice CRM – vanligtvis ett företag, en kontakt eller ett projekt – som kan kopplas till en ERP-aktör. |

Du kan använda fliken **Synk** för att lägga till, konfigurera och prioritera kopplingar.

## Vad ERP-synk möjliggör

När ERP-integrationen är korrekt konfigurerad får användare tillgång till fliken **ERP** i vyerna **Företag**, **Kontakt** och **Projekt** i SuperOffice CRM.

På denna flik kan användare:

* Knyta SuperOffice-poster till motsvarande aktörer i ERP-systemet.
* Visa synkroniserade fält och värden från ERP.

Detta bidrar till att minska dubbelregistrering och förbättrar datakvaliteten mellan systemen.

> [!NOTE]
> Fliken **ERP** visas endast för användare med korrekt licens och åtkomst till en aktiv ERP-koppling.

## Relaterat innehåll

* [Lägg till en Sync Connector och definiera en ERP-koppling][1]
* [Redigera en ERP-koppling][7]
* [Konfigurera fältkoppling och standardvärden][4]
* [Ange synkprioritet][3]
* [Importera från ERP][9]

<!-- Referenced links -->
[1]: add-connection.md
[3]: configure.md#priority
[4]: configure.md
[7]: update-connection.md
[9]: ../../admin/import/from-erp.md
