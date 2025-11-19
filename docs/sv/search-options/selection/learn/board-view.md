---
uid: help-sv-selection-board-view
title: Använd tavlevy i urval
description: Visualisera urval med tavlevy med gruppering, filter och dra-och-släpp-kort
keywords: tavlevy, urvalsvy,urval, säljtavla, projekttavla, ärendetavla, kanban, gruppera efter, filterverktygsfält, försäljningsdatum märke, dagar i fas, dagar sedan registrerad
author: digitaldiina
date: 12.02.2025
version: 11.7
content_type: howto
license: salespremium, servicepremium, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Använd tavlevy i urval <i class="ph ph-kanban" aria-hidden="true"></i>

Tavlevy visar ditt [urval][2] i ett kolumnbaserat layout med kort. Du kan gruppera och filtrera urvalsmedlemmarna (posterna som visas i tavlan), samt använda dra-och-släpp för att flytta kort mellan grupper.

Funktionen är densamma för alla stödda urvalstyper: Du kan dra kort, öppna uppgiftsmenyer och justera tavleinställningar. De tillgängliga grupperings- och filterfälten varierar beroende på om du arbetar med företag, kontakt, försäljning, projekt eller ärenden.

![Tavlevy som visar försäljningar grupperade efter fas -screenshot][img2]

## Öppna tavlevy

1. Gå till ett urval.

1. Klicka på ikonen för **tavlevy** i det övre högra hörnet (<i class="ph ph-kanban" aria-label="Kanban board"></i>).

    ![Växlingsikon för tavlevy i det övre högra hörnet i ett urval][img1]

1. Om ditt urval innehåller företag och kontakter visar tavlevyn endast en enhetstyp åt gången. För att växla klickar du på <i class="ph ph-gear-six" aria-label="Settings"></i> och använder sedan rullgardinsmenyn **Visa enhet** för att välja *Företag* eller *Kontakt*.

## Arbeta med kort

* Klicka på korttiteln för att öppna hela posten (t.ex. ett försäljningskort).

* Håll muspekaren över ett namn eller företag för att förhandsgranska kontaktuppgifter.

    ![Förhandsvisning vid hover med kontaktuppgifter på ett kort -screenshot][img3]

* Dra kort mellan kolumner för att uppdatera grupperingsfältet (t.ex. fas eller ägare).
  * Om undergrupper är aktiverade kan du även dra kort mellan rader i varje kolumn.

* Klicka på ett kort för att visa dess detaljer i [sidopanelen][11]. (Aktivera förhandsgranskningen genom att välja den i listrutan högst upp på sidopanelen).

    ![Sidopanel som visar projektdetaljer -screenshot][img12]

* För att redigera ett kort, peka på det och välj knappen **Redigera** (<i class="ph ph-pencil" aria-hidden="true"></i>). Detta öppnar samma redigeringsdialog som används på andra ställen i SuperOffice CRM – utan att lämna tavlevyn.

  ![Markör pekar på redigeringsknappen på ett försäljningskort -screenshot][img4]

* För fler alternativ, peka på kortet för att visa **Uppgift**-menyn <i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>, klicka på den och välj en åtgärd.

  * **Försäljning:** Redigera, Skapa händelse, Markera som såld/förlorad, Ta bort
  * **Projekt:** Redigera, Skapa händelse, Skapa dokument, Markera som slutfört, Ta bort
  * **Ärenden:** Redigera, Stäng ärende, Ta bort
  * **Företag:** Redigera, Skapa händelse, Registrera försäljning, Gå till nästa kategori, Ta bort
  * **Kontakt:** Redigera, Skapa händelse, Registrera försäljning, Ta bort

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

1. Välj eventuellt ett värde för **Dela inn i undergrupp baseart på** för att visa kort i separata rader i varje kolumn.

1. Välj eventuellt **Spara kolumner endast för markerat urval** för att tillämpa ändringarna endast i denna tavlevy.

1. Klicka på **Klar** för att tillämpa dina inställningar.

Exempel på grupperingsfält:

* **Försäljning:** Fas, Försäljningstyp, Ägare
* **Projekt:** Status, Ansvarig, Typ
* **Ärenden:** Status, Ärendetyp, Prioritet, Ägare
* **Företag:** Kategori, Vår kontakt
* **Kontakt:** Kategori, Vår kontakt, Lead-status

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

Exempel på filter:

* **Försäljning:** Försäljningstyp, Ägare, Fas, Nästa aktivitet, Försäljningsdatum
* **Projekt:** Typ, Ansvarig, Status, Nästa milstolpe, Slutdatum
* **Ärenden:** Ärendekategori, Ägare, Status, Registrerad, Tidsfrist, Prioritet
* **Företag:** Vår kontakt, Registreringsdatum, Nästa aktivitet, Kategori, Land
* **Kontakt:** Vår kontakt, Ägargrupp, Registreringsdatum, Nästa aktivitet, Lead-status, Kategori, Land

### Sammanfatta (endast försäljning)

Du kan visa summor för numeriska fält i tavlevy för försäljning.

