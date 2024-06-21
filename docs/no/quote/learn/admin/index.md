---
uid: help-no-quote-admin
title: Tilbud/Sync
description: "SuperOffice Quote hjelper deg med å opprette, validere og administrere tilbud og ordrer gjennom hele livssyklusen til en ordre."
author: SuperOffice RnD
date: 12.13.2023
keywords: tilbud, Sync, salg
topic: concept
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Tilbud/Sync

SuperOffice Quote hjelper deg med å opprette, validere og administrere tilbud og ordrer gjennom hele livssyklusen til en ordre. Det hjelper deg med å få nye eller oppdaterte tilbud til kundene dine raskere og fremskynder overgangen fra en potensiell kunde til et vunnet salg.

> [!NOTE]
> Denne funksjonen krever en brukerplan for Sales Premium og lisens for Developer Tools.

Hjelp kollegene dine med å sende tilbudene sine raskere og unngå unødvendige feil ved å bruke et automatisert tilbudssystem. Spar tid ved å konvertere tilbudet til en ordrebekreftelse med bare ett klikk på en knapp.

![Bildet Tilbud i Salg viser et tilbud for Jon Sørensen -screenshot][img1]

Det vil være veldig enkelt for deg og kollegene dine å velge produktene i et tilbud fra prislisten. Du kan sende forskjellige versjoner av tilbudet til kundene dine og automatisk registrere en oppfølgingsaktivitet. Det er også viktig å sette opp en god dokumentmal for tilbud, slik at kundene dine også får informasjon om produkter og priser som er lagt til i tilbudet.

## Bildet

I **Tilbud/Sync**-bildet kan du administrere koblinger og innstillinger for ERP-systemer som er koblet til SuperOffice CRM. Her kan du også jobbe med prislistene og produktene som ligger i SuperOffice-databasen.

* [ERP-koblinger][1] – Her kan du konfigurere og legge til Quote Connectors og ERP-koblinger.
* [SuperOffice-produkter][2] – Her kan du jobbe med prislistene og produktene som ligger i SuperOffice.
* [Innstillinger][3] – Her kan du tilpasse innstillingene for tilbud og konfigurere feltene som vises for produkter.
* [Sync][4] – Her kan du konfigurere og legge til Sync Connectors og tilhørende ERP-koblinger.

## Hva er Quote/Sync Connectors og ERP-koblinger?

* Hver Quote Connector eller Sync Connector er en DLL-fil/nettjeneste som håndterer kommunikasjonen mellom SuperOffice og et ERP-system.
* Quote Connectors brukes til å beregne tilbudspriser, og sende ordredetaljer til ERP-systemet når kunden takker ja til tilbudet.
* Sync Connectors brukes til å integrere SuperOffice og ERP-systemet, slik at firmaer i SuperOffice kan tilknyttes/synkroniseres med kunder og leverandører i ERP-systemet. Det samme gjelder for personer og prosjekter.
* En ERP-kobling består av en Quote Connector eller Sync Connector og konfigurasjonsinformasjon (for eksempel klientinformasjon (hvis ERP-systemet brukes av flere firmaer) og autentiseringsinformasjon for ERP-systemet).

## Hvordan konfigurerer jeg en ERP-tilkobling for SuperOffice CRM for Web (online)?

[!include[How to set up ERP](includes/set-up-erp.md)]

## Aktuelt innhold

* [Tilpasse prislister][5]
* [Konfigurere produktfelt][6]
* [Legge til produkt i prisliste][7]
* [Legg til et produktbilde][8]

<!-- Referenced links -->
[1]: quotesync-tab-erp-connections.md
[2]: product/index.md
[3]: product/configure.md
[4]: sync/index.md
[5]: product/add-price-list.md
[6]: product/configure.md
[7]: product/add-product-to-price-list.md
[8]: product/select-product-image.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/quote/quote-management.png
