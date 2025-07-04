---
uid: help-nl-project-type
title: Projecttype
description: Leer hoe u een nieuw projecttype maakt in SuperOffice CRM. Definieer namen, stel geschatte duur in, koppel statussen en voeg optioneel projectgidsen toe voor een gestroomlijnd projectbeheer.
keywords: projecttype toevoegen, projecttype, lijst Project - Type status, project
author: Bergfrid Dias
date: 03.14.2025
version: 10.5.2
content_type: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Instellingen en onderhoud
language: nl
redirect_from:
  - /nl/admin/lists/learn/project-type
  - /nl/project/learn/screen/project-type-admin
---

# Projecttype

[!include[Moet beheerder zijn](../../learn/includes/req-admin.md)]

Het veld **Type** in de projectkaart categoriseert projecten en bepaalt hun workflows. Deze typen zijn vooraf gedefinieerd in de lijst **Project - Type, status**, die u kunt beheren in **Instellingen en onderhoud** onder **Lijsten**.

Elk project moet een type hebben, en deze typen kunnen worden gekoppeld aan specifieke [statussen][1] en optioneel aan [projectgidsen][4]. Projectgidsen helpen bij een gestroomlijnde uitvoering door gebruikers door vooraf gedefinieerde fasen, vervolgactiviteiten en documenten te leiden.

## Een projecttype toevoegen

1. Selecteer <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lijsten** in de navigator.

1. Selecteer **Project - Type, status** in het dropdownmenu. Het tabblad **Items** toont alle bestaande projecttypen.

1. Klik op **Toevoegen** om het dialoogvenster **Lijstitem bewerken** te openen.

    ![Dialoogvenster Lijstitem bewerken met velden voor projecttypeconfiguratie -screenshot][img1]

1. Voer een naam in voor het projecttype in het veld **Naam**. *(Verplicht)*

    Deze naam verschijnt in het veld **Type** op de projectkaart.

1. Geef de geschatte duur van het project op in het veld **Geschatte duur van dit projectproces** (aantal weken, dagen of maanden).

    Dit bepaalt de standaard einddatum bij het maken van een project (de datum van vandaag + geschatte tijdsduur).

1. Selecteer de benodigde statussen in de lijst **Statussen die worden gebruikt voor dit projecttype**.

    > [!NOTE]
    > Om het projecttype te koppelen aan een projectgids, moet u minimaal twee statussen selecteren.

1. *(Optioneel)* Schakel **Dit projecttype is gekoppeld aan een gids** in als u wilt dat projecten van dit type een projectgids volgen.

1. *(Optioneel)* Schakel **Voorstellen het project automatisch naar de volgende status te verplaatsen** in om gebruikers te vragen [naar de volgende status te gaan][5] zodra alle activiteiten in de huidige status zijn voltooid.

1. Voeg indien nodig een beschrijving toe in het veld **Beschrijving**.

1. Klik op **Opslaan** om de wijzigingen toe te passen of op **Annuleren** om deze te annuleren.

    Het projecttype wordt toegevoegd aan de lijst **Items**. Herhaal deze stappen om meer projecttypen toe te voegen.

## Een projecttype bewerken of verwijderen

1. Volg stap 1-2 hierboven om toegang te krijgen tot de lijst **Project - Type, status**.

1. Om te bewerken:
    * Dubbelklik op het gewenste projecttype om het dialoogvenster **Lijstitem bewerken** te openen.
    * Breng de benodigde wijzigingen aan en klik op **Opslaan**.

1. Om te verwijderen:
    * Selecteer het projecttype in de lijst en klik op **Verwijderen**.

    > [!CAUTION]
    > Het verwijderen van een projecttype verwijdert ook de koppeling met statussen en projectgidsen. Controleer of het type niet actief in gebruik is voordat u verdergaat.

## <a id="restore"></a>Een verwijderd projecttype herstellen

Als een projecttype is verwijderd, kunt u dit herstellen vanuit de lijst **Project - Type, status**. Houd er rekening mee dat het herstellen niet automatisch de koppelingen met projectstatussen of gidsen herstelt. U moet deze handmatig opnieuw instellen indien nodig.

1. Ga naar de lijst **Project - Type, status**.

1. Schakel **Verwijderde items en koppen tonen** in de voettekst in. Verwijderde items worden doorgestreept weergegeven op het tabblad **Items**.

1. Dubbelklik op het verwijderde item dat u wilt herstellen. Het dialoogvenster **Lijstitem bewerken** wordt geopend.

1. Klik op **Herstellen**.

1. Werk indien nodig velden bij en klik op **Opslaan**. Het item is nu actief en verschijnt in het tabblad **Items**.

## Gerelateerde inhoud

* [Een projectstatus toevoegen][1]
* [Een projectgids maken][2]
* [Een projectgids bewerken][3]

<!-- Referenced links -->
[1]: project-status.md
[2]: create-project-guide.md
[3]: edit-project-guide.md
[4]: ../learn/project-guides.md
[5]: ../learn/project-guides.md#change-status

<!-- Referenced images -->
[img1]: ../../../media/loc/en/project/edit-project-type.png
