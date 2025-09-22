---
uid: help-nl-sales-target-types
title: Een verkooptargettype met subtypen instellen
description: Bovenop uw verkooptargets zitten kan stressvol zijn. Maar als u parameters en dimensies van uw verkooptargets definieert, wordt het beheren van uw doelen veel eenvoudiger.
keywords: verkooptarget, dimensie
author: SuperOffice Product and Engineering
date: 09.19.2025
version: 10.5
content_type: howto
license: salespremium, Unlimited sales targets
functional_right: Targets administrator
deployment: online
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Een verkooptargettype met subtypen instellen

Bovenop uw verkooptargets zitten kan stressvol zijn. Maar als u parameters en dimensies van uw verkooptargets definieert, wordt het beheren van uw doelen veel eenvoudiger.

Standaard bevat SuperOffice één targettype: **Alle verkopen – Bedrag**. U kunt aangepaste targettypen toevoegen op basis van verkoopdata, bedrijfsgegevens of door gebruiker gedefinieerde velden.

## Vereisten

U moet het functionele recht **Targets administrator** hebben om targettypen toe te voegen, te bewerken of te verwijderen.

> [!NOTE]
> Om targettypen toe te voegen, hebt u de Unlimited sales targets-licentie nodig naast de Sales Premium-licentie.

## Beschikbare targettypen

Een **targettype** definieert wat u wilt meten. U kunt kiezen uit de volgende systeem-gedefinieerde dimensies:

* Alle verkopen
* Verkooptype
* Verkoopbron
* Verkoop gecrediteerd
* Verkoopconcurrent
* Bedrijfscategorie
* Bedrijfsbranche
* Land van het bedrijf

U kunt ook uw eigen door gebruiker gedefinieerde velden gebruiken, als ze lijstwaarden bevatten.

**Elke dimensie kan slechts één keer worden gebruikt om duplicaten te voorkomen.**

## Een nieuw targettype toevoegen

1. Klik <i class="ph ph-list" aria-label="Hoofdmenu"></i> en selecteer **Targets**.

1. In het **Targets**-scherm, klik **Nieuw targettype toevoegen** om een aangepaste verkoopdimensie te definiëren. U kunt ook op <i class="ph ph-gear" aria-label="Tandwiel"></i> (**Target configureren**) op een bestaand tabblad klikken om het te bewerken.

    ![Targets-scherm met knop Nieuw targettype toevoegen -screenshot][img4]

1. Klik **Targettype** om de dimensie te selecteren die u wilt volgen, zoals **Verkoopbron** of **Bedrijfscategorie**.

    ![Targetinstellingen-dialoog voor het maken van een nieuw targettype -screenshot][img1]

1. Klik **Meeteenheid** om te kiezen hoe resultaten worden berekend:

    * **Bedrag:** Totale waarde van verkopen
    * **Aantal:** Aantal verkopen
    * **Winst:** Winstmarge

    De opties zijn afhankelijk van het geselecteerde targettype.

1. Onder **Aparte targets**, kies specifieke subtypes om apart te volgen. De opties zijn afhankelijk van het geselecteerde targettype.

    Bijvoorbeeld, als het targettype **Categorie** is, zijn de subtypes uw bedrijfscategorieën.

1. Selecteer het selectievakje **Alleen beschikbaar op bedrijfs- en groepsniveau** als dit targettype niet beschikbaar moet zijn op gebruikersniveau.

1. Klik **Opslaan**. Het targettype wordt toegevoegd als een tabblad. U kunt nu [groepen en gebruikers toevoegen aan uw verkooptarget][3].

## Een targettype verwijderen

Om een targettype te verwijderen:

1. Open **Targetinstellingen** van het relevante tabblad.
2. Klik **Verwijderen**.

> [!WARNING]
> Het verwijderen van een targettype verwijdert permanent alle gerelateerde gegevens voor alle jaren - vorige, huidige en toekomstige. U kunt het standaardtype **Alle verkopen – Bedrag** niet verwijderen.

## Tips en probleemoplossing

* Na het opslaan kunnen het targettype en de meeteenheid niet worden gewijzigd. Om deze instellingen aan te passen, maak een nieuw targettype aan en verwijder het oude.

* U kunt de lijst **Aparte targets** en het selectievakje **Alleen beschikbaar op bedrijfs- en groepsniveau** na het opslaan bewerken.

    > [!NOTE]
    > Als u de beschikbaarheid alleen op bedrijfs-/groepsniveau inschakelt na het invoeren van waarden op gebruikersniveau, verschijnt er een waarschuwing. Het opslaan van deze wijziging zal de targets op gebruikersniveau verwijderen.

## Gerelateerde inhoud

* [Groepen en gebruikers toevoegen aan uw verkooptarget][3]
* [Verkooptargets gebruiken in dashboard-tegels][2]

<!-- Referenced links -->
[2]: ../../../dashboard/learn/show-sales-targets.md
[3]: create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/target-settings.png
[img4]: ../../../../media/loc/en/sale/add-new-target-type-button.png
