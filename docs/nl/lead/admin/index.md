---
uid: help-nl-lead-admin
title: Leadbeheer instellen
description: Leer hoe u leadbeheer in SuperOffice CRM activeert, configureert en uitbreidt.
keywords: leadbeheer, leadinstelling, leadstatus, potentiële klant, verkoopproces
author: digitaldiina
date: 12.11.2025
version: 11.6
content_type: concept
category: sale
topic: lead
license: salesessentials
audience: settings
audience_tooltip: Instellingen en onderhoud
index: true
language: nl
---

# Leadbeheer instellen

Leadbeheer in SuperOffice CRM helpt u potentiële klanten te volgen vanaf het eerste contact, via kwalificatie tot in het verkoopproces. Beheerders moeten configureren welke bedrijfscategorieën **Leadstatus** gebruiken, de beschikbare statuswaarden controleren en desgewenst de tracking uitbreiden met marketinggegevens.

> [!NOTE]
> De standaardcategorieën *Lead*, *Marketinggekwalificeerde lead*, *Kans* en *Verloren kans* zijn alleen opgenomen in nieuwe databases.
> Bestaande klanten moeten categorieën handmatig toevoegen of bijwerken om de leadstatus te activeren.

## Stap 1: Leadstatus inschakelen voor een bedrijfscategorie

Leadstatus kan alleen worden gebruikt voor categorieën die behoren tot de groep **Potentiële klant**. Zorg ervoor dat er ten minste één categorie op deze manier is ingesteld voordat u leadbeheer activeert.

1. Ga naar **Instellingen en onderhoud** > **Lijsten** > **Bedrijf – Categorie**.
1. Maak een nieuwe categorie of bewerk een bestaande.
1. Stel **Categoriegroep** in op *Potentiële klant*.
1. Selecteer **Leadstatus voor deze categorie inschakelen**.
1. Klik **OK** om de wijzigingen op te slaan.

![Leadstatus inschakelen voor een categorie in de Bedrijf – Categorie-lijst, met de geselecteerde groep Potentiële klant. -screenshot][img1]

Zie voor meer informatie [Bedrijfscategorie en categoriegroep][1].

## Stap 2: De lijst met leadstatussen aanpassen

De lijst **Persoon – Leadstatus** definieert de kwalificatiestadia die in uw organisatie worden gebruikt. Standaard bevat SuperOffice statussen zoals *Open*, *Contact opnemen*, *Gekwalificeerd*, *Gediskwalificeerd* en *Opnieuw benaderen*.

1. Ga naar **Instellingen en onderhoud** > **Lijsten** > **Persoon – Leadstatus**.
1. Controleer de vooraf gedefinieerde items.
1. Voeg statussen toe, bewerk of verwijder ze om uw eigen kwalificatieproces aan te passen.

Zie [Leadstatus beheren][2] voor gedetailleerde stappen.

## Stap 3: (Optioneel) Uitbreiden met Marketing Premium

Als u Marketing Premium gebruikt, kunt u extra tracking- en automatiseringsfuncties benutten in uw leadproces:

* **UTM-tracking:** Leg de bron van nieuwe leads vast via online formulieren.
  Zie [Formulier-UTM-gegevens volgen][3].
* **Lead-nurturingflow:** Verdeel nieuwe leads automatisch over gebruikers.
  Zie [Nieuwe leads verdelen][4].

## Gerelateerde inhoud

* [Overzicht van leadbeheer][5]
* [Bedrijfscategorie en categoriegroep][1]
* [Leadstatus beheren][2]

<!-- Referenced links -->
[1]: add-company-category.md
[2]: add-lead-status.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/enable-lead-status.png
[3]: ../learn/index.md
[5]: ../../marketing/utm/admin/set-up.md
[4]: ../../marketing/flows/learn/define-flow-actions.md#distribute
