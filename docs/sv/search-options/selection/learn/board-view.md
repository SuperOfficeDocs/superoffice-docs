---
uid: help-sv-selection-board-view
title: Använd tavlevy i urval
description: Visualisera urval med tavlevy med gruppering, filter och dra-och-släpp-kort
keywords: tavlevy, urvalsvy,urval, säljtavla, kanban, gruppera efter, filterverktygsfält
author: Bergfrid Dias
date: 06.17.2025
version: 11.2
topic: howto
license: salespremium, servicepremium, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Använd tavlevy i urval <i class="ph ph-kanban" aria-hidden="true"></i>

Tavlevy visar ditt [urval][2] i ett kolumnbaserat layout med kort. Du kan gruppera och filtrera urvalsmedlemmarna (posterna som visas i tavlan), samt använda dra-och-släpp för att flytta kort mellan grupper.

Funktionen är densamma för alla stödda urvalstyper: Du kan dra kort, öppna uppgiftsmenyer och justera tavleinställningar. De tillgängliga grupperings- och filterfälten varierar beroende på om du arbetar med försäljning, projekt eller ärenden.

![Tavlevy som visar försäljningar grupperade efter fas -screenshot][img2]

Tavlevy är för närvarande tillgänglig för **urval av försäljning**, och stöd för **projekt** och **ärenden** är planerat.

## Öppna tavlevy

1. Gå till ett urval.
1. Klicka på ikonen för **tavlevy** i det övre högra hörnet (<i class="ph ph-kanban" aria-label="Kanban board"></i>).

    ![Växlingsikon för tavlevy i det övre högra hörnet i ett urval][img1]

## Arbeta med kort

* Klicka på korttiteln för att öppna hela posten (t.ex. ett försäljningskort).

* Håll muspekaren över ett namn eller företag för att förhandsgranska kontaktuppgifter.

    ![Förhandsvisning vid hover med kontaktuppgifter på ett kort -screenshot][img3]

* Dra kort mellan kolumner för att uppdatera grupperingsfältet (t.ex. fas eller ägare).
  * Om undergrupper är aktiverade kan du även dra kort mellan swimlanes.

* För att redigera ett kort, peka på det och välj knappen **Redigera** (<i class="ph ph-pencil" aria-hidden="true"></i>). Detta öppnar samma redigeringsdialog som används på andra ställen i SuperOffice CRM – utan att lämna tavlevyn.

  ![Markör pekar på redigeringsknappen på ett försäljningskort -screenshot][img4]

* För fler alternativ, peka på kortet för att visa **Uppgift**-menyn <i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>, klicka på den och välj en åtgärd.

  * **Försäljning:** Redigera, Skapa uppföljning, Markera som såld/förlorad, Ta bort
  * **Projekt:** Redigera, Skapa uppföljning, Skapa dokument, Markera som slutfört, Ta bort
  * **Ärenden:** Redigera, Stäng ärende, Ta bort

  ![Uppgiftsmeny i tavlevy för en försäljning med tillgängliga alternativ -screenshot][img5]

<!-- markdownlint-disable-next-line MD013 -->
## Anpassa tavlelayout <i class="ph ph-gear-six" aria-hidden="true"></i> <i class="ph ph-sliders-horizontal" aria-hidden="true"></i>

### Grupper och undergrupper

Så här väljer du vilka kolumner som ska visas:

1. Klicka på ikonen **inställningar** (<i class="ph ph-gear-six" aria-hidden="true"></i>).

1. Välj **Gruppera efter**.

    ![Inställningspanel för tavlevy för försäljningsurval med grupperingsalternativ -screenshot][img6]

1. Välj ett fält för att definiera kolumnlayouten.

    ![Gruppera-efter-menyn med tillgängliga försäljningsfält som Fas och Ägare -screenshot][img7]

1. Klicka på tillbakapilen (<i class="ph ph-caret-left" aria-hidden="true"></i>) för att återgå till översikten över inställningar.

1. Välj eventuellt ett värde för **Dela inn i undergrupp baseart på** för att lägga till swimlanes.

1. Välj eventuellt **Spara kolumner endast för markerat urval** för att tillämpa ändringarna endast i denna tavlevy.

1. Klicka på **Klar** för att tillämpa dina inställningar.

Exempel på grupperingsfält:

* **Försäljning:** Fas, Försäljningstyp, Ägare
* **Projekt:** Status, Ansvarig, Typ
* **Ärenden:** Status, Ärendetyp, Prioritet, Ägare

### Sortera kort i kolumner

Använd inställningspanelen (<i class="ph ph-gear-six" aria-hidden="true"></i>) för att konfigurera **Sortera efter** och **Sorteringsordning**, t.ex. efter försäljningsdatum.

### Ange filter

1. Klicka på <i class="ph ph-sliders-horizontal" aria-label="Toggle filter toolbar"></i> för att visa filterverktygsfältet.

    ![Filterverktygsfält i tavlevy för försäljningsurval -screenshot][img9]

