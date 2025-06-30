---
uid: help-nl-saint-status-create
title: Nieuwe status maken
description: Nieuwe status maken
keywords: SAINT, statuscontroles
author: SuperOffice RnD
date: 02.22.2023
version: 9
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
---

# Een nieuwe status maken

[!include[Requirement](../includes/note-saint-req.md)]

## Het nut van een statuscontrole

U wilt bedrijven bewaken waar u heel weinig activiteiten mee hebt, om ontevreden klanten en verloop te voorkomen. Met deze statuscontrole heeft u op eenvoudige wijzen een overzicht van alle klanten die aandacht nodig hebben.

![Maak een statuscontrole door op de knop toevoegen op het scherm te klikken -screenshot][img1]

## Stappen

1. [!include[Open SAINT](includes/open-saint-select-tab.md)]

1. Klik op **Toevoegen** onder de lijst **Statuscontroles**.

1. Vul in het dialoogvenster deze velden in:

    * **Naam**: voer een beschrijvende naam in voor de status die u wilt toevoegen.

        Optioneel: Klik op <i class="ph ph-translate" aria-label="Translate"></i> om [vertalingen toe te voegen][8] van de statusnaam.

    * **Beschrijving**: voer een toelichting bij de status in en geef daarbij aan welke maatregelen vereist zijn of aanbevolen worden. U kunt in dit veld ook [sjabloonvariabelen][9] gebruiken om de tekst aan specifieke bedrijf, persoon of project aan te passen.

    De naam en beschrijving worden weergegeven in SuperOffice CRM wanneer de gebruiker de muisaanwijzer op de statusafbeelding houdt of de statusafbeelding voor het bedrijf opent. U kunt vervolgens de [beschrijving bewerken][2].

1. Klik op **Opslaan**. De status wordt weergegeven in de statuslijst.

1. Als er meerdere statussen in de lijst staan, moet u een prioriteit opgeven voor de nieuwe status. Klik op de status en gebruik de pijltoetsen rechts van de statuslijst om de status omhoog of omlaag te verplaatsen in de lijst.

### Waaruit bestaat de statuslijst?

* Het pictogram **Visualiseren** (<i class="ph ph-eye" aria-hidden="true"></i>) geeft aan of een [statusafbeelding][3] moet worden weergegeven voor bedrijven, personen of projectkaarten die aan de statuscriteria voldoen. Het pictogram wordt alleen weergegeven als u **Visualiseren** hebt aangevinkt op het tabblad **Afbeelding** voor de betreffende status.

* Een rood kruis geeft aan dat de status opnieuw moet worden gegenereerd. Telkens wanneer u een criterium toevoegt, bewerkt of verwijdert, of bijvoorbeeld een intentie voor een taak wijzigt, moet de [status opnieuw worden gegenereerd][4]. Statussen met rode kruizen worden niet bijgewerkt en leveren geen actuele gegevens op bij gebruik van SuperOffice CRM.

* **Naam** – de naam van de statussen. Verwijderde statussen worden in rood weergegeven als u **Verwijderde items weergeven** hebt ingeschakeld.

* **Prioriteit** – de prioriteit van de statussen. De prioriteit bepaalt welke status weergegeven wordt als een bedrijf, persoon of project aan de criteria voor meerdere statussen voldoet.

## Waarom moet ik een prioriteit voor een status opgeven?

Een bedrijf, persoon of project kan aan de criteria voor meerdere statussen voldoen, maar er kan slechts één statusafbeelding op de bedrijfskaart, het persoonskaart of de projectkaart in SuperOffice CRM worden weergegeven. Er moet dus een prioriteitsvolgorde worden opgegeven voor de weergave van statussen in SuperOffice CRM. Als een bedrijf, persoon of project niet voldoet aan de criteria voor de status met de hoogste prioriteit, wordt de status met de op een na hoogste prioriteit weergegeven. Als het bedrijf, de persoon of het project niet aan deze criteria voldoet, wordt de eerstvolgende status weergegeven, enzovoort.

Als een bedrijf, persoon of project meerdere actieve statussen heeft, worden de statussen met lagere prioriteit weergegeven als koppelingen in het dialoogvenster Status. Dit dialoogvenster wordt weergegeven wanneer de gebruiker op de statusafbeelding in SuperOffice CRM klikt of voor een bedrijf, persoon of project met een actieve status **Statusinformatie weergeven** in het menu **Bedrijf**, **Persoon** of **Project** selecteert.

## Gerelateerde inhoud

* [Een afbeelding selecteren voor een status][3]
* [Een standaardtype vervolgactiviteit selecteren voor een status][5]
* [Statuscriteria opgeven][6]
* [Een periodeduur opgeven][7]
* [Statuscontroles beheren][4]

<!-- Referenced links -->
[2]: edit-status.md
[3]: select-image-for-status.md
[4]: manage-status-monitors.md
[5]: select-default-follow-up-type-for-status.md
[6]: select-status-criteria.md
[7]: select-period-length.md
[8]: ../../globalization-and-localization/learn/translate-fields.md
[9]: ../../document/templates/variables/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/admin-saint-company.png
