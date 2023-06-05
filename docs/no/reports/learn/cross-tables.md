---
uid: help-no-cross-table-reports
title: Vise krysstabeller
description: Vise krysstabeller
author: SuperOffice RnD
so.date: 07.04.2022
keywords: rapport
so.topic: concept
language: no
---

# Krysstabeller

Du kan vise og skrive ut krysstabeller på ulike måter. Blant annet kan du velge hvilke deler av krysstabellen som skal vises i en utskrift, forhåndsvise krysstabellen og skrive ut krysstabellen som vanlig tabell eller som diagram.

> [!TIP]
> Hvis du lurer på om rapporten din er en krysstabell, kan du se på bildet mellom rapportlisten og rapportbeskrivelsen. [Slik][1].

## <a id="install" />Installering av program for visning av krysstabeller

Hvis du vil vise en krysstabellrapport (.Dcube file), må du installere **programmet for visning av krysstabeller** (ett per datamaskin).

1. Klikk på ![ikon][img1] **Hovedmeny** og velg **Last ned** > **Last ned program for visning av krysstabeller**.
1. Klikk på den nedlastede filen (**SoCrossTableInstaller.exe**) for å kjøre den.
1. Hvis det vises et sikkerhetsvarsel, bekrefter du at du vil kjøre filen.
1. Følg instruksene i veiviseren til programmet er ferdig installert.

## Slik viser du en krysstabell

1. [!include[How to-goto-reports](includes/goto-reports.md)]

1. [Merk ønsket krysstabellrapport][1].

1. Klikk på **Forhåndsvisning**-knappen under kriterielisten. Krysstabellrapporten blir generert.

1. Klikk på rapportfilen (.Dcube) som vises i nettleseren. Filen åpnes i SuperOffices program for visning av krysstabeller. Her ser du krysstabellrapporten slik den blir når den fylles ut med data fra SuperOffice-databasen.

    > [!NOTE]
    > Hvis du ikke kan se krysstabellrapporten i nettleseren (. Dcube), må du [installere programmet for visning av krysstabeller](#install).

1. Rediger innholdet i krysstabellen ved hjelp av knappene (se nedenfor).

    > [!NOTE]
    > Felt/rader/kolonner du velger å skjule i trinnet ovenfor, blir ikke med på utskriften.

1. Når du har redigert innholdet i krysstabellen, kan du gjøre ett av følgende:

    * Velg **Fil** > **Forhåndsvisning** for å forhåndsvise rapporten.
    * Velg **Fil** > **Utskrift** for å skrive ut rapporten.
    * Klikk på **Eksporter** for å lagre rapporten i Excel-format.

1. Klikk på **OK** for å lukke programmet for visning av krysstabeller.

## <a id="print" />Skrive ut krysstabeller

Du har flere utskriftsmuligheter for krysstabeller. Blant annet kan du velge hvilke deler av krysstabellen som skal vises i en utskrift, forhåndsvise krysstabellen og skrive ut krysstabellen som vanlig tabell eller som diagram.

## <a id="export" />Lagre krysstabellrapporter som filer

Lagring av rapporter som filer fungerer litt annerledes med rapporttypen krysstabell enn med andre rapporttyper. Hvis du vil lagre en krysstabellrapport som en fil, klikker du på **Eksporter** når du viser rapporten i programmet for visning av krysstabeller.

## Knapper

| Ikon | Beskrivelse |
|---|---|
| ![ikon][img2] | Klikk på denne knappen for å vise en listeboks som inneholder ulike alternativer for å vise og skjule rader/kolonner. |
| ![ikon][img3] | Fjern merkingen i denne boksen hvis du ikke vil at raden eller kolonnen skal vises i krysstabellen. |
| ![ikon][img4] | Klikk på pluss for å velge å vise alle radene/kolonnene på listen. |
| ![ikon][img5] | Klikk på minus for å velge å skjule alle radene/kolonnene på listen. |
| ![ikon][img6] | Klikk på stjerne for å veksle mellom å vise og skjule rader/kolonner. |
| ![ikon][img7] | Klikk på hake for å bekrefte valget ditt. |
| ![ikon][img8] | Klikk på kryss for å avbryte. |
| ![ikon][img9], ![ikon][img10] | Du kan også dra og slippe enkelte komponenter i krysstabellen. Musepekeren endres til et pilkryss når du holder den over komponenter som kan flyttes. Felt der du kan flytte komponenter, vises med grønn strek når du holder musepekeren over dem. |

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
