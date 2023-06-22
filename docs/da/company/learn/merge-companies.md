---
uid: help-da-company-merge
title: Flet kontakter
description: For at kunne være effektiv i arbejdet med kunder og kontakter er det vigtigt at have et miljø uden rod. Det betyder at slette ubrugte virksomheder og kontakter og flette duplikerede virksomheder og kontakter.
author: SuperOffice RnD
so.date: 12.15.2022
keywords: firma
so.topic: howto
language: da
---

# Flet kontakter

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

Du kan flette dublerede databaseposter for firmaer. Personer og aktiviteter bliver flyttet til målfirmaet, og kildefirmaet bliver slettet.

Hvis to firmaer i kundedatabasen beslutter at fusionere, eller et af firmaerne har købt det andet firma, kan du slå disse firmaer sammen til ét firma. Personer (og relaterede anmodninger), fakturaer og registrerede domæner opbevares for begge firmaer.

## Trin

[!include[Go to company](../../learn/includes/goto-company.md)]

1. Vælg **Vedligehold firmaer** fra knappen ![ikon][img3] **Opgave** og klik på **Læg firmaer sammen**.
    Dialogboksen **Slå firmaer sammen** åbnes. Kildefirmaet er angivet under **Fra**.

1. Under **Til firma** vælger du det firma, som skal opdateres med oplysninger fra kildefirmaet. Begynd at skrive i feltet for at [søge efter et firma][1].

    > [!TIP]
    > Hvis du vil bytte om på **Fra-** og **Til-**firmaer, skal du klikke på knappen ![ikon][img1].

1. Under **Detaljeoplysninger om firma og personer** kan du markere følgende:

    * Læg identiske personer sammen. Hvis denne indstilling er valgt, flettes kontakter med identiske navne.

        > [!NOTE]
        > Navnene skal være HELT identiske for at blive lagt sammen, både fornavn, mellemnavn og efternavn.

    * **Erstat tomme felter \[target company\] med værdier fra \[source company\]**. Hvis du vælger denne indstilling, bliver det tomme datafelt i **Til**-firmaet opdateret med data fra **Fra**-firmaet.

    [!include[Preview results](../../learn/includes/note-preview-results.md)]

1. Klik på **Slå sammen**. Følgende sker:

    * Firmaerne lægges sammen.
    * Personer flyttes eller lægges sammen.
    * Alle aktiviteter flyttes.
    * Projektmedlemskab og medlemskab i statiske udvalg følger firmaet.
    * Alle detaljer lægges sammen, hvis du har valgt **Erstat tomme felter i &lt;target company&gt; med værdier fra &lt;source company&gt;**.
    * Kildefirmaet slettes.

![Slå firmaer sammen -screenshot][img4]

[I dialogboksen Flet virksomheder skal du sørge for at vælge det korrekte firma i Fra-felt OG i Til-felt-skærmbillede][img5]

![Hvis du vil have ekstra oplysninger, før du fusionerer de to virksomheder, skal du klikke på knappen Info på Vis resultat -screenshot][img6]

> [!TIP]
> Du kan også lægge firmaer i dynamiske og statiske udvalg sammen.

## Relaterede emner

* [Flette kontaktpersoner][2]

<!-- Referenced links -->
[1]: ../../search-options/learn/using-fastsearcher.md
[2]: ../../contact/learn/merge-contacts.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/info-ball.png
[img3]: ../../../media/icons/btn-menu.png
[img4]: media/merge-companies.bmp
[img5]: media/company-merge.png
[img6]: media/company-merge-info.png
