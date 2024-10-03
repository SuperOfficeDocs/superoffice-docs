---
uid: help-no-screen-designer-grid
title: Arbeide med rutenett
description: Slik legger du til og fyller ut rutenett i et oppsett ved hjelp av Skjermdesigneren i Innstillinger og vedlikehold.
keywords: Skjermdesigner, layout, oppsett, rutenett, tabell
author: Bergfrid Dias
date: 10.07.2024
version: 10
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Arbeide med rutenett

[!include[Krav](../../../../../common/includes/req-dev-tools.md)]

Hvis du har mange felt, kan du bruke et rutenett for å plassere dem mer nøyaktig. Dette er et alternativ til å plassere basert på sorteringsrekkefølge og kolonner.

Instruksjonene nedenfor forutsetter at du allerede [redigerer layouten][1].

## Legg til et rutenett

1. Velg fanen du vil legge til et rutenett i.

1. Klikk for å velge seksjonen **Elementer**.

1. Klikk og dra **Rutenett**-elementet til layouten.

    ![Skjermdesigner rutenettelement -screenshot][img1]

1. Klikk for å velge det nye rutenettet.

1. Juster i seksjonen **Innstillinger** til venstre antall kolonner og rader etter behov.

    ![Skjermdesigner rutenettinnstillinger -screenshot][img2]

1. Velg en rutenettstil: linjer (standard), ingen eller overskrift.

## Legg til felt i rutenett

1. Gå til plasseringen av rutenettet.

1. Hold pekeren over rutenettet og klikk på den blå blyanten.

    ![Skjermdesigner rutenett redigeringsmodus -screenshot][img3]

    Dette setter rutenettet i redigeringsmodus, indikert med et grønt hake.

    ![Skjermdesigner rutenett i redigeringsmodus -screenshot][img4]

1. Sørg for at seksjonen **Felt** er valgt.

1. [Dra felt fra listen][2] til en celle i rutenettet. Du kan også legge til [etiketter][3], [koblinger og knapper][4].

    > [!TIP]
    > Bruk Tab for å flytte fra celle til celle for effektiv inntasting.

1. Når du er ferdig, klikker du på den grønne haken for å låse rutenettet og gå tilbake til normal redigeringsmodus.

## Rediger rutenettinnhold

1. Sett rutenettet i redigeringsmodus som beskrevet ovenfor.

1. For å flytte et felt, klikk på **=** til venstre for feltet og dra det til en ny celle.

    Hvis du slipper et felt i en opptatt celle, byttes innholdet i de to cellene.

1. For å fjerne et felt, hold pekeren over cellen og klikk på den røde sirkel x-en.

## Rediger rutenettets utseende

1. Velg fanen som inneholder rutenettet.

1. Klikk på rutenettet i forhåndsvisningen. Sørg for at rutenettet ikke er i redigeringsmodus. Klikk på den grønne haken hvis du ser den.

1. Juster dimensjonene og stilen til rutenettet i seksjonen **Innstillinger**.

> [!NOTE]
> Du kan ikke fjerne spesifikke rader eller kolonner, men du kan redusere antall rader og kolonner. Når du reduserer antallet rader, forsvinner den **siste raden** fra brukergrensesnittet sammen med innholdet. Når du reduserer antallet kolonner, forsvinner den **siste kolonnen**. Flytt feltene dine først for å unngå overraskelser.

## Flytt rutenett

For å flytte et rutenett, klikk på **=** til venstre for rutenettet og dra elementet til en ny posisjon. Dette ligner på å flytte felt.

## Fjern rutenett

Når du fjerner et rutenett, fjernes også innholdet (felt osv.). Denne handlingen påvirker bare det som vises i brukergrensesnittet og endrer ikke databasen eller verdiene på noen måte.

For å fjerne et rutenett:

* Hold pekeren over rutenettet og klikk på den røde sirkel x-en.

For å gjenopprette et rutenett:

* Hvis du arbeider med et utkast, kan du ganske enkelt forkaste utkastet for å angre alle endringene dine.
* Hvis du har publisert layouten etter fjerning, må du gjenskape rutenettet.

<!-- Referenced links -->
[1]: edit-layout.md
[2]: working-with-fields.md
[3]: working-with-tabs.md#label
[4]: add-button.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/ui/new-grid.png
[img2]: ../../../../media/loc/en/ui/grid-settings.png
[img3]: ../../../../media/loc/en/ui/hover-grid.png
[img4]: ../../../../media/loc/en/ui/edit-grid.png
