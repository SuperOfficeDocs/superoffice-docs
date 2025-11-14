---
uid: help-nl-add-company-category
title: Bedrijfscategorie en categoriegroep
description: Maak of werk bedrijfscategorieën bij, wijs categoriegroepen toe en schakel leadstatus-tracking in.
keywords: bedrijfscategorie, categoriegroep, leadstatus, potentiële klant, lijsten
author: digitaldiina
date: 12.11.2025
version: 11.6
content_type: howto
category: sale
topic: lead
license: salesessentials
audience: settings
audience_tooltip: Instellingen en onderhoud
index: true
language: nl
---

# Bedrijfscategorie en categoriegroep

[!include[Moet beheerder zijn](../../learn/includes/req-admin.md)]

De lijst **Bedrijf – Categorie** definieert de types bedrijven in uw database, zoals *Klant*, *Partner* of *Lead*.
Elke categorie kan behoren tot een **Categoriegroep**, die bepaalt hoe deze zich gedraagt in zoekopdrachten, automatiseringen en lead-beheer.

U beheert bedrijfscategorieën onder **Instellingen en onderhoud** onder **Lijsten** > **Bedrijf – Categorie**.

## Over categoriegroepen

Categoriegroepen bieden een manier om categorieën in te delen naar doel en ongewenste automatiseringswijzigingen te voorkomen. Bijvoorbeeld: een bedrijf dat als *Klant* is gemarkeerd, mag nooit automatisch veranderen in een *Lead* door een formulier-invoer.

| Categoriegroep | Beschrijving |
|---|---|
| Klant | Gebruikt voor bestaande klanten, zoals *Klant A*, *Klant B* of *VIP-klant*. |
| Verloren | Gebruikt voor voormalige klanten of verloren kansen. |
| Partner | Gebruikt voor wederverkopers, integratoren of zakenpartners. |
| Potentiële klant | Gebruikt voor leads of prospects die nog geen klant zijn geworden. Alleen deze groep kan de **Lead-status** geactiveerd hebben. |
| Overig | Gebruikt voor elk ander type bedrijf. |

## Een bedrijfscategorie toevoegen

1. Selecteer <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lijsten** in de Navigator.

1. Kies uit het dropdownmenu **Bedrijf – Categorie**. Het tabblad **Items** toont alle bestaande categorieën.

1. Klik op **Toevoegen** om het dialoogvenster **Lijstitem bewerken** te openen.

1. Voer een naam in voor de categorie in het veld **Naam**. *(Verplicht)*

    Deze naam verschijnt in het veld **Categorie** op het bedrijfs­scherm.

1. Kies uit de keuzelijst **Categoriegroep** de juiste groep.

    De groep bepaalt hoe de categorie zich gedraagt in zoekopdrachten en automatiseringen, maar is niet zichtbaar voor eindgebruikers.

    * Om later lead-status te kunnen inschakelen, kiest u **Potentiële klant**.

1. *(Optioneel)* Voer een beschrijving in om te verduidelijken hoe de categorie gebruikt moet worden.

1. *(Optioneel)* Selecteer **Lead-status voor deze categorie inschakelen** indien van toepassing.

1. Klik **OK** om de nieuwe categorie op te slaan of **Annuleren** om uw wijzigingen te verwerpen.

![Bewerken van een bedrijfscategorie in de lijst Bedrijf – Categorie, waarbij de groep Potentiële klant is geselecteerd en de optie om leadstatus voor de categorie in te schakelen. -screenshot][img1]

## Bedrijfscategorieën bewerken of verwijderen

> [!NOTE]
> Het bewerken of verwijderen van categorieën die in gebruik zijn, kan leiden tot inconsistente data.
> Het wijzigen van een categoriegroep of het uitschakelen van lead-status kan bedrijven en contacten achterlaten met lead-informatie die niet langer bijgewerkt kan worden.
> Bekijk het gebruik van de categorie zorgvuldig voordat u wijzigingen aanbrengt.

1. Open de lijst **Bedrijf – Categorie**.

1. Om te bewerken:

    1. Dubbelklik een categorie om deze te openen.
    1. Werk **Naam**, **Categoriegroep** of de optie **Lead-status** bij.
    1. Klik **OK** om op te slaan.

1. Om te verwijderen:

    1. Selecteer de categorie in de lijst.
    1. Klik **Verwijderen**.

## Verwijderde bedrijfscategorieën herstellen

1. Open de lijst **Bedrijf – Categorie**.

1. Selecteer **Verwijderde items en koppen weergeven**.

1. Zoek de verwijderde categorie, dubbelklik erop en klik **Herstellen**.

1. Klik **OK**.

## Gerelateerde inhoud

* [Categorien voor potentiële klanten][2]
* [Lead-status voor bedrijfscategorieën inschakelen][1]
* [Lead-statussen beheren][3]
* [Gebruikersgroepfiltering][4]

<!-- Referenced links -->
[1]: index.md
[2]: ../learn/index.md
[3]: add-lead-status.md
[4]: ../../admin/lists/user-group-filtering.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/add-company-category.png
