---
uid: help-nl-saint-update
title: Activiteitsmonitoring bijwerken
description: Activiteitsmonitoring bijwerken
keywords: SAINT, activiteitsmonitoring, standaard vervolgactiviteit, statusmonitoring verwijderen, statusmonitoring herstellen, criteria
author: SuperOffice Product and Engineering
date: 09.22.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Instellingen en onderhoud
language: nl
index: true
redirect_from: 
  - /nl/sale/saint/learn/admin/edit-status
  - /nl/saint/admin/edit-status
  - /nl/sale/saint/learn/admin/select-default-follow-up-type-for-status
  - /nl/saint/admin/select-default-follow-up-type-for-status
  - /nl/sale/saint/learn/admin/restore-status
  - /nl/saint/admin/restore-status
  - /nl/sale/saint/learn/admin/select-status-criteria
  - /nl/saint/admin/select-status-criteria
---

# Activiteitsmonitoring bijwerken

[!include[Requirement](../includes/note-saint-req.md)]

## Open het SAINT-scherm

Voordat u een van de volgende taken uitvoert, opent u het scherm **SAINT** in Instellingen en onderhoud en selecteer het tabblad **Bedrijf**, **Persoon** of **Project**.

## Een statusbeschrijving bewerken

Op het tabblad **Beschrijving** wordt de beschrijving weergegeven die u hebt ingevoerd bij het [maken van de status][1].

1. Selecteer in de statuslijst de status waarvoor u de beschrijving wilt bewerken.

1. Bewerk de tekst in het tabblad **Beschrijving**.

## Een standaardtype vervolgactiviteit selecteren voor een status

U kunt een vervolgactiviteitstype koppelen aan een status. Wanneer een gebruiker in het midden van de statuskaart klikt, wordt automatisch een vervolgactiviteit geopend. Dit kan vooraf ingevulde tekst bevatten die uitlegt welke actie ondernomen moet worden voor bedrijven, contactpersonen of projecten met deze status.

Om een standaard vervolgactiviteitstype en beschrijving op te geven, gebruikt u het tabblad **Vervolgactiviteit maken**.

1. Selecteer de gewenste status in de statuslijst.
1. Ga naar het tabblad **Vervolgactiviteit maken**.
1. Selecteer een vervolgactiviteitstype uit de dropdown **Type**.
1. Voer het bericht in dat moet worden weergegeven in het vervolgactiviteitsdialoogvenster.

![Het tabblad 'Vervolgactiviteit maken' in de SAINT-statusmonitoring, dat de selectie van vervolgactiviteitstype en invoer van aangepast bericht toont. -screenshot][img1]

## <a id="criteria"></a>Criteria toevoegen aan een status

Elke status moet ten minste één criterium hebben. De [criteria][2] bepalen voor welke bedrijven, personen of projecten de status van toepassing is.

1. Selecteer in de statuslijst de gewenste status.

1. Selecteer onder de criterialijst **Toevoegen** om een nieuwe rij in te voegen.

1. Selecteer een criteriatype uit de dropdown.

    ![Criterialijst met meerdere gedefinieerde voorwaarden en de knop Toevoegen onder de lijst -screenshot][img3]

1. Stel de voorwaarde in (zoals **Voor**, **Na** of **Gelijk aan**) en voer een waarde in.

1. Herhaal om meer criteria toe te voegen.

    > [!NOTE]
    > U kunt slechts één van elk criteriatype toevoegen. U kunt bijvoorbeeld het criterium **Postcode** niet twee keer toevoegen.

1. Selecteer <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> **Geselecteerde statuscontrole opnieuw genereren** om de wijzigingen toe te passen.

## <a id="delete"></a>Een statusmonitoring verwijderen

U kunt een status verwijderen uit de statusmonitoringlijst. Verwijderde statussen kunnen later worden hersteld.

1. Selecteer in de statuslijst de status die u wilt verwijderen.
1. Klik onderaan de lijst op **Verwijderen**.

De verwijderde status wordt uit de actieve lijst verwijderd, maar kan opnieuw worden weergegeven door **Verwijderde items weergeven** te selecteren.

## <a id="restore"></a>Een verwijderde statusmonitoring herstellen

U kunt een eerder verwijderde status herstellen en regenereren.

1. Selecteer onderaan de statuslijst **Verwijderde items weergeven**.

1. Dubbelklik op de status die u wilt herstellen.

    ![Statusmonitoringdialoog geopend na selectie van een verwijderde status, met zichtbare knoppen Herstellen en Opslaan -screenshot][img2]

1. Selecteer in het dialoogvenster **Statusmonitoring** **Herstellen** en selecteer vervolgens **Opslaan**.

    De status wordt hersteld en wordt met zwarte tekst in de lijst weergegeven.

1. Selecteer **Geselecteerde statusmonitoring regenereren** om de herstelde status bij te werken.

## <a id="regen"></a>Statussen en tellers opnieuw genereren <i class="ph ph-arrow-circle-right" aria-hidden="true"></i>

Onderaan het tabblad **Statusmonitors** ziet u indicatoren met de datum van de meest recente update. Een rood kruis in de statuslijst betekent dat de status niet actief is totdat u deze opnieuw genereert. Als een item nog nooit is gegenereerd of de laatste generatie lang geleden is, kunnen de resultaten verouderd zijn.

Statussen en tellers die niet zijn bijgewerkt, blijven zichtbaar in SuperOffice CRM, maar de gegevens kunnen onjuist zijn. U moet opnieuw genereren wanneer criteria veranderen, een intentie voor een taak bewerkt zijn, of wanneer de indicatoren aangeven dat de gegevens niet actueel zijn.

### Statussen opnieuw genereren

| Naam | Beschrijving | Locatie |
|---|---|---|
| Geselecteerde statusmonitor opnieuw genereren | Werkt de geselecteerde status bij | Onderaan het tabblad **Bedrijf**, **Contact** of **Project** |
| Alle statusmonitors opnieuw genereren | Werkt alle statussen bij | Onderaan het tabblad **Statusmonitors** |

### Tellers opnieuw genereren

| Naam | Beschrijving |
|---|---|
| Alle tellers regenereren | Werkt alle tellers bij |

<!-- Referenced links -->
[1]: set-up.md
[2]: ../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/saint-create-follow-up-tab.png
[img2]: ../../../media/loc/en/saint/delete-restore-status-monitor.png
[img3]: ../../../media/loc/en/saint/criteria.png
