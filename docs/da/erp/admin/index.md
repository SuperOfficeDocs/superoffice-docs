---
uid: help-da-erp-admin
title: Administrer ERP-synkronisering
description: Introduktion til konfiguration af synkronisering mellem SuperOffice CRM og eksterne ERP-systemer.
keywords: ERP-fane, ERP-system, ERP-aktør, Sync Connector, ERP-link, synk, connector, forbindelse, link, Tilbud/Sync-skærmbillede, ERP
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: concept
license: development-tools
audience: settings
audience_tooltip: Indstillinger og vedligeholdelse
language: da
redirect_from: /da/quote/learn/admin/sync/index
index: true
---

# Administrer ERP-synkronisering

Fanen **Sync** i skærmbilledet Tilbud/Sync i Indstillinger og vedligeholdelse viser Sync Connectors og ERP-links, der muliggør integration mellem SuperOffice CRM og eksterne ERP-systemer.

[!include[Requirement](../../includes/req-dev-tools.md)]

## Terminologi

| Begreb | Beskrivelse |
|---|---|
| **Sync Connector** | Integrationskomponenten, der forbinder SuperOffice CRM med et eksternt ERP-system. Hver connector peger på et specifikt ERP-system. |
| **ERP-link** | En konfiguration, der bruger en Sync Connector til at definere, hvad der skal synkroniseres, hvordan autentificering foregår, og hvilken ERP-klient der skal tilgås. Der kan være flere links pr. connector. |
| **ERP-aktør** | En post i ERP-systemet, der kan knyttes til en entitet i SuperOffice CRM. |
| **CRM-entitet** | En post i SuperOffice CRM – typisk et firma, en person eller et projekt – der kan knyttes til en ERP-aktør. |

Du kan bruge fanen **Sync** til at tilføje, konfigurere og prioritere links.

## Hvad ERP-synkronisering muliggør

Når ERP-integrationen er korrekt konfigureret, får brugerne adgang til fanen **ERP** på skærmbillederne **Firma**, **Person** og **Projekt** i SuperOffice CRM.

Fra denne fane kan brugerne:

* Knytte SuperOffice-poster til matchende aktører i ERP-systemet.
* Se synkroniserede felter og værdier fra ERP.

Dette hjælper med at reducere dobbeltindtastning og forbedrer datakonsistensen på tværs af systemer.

> [!NOTE]
> Fanen **ERP** vises kun for brugere med den rette licens og adgang til et aktivt ERP-link.

## Relateret indhold

* [Tilføj en Sync Connector og definer et ERP-link][1]
* [Rediger et ERP-link][7]
* [Konfigurer felttilknytning og standardværdier][4]
* [Angiv synkroniseringsprioritet][3]
* [Importer fra ERP][9]

<!-- Referenced links -->
[1]: add-connection.md
[3]: configure.md#priority
[4]: configure.md
[7]: update-connection.md
[9]: ../../admin/import/from-erp.md
