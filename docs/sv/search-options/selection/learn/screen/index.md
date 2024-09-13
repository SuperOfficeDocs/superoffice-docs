---
uid: help-sv-selection-screen
title: Detaljkorten i fönstret Urval
description: Detaljkorten i fönstret Urval
keywords: selection
author: Bergfrid Dias
date: 09.17.2024
version: 10.3.9
topic: reference
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Urvalsskärmen

Den första fliken i urvalet innehåller en lista över medlemmar (poster, data) i det aktiva urvalet. Medlemmar i urval kan vara företag eller kontakter, projekt, försäljningar, dokument, händelser, formulärinlämningar, chattkonversationer, utskick eller produkter.

Medlemslistan ser lite olika ut beroende på vad urvalet innehåller. Alla urvalstyper utom **Företag/kontakt** har två flikar som innehåller urvalsdata.

> [!TIP]
> Om du dubbelklickar på en post i medlemslistan, visas den aktuella posten.

## Detaljkorten i fönstret Urval

| Flik | Beskrivning |
|---|---|
| Medlemslistan | Innehåller urvalsdata. |
| Företag/kontakt | Innehåller företag och kontakter kopplade till medlemslistan. Exempel: Alla kontakter eller företag som är kopplade till försäljningen i ett urval. Om urvalet är ett urval av företag/kontakter är detta den enda fliken med medlemmar. |
| Kriterier | Visa och [redigera kriterierna][3] för ett dynamiskt urval. |
| Specifikation | Visa och redigera [allmän information för ett urval][1]. |
| Diagram | [Visa urvalsdata i ett diagram.][5] Urval med diagram kan också användas i [dashboards][6]. |
| Utskick | Skapa ett utskick till kontakter i ett urval. [Visa de utskick](#mailing) som är arkiverade för detta urval. |

> [!TIP]
> Klicka på ![ikon][img3] till höger om kolumnrubrikerna i ett urval för att gruppera och filtrera poster, för att ta bort/lägga till kolumner, samt för att specificera beräkningar. Dessa inställningar kan sparas för det aktiva urvalet genom att du väljer **Spara kolumner endast för markerat urval**. Se även [Detaljkorten][9] för fler funktioner.

Om du vill flytta mellan olika urval, klickar du på knapparna föregående/nästa ( ![ikon][img2] ![ikon][img1] ) längst upp till höger på skärmen.

### <a id="filter"></a>Filtrera medlemslistan

> [!NOTE]
> Innan du filtrerar medlemslistan (för t.ex. försäljning eller händelser), klicka på **Visa alla** i sidfoten på fliken. Detta säkerställer att fliken visar alla poster i urvalet. För att säkerställa bästa möjliga prestanda när du arbetar med stora urval laddas oftast bara de första 100 posterna i deltagarlistan.

För att aktivera kolumnfiltret, klicka på ![ilon][img3] till höger om kolumnrubrikerna och klicka på **Aktivera filter**. Filterknappen (![ikon][img7]) visas nu på kolumner som kan [filtreras][8].

### Uppgift-knappen

![ikon][img6]

Använd **Uppgift**-knappen för att utföra olika uppgifter för alla eller några av medlemmarna i urvalet. Exempel: skicka e-post, massredigering och export. Vilka uppgifter som visas beror på vad urvalet består av (vad som har valts i fältet **Urval av**).

### Andra knappar

* **Ta bort medlemmar**. Detta alternativ är endast tillgängligt för statiska urval. För att [ta bort deltagare i urvalet][2] markerar du de relevanta medlemmarna, högerklickar och markerar **Ta bort**.

* **Antal: antal**, Antal medlemmar i det aktiva urvalet.

* **Visa alla**. Används för att visa alla medlemmar i urvalet.

    > [!NOTE]
    > Som standard visar listan endast de första 100 posterna i urvalet. För att ändra detta värde, gå till ![ikon][img4] **Personliga inställningar** > **Inställningar** > **Funktioner** > **Arkivsidstorlek**.

* ![ikon][img5]: Uppdaterar data i listan.

### <a id="mailing"></a> Visa arkiverade utskick för urval

Använd fliken **Utskick** i fönstret Urval för att hålla reda på alla utskick som är kopplade till ett urval.

Öppna ett utskick genom att dubbelklicka på det.

**Skapa utskick**: Klicka för att [skapa ett nytt utskick][7] till kontakterna i detta urval.

**Exportera**: Används för att exportera listan till ett kalkylark.

## Relaterade ämnen

* [Utföra uppgifter för urval][4]
* [Använda filter på detaljkort][8]
* [Skapa urval][1]

<!-- Referenced links -->
[1]: ../create/index.md
[2]: ../update/add-remove-members-static.md
[5]: ../howto/display-as-charts.md
[3]: ../../../learn/search-criteria.md
[6]: ../../../../dashboard/learn/create.md
[7]: ../../../../marketing/mailing/learn/create/index.md
[8]: ../../../../learn/section-tabs/filter.md
[9]: ../../../../learn/section-tabs/index.md
[4]: ../../../../learn/getting-started/index.md

<!-- Referenced images -->
[img3]: ../../../../../../common/icons/cog-wheel.png
[img1]: ../../../../../media/icons/arrow-right.png
[img2]: ../../../../../media/icons/arrow-left.png
[img4]: ../../../../../media/icons/personal-settings-small.png
[img5]: ../../../../../media/icons/refresh.png
[img7]: ../../../../../media/icons/filter-column.png
[img6]: ../../../../../media/loc/en/learn/task.png
