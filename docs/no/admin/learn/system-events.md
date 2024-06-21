---
uid: help-no-system-events
title: Systemoperasjoner
description: Systemoperasjoner
author: SuperOffice RnD
date: 06.29.2022
keywords: arrangement
topic: concept
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Systemoperasjoner

Følgende typer operasjoner startes fra de forskjellige bildene i Innstillinger og vedlikehold:

* **UDefRebuild**, som det finnes flere typer av: Utseendet for brukerdefinerte felt oppdateres, og de brukerdefinerte feltene får ikke tilgang mens hendelsen pågår.

    > [!NOTE]
    > Du må ikke avbryte denne hendelsen fra fanen **Systemmeldinger**.

* **FreetextRebuild**: fritekstindeksen genereres, og brukere kan ikke bruke friteksten mens genereringen pågår.

* **PrototypeRebuild**: En Travel-prototyp genereres. Travel-funksjonene er utilgjengelige mens operasjonen pågår.

    > [!NOTE]
    > I nødstilfeller kan du avbryte både **FreetextRebuild** og **PrototypeRebuild** fra listen **Systemmeldinger**.

* **ROURebuild**: Tellere eller statusovervåking regenereres. Statusbilder, fanen **Statistikk** og tellere er utilgjengelige mens operasjonen pågår. (Statusovervåking krever en [egen lisens][2].)

Du kan starte følgende hendelsestyper fra Lisenser-bildet på **Status**-fanen:

* **No Login**: Velg denne hendelsen for å hindre pålogging under server- eller databaseoppgraderinger, planlagt vedlikehold og lignende.
* **No Freetext**: Velg denne operasjonen for å begrense størrelsen på den utgående Travel-databasen.
* **No Travel**: Velg denne operasjonen for å deaktivere Travel. Dette kan være nyttig rett før store systemoppgraderinger, for å unngå synkroniseringsproblemer for returnerende Travel-brukere.
* **Dagens melding**: Velg denne hendelsen for å opprette viktige meldinger som vises til alle som logger på SuperOffice CRM (og etter noen minutter vises meldingen også til alle som allerede er pålogget).

[!include[Terminate events](includes/note-terminate-event.md)]

## Hva vil du gjøre nå?

* [Legge til systemoperasjoner][1]

<!-- Referenced links -->
[1]: add-system-event.md
[2]: ../../../en/admin/license/index.md

<!-- Referenced images -->