1. Klicka på <i class="ph ph-gear-six" aria-hidden="true"></i> för att öppna inställningspanelen.
2. Välj **Sammanfatta baserat på**.
3. Välj ett numeriskt fält, t.ex. **Belopp** eller **Viktat belopp**.

Det totala värdet visas **bredvid varje kolumnnamn**, vilket hjälper dig att följa värdefördelningen över faser, ägare eller andra grupperingsfält.

![Tavlevy för försäljning med summerade belopp vid kolumnnamn -screenshot][img11]

### Försäljningsdatum märke (endast försäljning)

Du kan kontrollera vad det **grå märket** på varje försäljningskort visar i tavlevyn. Detta hjälper dig att förstå ålder vid ett ögonkast – antingen hur länge en försäljning har varit öppen eller hur länge den har varit i sin nuvarande fas.

1. Klicka på <i class="ph ph-gear-six" aria-hidden="true"></i> för att öppna **Inställningar**-panelen.

    ![Inställningspanel för försäljningstavla som visar alternativ för gruppering, sortering, sammanfattning, filter, försäljningsdatum märke och dölj stängda försäljningar. -screenshot][img13]

1. Välj **Försäljningsdatum märke**.

1. Välj ett av följande alternativ:

    * **Dagar i fas:** Visar hur många dagar försäljningen har varit i sin nuvarande fas.
    * **Dagar sedan registrerad:** Visar hur länge sedan försäljningen skapades.

    ![Inställningsdialog för försäljningsdatum märke med alternativen Dagar i fas och Dagar sedan registrerad. -screenshot][img14]

Det valda måttet visas som ett **grått märke** på varje försäljning i tavlevyn. Ett **rött märke** används fortfarande för att markera försenade försäljningar.

## Användningsområden

Tavlevy stödjer olika roller och arbetsflöden. Här är exempel för säljare, projektmedlemmar, supportmedarbetare och chefer:

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

### Projektmedlemmar

* **Visualisera dina aktiva projekt**, och följ framsteg genom olika statusar.
* **Dra ett kort till en annan kolumn** för att uppdatera projektets status.
* **Filtrera efter nästa milstolpe eller slutdatum** för att fokusera på brådskande leveranser.
* **Gruppera efter ansvarig** för att se projektansvar i teamet.
* **Öppna uppgiftsmenyn** för att skapa en händelse eller ett dokument, eller för att markera projektet som klart.

### Projektledare

* **Få en fullständig översikt över alla projekt** för att övervaka status och identifiera förseningar.
* **Sammanfatta efter typ** för att jämföra kundprojekt, interna initiativ eller utvecklingsarbete.
* **Filtrera efter ansvarig** för att balansera arbetsbelastningen mellan teammedlemmar.
* **Gruppera efter status** för att se hur projekt rör sig genom faserna, eller efter typ för att anpassa till affärsprioriteringar.

### Supportmedarbetare

* **Visualisera dina tilldelade ärenden**, och följ dem genom statusar som ny, pågår och stängd.
* **Dra ett kort till en annan kolumn** för att uppdatera ärendets status.
* **Filtrera efter deadline eller prioritet** för att börja med de mest akuta ärendena.
* **Gruppera efter status** för att följa framsteg, eller efter ärendetyp för att fokusera på specifika kategorier.
* **Öppna uppgiftsmenyn** för att stänga ärendet.

### Supportchefer

* **Få en fullständig översikt över inkommande ärenden**, och se fördelningen efter status.
* **Sammanfatta efter prioritet** för att säkerställa att viktiga ärenden hanteras snabbt.
* **Filtrera efter kategori eller skapelsedatum** för att analysera trender i kundproblem.
* **Gruppera efter ägare** för att övervaka arbetsbelastning bland agenter och omfördela ärenden vid behov.
* **Använd status som grupp och prioritet som undergrupp** för att få en strukturerad översikt för analys och rapportering.

Använd gruppering kreativt för effektiv datahantering.

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
* [Skapa ett ärende / ärendeegenskaper][14]
* [Skapa ärendestatus][15]
* [Skapa ärendekategori][16]
* [Skapa ett projekt / fält i projektkortet][17]
* [Konfigurera projektstatus][18]
* [Konfigurera projekttyper][19]

<!-- Refererade länkar -->
[1]: create.md
[2]: index.md
[11]: ../../../learn/getting-started/main-screen/side-panel.md
[12]: ../../../sale/learn/create.md
[13]: ../../../sale/admin/sale-stage.md
[14]: ../../../request/learn/create.md
[15]: ../../../request/admin/status/create.md
[16]: ../../../request/admin/category/create.md
[17]: ../../../project/learn/create.md
[18]: ../../../project/admin/project-status.md
[19]: ../../../project/admin/project-type.md

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
[img12]: ../../../../media/loc/en/search-options/selection-board-view-project-preview.png
[img13]: ../../../../media/loc/en/search-options/board-view-settings-for-sales.png
[img14]: ../../../../media/loc/en/search-options/sale-date-badge-setting.png
