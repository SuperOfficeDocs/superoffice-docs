---
uid: help-nl-sale-stage-add
title: Een verkoopfase toevoegen
description: Leer hoe u een nieuwe verkoopfase toevoegt in SuperOffice CRM. Maak en beheer vooraf gedefinieerde fasen om de voortgang van verkopen bij te houden en verkoopprocessen te stroomlijnen.
keywords: verkoopfase toevoegen, verkoopfase, fase, verkoop, lijst Verkoop - Fase
author: Bergfrid Dias
date: 03.14.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from:
  - /nl/admin/lists/learn/sale-stage
  - /nl/sale/learn/screen/sale-stage
index: true
---

# Een verkoopfase toevoegen

[!include[Must be admin](../../learn/includes/req-admin.md)]

Het veld **Fase** op de verkoopkaart helpt bij het categoriseren en volgen van de voortgang van een verkoop. Deze fasen worden vooraf gedefinieerd in de lijst **Verkoop - Fase**, die u kunt beheren in **Instellingen en onderhoud** onder **Lijsten**.

Fasen kunnen worden gekoppeld aan [verkooptypen][1], zodat u kunt bepalen welke fasen beschikbaar zijn voor elk type. Als er geen verkoopgids is gedefinieerd, blijft het veld **Fase** zichtbaar op de verkoopkaart, zodat gebruikers de huidige status van de verkoop kunnen bekijken en bijwerken.

## Een verkoopfase toevoegen

1. Selecteer <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lijsten** in de navigator.

1. Selecteer **Verkoop - Fase** in het dropdownmenu. Het tabblad **Items** toont alle bestaande fasen.

1. Klik op **Toevoegen** om het dialoogvenster **Lijstitem bewerken** te openen.

1. Voer in het veld **Naam** de naam van de nieuwe fase in. *(Verplicht)*

    Deze naam wordt weergegeven in het veld **Fase** op de verkoopkaart.

1. Voer in het veld **Kans** het percentage in dat de waarschijnlijkheid van een succesvolle verkoop in deze fase aangeeft.

    Dit percentage wordt weergegeven naast de fase in het scherm Verkoop.

1. *(Optioneel)* Voeg een beschrijving toe in het veld **Beschrijving** om het doel van de fase te verduidelijken.

1. Klik op **Opslaan** om de wijzigingen toe te passen of **Annuleren** om ze te negeren.

## Een verkoopfase bewerken of verwijderen

1. Volg stap 1–2 in **Een verkoopfase toevoegen** om toegang te krijgen tot de lijst **Verkoop - Fase**.

1. Om te bewerken:
    1. Dubbelklik op de gewenste fase om het dialoogvenster **Lijstitem bewerken** te openen.
    1. Werk de velden bij en klik op **Opslaan**.

1. Om te verwijderen:
    1. Selecteer de fase in de lijst en klik op **Verwijderen**.

    > [!CAUTION]
    > Het verwijderen van een fase verwijdert deze uit alle gekoppelde verkooptypen en verkoopgidsen. Zorg ervoor dat de fase niet in gebruik is voordat u doorgaat.

## Een verwijderde verkoopfase herstellen

Als een verkoopfase is verwijderd, kunt u deze herstellen via de lijst **Verkoop - Fase**. Houd er echter rekening mee dat herstellen niet automatisch de koppelingen met verkooptypen of verkoopgidsen herstelt. U moet deze handmatig opnieuw instellen indien nodig.

De stappen hiervoor zijn vergelijkbaar met [het herstellen van een verwijderd verkooptype][2].

## Gerelateerde inhoud

* [Verkooptypen toevoegen of bijwerken][1]
* [Een verkoopgids maken][3]
* [Een verkoopgids bewerken][4]
* [De voortgang van verkopen bijhouden][5]

<!-- Referenced links -->
[1]: sale-type.md
[2]: sale-type.md#restore
[3]: create-sales-guide.md
[4]: edit-sales-guide.md
[5]: ../learn/sales-guides.md#change-stage
