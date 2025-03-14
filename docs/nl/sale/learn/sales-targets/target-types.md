---
uid: help-nl-sales-target-types
title: Een verkooptargettype met subtypen instellen
description: Bovenop uw verkooptargets zitten kan stressvol zijn. Maar als u parameters en dimensies van uw verkooptargets definieert, wordt het beheren van uw doelen veel eenvoudiger.
author: SuperOffice RnD
date: 02.16.2023
keywords: verkoop
topic: howto
language: nl
---

# Een verkooptargettype met subtypen instellen

Bovenop uw verkooptargets zitten kan stressvol zijn. Maar als u parameters en dimensies van uw verkooptargets definieert, wordt het beheren van uw doelen veel eenvoudiger.

U kunt nieuwe targettypen (dimensies) toevoegen in aanvulling op het standaardtargettype **Alle verkopen - Bedrag**.

> [!NOTE]
> U hebt een Sales Premium-licentie nodig samen met de licentie Unlimited sales targets om meer dan één gebruikersgroep en targettype toe te voegen. Als u alleen een Sales Premium-licentie hebt, kunt u één groep toevoegen voor het doeltype Alle verkopen - Bedrag.

U moet de functionele juiste targetbeheerder hebben voor uw rol om targettypen toe te voegen, bewerken en verwijderen.

## Targettype instellen

Om de parameters en dimensies te definiëren, moet u eerst een targettype instellen.

U kunt een targettype instellen voor zowel gebruikers als groepen naast andere targetparameters: Targettype, Meeteenheid, Afzonderlijke targets. U kunt ook definiëren of het alleen beschikbaar moet zijn op bedrijfs- en groepsniveau (en niet op gebruikersniveau).

![Overzicht van de verschillende targettypen en subtypen voor een verkooptype -screenshot][img1]

## Nieuw targettype toevoegen

1. Klik op **Nieuw targettype toevoegen**. Of klik op <i class="ph ph-gear" aria-label="Gear"></i> (**Target configureren**) op het tabblad om een bestaand targettype te bewerken.

2. Klik op **Targettype** om het targettype (dimensie) te selecteren dat u wilt gebruiken.

3. Klik op **Meeteenheid** om de relevante eenheid te selecteren. De beschikbare eenheden zijn afhankelijk van het geselecteerde targettype. Als u **Categorie** als targettype hebt geselecteerd kunt u er bijvoorbeeld voor kiezen om te meten op basis van bedrag of aantal (aantal verkopen in een categorie).

4. In de volgende lijst kunt u specifieke elementen van het geselecteerde doeltype selecteren. Als u er geen selecteert, wordt alles opgenomen. Bijvoorbeeld: Als u **Categorie** als targettype hebt geselecteerd, kunt u de bedrijfscategorieën selecteren waarvoor u targets wilt maken.

5. Selecteer **Alleen beschikbaar op bedrijfsniveau en groepsniveau** als dit targettype niet beschikbaar mag zijn op gebruikersniveau, alleen op groeps-/teamniveau en bedrijfsniveau.

6. Klik op **Opslaan**. Het nieuwe targettype wordt toegevoegd als een tabblad. U kunt nu targets toevoegen zoals hierboven beschreven.

> [!NOTE]
> Targettype en de meeteenheid niet kunnen worden gewijzigd in een bestaand targettype. U kunt ook een nieuw targettype maken met de vereiste instellingen en vervolgens het oude targettype verwijderen.

### Targettypen (parameters)

* Alle verkopen
* Verkooptype
* Verkoopbron
* Verkoop gecrediteerd
* Verkoopconcurrent
* Bedrijfscategorie
* Bedrijfsbranche
* Land van het bedrijf

U kunt ook targets instellen voor uw eigen door de gebruiker gedefinieerde velden die lijsten bevatten. Nadat een targettype is geselecteerd, is het niet mogelijk om dat targettype opnieuw te selecteren om te voorkomen dat er duplicaten worden gemaakt.

### Meeteenheid

U kunt een verkoop op verschillende manieren meten. Kies uw voorkeurseenheid, afhankelijk van welke eenheden uw bedrijf gebruikt.

* Bedrag
* Totaal
* Winst

### Afzonderlijke subtargets (dimensies)

De lijst met beschikbare zijn afhankelijk van het geselecteerde targettype. Bijvoorbeeld:

* Als het targettype is ingesteld op Verkooptype, staan in de targetsubtypen de lijst met verkooptypen die door uw bedrijf zijn gedefinieerd.
* Als het targettype is ingesteld op Bron, staan in de targetsubtypen de lijst met verkoopbronnen die door uw bedrijf zijn gedefinieerd.

Onderaan het dialoogvenster staat een selectievakje voor Alleen beschikbaar op bedrijfs- en groepsniveau. Wanneer u dit selectievakje inschakelt, wordt het targettype alleen toegevoegd op bedrijfs- en groepsniveau en verschijnen de verschillende gebruikers niet in uw targetlijst.

> [!NOTE]
> Wanneer u uw nieuwe target hebt opgeslagen, kunt u nog steeds naar Instellingen gaan en de lijst Afzonderlijke targets en het selectievakje voor Alleen beschikbaar op bedrijfs- en groepsniveau wijzigen. Houd er rekening mee dat als u Alleen beschikbaar op bedrijfs- en groepsniveau selecteert nadat u getallen op gebruikersniveau hebt toegevoegd, u een waarschuwing krijgt dat de getallen van de gebruiker worden verwijderd wanneer ze worden opgeslagen.

Wanneer het nieuwe targettype is opgeslagen, is het tijd om[groepen en gebruikers toe te voegen aan uw verkoopdoel][3].

![U vindt de knop Groepen en gebruikers toevoegen in het overzicht Verkooptargets -screenshot][img2]

## Targettypen filteren

Als het gaat om de targettypen met de lijst met targetsubtypen, kunt u op de knop Filteren klikken en op de verschillende lijstitems filteren.

![Klik op de filterknop om te filteren op targetsubtype -screenshot][img3]

## Targettypen verwijderen

Als u een targettype wilt verwijderen, klikt u op de targetinstellingen en klikt u op de knop Verwijderen. Houd er rekening mee dat het verwijderen van een targettype een niet-omkeerbare actie is en dat alle gegevens voor het targettype in eerdere, huidige en toekomstige jaren worden verwijderd. Het standaard targettype Alle verkopen - Bedrag kan niet worden verwijderd.

## Gerelateerde inhoud

* [Verkooptargets gebruiken op dashboardtegels][2]

<!-- Referenced links -->
[2]: ../../../dashboard/learn/show-sales-targets.md
[3]: create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/user-targets-new-target-type.png
[img2]: ../../../../media/loc/en/sale/user-targets-add-groups-users.png
[img3]: ../../../../media/loc/en/sale/user-targets-filter-type.png
