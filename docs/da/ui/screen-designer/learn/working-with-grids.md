---
uid: help-da-screen-designer-grid
title: Arbejde med gittere
description: Sådan tilføjer og udfylder du gittere i et layout ved hjælp af Skærmdesigneren i Indstillinger og vedligeholdelse.
keywords: Skærmdesigner, layout, gitter
author: Bergfrid Dias
date: 10.07.2024
version: 10
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Arbejde med gittere

[!include[Krav](../../../../../common/includes/req-dev-tools.md)]

Hvis du har mange felter, kan du bruge et gitterelement til at placere dem mere præcist. Dette er et alternativ til positionering baseret på sorteringsrækkefølge og kolonner.

Instruktionerne nedenfor forudsætter, at du allerede [redigerer layoutet][1].

## Tilføj et gitter

1. Vælg den fane, du vil tilføje et gitter til.

1. Klik for at vælge afsnittet **Elementer**.

1. Klik og træk **Gitter**-elementet ind i layoutet.

    ![Skærmdesigner gitterelement -screenshot][img1]

1. Klik for at vælge det nye gitter.

1. Juster i afsnittet **Indstillinger** til venstre antallet af kolonner og rækker efter behov.

    ![Skærmdesigner gitterindstillinger -screenshot][img2]

1. Vælg en gitterstil: linjer (standard), ingen eller overskrift.

## Tilføj felt til gitter

1. Gå til gitterets placering.

1. Hold markøren over gitteret, og klik på den blå blyant.

    ![Skærmdesigner gitter i redigeringstilstand -screenshot][img3]

    Dette sætter gitteret i redigeringstilstand, hvilket angives af et grønt flueben.

    ![Skærmdesigner gitter i redigeringstilstand -screenshot][img4]

1. Sørg for, at afsnittet **Felter** er valgt.

1. [Træk felter fra listen][2] til en celle i gitteret. Du kan også tilføje [etiketter][3], [links og knapper][4].

    > [!TIP]
    > Tab fra celle til celle for effektiv indtastning.

1. Når du er færdig, skal du klikke på det grønne flueben for at låse gitteret og genoptage normal redigeringstilstand.

## Rediger gitterindhold

1. Sæt gitteret i redigeringstilstand som beskrevet ovenfor.

1. For at flytte et felt skal du klikke på **=** til venstre for feltet og trække det til en ny celle.

    Hvis du slipper et felt i en besat celle, byttes indholdet af de to celler.

1. For at fjerne et felt skal du holde markøren over cellen og klikke på den røde omkransede x-en.

## Rediger gitterets udseende

1. Vælg fanen, der indeholder gitteret.
1. Klik på gitteret i forhåndsvisningen. Sørg for, at gitteret ikke er i redigeringstilstand. Klik på det grønne flueben, hvis du ser det.
1. Juster gitterets dimensioner og stil i afsnittet **Indstillinger**.

> [!NOTE]
> Du kan ikke fjerne specifikke rækker eller kolonner, men du kan reducere antallet af rækker og kolonner. Når du mindsker antallet af rækker, forsvinder den **sidste række** fra brugergrænsefladen sammen med dens indhold. Når du mindsker antallet af kolonner, forsvinder den **sidste kolonne**. Flyt dine felter først for at undgå overraskelser.

## Flyt gitter

For at flytte et gitter skal du klikke på **=** til venstre for gitteret og trække feltet til en ny position. Dette ligner flytning af felter.

## Fjern gitter

Når du fjerner et gitter, fjernes også dets indhold (felter osv.).

Denne handling påvirker kun, hvad der vises i brugergrænsefladen, og ændrer ikke databasen eller værdierne på nogen måde.

For at fjerne et gitter:

* Hold markøren over gitteret, og klik på den røde omkransede x-en.

For at gendanne et gitter:

* Hvis du arbejder på et udkast, skal du blot kassere udkastet for at fortryde alle dine ændringer.
* Hvis du har udgivet layoutet efter fjernelsen, skal du oprette gitteret igen.

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
