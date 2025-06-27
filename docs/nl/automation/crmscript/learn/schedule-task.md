---
uid: help-nl-automation-schedule-task
title:  Geplande taken
description: Geplande taken
author: SuperOffice RnD
date: 06.29.2022
keywords: macro, script, schema
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
---

# Geplande taken

Op het tabblad **Geplande taken** kunt u aangeven of een script of macro op bepaalde momenten moet worden uitgevoerd.

> [!TIP]
> Plan tijdrovende taken op momenten waarop weinig mensen SuperOffice gebruiken.

Klik op een taak in de lijst om de eigenschappen ervan te bewerken, zoals de laatste uitvoering ervan, de duur van de uitvoering en de verzonden/ontvangen objecten.

## Een nieuwe geplande taak maken

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Klik op **CRMScript** en selecteer het tabblad **Geplande taken**.

1. Klik op **Nieuwe taak**.

1. Selecteer in de lijst **Frequentie** hoe vaak de taak moet worden uitgevoerd. U kunt **Uitvoeren na ander schema** gebruiken om een taak pas te laten starten nadat een andere taak is voltooid. U kunt deze optie gebruiken om taken aan elkaar te koppelen.

1. Klik op **OK**.

1. Vul de volgende velden in op het tabblad **Eigenschappen**:
    * **Naam**: Typ hier een naam voor de taak.
    * **ejScript/CRMScript**: Selecteer het te gebruiken script of de te gebruiken macro voor de taak.

1. Klik op **Toepassen** en ga naar het tabblad **Schema**.

1. Selecteer **Nu starten** om de taak uit te voeren zodra het systeem controleert op geplande taken (normaliter binnen 1 minuut).

1. Selecteer **Uitschakelen** als de taak voorlopig inactief moet blijven.

1. Bewerk het schema. De beschikbare velden zijn afhankelijk van de geselecteerde frequentie:

    * **Nooit**: De taak wordt niet uitgevoerd tenzij u **Nu starten** selecteert.
    * **Interval in minuten**: De taak wordt uitgevoerd met het geselecteerde interval (in minuten). Zorg ervoor dat het interval langer is dan de tijd die nodig is om de taak uit te voeren.
    * **Ieder uur**: De taak wordt ieder uur uitgevoerd, X minuten over het hele uur.
    * **Weekinterval**: De taak wordt wekelijks uitgevoerd. Voer het tijdstip in en de dag(en) waarop de taak moet worden uitgevoerd.
    * **Maandinterval**: De taak wordt maandelijks uitgevoerd. Voer het tijdstip in, de dag van de maand en de maand(en) waarin de taak moet worden uitgevoerd.
    * **Na**: De taak wordt uitgevoerd op de ingestelde datum en het ingestelde tijdstip.
    * **Uitvoeren na schema**: De taak wordt uitgevoerd wanneer de geselecteerde geplande taak is voltooid. U kunt deze optie gebruiken om taken aan elkaar te koppelen.

1. Stel **vergrendelingstijd in minuten in** om te voorkomen dat meerdere taken uit hetzelfde schema tegelijkertijd worden uitgevoerd. U moet deze waarde instellen op een hogere waarde dan de verwachte uitvoeringstijd van uw taak. Als uw taak meer tijd in beslag neemt dan hier is opgegeven, wordt deze taak beschouwd als mislukt en kan er een nieuwe taak uit hetzelfde schema worden uitgevoerd.

1. Stel **Aantal minuten opnieuw starten na fout** in. Deze instelling geeft aan hoeveel tijd er verstrijkt voordat een mislukte taak (een taak die is vastgelopen) opnieuw wordt uitgevoerd.

1. Klik op **OK**. De taak wordt toegevoegd aan de lijst en de status en het tijdstip van de volgende uitvoering van de taak zijn zichtbaar.

## Gerelateerde inhoud

* [Beste praktijken voor CRMScript][1]

<!-- Referenced links -->
[1]: ../../../../en/automation/crmscript/code-quality/best-practices.md
