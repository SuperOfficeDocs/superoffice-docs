---
uid: help-sv-dashboard-tile-sales-targets
title: Använda försäljningsmål i figurer
description: Använd dashboards och figurer för att jämföra dina försäljningsmål med din faktiska försäljning.
author: SuperOffice RnD
date: 12.13.2022
keywords: dashboard, försäljning, mål, diagram
topic: howto
language: sv
---

# Använda mål i figurer

Om [försäljningsmål][4] har definierats för ditt företag, dina team/grupper och/eller dina säljare kan du lägga till dessa mål i dina dashboardfigurer. Du kommer då att få en visuell presentation av din faktiska försäljning och dina mål.

För att du ska kunna visualisera dina mål i en figur måste du först lägga till eller redigera figurerna på dashboarden. När du har valt rätt figur kan du redigera figurens layout och diagramtyp.

![Gå till fliken Layout och välj Jämför med mål i sektionen Gruppering -screenshot][img7]

## Lägg till figur med försäljningsmål på en dashboard

1. Öppna skärmen **Dashboard**.

2. Välj den dashboard som du vill redigera.

3. Klicka på **Uppgift**-knappen välj **Lägg till figur/Redigera layout**. Till höger på den dashboard som du har valt visas avsnittet **Lägg till figur/Redigera layout**.

4. I listan **Visa figurer för** väljer du **Försäljning**.

5. Välj något av följande diagram under fliken **Bibliotek**:

    * ![ikon][img2] – Stora siffror
    * ![ikon][img3] – Stapeldiagram
    * ![ikon][img4] – Kolumndiagram
    * ![ikon][img5] – Mätardiagram
    * Tom försäljningspanel

    > [!TIP]
    > Du kan också [välja en tom figur][1] för att skapa en figur från grunden, men diagramtypen måste vara någon av de som listas ovan.

6. För att lägga till en figur i dashboarden drar du och släpper den i önskad position på dashboarden. Du kan även klicka på **Lägg till** för att lägga till en figur i nästa tilgängliga position. Figuren anpassas automatiskt till den tillgängliga ytan och justeras efter rutnätet och kolumnerna.

7. Justera figurerna på dashboarden:

    * Håll muspekaren över en figur och klicka och dra i ramen för att justera storleken på figuren. Tillgängliga platser/ytor på dashboarden gulmarkeras om figuren får plats i den aktuella positionen.

    * Klicka på rubriken för en figur och dra denna till en annan position.

8. Klicka på ikonen **Redigera figur** ![ikon][img6] på den nya figuren.

9. Under fliken **Dataset**, ställ in **Försäljningsdatum** på innevarande år, kvartal eller månad. Redigera övriga [kriterier][2] efter behov. Kom ihåg att uppdatera figurens namn för att spegla eventuella ändringar som har gjorts här.

10. Redigera layouten på fliken **Layout**:

    * **Diagramtyp**: Ändra detta till valfri diagramtyp i steg 5.
    * **Mått**: Välj **Summa** eller **Antal**. Till exempel summan av all försäljning eller det totala antalet från all försäljning.
    * **Av**: Om du valde **Antal** ovan måste du välja **Försäljnings-ID** i den här listan. Om du valde **Summa** väljer du **Belopp** eller **Viktat belopp**.
    * **Per**: Välj **Försäljning &gt; Ägare** (ägare, fullständigt namn eller grupp) eller **Försäljning &gt; Försäljningsdatum**. Det här alternativet är bara relevant för stapeldiagram och kolumndiagram.
    * **Gruppering** eller **Sidfot**: Välj **Jämför med mål**.
      * Om det här alternativet inte är synligt eller är inaktiverat dubbelkollar du att du har utfört stegen ovan. Om du inte ser alternativet **Jämför med mål** (om det är inaktiverat) kan du hålla muspekaren över texten. Detta visar ett verktygstips som förklarar vad du behöver ändra för att aktivera och välja alternativet.
    * **Mål**: Välj det mål som du vill lägga till i figuren. (Inte relevant för stapeldiagram.)
    * **Visa som %**: Välj detta alternativ för att visa procentandel av målet istället för summor eller antal. (Inte relevant för kolumndiagram och stora siffror.)

11. Redigera formateringen. Beroende på vilken diagramtyp du har valt har du ytterligare alternativ under **Formatering**:

    * Stora siffror: Du kan redigera färgerna som används för att visa mål.
    * Mätardiagram: Använd alternativet **Markera målet på** för att ställa in målet på mätardiagrammet.

12. Klicka på ![ikon][img1] för att [lägga till en översättning][3] till figurnamnet, rubrikerna och ledtexterna.

13. Klicka på **Spara**. Klicka sedan på **Klar**.

## Varför kan jag inte välja Jämför med mål?

Om du ser fältet Jämför med mål, men det är inaktiverat, kan du hålla muspekaren över fältet så visas en hjälptext som förklarar vad du behöver ändra för att du ska kunna aktivera och välja fältet.

![Håll muspekaren över fältet Jämför med mål om du vill se en hjälptext -screenshot][img8]

Om alternativet Jämför med mål inte är synligt överhuvudtaget kontrollerar du att du har valt rätt diagramtyp och att du har använt Försäljningsdatum som villkor på fliken Dataset.

## Relaterat

* [Lägg till en ny dashboard][5]
* [Redigera eller skapa figurer][2]
* [Konfigurera försäljningsmål][7]
* [Dashboarddata][6]

<!-- Referenced links -->
[1]: edit-tile.md
[2]: ../../search-options/learn/search-criteria.md
[3]: ../../globalization-and-localization/learn/translate-fields.md
[4]: ../../sale/learn/sales-targets/index.md
[5]: create.md
[6]: working-with-tiles.md
[7]: ../../sale/learn/sales-targets/create.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/az.png
[img2]: ../../../../common/icons/big-numbers.png
[img3]: ../../../../common/icons/column-bar.png
[img4]: ../../../../common/icons/bar.png
[img5]: ../../../../common/icons/gauge.png
[img6]: ../../../../common/icons/edit-pen.png
[img7]: ../../../media/loc/en/dashboard/user-dashboard-tile-comparetotarget.png
[img8]: ../../../media/loc/en/dashboard/user-dashboard-tile-disabled-comparetotarget.png
