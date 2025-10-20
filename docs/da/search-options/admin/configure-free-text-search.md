---
uid: help-da-settings-free-text-search
title: Konfigurer fritekstsøgning
description: Konfigurer fritekstsøgning
keywords: fritekstsøgning
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: da
redirect_from:
  - /da/admin/options/learn/freetext-search/enable
  - /da/admin/options/learn/freetext-search/configure
  - /da/admin/options/learn/freetext-search/index
  - /da/search-options/admin/index
---

# Konfigurer fritekstsøgning

Ved hjælp af funktionen til fritekstsøgning i SuperOffice CRM kan brugerne søge efter tekst i hele programmet. Dette gælder for tekst, som de selv har føjet til databasen, f.eks. firmanavne, afdelinger og tekst fra skærmbillederne Person og Dokument.

Du kan definere præcis, hvordan dette skal fungere i SuperOffice CRM, fra fanen **Fritekstsøgning** i Indstillinger og vedligeholdelse.

## Deaktiver fritekstsøgning (onsite)

1. [!include[Go to freetext search tab](includes/goto-freetext.md)]

1. Fjern markeringen af **Gør fritekstsøgning tilgængelig**.

Som standard er fritekstsøgning aktiveret, men hvis din organisation ønsker at spare systemressourcer, der bruges på at opdatere fritekstindekset, hver gang der tilføjes nye data, kan du fjerne markeringen af **Gør fritekstsøgning tilgængelig**. Dette deaktiverer feltet til fritekstsøgning i SuperOffice CRM onsite. Bemærk: fritekstsøgning kan ikke deaktiveres for online-/cloud-versioner.

## Angivelse af søgekriterier til en fritekstsøgning

Du kan angive søgekriterier for både enkelte ord (f.eks. *Peter*) og sætninger, der består af flere ord (f.eks. *Oliver Peter Nielsen*).

1. [!include[Go to freetext search tab](includes/goto-freetext.md)]

1. Kontroller, at fritekstsøgning er aktiveret.

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

## Relateret indhold

* [Tilføjelse af stopord][3]
* [Gendannelse af fritekstindeks][4]

<!-- Referenced links -->
[3]: stopwords.md
[4]: regenerate-index.md

<!-- Referenced images -->
