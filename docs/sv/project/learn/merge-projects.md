---
uid: help-sv-project-merge
title: Slå ihop projekt
description: Så här slår du ihop projekt i SuperOffice
author: SuperOffice RnD
so.date: 07.04.2022
keywords: projekt
so.topic: howto
language: sv
---

# Slå ihop projekt

Om du har två projekt som är nästan identiska är det nu möjligt att slå ihop dem och få med projektdeltagare och aktiviteter. Källprojektet kommer att tas bort.

1. Gå till det projekt du vill koppla in i ett annat projekt. Se [Använda fönstret Sök][1].

2. Klicka på ![ikon][img1] **Uppgift** på kortet **Projekt** och välj **Slå ihop projekt**.

3. I dialogrutan **Slå ihop projekt**, under **Till**, väljer du det projekt som du vill slå ihop med det aktuella projektet. Börja skriva i det här fältet för att söka efter ett projekt.

    ![Dialogrutan slå ihop projekt -screenshot][img2]

    > [!TIP]
    > För att byta plats på projekten under **Från** och **Till**, klicka på ![ikon][img3].

4. Markera alternativet **Skriv över tomma fält i \[target project\] med värden från \[source project\]** för att uppdatera tomma fält i målprojektet med detaljer från källprojektet.

    [!include[Preview results](../../learn/includes/note-preview-results.md)]

5. Klicka på **Slå ihop**. Följande sker:
    * Projekten slås ihop.
    * Detaljer slås ihop (om det anges).
    * Projektdeltagare flyttas eller slås ihop.
    * Eventuella tillhörande försäljningar flyttas.
    * Alla aktiviteter flyttas.
        Om du slår ihop ett projekt som är kopplat till en projektguide med ett projekt som har en annan projektguide eller inte har någon projektguide tas projektguiden bort från källprojektet. Alla händelser och dokument som har skapats flyttas dock över till det nya projektet och visas på detaljkortet **Aktiviteter**.
    * Eventuellt tidigare publicering av käll- och målprojektet inaktiveras.
    * Källprojektet tas bort.

## Relaterade ämnen

* [Redigera projekt][3]
* [Slå ihop företag][2]

<!-- Referenced links -->
[1]: ../../search-options/learn/find-screen.md
[2]: ../../company/learn/merge-companies.md
[3]: edit.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-menu.png
[img3]: ../../../../common/icons/info-ball.png
[img2]: ../../../media/loc/en/project/merge-project.png
