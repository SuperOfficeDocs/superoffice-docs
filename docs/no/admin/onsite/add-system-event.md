---
uid: help-no-system-event-add
title: Legge til systemoperasjoner
description: Legge til systemoperasjoner
author: SuperOffice Product and Engineering
keywords: varsling, systemoperasjon, hendelse
author: SuperOffice Product and Engineering
date: 07.10.2025
version: 10.5
content_type: howto
deployment: onsite
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: 
  - /no/admin/learn/system-events
  - /no/admin/learn/add-system-events
language: no
---

# Legge til systemoperasjoner (Onsite)

Noen systemoperasjoner kan du sette i gang fra fanen **Systemmeldinger** på fanen **Status**.

1. Gå til Lisenser-bildet.

2. Velg fanen **Status**.

3. Klikk på **Legg til**-knappen under **Systemmeldinger**.

4. I dialogboksen **Legg til operasjon** velger du en [systemoperasjonstype](#types) fra listeboksen **Operasjonstype**.

5. I feltet **Avsluttes** angir du dato og klokkeslett når du forventer at operasjonen skal være ferdig.

    > [!NOTE]
    > Operasjonene avsluttes ikke automatisk. Du må slette dem manuelt fra fanen **Systemoperasjoner** for å avslutte dem.

6. I feltet **Beskrivelse** legger du inn mer detaljert informasjon om operasjonen.

    > [!NOTE]
    > Hvis du legger inn en operasjon av typen **Dagens melding** (melding til alle brukere), er det teksten fra feltet **Beskrivelse** som blir sendt ut til brukerne, sammen med forventet sluttid.

7. Klikk på **Lagre** for å opprette operasjonen. Den vises i listen **Systemmeldinger** på fanen **Status**.

> [!TIP]
> Du kan redigere en operasjon ved å dobbeltklikke på den i listen.
>
> Du kan slette en operasjon ved å merke den på listen og klikke på **Slett**-knappen.

## <a id="types"></a>Typer

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

<!-- Referenced links -->
[2]: ../../../en/admin/license/index.md

<!-- Referenced images -->
