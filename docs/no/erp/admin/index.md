---
uid: help-no-erp-admin
title: Administrer ERP-synkronisering
description: Introduksjon til konfigurasjon av synkronisering mellom SuperOffice CRM og eksterne ERP-systemer.
keywords: ERP-fane, ERP-system, ERP-aktør, Sync Connector, ERP-kobling, synk, connector, kobling, Tilbud/Sync-bildet, ERP
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: concept
license: development-tools
audience: settings
audience_tooltip: Innstillinger og vedlikehold
language: no
redirect_from: /no/quote/learn/admin/sync/index
index: true
---

# Administrer ERP-synkronisering

Fanen **Sync** i Tilbud/Sync-bildet under **Innstillinger og vedlikehold** viser Sync Connectors og ERP-koblinger som muliggjør integrasjon mellom SuperOffice CRM og eksterne ERP-systemer.

[!include[Requirement](../../includes/req-dev-tools.md)]

## Terminologi

| Begrep | Beskrivelse |
|---|---|
| **Sync Connector** | Integrasjonskomponenten som kobler SuperOffice CRM til et eksternt ERP-system. Hver connector peker til ett spesifikt ERP-system. |
| **ERP-kobling** | En konfigurasjon som bruker en Sync Connector for å definere hva som skal synkroniseres, hvordan autentisering skjer, og hvilken ERP-klient som skal benyttes. Du kan ha flere koblinger per connector. |
| **ERP-aktør** | En post i ERP-systemet som kan knyttes til en enhet i SuperOffice CRM. |
| **CRM-enhet** | En post i SuperOffice CRM – vanligvis et firma, en person eller et prosjekt – som kan knyttes til en ERP-aktør. |

Bruk fanen **Sync** til å legge til, konfigurere og prioritere koblinger.

## Hva ERP-synkronisering gjør mulig

Når ERP-integrasjon er korrekt konfigurert, får brukere tilgang til **ERP**-fanen i skjermbildene **Firma**, **Person** og **Prosjekt** i SuperOffice CRM.

Fra denne fanen kan brukerne:

* Knytte SuperOffice-poster til tilsvarende aktører i ERP-systemet.
* Vise synkroniserte felt og verdier fra ERP.

Dette bidrar til å redusere dobbeltregistrering og gir bedre datakvalitet på tvers av systemer.

> [!NOTE]
> **ERP**-fanen vises bare for brukere som har riktig lisens og tilgang til en aktiv ERP-tilkobling.

## Relatert innhold

* [Legge til Sync Connector og definere en ERP-tilkobling][1]
* [Redigere en ERP-tilkobling][7]
* [Konfigurere felttilordning og standardverdier][4]
* [Angi synkroniseringsprioritet][3]
* [Importere fra ERP][9]

<!-- Referenced links -->
[1]: add-connection.md
[3]: configure.md#priority
[4]: configure.md
[7]: update-connection.md
[9]: ../../admin/import/from-erp.md