1. Så här väljer du vilka filter som ska vara tillgängliga:

    1. Klicka på <i class="ph ph-gear-six" aria-hidden="true"></i> för att öppna inställningspanelen.
    1. Välj **Filterverktygsfält** och aktivera filter med kryssrutorna.
    1. Klicka på tillbakapilen (<i class="ph ph-caret-left" aria-hidden="true"></i>) och klicka sedan på **Klar**.

    ![Filterinställningar som visar tillgängliga försäljningsfält som Fas och Ägare -screenshot][img8]

1. I verktygsfältet, expandera ett filter (t.ex. **Ägare**) för att visa en lista.

    * Markera eller avmarkera objekt för att inkludera dem.
    * Klicka på **Radera** längst ned i rullgardinsmenyn för att återställa det filtret.
    * Klicka på **X** längst till höger i verktygsfältet för att återställa **alla** filter.

    ![Filterverktygsfält, försäljningstyp expanderad -screenshot][img10]

### Sammanfatta (endast försäljning)

Du kan visa summor för numeriska fält i tavlevy för försäljning.

1. Klicka på <i class="ph ph-gear-six" aria-hidden="true"></i> för att öppna inställningspanelen.
2. Välj **Sammanfatta baserat på**.
3. Välj ett numeriskt fält, t.ex. **Belopp** eller **Viktat belopp**.

Det totala värdet visas **bredvid varje kolumnnamn**, vilket hjälper dig att följa värdefördelningen över faser, ägare eller andra grupperingsfält.

![Tavlevy för försäljning med summerade belopp vid kolumnnamn -screenshot][img11]

## Användningsområden

Tavlevy stödjer olika roller och arbetsflöden. Här är exempel för säljare och försäljningschefer:

### Säljare

* **Visualisera dina öppna försäljningar** och spåra var varje affär är i pipelinen.
* **Dra ett kort till en annan kolumn** för att uppdatera fasen.
* **Filtrera efter försäljningsdatum** för att fokusera på det som är aktuellt nu.
* **Öppna uppgiftsmenyn** för att skapa händelse eller markera som såld/förlorad.
* **Snabbredigera ett kort** för att uppdatera detaljer, som en ny kontaktperson.

### Försäljningschefer

* **Visualisera hela pipelinen** och förstå hur försäljningen är fördelad över faser.
* **Sammanfatta belopp** för att stödja prognoser.
* **Filtrera efter försäljningstyp** för att fokusera på nyförsäljning eller specifika kampanjer.
* **Gruppera efter ägare** för att granska arbetsbelastning per säljare och balansera med dra-och-släpp.
* **Använd fas som grupp och försäljningstyp som undergrupp** för strategisk översikt.

Använd gruppering och swimlanes kreativt för effektiv datahantering.

## Felsökning och tips

* **Nya försäljningar saknas:** Klicka på <i class="ph ph-arrow-clockwise" aria-label="Refresh icon"></i> för att uppdatera tavlevyn med senaste data.

* **Filterverktygsfältet visas inte:** Växla det med ikonen <i class="ph ph-sliders-horizontal" aria-hidden="true"></i>.

* **En kolumn är tom:** Innehållet kan vara filtrerat bort. Kontrollera aktiva filter.

* **Hittar inte ett filterfält:** Gå till **Inställningar** (<i class="ph ph-gear-six" aria-hidden="true"></i>) > **Filterverktygsfält** och aktivera önskat fält.

* **Behöver du redigera själva urvalet (inte en post)?** Klicka på <i class="ph ph-subtract-square" aria-label="Selection icon"></i> för att återgå till urvalsvy. Redigering av urvalet är inte tillgänglig i tavlevyn.

* **Sök i tavlan efter namn:** Använd fältet **Filtrera efter titel** överst för att begränsa synliga kort.

* **Spara layout per användning:** Välj **Spara kolumner endast för markerat urval** om du vill behålla en specifik layout, filter eller gruppering för ett urval.

## Relaterat innehåll

* [Skapa ett urval][1]
* [Skapa en försäljning / fält i försäljningskortet][12]
* [Konfigurera försäljningsfaser][13]

<!-- Refererade länkar -->
[1]: create.md
[2]: selections.md
[12]: ../../../sale/learn/create.md
[13]: ../../../sale/admin/sale-stage.md

<!-- Refererade bilder -->
[img1]: ../../../../media/loc/en/search-options/board-view-toggle.png
[img2]: ../../../../media/loc/en/search-options/board-view.png
[img3]: ../../../../media/loc/en/search-options/board-view-preview-contact-on-hover.png
[img4]: ../../../../media/loc/en/search-options/board-view-card-edit-icon.png
[img5]: ../../../../media/loc/en/search-options/board-view-card-task-menu.png
[img6]: ../../../../media/loc/en/search-options/board-view-settings.png
[img7]: ../../../../media/loc/en/search-options/board-view-settings-group-by.png
[img8]: ../../../../media/loc/en/search-options/board-view-settings-filter.png
[img9]: ../../../../media/loc/en/search-options/board-view-filter-toolbar.png
[img10]: ../../../../media/loc/en/search-options/board-view-filter-on-sale-type.png
[img11]: ../../../../media/loc/en/search-options/board-view-summarized-sale-amount-per-column.png
