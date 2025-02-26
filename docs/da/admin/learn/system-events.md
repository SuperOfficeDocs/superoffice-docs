---
uid: help-da-system-events
title: Systemhændelser
description: Systemhændelser
author: SuperOffice RnD
date: 06.29.2022
keywords: arrangement
topic: concept
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Systemhændelser

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

[!include[Terminate events](includes/note-terminate-event.md)]

## Relateret indhold

* [Tilføjelse af systemhandlinger][1]

<!-- Referenced links -->
[1]: add-system-event.md
[2]: ../../../en/admin/license/index.md

<!-- Referenced images -->
