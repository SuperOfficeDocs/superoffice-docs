---
uid: help-nl-selection-create
title: Selectie maken
description: Werken met dynamische en statische selecties
keywords: selectie maken, nieuw selectie, opslaan als selectie, selectie
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: nl
redirect_from:
  - /nl/sale/saint/learn/using-status-monitors-in-dynamic-selections
  - /nl/search-options/selection/learn/create/copy
  - /nl/search-options/selection/learn/create/index
  - /nl/search-options/selection/learn/create/tutorial
---

# Selecties maken

U begint met een reeks criteria in het scherm **Zoeken** door een frequente zoekactie te gebruiken of uw eigen criteria toe te voegen. Van daaruit kunt u het resultaat opslaan als een dynamische of statische selectie. Het verschil tussen de twee is dat de eerste een selectie is die het aantal leden blijft bijwerken (dynamisch) terwijl de tweede een selectie is waarbij de leden worden bevroren met een momentopname van de huidige set leden (statisch).

## Stappen

1. Klik op **Nieuw** op de bovenste balk en selecteer **Selectie**.

1. Klik in het scherm Zoeken op de optie **Zoeken** die relevant is voor het type gegevens dat u wilt gebruiken in uw selectie. U kunt ook klikken op **Typische zoekopdrachten** om vooraf gedefinieerde zoekopdrachten te gebruiken.

1. [Uw zoekcriteria toevoegen][9] in het tabblad **Criteria**.

1. Klik op **Zoeken**. Op het tabblad **Resultaten** worden de gegevens weergegeven die overeenkomen met uw criteria.

1. Om de resultaten op te slaan in een selectie, klikt u op **Opslaan als selectie**. Als dit niet het geval is, verfijn dan uw zoekcriteria.

1. Kies in het dialoogvenster **Opslaan als selectie** de volgende opties:

    * **Dynamische selectie** - dit type selectie wordt altijd bijgewerkt wanneer leden worden toegevoegd die aan de selectiecriteria voldoen.
    * **Statische selectie** - dit type selectie bevat alleen de leden die u handmatig hebt toegevoegd.
    * **Toevoegen aan bestaande statische selectie:** Sla het resultaat op in een bestaande selectie. U kunt later handmatig leden aan de selectie toevoegen of verwijderen.

1. Klik op **Opslaan**.

1. Typ de naam van de nieuwe selectie op de plaats waar *Selectienaam* wordt weergegeven. Dit is een verplicht veld.

1. In het veld **Selectie is** kunt u desgewenst overstappen op een ander type selectie.

1. **Details kiezen:**

    * **Eigenaar:** In het veld wordt automatisch de naam weergegeven van de aangemelde gebruiker.

        Na opslaan van een nieuwe selectie, kunt u de eigenaar wijzigen door [de selectie te bewerken][6]. In de praktijk betekent dit dat u vanaf dat moment geen eigenaar meer bent van de selectie, maar iemand anders binnen het bedrijf.

    * **Categorie:** Kies het gewenste type selectie. Deze zijn gedefinieerd in Instellingen en onderhoud.

    * **Zichtbaar voor:** Geeft aan of de selectie voor iedereen zichtbaar moet zijn, privé is (alleen zichtbaar voor de persoon die is gedefinieerd als eigenaar) of zichtbaar is voor iedereen in de gebruikersgroep waarvan de eigenaar deel uitmaakt.

1. Voeg desgewenst een beschrijving van de selectie toe in het veld **Beschrijving**.

1. Als u klaar bent met het definiëren van de kerngegevens voor de selectie, klikt u op **Opslaan**.

## <a id="copy"></a>Een selectie kopiëren

Het selecteren van de taak **Selectie kopiëren** is een snelle en eenvoudige manier om een exacte kopie van een selectie te maken.

Wanneer u op deze knop klinkt, wordt een kopie van de selectie gemaakt met de tekst (kopie) naast de naam van de selectie. Met andere woorden, als u een kopie maakt van de selectie met de naam *Mijn statische selectie*, wordt de naam van de kopie *Mijn statische selectie (kopie)*.

1. [!include[Start](includes/steps-start-task.md)]

1. Klik op <i class="ph ph-dots-three-circle-vertical" aria-label="Taak"></i> en selecteer **de selectie kopiëren**. Dit zorgt ervoor dat de selectie gekopieerd wordt.

1. Geef de nieuwe selectie een nieuwe naam.

## Tips

* Als u probeert een selectie te registreren met de naam van een bestaande selectie, wordt het [dialoogvenster Duplicaten][8] geopend. Dit dialoogvenster werkt hetzelfde als bij bedrijven.
[]
* Klik op <i class="ph ph-star" aria-label="Star icon"></i> om de selectie aan [je favorieten][7] toe te voegen.

* Klik op <i class="ph ph-gear" aria-label="Gear"></i> rechts van de kolomkoppen. U kunt hier records groeperen en filteren en kolommen toevoegen/verwijderen. U kunt deze instellingen opslaan voor de actieve selectie door **Kolommen alleen opslaan voor huidige selectie** te selecteren.

* Schakel de optie **Voltooid** in om aan te geven dat de selectie inactief is. Als u de selectie actief wilt laten, schakelt u dit selectievakje niet in.

* Met **SAINT** ingeschakeld (vereist Sales-Premium of Service-Premium) kun je [statussen][14] gebruiken als criteria voor het maken van dynamische selecties. Dit geeft je een overzicht van bedrijven, personen of projecten die voldoen aan specifieke statuscriteria. De SAINT-criteria vind je onder **Tellers (SAINT)** in de [criterialijst][9] op het scherm **Zoeken**.

## Gerelateerde inhoud

* [Selecties combineren][3]
* [Selectie bijwerken][6]
* [Taken uitvoeren met selecties][5]

<!-- Referenced links -->
[3]: combine.md
[7]: ../../../learn/basics/fav.md
[8]: ../../../learn/basics/duplicates.md
[5]: howto/index.md
[6]: update.md
[9]: ../../learn/search-criteria.md
[14]: ../../../saint/learn/index.md
