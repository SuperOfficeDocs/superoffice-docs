---
uid: help-sv-project-merge
title: Slå ihop projekt
description: Så här slår du ihop projekt i SuperOffice
keywords: slå ihop projekt, projekt, projektledning
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Slå ihop projekt

Om du har två nästan identiska projekt kan du slå ihop dem, inklusive projektdeltagare och aktiviteter. Källprojektet kommer att tas bort.

## Steg

1. Gå till det projekt du vill slå ihop med ett annat projekt. Se [Använda fönstret Sök][1].

1. Klicka på **Uppgift**-knappen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) i det övre högra hörnet av projektkortet och välj **Slå ihop projekt**.

    > [!NOTE]
    > Om alternativet **Slå ihop** är nedtonat har du inte tillräckliga användarrättigheter för att slå ihop projekt.

1. I dialogrutan **Slå ihop projekt**:

    * Under **Till**, välj det projekt som det aktuella projektet ska slås ihop med. Börja skriva i fältet för att söka efter ett projekt.
    * Om du vill byta plats på **Från**- och **Till**-projekten klickar du på pilknappen (<i class="ph ph-arrows-left-right" aria-hidden="true"></i>).

    > [!CAUTION]
    > Kontrollera noga att du har valt rätt projekt i fälten **Från** och **Till** innan du fortsätter. **Sammanfogningen kan inte ångras**.

1. (Valfritt) Markera **Skriv över tomma fält med data från [källprojekt]** för att uppdatera tomma fält i målprojektet med detaljer från källprojektet.

1. Klicka på **Slå ihop**. Följande händer:
    * Projektdeltagare flyttas eller slås ihop.
    * Alla aktiviteter flyttas.
    * Eventuella tillhörande försäljningar flyttas.
    * Detaljer slås ihop (om det anges).
    * Om du slår ihop ett projekt som är kopplat till en projektguide med ett projekt som har en annan eller ingen projektguide, tas projektguiden bort från källprojektet.
    * Källprojektet tas bort.

![Dialogrutan Slå ihop projekt -screenshot][img2]

## Relaterat innehåll

* [Redigera projekt][3]
* [Slå ihop företag][2]

<!-- Referenced links -->
[1]: ../../search-options/learn/find-screen.md
[2]: ../../company/learn/merge-companies.md
[3]: edit.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/project/merge-projects.png
