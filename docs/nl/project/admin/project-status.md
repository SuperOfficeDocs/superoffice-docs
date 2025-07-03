---
uid: help-nl-project-status
title: Projectstatus
description: Leer hoe u een nieuwe projectstatus toevoegt in SuperOffice CRM. Maak en beheer vooraf gedefinieerde statussen om projectfasen te volgen en workflows efficiënt te stroomlijnen.
keywords: projectstatus toevoegen, projectstatus, lijst Project - Status, project
author: Bergfrid Dias
date: 03.14.2025
version: 10.5.2
content_type: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Instellingen en onderhoud
language: nl
redirect_from:
  - /nl/admin/lists/learn/project-status
  - /nl/project/learn/screen/project-status-admin
---

# Projectstatus

[!include[Moet beheerder zijn](../../learn/includes/req-admin.md)]

Het veld **Status** in de projectkaart helpt bij het categoriseren en volgen van de voortgang van een project. Deze statussen zijn vooraf gedefinieerd in de lijst **Project - Status**, die u kunt beheren in **Instellingen en onderhoud** onder **Lijsten**.

Statussen kunnen worden gekoppeld aan [projecttypen][1], zodat u bepaalt welke statussen beschikbaar zijn per projecttype. Als er geen projectgids is gedefinieerd, blijft het veld **Status** zichtbaar op het project, zodat gebruikers de huidige status kunnen bekijken en bijwerken.

## Een status toevoegen

1. Selecteer <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lijsten** in de navigator.

1. Selecteer **Project - Status** in het dropdownmenu. Het tabblad **Items** toont alle bestaande statussen.

1. Klik op **Toevoegen** om het dialoogvenster **Lijstitem bewerken** te openen.

1. Typ de naam van de nieuwe status in het veld **Naam**. *(Verplicht)*

    Deze naam verschijnt in het veld **Status** op de projectkaart.

1. *(Optioneel)* Voeg een beschrijving toe in het veld **Beschrijving** om het doel van de status toe te lichten.

1. Klik op **Opslaan** om de wijzigingen toe te passen of op **Annuleren** om deze te annuleren.

## Een status bewerken of verwijderen

1. Volg stap 1-2 in **Een status toevoegen** om de lijst **Project - Status** te openen.

1. Om te bewerken:
    1. Dubbelklik op de gewenste status om het dialoogvenster **Lijstitem bewerken** te openen.
    1. Werk de velden bij en klik op **Opslaan**.

1. Om te verwijderen:
    1. Selecteer de status in de lijst en klik op **Verwijderen**.

    > [!CAUTION]
    > Het verwijderen van een status verwijdert ook de koppeling met alle gekoppelde projecttypen en projectgidsen. Zorg ervoor dat de status niet actief wordt gebruikt voordat u verdergaat.

## Een verwijderde projectstatus herstellen

Als een projectstatus is verwijderd, kunt u deze herstellen vanuit de lijst **Project - Status**. Houd er rekening mee dat het herstellen niet automatisch de koppelingen met projecttypen of projectgidsen herstelt. U moet deze handmatig opnieuw instellen indien nodig.

De stappen zijn vergelijkbaar met het [herstellen van een verwijderd projecttype][2].

## Gerelateerde inhoud

* [Projecttypen toevoegen of bijwerken][1]
* [Een projectgids maken][3]
* [Een projectgids bewerken][4]
* [Projectstatus wijzigen][5]

<!-- Referenced links -->
[1]: project-type.md
[2]: project-type.md#restore
[3]: create-project-guide.md
[4]: edit-project-guide.md
[5]: ../learn/project-guides.md#change-status
