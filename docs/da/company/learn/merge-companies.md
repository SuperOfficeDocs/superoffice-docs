---
uid: help-da-company-merge
title: Flet kontakter
description: For at kunne være effektiv i arbejdet med kunder og kontakter er det vigtigt at have et miljø uden rod. Det betyder at slette ubrugte virksomheder og kontakter og flette duplikerede virksomheder og kontakter.
keywords: firma
author: SuperOffice
date: 08.27.2024
version: 10.3.8
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
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

1. Under **Til firma** vælger du det firma, som skal opdateres med oplysninger fra kildefirmaet. Begynd at skrive i feltet for at søge efter et firma. Hvis du vil bytte om på **Fra-** og **Til-**firmaer, skal du klikke på pilknappen.

    > [!CAUTION]
    > Vælg det korrekte firma i Fra-felt OG i Til-felt.

1. Under **Detaljeoplysninger om firma og personer** kan du markere følgende:

    * Læg identiske personer sammen. Hvis denne indstilling er valgt, flettes kontakter med identiske navne.

        Navnene skal være HELT identiske for at blive lagt sammen, både fornavn, mellemnavn og efternavn.

    * **Erstat tomme felter \[target company\] med værdier fra \[source company\]**. Hvis du vælger denne indstilling, bliver det tomme datafelt i **Til**-firmaet opdateret med data fra **Fra**-firmaet.

1. Klik på **Slå sammen**. Følgende sker:

    * Firmaerne lægges sammen.
    * Personer flyttes eller lægges sammen.
    * Alle aktiviteter flyttes.
    * Projektmedlemskab og medlemskab i statiske udvalg følger firmaet.
    * Alle detaljer lægges sammen, hvis du har valgt **Erstat tomme felter i &lt;target company&gt; med værdier fra &lt;source company&gt;**.
    * Kildefirmaet slettes.

![Slå firmaer sammen -screenshot][img4]

> [!TIP]
> Du kan også lægge firmaer i dynamiske og statiske udvalg sammen.

## Relaterede emner

* [Flette kontaktpersoner][2]

<!-- Referenced links -->
[2]: ../../contact/learn/merge-contacts.md

<!-- Referenced images -->
[img3]: ../../../media/icons/btn-menu.png
[img4]: ../../../media/loc/en/company/merge-companies.png
