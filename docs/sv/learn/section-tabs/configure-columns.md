---
uid: help-sv-section-tabs-configure
title: Ändrar kolumnvisningen
description: Ändrar kolumnvisningen
keywords: detaljkort, arkiv, kolumn
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Konfigurera kolumner

Du kan anpassa kolumnerna i detaljkorten så att de visar just den information du behöver. Du kan ändra vilka kolumner som visas i översikten, i vilken ordning och med vilken bredd.

Genom att konfigurera kolumner kan du anpassa visad information och arbeta med CRM-data på det sätt du behöver. Lär dig hur du konfigurerar kolumner med den här videon eller följ stegen nedan:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/IjlPSN-u0MA]

(videons längd – 1:44)

## Ändra ordning på kolumnerna

Om du vill ändra ordningen på kolumnerna på ett detaljkort klickar du och drar en kolumnrubrik till en ny plats.

## Lägga till eller ta bort kolumn

1. Gå till det detaljkort du vill redigera.
2. Klicka på <i class="ph ph-gear" aria-label="Gear"></i> till höger om kolumnrubrikerna. En dialogruta visas.
3. Markera eller avmarkera relevanta kolumner. Använd fälten **Filterkolumner** för att filtrera de kolumner som visas.
4. Klicka på **OK**.

För att återställa kolumnerna till standard klickar du på **Återställ**.

## <a id="calculate"></a>Kolumnberäkningar

Du kan utföra beräkningar som summa, genomsnitt eller min/max på datum- och talfält.

1. Klicka på kugghjulssymbolen i detaljkortet för att öppna inställningarna.

2. Gå till fliken **∑ Summa** i dialogrutan.

3. Välj de kolumner du vill inkludera i beräkningen. Du kan också **aktivera gruppering** för att organisera data.

    ![Detaljkortets inställningar - summa av belopp och aktivera gruppering -screenshot][img2]

4. Välj vilken beräkning som ska utföras på varje kolumn. De tillgängliga alternativen beror på fälttypen.

**Resultat:**

![Detaljkort för försäljning - summa och gruppering på belopp -screenshot][img3]

> [!NOTE]
> Om din organisation använder flera valutor, se till att du arbetar med konsekventa värden i försäljningsberäkningar. Använd **basvaluta**-versionerna av fälten **Belopp** och **Viktat belopp** för att säkerställa noggrannhet.

![Detaljkort för försäljning - summa av belopp för basvaluta -screenshot][img5]

## Justera kolumnbredder manuellt

1. Håll muspekaren över den vertikala linjen framför eller bakom en kolumnrubrik. Markören ändras då till en vertikal dubbelpil.

1. Håll ned musknappen medan du drar skiljelinjen i önskad riktning, beroende på om du vill öka eller minska kolumnbredden. Kolumnerna kommer att ha den angivna bredden nästa gång du startar programmet.

> [!NOTE]
> Du kan inte justera kolumnbredder manuellt om **Anpassa kolumnbredd automatiskt** är aktiv.

## Justera kolumnbredder automatiskt

Du kan ställa in att kolumnernas bredd ska anpassas automatiskt efter innehållet i kolumnerna. När kolumner läggs till eller tas bort anpassas alla kolumnbredder optimalt varje gång. Om kolumnerna är för många för att passa i det tillgängliga utrymmet visas en horisontell rullist.

1. Gå till det detaljkort du vill redigera.
2. Klicka på <i class="ph ph-gear" aria-label="Gear"></i> till höger om kolumnrubrikerna. En dialogruta visas.
3. Väl **Anpassa kolumnbredd automatiskt**.
4. Klicka på **OK**.

## Relaterat innehåll

* [Lista över grupper][3]
* [Filtrera detaljkorten][1]
* [Exportera detaljkort][2]

<!-- Referenced links -->
[1]: filter.md
[2]: export-archives.md
[3]: group.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/learn/section-tab-sum-amount.png
[img3]: ../../../media/loc/en/learn/group-sales-by-status.png
[img5]: ../../../media/loc/en/sale/currency-adjusted-sale-amount-calculation.png
