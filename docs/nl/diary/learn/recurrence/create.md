---
uid: help-nl-recurrence-set
title: Plan herhalende vervolgactiviteit
description: Plan herhalende vervolgactiviteit
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: agenda, vervolgactiviteit, herhalen, terugkeren, plan, regelmatig, frequentie
so.topic: howto
language: nl
---

# Plan herhalende vervolgactiviteit

Het instellen van herhaling betekent het plannen van de startdatum van follow-ups in een serie.

[!include[Caution](../includes/caution-do-not-change-recurring-date.md)]

## Stappen

<!-- markdownlint-disable MD051 -->
### [Classic](#tab/fields-old)

1. [Open of maak een vervolgactiviteit][2].

2. Selecteer het tabblad **Details** en klik op het woord **Nooit** naast het veld **Herhalen**.

    Als je een herhalende vervolgactiviteit bijwerkt, klik dan op het eerder ingestelde patroon, bijvoorbeeld, **Maandelijks (23.09.2023 - 23.09.2024)**.

3. Onder **Frequentie** geeft u aan of de vervolgactiviteit dagelijks, wekelijks, maandelijks, jaarlijks of met een door de gebruiker gedefinieerd interval moet worden herhaald.

4. Selecteer vervolgens verdere details met [betrekking tot frequentie][4] in het midden van het dialoogvenster. De opties die hier beschikbaar zijn, zijn afhankelijk van wat u selecteert onder **Frequentie**:

    Als geen van de patronen voor jou werkt, kun je handmatig de datums invoeren die je nodig hebt.
    Selecteer **Aangepast**. Selecteer vervolgens een datum in de kalender en klik op de pijl ![icoon][img2] om het aan de lijst met geselecteerde datums toe te voegen. Herhaal om meer datums toe te voegen. Om een datum te verwijderen, selecteer je de datum in de lijst en klik je op **Verwijderen**.

5. In het veld **Herhalende vervolgactiviteiten eindigen** kunt u aangeven of de vervolgactiviteit na een bepaald aantal herhalingen of na een bepaalde datum moet stoppen.

6. U kunt desgewenst een of meer datums handmatig wijzigen in de lijst met geselecteerde datums, bijvoorbeeld als er een conflict is.

    * **Om een datum te verplaatsen,** selecteer de datum die u wilt verplaatsen en klik op **Later** als u de vervolgactiviteit een dag wilt uitstellen, of klik op **Vroeger** als u de vervolgactiviteit een dag naar voren wilt halen.

    * **Om een datum te toevoegen,** klik op de knop **Toevoegen** onder de lijst. Selecteer de gewenste datum en klik op de pijlknop ![pictogram][img2] rechts van de kalender om de datum aan de lijst toe te voegen. Gebruik de pijlknoppen aan weerszijden van de naam van de maand in de kalender om andere maanden weer te geven.

    * **Om een datum te verwijderen,** selecteer de datum die u wilt verwijderen en klik op de knop **Verwijderen** onder de lijst. De datum wordt uit de lijst met datums verwijderd.

7. Na het invoeren van datums voor de vervolgactiviteit, klikt u op **OK** om de datums op te slaan en het dialoogvenster te sluiten, of op **Annuleren** om het dialoogvenster te sluiten zonder de datums op te slaan.

    In de dialoogvenster geeft de tekst naast het veld **Herhalen** aan welk type herhaling u hebt opgegeven voor de vervolgactiviteit, bijvoorbeeld **Maandelijks (23.09.2016 - 23.09.2017)**.

8. Klik op **Opslaan** in het dialoogvenster **Afspraak** om uw wijzigingen op te slaan.

![Screenshot van het dialoogvenster Herhalende vervolgactiviteiten -screenshot][img6]

### [Nieuw (vanaf versie 10.2.11 pilot)](#tab/fields-new)

1. [Open of maak een vervolgactiviteit][2].

1. Klik op het herhaalsymbool ![symbool][img1] en kies een van de voorgestelde frequenties. Als geen van de patronen voor jou werkt, kies **Aangepast**.

    ![Vervolgactiviteitendialoog, voorgestelde herhaling -screenshot][img8]

    Als je het pictogram niet ziet, klik dan op **Meer tonen**.

1. Werk de startdatum indien nodig bij.

1. Kies een frequentie, bijvoorbeeld, herhaal elke 2 weken. Extra opties verschijnen als je *Week(en)*, *Maand(en)* of *Jaar(en)* selecteert.

    ![Vervolgactiviteitendialoog, herhaling -screenshot][img7]

1. Beslis of de vervolgactiviteit moet stoppen na een specifiek aantal keren of na een specifieke datum.

1. Optioneel, verfijn de lijst met geselecteerde data, bijvoorbeeld, als er een conflict is. Klik op een datum en gebruik dan de knoppen onder de lijst om die datum te verwijderen of te verplaatsen.

1. Klik op **OK** om de data op te slaan en terug te keren naar de details van de vervolgactiviteit.

1. Klik op **Opslaan** in het **Vervolgactiviteit**-venster om alle wijzigingen op te slaan.

***
<!-- markdownlint-restore -->

## Waarover zou u meer te weten willen komen?

* [Herhalende vervolgactiviteiten bewerken][1]
* [Herhalende vervolgactiviteiten stoppen][3]

<!-- Referenced links -->
[1]: ../edit-follow-up.md#repeat
[2]: ../create-follow-up.md
[3]: stop.md
[4]: index.md#frequency

<!-- Referenced images -->
[img1]: ../../../../../common/icons/refresh-icon.png
[img2]: ../../../../media/icons/arrow-right.png
[img6]: ../../../../media/loc/en/diary/recurrence-dialog.png
[img7]: ../../../../media/loc/en/diary/recurrence-selected-dates.png
[img8]: ../../../../media/loc/en/diary/suggested-pattern.png
