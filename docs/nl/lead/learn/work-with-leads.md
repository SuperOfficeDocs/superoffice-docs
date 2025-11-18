---
uid: help-nl-work-with-leads
title: Werken met leads in SuperOffice
description: Leer hoe u leads bekijkt, bijwerkt en opvolgt in SuperOffice CRM.
keywords: lead
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: howto
category: sale
topic: lead
license: salesessentials
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Werken met leads in SuperOffice

Leads zijn personen die interesse hebben getoond maar nog niet deelnemen aan een actief verkoopproces. SuperOffice helpt u te volgen in welk stadium van de kwalificatie elke lead zich bevindt en welke vervolgactie wanneer nodig is.

Deze pagina laat zien hoe u leadinformatie kunt bekijken, bijwerken en gebruiken in uw dagelijkse werk.

## Leadinformatie op een persoon bekijken

> [!NOTE]
> Het veld **Leadstatus** verschijnt alleen wanneer het bedrijf behoort tot een categorie in de groep **Potentiële klant** én **Leadstatus inschakelen** is geselecteerd.

1. Open een persoon.

1. Controleer het veld **Categorie** om te zien of de persoon tot een potentiële klantcategorie behoort.

1. Als leadstatus is ingeschakeld voor de bedrijfscategorie, verschijnt het veld **Leadstatus** direct onder het veld **Categorie**.

1. Beweeg de muis over de statuswaarde om de beschrijving te bekijken.

    ![Leadstatus weergegeven op het persoonscherm met een tooltip die de geselecteerde status beschrijft. -screenshot][img1]

## De leadstatus bijwerken

1. Klik op <i class="ph ph-pencil-simple" aria-label="Edit"></i> rechtsboven in de persoonskaart.

1. Selecteer de keuzelijst **Leadstatus**.

1. Kies de status die het huidige stadium van de lead het beste weergeeft.

    * **Contact opnemen:** U probeert de lead te bereiken.
    * **Gekwalificeerd:** De lead past goed en toont interesse.
    * **Gediskwalificeerd:** De lead is niet relevant.
    * **Opnieuw benaderen:** Later opnieuw opvolgen.

1. Klik **Opslaan** om uw wijzigingen op te slaan.

## Leads bekijken op het tabblad Contactpersonen

1. Ga naar een bedrijf en open het [**Contactpersonen**-tabblad][7].

1. Selecteer <i class="ph ph-gear" aria-label="Settings (cogwheel)"></i> om kolommen aan te passen.

1. Voeg **Categorie**, **Categoriegroep** en **Leadstatus** toe.

1. U kunt de lijst ook [filteren of groeperen][8] om u te richten op specifieke leadstadia.

    ![Categorie en Categoriegroep toevoegen aan het tabblad Contactpersonen. -screenshot][img2]

## Selecties maken

U kunt categorieën en leadstatus gebruiken om personen en bedrijven in SuperOffice CRM te zoeken en segmenteren.

In het **Zoeken**-scherm kunt u criteria toevoegen zoals:

* **Persoon** > **Leadstatus** – Is één van / Is niet één van.
* **Bedrijf** > **Categoriegroep** – Is één van / Is niet één van.
    Handig voor vragen als “Toon al mijn potentiële klanten” of “Toon al mijn klanten”.
* **Bedrijf** > **Lead** of **Persoon** > **Lead** gebaseerd op [UTM-gegevens][5] (vereist Marketing Premium).

![Contactpersonen filteren op Leadstatus en Categoriegroep in zoekcriteria. -screenshot][img3]

U kunt uw zoekresultaten opslaan als een **selectie**, die u later kunt gebruiken voor gerichte marketingactiviteiten of rapportages.

![Leadinfo bekijken in zoekresultaten, inclusief Categorie, Leadstatus en bron. -screenshot][img4]

Dynamische selecties van bedrijven of personen kunnen ook worden geopend in de [bordweergave][6] om leadvoortgang te visualiseren. Elke kolom vertegenwoordigt een leadstatus.

![Leads per status in de bordweergave, in kolommen zoals Open, Contact opnemen, Gediskwalificeerd, Opnieuw benaderen en Gekwalificeerd. -screenshot][img5]

## Tips en probleemoplossing

* **Ik zie het veld Leadstatus niet.**

    Het veld verschijnt alleen op personen en alleen als het bedrijf behoort tot **Potentiële klant**.

* **Ik kan Lead of Marketinggekwalificeerde lead niet als categorie kiezen.**

    Deze categorieën bestaan alleen in nieuwe databases.

* **Het veld Leadstatus is verdwenen nadat ik de bedrijfscategorie veranderde.**

    Leadstatus wordt verborgen wanneer het bedrijf wordt verplaatst naar een categorie buiten **Potentiële klant**. De waarde blijft in de database, is doorzoekbaar maar niet bewerkbaar.

* **Verschillende personen binnen hetzelfde bedrijf tonen verschillende leadstatussen.**

    Leadstatus wordt opgeslagen op persoonsniveau.

* **Een persoon krijgt altijd Leadstatus = Open wanneer deze wordt verplaatst naar een potentiële klantcategorie.**

    Dat is zoals verwacht: nieuwe leads starten altijd met *Open*.

* **Ik kan de categorie van een persoon niet wijzigen.**

    Personen erven de categorie van hun bedrijf. Om deze te wijzigen, werk je de categorie bij op het bedrijfsrecord.

## Gerelateerde inhoud

* [Overzicht leadbeheer][1]
* [Dashboards gebruiken om leads te monitoren][4]
* [Contactgegevens in bulk bijwerken][9]

<!-- Referenced links -->
[1]: index.md
[4]: ../../dashboard/learn/show-leads.md
[5]: ../../marketing/utm/learn/index.md
[6]: ../../search-options/selection/learn/board-view.md
[7]: ../../learn/section-tabs/contacts-tab.md
[8]: ../../learn/section-tabs/filter.md
[9]: ../../learn/basics/bulk-update.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/contact-card-open-lead.png
[img2]: ../../../media/loc/en/lead/contact-section-tab-with-lead-info.png
[img3]: ../../../media/loc/en/lead/find-leads.png
[img4]: ../../../media/loc/en/lead/save-leads-as-selection.png
[img5]: ../../../media/loc/en/lead/filtered-lead-board.png
