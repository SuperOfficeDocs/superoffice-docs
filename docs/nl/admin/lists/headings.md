---
uid: help-nl-list-headings
title: Kopteksten
description: Gebruik kopteksten om items te groeperen in lange lijsten in Instellingen en onderhoud.
keywords: koptekst, lijst organiseren
author: digitaldiina
date: 10.29.2025
version: 10.5
content_type: reference
audience: settings
audience_tooltip: Instellingen en onderhoud
index: true
redirect_from:
  - /nl/admin/lists/learn/organize/index
  - /nl/admin/lists/learn/organize/headings
  - /nl/admin/lists/learn/organize/adding-headings
  - /nl/admin/lists/learn/organize/headings-editing-and-deleting
  - /nl/admin/lists/learn/organize/grouping-items-under-headings
language: nl
---

# Kopteksten

Lijstitems kunnen op twee niveaus worden weergegeven. Het bovenste niveau wordt de **koptekst** van het item genoemd. Een koptekst bevat groepen items die onder het geselecteerde item kunnen worden weergegeven in SuperOffice CRM. Dezelfde items kunnen onder meerdere kopteksten worden weergegeven.

De lijst **Kopteksten** (rechtsonder in het scherm **Lijsten**) toont onder welke kopteksten de afzonderlijke items worden weergegeven. U kunt ook naar het tabblad **Kopteksten** gaan om te zien welke items onder een specifieke koptekst worden getoond.

## Wanneer is het handig om kopteksten te gebruiken?

Als een lijst erg lang is (met veel items), kunt u kopteksten gebruiken om de items logisch te groeperen. In de lijst **Documentsjablonen** bijvoorbeeld worden de items gegroepeerd onder kopteksten zoals **Brief**, **Fax**, **E-mail**, enzovoort.

## Werken met kopteksten in lijsten

Om kopteksten te beheren, opent u het scherm **Lijsten** en selecteert u de gewenste lijst via het keuzemenu linksboven.

> [!NOTE]
> Kopteksten zijn alleen beschikbaar voor lijsten waarvoor de optie **Groeperen en filteren op gebruikersgroep gebruiken voor deze lijst** is ingeschakeld (selectievakje rechtsboven).
>
> De groeperingsfunctie is niet beschikbaar voor bepaalde vooraf gedefinieerde lijsten (zoals **Algemeen – Gebruikersgroep**). Als een lijst niet kan worden gegroepeerd, is het selectievakje uitgeschakeld.

Er zijn twee manieren om kopteksten toe te wijzen:

* **Via het tabblad Items**: Selecteer een lijstitem en wijs een of meer kopteksten toe via het paneel **Kopteksten**.
* **Via het tabblad Kopteksten**: Selecteer een koptekst en wijs één of meer items toe die eronder moeten worden weergegeven.

U kunt ook nieuwe kopteksten toevoegen, bestaande kopteksten bewerken of verwijderen.

## <a id="add"></a>Koptekst toevoegen

Voordat u een koptekst aan een item kunt koppelen, moet u de gewenste kopteksten toevoegen.

1. Ga naar het tabblad **Kopteksten**.

1. Klik onder de lijst **Kopteksten** op **Toevoegen** om een nieuwe koptekst aan te maken.

1. Voer in het dialoogvenster de naam van de koptekst in *(verplicht)* en eventueel een beschrijving *(optioneel)*.

    * Het veld **Beschrijving** kan worden gebruikt om het doel van de koptekst toe te lichten en verschijnt mogelijk als tooltip in de gebruikersinterface.

1. [!include[Save or cancel](includes/save-or-cancel.md)]

De koptekst wordt toegevoegd aan de lijst **Kopteksten**. Herhaal deze procedure om meer kopteksten toe te voegen.

Nadat u de benodigde kopteksten hebt toegevoegd, kunt u [selecteren onder welke kopteksten de afzonderlijke items worden weergegeven](#group).

## <a id="group"></a>Items groeperen onder kopteksten

Als u een lijst met twee niveaus wilt gebruiken, moet u voor elk item in de lijst **Items** kopteksten selecteren. U kunt ook naar het tabblad **Kopteksten** gaan en per koptekst de gekoppelde items instellen. Beide methoden worden hieronder beschreven.

> [!NOTE]
> De lijst moet een bepaald minimum aantal items bevatten om op deze manier weergegeven te worden. Dit minimumaantal is gedefinieerd in het scherm [Voorkeuren][3].

### Kopteksten toewijzen aan een lijstitem

Alle reeds gedefinieerde kopteksten voor de geselecteerde lijst worden weergegeven in de lijst **Kopteksten** rechtsonder. Als dit veld leeg is, moet u [eerst kopteksten toevoegen](#add).

1. Selecteer het gewenste item in de lijst **Items**.

1. Schakel het selectievakje naast de gewenste koptekst in de lijst **Kopteksten** in. Hiermee geeft u aan dat het geselecteerde lijstitem onder die koptekst wordt weergegeven. Het vak wordt gemarkeerd met een vinkje (<i class="ph ph-check" aria-hidden="true"></i>).

    De wijzigingen worden automatisch opgeslagen.

> [!TIP]
> U kunt meerdere kopteksten aan één item toewijzen.

### Lijstitems toewijzen aan een koptekst

1. Ga naar het tabblad **Kopteksten**.

1. Selecteer een koptekst in de lijst.

1. In de lijst **Items onder deze koptekst** klikt u op het selectievakje naast elk item dat onder deze koptekst zichtbaar moet zijn.

1. Herhaal stap 2 en 3 voor elke koptekst.
    De wijzigingen worden automatisch opgeslagen.

## <a id="update"></a>Kopteksten bewerken

Dubbelklik op de gewenste koptekst in de lijst **Kopteksten** en pas de informatie aan.

## Kopteksten verwijderen

Selecteer de gewenste koptekst in de lijst **Kopteksten** en klik op **Verwijderen**.

> [!NOTE]
> Het verwijderen van een koptekst verwijdert **niet** de gekoppelde lijstitems. U kunt [verwijderde kopteksten herstellen][2].

<!-- Verwijzingen -->
[2]: restore.md
[3]: ../preferences/index.md
