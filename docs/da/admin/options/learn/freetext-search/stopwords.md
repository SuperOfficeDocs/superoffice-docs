---
uid: help-da-stopwords
title: Stopord
description: Stopord
author: Bergfrid Dias
date: 03.21.2023
keywords: fritekst, søge, stopord
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Stopord

Et stopord er et ord, der ikke er indekseret (ikke inkluderet i en fritekstsøgning). Det betyder typisk ord som *og*, *eller*, *det* og *for*. Formålet med at definere stopord er at nedbringe den tid, det tager at søge i fritekstindekset, ved at udelukke unødvendige ord og bruge mindre plads i databasen.

De ord, der er defineret som stopord til fritekstsøgninger, er anført i tabellen **Stopordsliste** under fanen **Fritekstsøgning** på skærmbilledet Indstillinger.

> [!TIP]
> Hvis ændringerne skal have tilbagevirkende kraft, skal du [generere fritekstindekset igen][3]. Gør dette, efter at du har tilføjet stopord, efter at systemet har foreslået stopord, eller efter at du har importeret en stor mængde tekst.

## Tilføjelse af stopord

1. [!include[Go to freetext search tab](../includes/goto-freetext.md)]

1. Kontroller, at [fritekstsøgning er aktiveret][2].

1. Klik på knappen **Tilføj** under stopordslisten.

1. I dialogboksen **Nye stopord** skal du skrive et eller flere stopord, som du vil medtage. Som separator skal du bruge et ikke-alfabetisk tegn, undtagen punktum.

1. Klik på **Gem**.

1. Der vises en meddelelse om, at ændringer af stopordslisten ikke har tilbagevirkende kraft. Med andre ord gælder nye stopord ikke for tekst, der er indtastet, før stopordet blev angivet. Klik på **OK**.

## Forslag til stopord

I stedet for at indtaste stopord manuelt, kan du lade systemet foreslå stopord for dig.

1. [!include[Go to freetext search tab](../includes/goto-freetext.md)]

1. Kontroller, at [fritekstsøgning er aktiveret][2].

1. Klik på knappen **Foreslå** under stopordslisten.

1. Der vises en meddelelse om, at det kan tage lang tid for systemet at gennemgå ordlisten og indekset for at finde mulige stopord. Klik på **OK**.

1. Når systemet har fundet mulige stopord, vises disse i dialogboksen **Nye stopord** . De hyppigst anvendte ord i databasen vises øverst. Markér dem, du vil medtage som stopord. Hold **CTRL**-tasten nede, og klik på de relevante stopord.

1. Klik på **Gem**.

1. Der vises en meddelelse for at minde dig om, at ændringer i stopordslisten ikke har tilbagevirkende kraft. Det betyder, at nye stopord ikke gælder for felter, der blev oprettet, før stopordene blev defineret. Klik på **OK**.

## Sletning af stopord

Formålet med at slette stopord er at medtage dem i fritekstsøgninger efter at have udelukket dem. Sådan slettes et stopord fra listen:

1. [!include[Go to freetext search tab](../includes/goto-freetext.md)]

1. Kontroller, at [fritekstsøgning er aktiveret][2].

1. Vælg det ønskede stopord.

1. Klik på knappen **Slet** under stopordslisten.

<!-- Referenced links -->
[2]: enable.md
[3]: regenerate-index.md

<!-- Referenced images -->
