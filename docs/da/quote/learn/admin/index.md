---
uid: help-da-quote-admin
title: Synkronisering af tilbud
description: SuperOffice Quote hjælper dig med at oprette, validere og administrere tilbud og ordrer på tværs af hele ordrelivscyklussen.
author: SuperOffice RnD
date: 12.13.2023
keywords: tilbud, sync, salg
topic: concept
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Tilbud/Sync

SuperOffice Quote hjælper dig med at oprette, validere og administrere tilbud og ordrer på tværs af hele ordrelivscyklussen. Det hjælper dig med at få nye eller opdaterede tilbud til dine kunder hurtigere og fremskynde overgangen fra et kundeemne til en lukket aftale.

> [!NOTE]
> Denne funktion kræver en brugerplan for Sales Premium og Developer Tools-licens.

Hjælp dine kolleger med at sende deres forslag hurtigere og undgå unødvendige fejl ved hjælp af et automatiseret tilbudssystem. Spar tid ved at konvertere dit tilbud til en ordrebekræftelse med et enkelt klik på en knap.

![Skærmbilledet Tilbud i Salg, der viser et tilbud på John Smith -screenshot][img1]

Det vil være meget nemt for dig og dine kolleger at vælge produkterne til et forslag fra prislisten. Du kan sende forskellige versioner af dit forslag til dine kunder og automatisk registrere en opfølgningsaktivitet. Det er også vigtigt at oprette en god tilbudsdokumentskabelon, så dine kunder også får oplysninger om produkter og priser, der er tilføjet i dit tilbud.

## Skærmen

I skærmbilledet **Tilbud/Sync** kan du administrere links og indstillinger for ERP-systemer, som er linket til SuperOffice CRM. Her kan du også arbejde med prislisterne og produkterne, som ligger i SuperOffice-databasen.

* [ERP-links][1] – Her kan du konfigurere og tilføje Quote Connectors og ERP-links.
* [SuperOffice-produkter][2] – Her kan du arbejde med de prislister og produkter, som ligger i SuperOffice.
* [Indstillinger][3] – Her kan du tilpasse indstillingerne for tilbud og konfigurere de felter, der vises for produkter.
* [Sync][4] – Her kan du konfigurere og tilføje Sync Connectors og tilhørende ERP-links.

## Hvad er Quote/Sync Connectors og ERP-links?

* Hver Quote Connector eller Sync Connector er en DLL-fil/internettjeneste, som håndterer kommunikationen mellem SuperOffice og et ERP-system.
* Quote Connectors bruges til at beregne tilbudspriser og sende ordreinformation til ERP-systemet, når kunden takker ja til tilbuddet.
* Sync Connectors bruges til at integrere SuperOffice og ERP-systemet, så firmaer i SuperOffice kan tilknyttes/synkroniseres med kunder/leverandører i ERP-systemet. Det samme gælder for personer og projekter.
* Et ERP-link består af en Quote Connector eller Sync Connector og konfigurationsinformation (for eksempel klientinformation (hvis ERP-systemet bruges af flere firmaer) og autentiseringsinformation for ERP-systemet).

## Hvordan indstiller jeg en ERP-forbindelse til SuperOffice CRM til web (online)?

[!include[How to set up ERP](includes/set-up-erp.md)]

## Relateret indhold

* [Tilpas prislister][5]
* [Konfigurer produktfelter][6]
* [Tilføje produkter til en prisliste][7]
* [Tilføj produktbillede][8]

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
