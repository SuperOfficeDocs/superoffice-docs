---
uid: help-no-erp-update-connection
title: Rediger ERP-kobling
description: Lær hvordan du endrer navn, omfang eller konfigurasjon for en eksisterende ERP-kobling i SuperOffice CRM.
keywords: rediger ERP-kobling, oppdater ERP-innstillinger, endre ERP-kobling, sync connector, ERP-konfigurasjon, SuperOffice sync
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Innstillinger og vedlikehold
language: no
redirect_from: /no/quote/learn/admin/sync/sync-edit-erp-connection
index: true
---

# Rediger ERP-kobling

Du kan endre navn, omfang eller konfigurasjonsverdier for en eksisterende ERP-kobling.

> [!NOTE]
> Hvis koblingen er aktiv (avmerket i kolonnen **Aktiv**), må du midlertidig deaktivere den før du kan endre konfigurasjonsverdier. Husk å aktivere koblingen igjen etter at konfigurasjonen er fullført.

## Trinn

1. I **Innstillinger og vedlikehold**, velg <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Tilbud/Sync** i navigatoren og gå til fanen **Sync**.

1. Velg ERP-koblingen og klikk på **Konfigurer ERP-kobling**.

1. Oppdater navn eller omfang etter behov.

1. For å oppdatere connector-spesifikke konfigurasjonsfelt:

    1. Fjern merkingen i avmerkingsboksen **Aktiv**.
    1. Oppdater feltene etter behov.
    1. Merk av for **Aktiv**.
    1. Klikk på **Test ERP-tilkobling** og rett eventuelle feil.

1. Klikk på **OK** for å lagre og lukke dialogboksen.

1. Hvis du også må endre felttilknytninger, standardverdier eller listekoblinger, gjør det nå via knappene nederst til venstre. Se [Konfigurer ERP-kobling][1] for detaljerte instruksjoner.

## Feilsøking

### ERP-koblingen kan ikke lagres

Hvis **OK**-knappen er nedtonet når du legger til eller redigerer en kobling:

* Sørg for at forbindelsestesten var vellykket.
* Kontroller at alle obligatoriske konfigurasjonsfelt er fylt ut.
* Bekreft at nødvendige innstillinger (for eksempel synlighet) er angitt.

## Relatert innhold

* [Legg til en Sync Connector og ERP-kobling][2]
* [Knytt firmaer, personer og prosjekter til ERP-aktører][3]

<!-- Referenced links -->
[1]: configure.md
[2]: add-connection.md
[3]: ../learn/connect.md
