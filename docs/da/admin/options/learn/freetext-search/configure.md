---
uid: help-da-freetext-search-configure
title: Angivelse af søgekriterier
description: Angivelse af søgekriterier
author: Bergfrid Dias
date: 03.24.2023
keywords: fritekst, søge
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Angivelse af søgekriterier til en fritekstsøgning

Du kan angive søgekriterier for både enkelte ord (f.eks. *Peter*) og sætninger, der består af flere ord (f.eks. *Oliver Peter Nielsen*).

1. [!include[Go to freetext search tab](../includes/goto-freetext.md)]

1. Kontroller, at [fritekstsøgning er aktiveret][1].

1. Vælg en af følgende muligheder for **Søgekriterium ved enkeltord**:

    * **Starter med**: en søgning efter *pet* returnerer *Peter* og *Peterson* som hit.
    * **Indeholder**: en søgning efter *eter* returnerer *Peter* og *Peterson* som hit.
    * **Fuldstændig overensstemmelse**: en søgning efter *Peter* returnerer kun *Peter* som hit.

    > [!NOTE]
    > Indstillingen **Fuldstændig overensstemmelse** er den mindst ressourcekrævende, når du søger, mens indstillingen **Indeholder** er den mest ressourcekrævende.

1. Vælg en af følgende muligheder for **Søgeoperator for flere ord**:
    * **Starter med**: en søgning efter *pet* returnerer *Peter Nielsen* som hit.
    * **Indeholder**: En søgning efter *pet* returnerer *Oliver Peter Nielsen* og *Alan Peterson* som hit.
    * **Fuldstændig overensstemmelse**: En søgning efter kun *Oliver Peter Nielsen* returnerer *Oliver Peter Nielsen* som et hit.

    > [!NOTE]
    > Når du søger efter sætninger, der består af flere ord, søges der efter alle ordene sammen.

<!-- Referenced links -->
[1]: enable.md

<!-- Referenced images -->
