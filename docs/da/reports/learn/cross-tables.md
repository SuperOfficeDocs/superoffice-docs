---
uid: help-da-cross-table-reports
title: Visning af krydstabeller
description: Visning af krydstabeller
author: SuperOffice RnD
so.date: 07.04.2022
keywords: rapport
so.topic: help
language: da
---

# Krydstabeller

Du kan vise og udskrive krydstabeller på forskellige måder. Du kan bl.a. vælge, hvilke dele af krydstabellen, der skal vises på udskriften, forhåndsvise krydstabellen og udskrive krydstabellen som en almindelig tabel eller som et diagram.

> [!TIP]
> Hvis du er i tvivl om, hvorvidt rapporten er en krydstabel, kan du se på billedet mellem rapportlisten og rapportbeskrivelsen. [Hvordan][1].

## <a id="install" />Installer CrossTable Viewer

Sådan får du vist en krydstabelrapport (. Dcube-fil), skal du installere **CrossTable-fremviseren** (én gang pr. computer).

1. Klik på ![ikonet][img1] **Hovedmenu** og vælg **Download &gt; Download CrossTable-fremviseren**.
1. Klik på den downloadede fil (**SoCrossTableInstaller.exe**) for at køre den.
1. Hvis der vises en sikkerhedsadvarsel, skal du bekræfte, at du vil køre filen.
1. Følg vejledningen i guiden for at installere programmet.

## Vis en krydstabel

1. [!include[How to-goto-reports](includes/goto-reports.md)]

1. [Vælg den ønskede krydstabelrapport][1].

1. Klik på knappen **Forhåndsvisning** under kriterielisten. Krydstabelrapporten genereres.

1. Klik på rapportfilen (.Dcube), der vises i browseren. Filen åbnes i SuperOffice-programmet til visning af krydstabeller. Her ser du krydstabelrapporten, som den kommer til at se ud, når den udfyldes med data fra SuperOffice-databasen.

    > [!NOTE]
    > Hvis du ikke kan se krydstabelrapporten i din browser (. Dcube), skal [du installere CrossTable-fremviseren](#install).

1. Rediger indholdet af krydstabellen ved hjælp af følgende knapper (se nedenfor).

    > [!NOTE]
    > De felter/rækker/kolonner, du vælger at skjule i trinnet ovenfor, kommer ikke med på udskriften.

1. Når du er færdig med at redigere indholdet i krydstabellen, kan du gøre en af følgende:

    * Vælg **Filer** &gt; **Forhåndsvisning** for at forhåndsvise rapporten.
    * Vælg **Filer** &gt; **Udskrift** for at udskrive rapporten.
    * Klik på **Eksporter** for at gemme rapporten i Excel-format.

1. Klik på **OK** for at lukke programmet til visning af krydstabeller.

## <a id="print" />Udskrivning af krydstabeller

Der er flere udskriftsmuligheder for krydstabeller. Du kan bl.a. vælge, hvilke dele af krydstabellen, der skal vises på udskriften, forhåndsvise krydstabellen og udskrive krydstabellen som en almindelig tabel eller som et diagram.

## <a id="export" />Lagring af krydstabelrapporter som filer

Lagring af rapporter som filer fungerer lidt anderledes for rapporttypen krydstabel end for de andre rapporttyper. Hvis du vil gemme en krydstabelrapport som en fil, skal du klikke på **Eksportér** når rapporten vises i Krydstabelfremviser.

## Knapper

| Ikon | Beskrivelse |
|---|---|
| ![ikon][img2] | Klik på denne knap for at få vist en rullemenu, som indeholder forskellige indstillinger til at vise eller skjule rækker/kolonner. |
| ![ikon][img3] | Fjern markeringen af dette afkrydsningsfelt, hvis du ikke vil have vist rækken eller kolonnen i krydstabellen. |
| ![ikon][img4] | Klik på plus for at vælge at vise alle rækker/kolonner på listen. |
| ![ikon][img5] | Klik på minus for at vælge at skjule alle rækker/kolonner på listen. |
| ![ikon][img6] | Klik på stjerne for at veksle mellem at vise og skjule rækker/kolonner. |
| ![ikon][img7] | Marker afkrydsningsfeltet for at bekræfte dit valg. |
| ![ikon][img8] | Klik på krydset for at afbryde. |
| ![ikon][img9],![ikon][img10] | Du kan også trække og slippe enkelte komponenter i krydstabellen. Musemarkøren vises som et pilekryds, når du holder den over komponenter, som kan flyttes. De felter, hvor du kan slippe komponenter, vises med en grøn streg, når du holder musemarkøren over dem. |

<!-- Referenced links -->
[1]: properties.md

<!-- Referenced images -->
[img1]: ../../../media/icons/main-menu.png
[img2]: ../../../media/icons/reports/list-box.bmp
[img3]: ../../../media/icons/reports/black-x-2.bmp
[img4]: ../../../media/icons/reports/plus.bmp
[img5]: ../../../media/icons/reports/minus.bmp
[img6]: ../../../media/icons/reports/asterisk.bmp
[img7]: ../../../media/icons/reports/check.bmp
[img8]: ../../../media/icons/reports/black-x.bmp
[img9]: ../../../media/icons/reports/arrows-plus.bmp
[img10]: ../../../media/icons/reports/arrows-split-green.bmp
