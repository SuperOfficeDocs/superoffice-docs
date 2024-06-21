---
uid: help-sv-cross-table-reports
title: Visa korstabeller
description: Visa korstabeller
author: SuperOffice RnD
date: 07.04.2022
keywords: rapport
topic: concept
language: sv
---

# Korstabeller

Du kan visa och skriva ut korstabeller på olika sätt. Du kan bland annat välja vilka delar av korstabellen som ska visas i en utskrift, förhandsgranska korstabellen och skriva ut korstabellen som en vanlig tabell eller som ett diagram.

> [!TIP]
> Om är osäker på om din rapport är en korstabell kan du se bilden mellan rapportlistan och rapportbeskrivningen. [Hur][1]?

## <a id="install" />Installera program för visning av korstabeller

Om du vill visa en korstabellsrapport (.Dcube-fil) måste du installera **program för visning av korstabeller** (en gång per dator).

1. Klicka på ![ikon][img1] **Huvudmeny** och välj **Hämta** > **Hämta program för visning av korstabeller**.
1. Klicka på den nedladdade filen (**SoCrossTableInstaller.exe**) för att köra den.
1. Om en säkerhetsvarning visas, bekräftar du att du vill köra filen.
1. Följ instruktionerna i guiden för att installera programmet.

## Visa en korstabell

1. [!include[How to-goto-reports](includes/goto-reports.md)]

1. [Välj önskad korstabellsrapport][1].

1. Klicka på knappen **Förhandsgranska** under kriterielistan. Korstabellrapporten genereras.

1. Klicka på rapportfilen (.Dcube) som visas i webbläsaren. Filen öppnas i SuperOffices program för visning av korstabeller. Här visas korstabellrapporten så som den ser ut när den fyllts med data från SuperOffice-databasen.

    > [!NOTE]
    > Om du inte kan se korstabellsrapporten i webbläsaren (.Dcube) måste du [installera programmet för visning av korstabeller](#install).

1. Redigera innehållet i korstabellen genom att använda knapparna (se nedan).

    > [!NOTE]
    > Fält/rader/kolumner som du väljer att dölja i steget ovan inkluderas inte i utskriften.

1. Efter att ha redigerat färdigt innehållet i korstabellen kan du göra ett av följande:

    * Välj **Arkiv** > **Förhandsgranska** för att förhandsgranska rapporten.
    * Välj **Arkiv** > **Skriv ut** för att skriva ut rapporten.
    * Klicka på **Exportera** för att spara rapporten i Excel-format.

1. Klicka på **OK** om du vill stänga programmet för granskning av korstabeller.

## <a id="print" />Skriva ut korstabeller

Det finns flera utskriftsmöjligheter för korstabeller. Du kan bland annat välja vilka delar av korstabellen som ska visas i en utskrift, förhandsgranska korstabellen och skriva ut korstabellen som en vanlig tabell eller som ett diagram.

## <a id="export" />Spara korstabellrapporter som filer

Om du vill spara en rapport med korstabellformat som en fil gör du på ett annat sätt än i rapporter med andra format. Om du vill spara en korstabellsrapport som en fil, klicka på **Exportera** när du visar rapporten i programmet för visning av korstabeller.

## Knappar

| Ikon | Beskrivning |
|---|---|
| ![ikon][img2] | Klicka på den här knappen om du vill visa en listruta med olika alternativ för att visa och dölja rader/kolumner. |
| ![ikon][img3] | Avmarkera den här rutan om du inte vill att raden eller kolumnen ska visas i korstabellen. |
| ![ikon][img4] | Klicka på plus om du vill välja att visa alla rader/kolumner i listan. |
| ![ikon][img5] | Klicka på minus om du vill välja att dölja alla rader/kolumner i listan. |
| ![ikon][img6] | Klicka på stjärna om du vill växla mellan att visa och dölja rader/kolumner. |
| ![ikon][img7] | Klicka på bocken om du vill bekräfta ditt val. |
| ![ikon][img8] | Klicka på kryss om du vill avbryta. |
| ![ikon][img9], ![ikon][img10] | Du kan även dra och släppa enskilda komponenter i korstabellen. Muspekaren ändras till ett pilkors när du håller den över komponenter som kan flyttas. Fält där du kan släppa komponenten visas med ett grönt streck när du håller muspekaren över dem. |

<!-- Referenced links -->
[1]: properties.md

<!-- Referenced images -->
[img1]: ../../../media/icons/main-menu.png
[img2]: ../../../media/icons/reports/list-box.png
[img3]: ../../../media/icons/reports/black-x-2.png
[img4]: ../../../media/icons/reports/plus.png
[img5]: ../../../media/icons/reports/minus.png
[img6]: ../../../media/icons/reports/asterisk.png
[img7]: ../../../media/icons/reports/check.png
[img8]: ../../../media/icons/reports/black-x.png
[img9]: ../../../media/icons/reports/arrows-plus.png
[img10]: ../../../media/icons/reports/arrows-split-green.png
