---
uid: help-da-freetext-index-regen
title: Gendannelse af fritekstindeks
description: Gendannelse af fritekstindeks
author: Bergfrid Dias
date: 03.24.2023
keywords: fritekst, søgeindeks
topic: howto
language: da
envir: onsite
---

# Gendannelse af fritekstindeks (onsite)

> [!NOTE]
> Denne fane er kun tilgængelig, hvis din SuperOffice-installation er på stedet. Hvis du bruger onlineløsningen, kan du ikke foretage ændringer i disse indstillinger. For SuperOffice Online regenereres fritekstindekset som standard hver 7. dag.

Når du [tilføjer eller sletter nye stopord][1], har dine ændringer ikke tilbagevirkende kraft. Det betyder, at hvis du indtaster *and* som stopord og allerede har mange forekomster af *og* i databasen, fjernes de ikke automatisk fra fritekstindekset. Ændringen gælder kun for eventuelle forekomster af *and*, som du tilføjer fra da af. I nogle tilfælde kan det være hensigtsmæssigt at opdatere fritekstindekset, så alle stopord fjernes fra det.

## Sådan gendannes fritekstindekset

1. [!include[Go to freetext search tab](../includes/goto-freetext.md)]

1. Kontroller, at [fritekstsøgning er aktiveret][4].

1. Klik på knappen **Regenerer fritekstindeks**.

1. Der vises en meddelelse om, at det kan tage lang tid at generere et nyt indeks, og at brugerne ikke kan få adgang til fritekstsøgningsfunktionen i denne periode. Klik på **OK**. Der åbnes et vindue, der viser status for regenereringsprocessen. Når dette forsvinder, er det nye fritekstindeks klar.

> [!NOTE]
> Hvis du vil gendanne et fritekstindeks, skal du tilhøre rollen **Brugerniveau 0** (eller tilsvarende). På Oracle-databaser skal du være den bruger, der er databaseejer.

<!-- Referenced links -->
[1]: stopwords.md
[4]: enable.md

<!-- Referenced images -->
