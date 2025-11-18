---
uid: help-sv-dashboard-tile-sales-targets
title: Använda försäljningsmål i paneler
description: Använd dashboards och paneler för att jämföra dina försäljningsmål med din faktiska försäljning.
keywords: dashboard, försäljningsmål, diagram
author: SuperOffice Product and Engineering
date: 11.21.2025
version: 11.6
content_type: howto
license: salespremium
deployment: online
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Använda mål i paneler

När [försäljningsmål][4] har ställts in för ditt företag, team eller enskilda användare kan du lägga till dessa mål i dashboardpaneler. Detta låter dig jämföra faktisk försäljning med mål direkt i visuella diagram som mätare, stapeldiagram och stora siffror.

För att lära dig hur dashboards och urval kan hjälpa dig att övervaka och förutse försäljning, se [Prognostisera din försäljning][8].

![Gå till fliken Layout och välj Jämför med mål i sektionen Gruppering -screenshot][img1]

## Lägg till panel med försäljningsmål på en dashboard

1. Öppna skärmen **Dashboard**.

2. Välj den dashboard som du vill redigera.

3. Klicka på <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> och välj **Redigera dashboard-paneler**. Till höger på den dashboard som du har valt visas avsnittet **Redigera dashboard-paneler**.

4. I listan **Visa paneler för** väljer du **Försäljning**.

5. Välj något av följande diagram under fliken **Bibliotek**:

    * <i class="ph ph-number-square-three" aria-hidden="true"></i> – Stora siffror
    * <i class="ph ph-chart-bar-horizontal" aria-hidden="true"></i> – Stapeldiagram
    * <i class="ph ph-chart-bar" aria-hidden="true"></i> – Kolumndiagram
    * <i class="ph ph-gauge" aria-hidden="true"></i> – Mätardiagram
    * Tom försäljningspanel

    > [!TIP]
    > Du kan också välja en tom panel för att [skapa en panel från grunden][6], men diagramtypen måste vara någon av de som listas ovan.

6. För att lägga till en panel i dashboarden drar du och släpper den i önskad position på dashboarden. Du kan även klicka på **Lägg till** för att lägga till en panel i nästa tilgängliga position. Figuren anpassas automatiskt till den tillgängliga ytan och justeras efter rutnätet och kolumnerna.

7. Justera panelerna på dashboarden:

    * Håll muspekaren över en panel och klicka och dra i ramen för att justera storleken på panelen. Tillgängliga platser/ytor på dashboarden gulmarkeras om panelen får plats i den aktuella positionen.

    * Klicka på rubriken för en panel och dra denna till en annan position.

8. Klicka på **Redigera panel** (<i class="ph ph-pencil" aria-hidden="true"></i>) på den nya panelen.

9. Under fliken **Dataset**, ställ in **Försäljningsdatum** på innevarande år, kvartal eller månad. Redigera övriga [kriterier][2] efter behov. Kom ihåg att uppdatera panelens namn för att spegla eventuella ändringar som har gjorts här.

10. Redigera layouten på fliken **Layout**:

    * **Diagramtyp**: Ändra detta till valfri diagramtyp i steg 5.
    * **Mått**: Välj **Summa** eller **Antal**. Till exempel summan av all försäljning eller det totala antalet från all försäljning.
    * **Av**: Om du valde **Antal** ovan måste du välja **Försäljnings-ID** i den här listan. Om du valde **Summa** väljer du **Belopp** eller **Viktat belopp**.
    * **Per**: Välj **Försäljning &gt; Ägare** (ägare, fullständigt namn eller grupp) eller **Försäljning &gt; Försäljningsdatum**. Det här alternativet är bara relevant för stapeldiagram och kolumndiagram.
    * **Gruppering** eller **Sidfot**: Välj **Jämför med mål**.
      * Om det här alternativet inte är synligt eller är inaktiverat dubbelkollar du att du har utfört stegen ovan. Om du inte ser alternativet **Jämför med mål** (om det är inaktiverat) kan du hålla muspekaren över texten. Detta visar ett verktygstips som förklarar vad du behöver ändra för att aktivera och välja alternativet.
    * **Mål**: Välj det mål som du vill lägga till i panelen. (Inte relevant för stapeldiagram.)
    * **Visa som %**: Välj detta alternativ för att visa procentandel av målet istället för summor eller antal. (Inte relevant för kolumndiagram och stora siffror.)

11. Redigera formateringen. Beroende på vilken diagramtyp du har valt har du ytterligare alternativ under **Formatering**:

    * Stora siffror: Du kan redigera färgerna som används för att visa mål.
    * Mätardiagram: Använd alternativet **Markera målet på** för att ställa in målet på mätardiagrammet.

12. Klicka på <i class="ph ph-translate" aria-label="Translate"></i> för att [lägga till en översättning][3] till figurnamnet, rubrikerna och ledtexterna.

13. Klicka på **Spara**. Klicka sedan på **Klar**.

## Varför kan jag inte välja Jämför med mål?

Om du ser fältet Jämför med mål, men det är inaktiverat, kan du hålla muspekaren över fältet så visas en hjälptext som förklarar vad du behöver ändra för att du ska kunna aktivera och välja fältet.

Om alternativet Jämför med mål inte är synligt överhuvudtaget kontrollerar du att du har valt rätt diagramtyp och att du har använt Försäljningsdatum som villkor på fliken Dataset.

## Relaterat

* [Lägg till en ny dashboard][5]
* [Redigera eller skapa paneler][6]
* [Paneler med leads och UTM-data][9]
* [Konfigurera försäljningsmål][7]
* [Prognostisera din försäljning][8]

<!-- Referenced links -->
[2]: ../../search-options/learn/search-criteria.md
[3]: ../../localization/learn/translate-fields.md
[4]: ../../sale/learn/sales-targets/index.md
[5]: create.md
[6]: working-with-tiles.md
[7]: ../../sale/learn/sales-targets/create.md
[8]: ../../sale/learn/forecasting.md
[9]: show-leads.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/dashboard/team-forecast-vs-target.png
