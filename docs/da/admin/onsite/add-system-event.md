---
uid: help-da-system-event-add
title: Tilføjelse af systemhændelser
description: Tilføjelse af systemhændelser
keywords: notifikation
author: SuperOffice Product and Engineering
date: 07.10.2025
version: 10.5
content_type: howto
deployment: onsite
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: 
  - /da/admin/learn/system-events
  - /da/admin/learn/add-system-events
language: da
---

# Tilføjelse af systemhændelser (onsite)

Du kan starte nogle systemhændelser på listen **Systemmeddelelser** under fanen **Status**.

1. Åbn skærmbilledet Licenser.

2. Vælg fanen **Status**.

3. Klik på knappen **Tilføj** under **Systemmeddelelser**.

4. I dialogboksen **Tilføj hændelse** vælger du en [systemhændelsestype](#types) på listen **Hændelsestype**.

5. Angiv den dato og det klokkeslæt, hvor du forventer, at hændelsen afsluttes, i felterne **Færdig**.

    > [!NOTE]
    > Hændelser afsluttes ikke automatisk. Du skal fjerne dem fra fanen **Systemhændelser** for at afslutte dem.

6. Angiv mere detaljerede oplysninger om hændelsen i feltet **Beskrivelse**.

    > [!NOTE]
    > Hvis du tilføjer en hændelse af typen **Dagens meddelelse** (meddelelse til alle brugere), er det teksten i feltet **Beskrivelse** der sendes til brugerne sammen med den forventede fuldførelsestid.

7. Klik på **Gem** for at oprette hændelsen. Den vises på listen **Systemmeddelelser** under fanen **Status**.

> [!TIP]
> Hvis du vil redigere en hændelse, skal du dobbeltklikke på den på listen.
>
> Hvis du vil slette en hændelse, skal du vælge den på listen og klikke på knappen **Slet**.

## <a id="types"></a>Typer

Følgende typer hændelser startes fra de forskellige skærmbilleder i Indstillinger og vedligeholdelse:

* **UDefRebuild**, som der er flere typer af: layoutet af brugerdefinerede felter opdateres, og de brugerdefinerede felter kan ikke tilgås, mens hændelsen er i gang.

    > [!NOTE]
    > Du må ikke annullere denne hændelse via listen **Systemmeddelelser**.

* **FreetextRebuild**: fritekstindekset genereres, og brugerne kan ikke bruge friteksten, mens genereringen er i gang.

* **PrototypeRebuild**: Der genereres en rejseprototype. Der er ikke adgang til rejsefunktionerne, mens denne hændelse er i gang.

    > [!NOTE]
    > I nødstilfælde kan du annullere både **FreetextRebuild** og **PrototypeRebuild** fra listen **Systemmeddelelser**.

* **ROURebuild**: Tællere eller statusovervågning regenereres. Statusbilleder, fanen **Statistik** og tællere er ikke tilgængelige, mens hændelsen er i gang. (Statusovervågning kræver en [separat licens][2].)

Du kan starte følgende hændelsestyper fra fanen **Status** på skærmbilledet Licenser:

* **Ingen logon**: Vælg denne hændelse for at forhindre logon under server- eller databaseopgraderinger, planlagt vedligeholdelse osv.
* **Ingen fritekst**: Vælg denne hændelse for at begrænse størrelsen på den udgående Travel-database.
* **Ingen Travel**: Vælg denne begivenhed for at deaktivere Travel. Dette kan være nyttigt lige før større systemopgraderinger for at undgå synkroniseringsproblemer for tilbagevendende Travel-brugere.
* **Dagens meddelelse**: Vælg denne hændelse for at oprette vigtige meddelelser, der vises til alle, der logger på SuperOffice CRM (og efter et par minutter vises meddelelsen også for alle, der allerede er logget på).

<!-- Referenced links -->
[2]: ../../../en/admin/license/index.md

<!-- Referenced images -->
