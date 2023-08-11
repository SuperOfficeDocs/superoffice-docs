---
uid: help-no-report-search-criteria-edit
title: Redigere søkekriterier i rapporter
description: Redigere søkekriterier i rapporter
author: SuperOffice RnD
so.date: 07.04.2022
keywords: rapport
so.topic: howto
language: no
---

# Redigere søkekriterier i rapporter

Du kan redigere søkekriterier i favorittrapporter. Du kan ikke redigere standardrapporter, men du kan tilpasse søkekriteriene i dem og lagre dem som dine egne [favorittrapporter][1].

1. [!include[How to-goto-reports](../includes/goto-reports.md)]

1. Velg en fane. Rapportene vises på rapportlisten.

    > [!NOTE]
    > Det anbefales ikke å kjøre rapporter uten å ha angitt søkekriterier. Da risikerer du å få svært store rapporter og en tidkrevende kjøringsprosess.

1. Merk ønsket rapport på listen.

1. Dobbeltklikk på kriteriet du vil redigere, i kriterielisten.

1. Dialogboksen **Legg til/rediger kriterier** åpnes.

1. [Rediger den ønskede informasjonen][2].

    > [!NOTE]
    > Hvilke kriterier du kan velge mellom, varierer etter hvilken fane og rapport du har valgt.

1. Klikk på **OK** nederst i dialogboksen **Legg til/rediger kriterier** når du er ferdig.

## Eksempel

Nå skal vi se på hvordan du kan justere kriteriene i en salgsrapport:

1. Klikk på fanen **Salg**. I rapportlisten vises en liste over standardrapporter for fanen du valgte.
1. Merk standardrapporten **Salgsrapport – Reelle salg**. I tekstfeltet vises en beskrivelse av rapporten, og i kriterielisten nedenfor vises kriteriene for standardrapporten du valgte.

Vi skal nå endre litt på kriteriene i standardrapporten, slik at du ser hvordan du kan endre kriteriene etter dine behov. Her skal vi endre standardrapporten slik at den viser alle reelle salg i forrige måned som *ikke* har statusen **Åpent**.

1. Dobbeltklikk på **Salg: Dato** i kriterielisten. Dialogboksen **Legg til/rediger kriterier** åpnes.

    ![Legge til / redigere søkekriterier -screenshot][img3]

1. Klikk på pilen ved siden av feltet **Denne måneden**, endre tidsrommet til **Forrige måned** og klikk på **OK**. Rapporten din kommer nå bare til å inneholde salg fra forrige måned.

1. Merk kriteriet **Salg: Eier** i kriterielisten, og klikk på **Slett**-knappen nederst. Rapporten din kommer nå til å inneholde alle salg, ikke bare de salgene der den aktuelle brukeren (du) står som eier.

1. Dobbeltklikk **på Salg: Status** i kriterielisten. Dialogboksen **Legg til/rediger kriterier** åpnes. Vi skal nå endre kriteriet **Salg: Status** slik at rapporten bare inneholder salg som ikke har status **Åpent**.

    ![Legge til / redigere søkekriterier -screenshot][img4]

1. Klikk på pilen ved siden av feltet **Er en av** og endre verdien til **Er ikke en av**.

1. I kolonnen **Valgte verdier** velger du **Solgt** og klikker på ![ikon][img2]. Kriteriet flyttes til kolonnen lengst til venstre.

1. I kolonnen lengst til venstre velger du **Åpne** og klikker på ![ikon][img1]. Kriteriet flyttes til kolonnen **Valgte verdier**. Rapporten vil nå inneholde salg som ikke har status **Åpent**.

1. Klikk på **OK**.

<!-- Referenced links -->
[1]: ../favorites/add.md
[2]: ../../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/arrow-right.png
[img2]: ../../../../media/icons/arrow-left.png
[img3]: ../../../../media/loc/en/reports/edit-criteria.png
[img4]: ../../../../media/loc/en/reports/edit-criteria-2.png
