---
uid: help-nl-follow-up-edit
title: Vervolgactiviteiten bewerken
description: Openen, bewerken of verwijderen van een vervolgactiviteit; de eindtijd van een vervolgactiviteit in de agenda wijzigen; uitnodiging bewerken of verwijderen; herhalende vervolgactiviteit bewerken
keywords: vervolgactiviteit bewerken, afspraak bijwerken, vergadering verlengen, vergadering inkorten, alleen deze instantie wijzigen, vervolgactiviteit verwijderen, vergadering annuleren, agenda, vervolgactiviteit, afspraak, vergadering, taak, takenlijst, telefoongesprek, uitnodiging
author: Bergfrid Dias
date: 02.21.2025
version: 10.5.2
content_type: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Vervolgactiviteit bewerken

[!include[Note](includes/note-edit-followup.md)]

Als u een uitnodiging die u hebt aangemaakt en verzonden verwijdert of als u de tijd, datum of locatie van een vervolgactiviteit wijzigt, ontvangen de genodigden hierover een bericht.

## Stappen

1. Open een bestaande vervolgactiviteit door erop te dubbelklikken:

    * In het sectietabblad **Activiteiten** in het scherm Bedrijf, Persoon, Agenda, Project of Verkoop.
    * Of op de verschillende tabbladen in het scherm Agenda.

2. [Breng de gewenste wijzigingen aan in het dialoogvenster.][3]

    [!include[Recurrence](includes/note-repetition.md)]

3. Klik op **Opslaan**.

> [!NOTE]
> U kunt voltooide vervolgactiviteiten pas bewerken nadat u de status **Voltooid** hebt uitgeschakeld.

## <a id="change-end"></a>De eindtijd van een vervolgactiviteit in de agenda wijzigen

U kunt de eindtijd van een vervolgactiviteit in de agenda wijzigen zonder deze te openen:

1. Klik op de vervolgactiviteit in het tabblad **Dag**, **Week** of **Weergave**.

2. Plaats de muisaanwijzer op de onderkant van de vervolgactiviteit. De muisaanwijzer verandert in een dubbelpijl.

3. Klik en houd de muisknop ingedrukt terwijl u de onderrand omhoog of omlaag sleept om de duur van de vervolgactiviteit aan te passen. De bijgewerkte eindtijd wordt weergegeven terwijl u sleept.

4. Laat de muisknop los om de wijziging toe te passen.

> [!NOTE]
> U kunt de tijd ook wijzigen door de vervolgactiviteit te openen en de velden **Start**, **Einde**, **Vervaldatum** of **Duur** te bewerken.

## <a id="repeat"></a>Herhalende vervolgactiviteit bewerken

Wijzigingen werken op dezelfde manier als bij het bewerken van vervolgactiviteiten, maar wanneer u een wijziging aanbrengt, verschijnt het dialoogvenster **Herhalende vervolgactiviteit**.

![Dialoogvenster herhalende vervolgactiviteit -screenshot][img1]

* Als u **Alleen dit item wijzigen** selecteert, heeft de wijziging geen invloed op andere vervolgactiviteiten.

* Als u **Alle toekomstige items wijzigen inclusief dit item** selecteert, wordt de wijziging ook toegepast op alle toekomstige herhalingen van deze vervolgactiviteit.

U kunt alleen de startdatum van de vervolgactiviteit wijzigen terwijl u de herhalingsdetails bekijkt. Om de tijd te wijzigen, klikt u op **OK** of **Annuleren** om terug te keren naar de vervolgactiviteit.

Als u besluit de regel in het midden van een reeks vergaderingen te wijzigen, wordt een nieuwe regel aangemaakt en stopt de oude regel op het punt waar de wijziging plaatsvindt.

Als u de starttijd van een enkele vergadering wijzigt, heeft dit geen invloed op de regel. De vergadering wordt behandeld als een uitzondering op de regel. U kunt deze uitzondering opheffen door de vergadering weer in lijn te brengen met de andere vergaderingen.

[!include[Caution](includes/caution-do-not-change-recurring-date.md)]

## <a id="delete"></a>Vervolgactiviteit verwijderen via de agenda

* Als u een vervolgactiviteit verwijdert waarvoor u bent uitgenodigd, wordt deze alleen uit uw agenda verwijderd.
* Als u een uitnodiging verwijdert waarvan u de eigenaar bent, verdwijnt de vervolgactiviteit ook uit de agenda's van de genodigden.

1. Selecteer de gewenste vervolgactiviteit.
2. Klik met de rechtermuisknop en kies **Verwijderen**.
3. Kies **Ja** om de verwijdering te bevestigen of **Nee** om de vervolgactiviteit te behouden.

[!include[Deleting items](../../learn/includes/tip-deletion.md)]

## Verwante inhoud

* [De status Voltooid van een activiteit wijzigen][2]
* [Herhalende vervolgactiviteiten stoppen][5]
* [Link toevoegen naar document, verkoop, project of website][6]

<!-- Referenced links -->
[2]: change-completed-status.md
[3]: create-follow-up.md#fields
[5]: recurrence/stop.md
[6]: ../../learn/basics/links.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/diary/change-repeating-fo.png
