---
uid: help-nl-follow-up-edit
title: Vervolgactiviteiten bewerken
description: Vervolgactiviteiten openen, bewerken, verwijderen via de agenda; De eindtijd voor een vervolgactiviteit in de agenda wijzigen
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: agenda, vervolgactiviteit, uitnodiging, afspraak, taak, gesprek, herhalen, terugkeren, instantie
so.topic: howto
language: nl
---

# Vervolgactiviteit bewerken

[!include[Note](includes/note-edit-followup.md)]

Als u een uitnodiging die u hebt aangemaakt en verzonden, verwijdert of tijd, datum of locatie bewerkt, wordt er hierover een bericht gestuurd aan de genodigden.

## Stappen

1. Open de gewenste vervolgactiviteit door erop te dubbelklikken:

    * Op het sectietabblad **Activiteiten** in het scherm Bedrijf, Persoon, Verkoop, Project, Agenda.
    * Op de verschillende tabbladen in het scherm Agenda.

2. [Breng de gewenste wijzigingen aan in het dialoogvenster.][3]

    [!include[Recurrence](includes/note-repetition.md)]

3. Klik op **Opslaan**.

> [!NOTE]
> Voltooide vervolgactiviteiten kunt u pas bewerken als u de optie **Voltooid** hebt uitgeschakeld.

## <a id="change-end" />De eindtijd voor een vervolgactiviteit in de agenda wijzigen

U kunt als volgt de eindtijd voor een vervolgactiviteit wijzigen in het scherm Agenda zonder de activiteit te openen:

1. Klik op de vervolgactiviteit in het tabblad **Dag**, **Week** of **Weergave**.

2. Plaats de muisaanwijzer op de onderrand van de vervolgactiviteit. De muisaanwijzer verandert in twee pijlen.

3. Klik op het kader en houd de muisknop ingedrukt, terwijl u de blauwe lijn naar boven of beneden sleept om de tijdsspanne voor de vervolgactiviteit te verlagen of verhogen. U kunt de eindtijd voor de vervolgactiviteit in de top van de blauwe zone te zien.

4. Laat de muisknop los. De tijdspanne voor de vervolgactiviteit werd veranderd.

> [!NOTE]
> U kunt de tijd ook wijzigen door de vervolgactiviteit te openen en de velden **Start**, **Eind**, **Vervaldatum** of **Duur** te wijzigen.

## <a id="repeat" />Herhalende vervolgactiviteit bewerken

Wijzigingen worden op dezelfde manier doorgevoerd als in Vervolgactiviteiten bewerken, maar wanneer u een wijziging doorvoert, wordt het dialoogvenster **Herhalende vervolgactiviteiten** weergegeven.

![Repeating follow-up dialog -screenshot][img1]

* Als u **Alleen dit item wijzigen** selecteert, heeft de wijziging geen invloed op andere vervolgactiviteiten.

* Als u **Alle toekomstige items wijzigen inclusief dit item** selecteert, is de wijziging ook in de toekomst van toepassing op deze vervolgactiviteit.

U kunt alleen de startdatum van de vervolgactiviteit wijzigen terwijl je de herhalingsdetails bekijkt. Om de tijd te wijzigen, klik op **OK** of **Annuleren** om terug te keren naar de opvolgingsgegevens.

Als u besluit om het regel in het midden van een reeks vergaderingen te wijzigen, wordt er een nieuwe regel gecreëerd, en de oude regel wordt gestopt op het punt waar de onderbreking plaatsvindt.

Als u de starttijd van een enkele vergadering wijzigt, heeft dit geen invloed op de regel. De vergadering wordt beschouwd als een uitzondering op de regel. De uitzondering kan weer normaal worden gemaakt door deze in lijn te brengen met de andere vergaderingen.

[!include[Caution](includes/caution-do-not-change-recurring-date.md)]

## <a id="delete" />Vervolgactiviteit verwijderen via de agenda

* Als u een vervolgactiviteit verwijdert waarvoor u bent uitgenodigd, wordt deze slechts verwijderd uit uw eigen agenda.
* Als u een uitnodiging waarvan u de eigenaar bent verwijdert uit uw agenda, wordt deze vervolgactiviteit ook verwijderd uit de agenda's van de genodigden.

1. Selecteer de gewenste vervolgactiviteit.
2. Klik met de rechtermuisknop en kies **Verwijderen**.
3. Bevestig of annuleer de verwijdering in het bevestigingsdialoogvenster.

[!include[Deleting items](../../learn/includes/tip-deletion.md)]

## Verwante onderwerpen

* [De status Voltooid voor een activiteit wijzigen][2]
* [Herhalende vervolgactiviteiten stoppen][5]

<!-- Referenced links -->
[2]: change-completed-status.md
[3]: create-follow-up.md#fields
[5]: recurrence/stop.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/diary/change-repeating-fo.png
