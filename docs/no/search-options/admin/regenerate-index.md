---
uid: help-no-free-text-index-regen
title: Regenerere en fritekstindeks
description: Regenerere en fritekstindeks
keywords: fritekst, søkeindeks
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: no
deployment: onsite
redirect_from: /no/admin/options/learn/freetext-search/regenerate-index
---

# Regenerere en fritekstindeks (onsite)

> [!NOTE]
> Denne fanen er bare tilgjengelig hvis SuperOffice-installasjonen er onsite (på stedet). Hvis du bruker online-løsningen, kan du ikke gjøre endringer i disse innstillingene. For SuperOffice Online genereres fritekstindeksen på nytt hver 7. dag som standard.
>
> For å kunne regenerere en fritekstindeks må du tilhøre rollen **Brukernivå 0** (eller tilsvarende). På Oracle-databaser må du benytte brukeren som er databaseeier.

Når du bare [legger til eller sletter nye stoppord][1], har ikke endringene dine tilbakevirkende kraft. Det betyr for eksempel at hvis du registrerer *og* som stoppord og allerede har mange forekomster av *og* i databasen, blir ikke disse automatisk fjernet fra fritekstindeksen. Endringen gjelder bare forekomster av*og* som du legger til fra da av. I noen tilfeller kan det derfor være aktuelt å oppdatere fritekstindeksen, slik at alle stoppord blir fjernet fra den.

## Regenerere fritekstindeksen

1. [!include[Go to freetext search tab](includes/goto-freetext.md)]

1. Kontroller at alternativet **Aktiver fritekstsøk** er valgt.

1. Klikk på knappen **Bygg fritekstindeks**.

1. Du får en melding om at det kan ta lang tid å regenerere en ny indeks, og at brukerne ikke vil få tilgang til funksjonen for fritekstsøk i denne perioden. Klikk på **OK**. Du får frem et vindu som viser status for byggeprosessen. Når dette forsvinner, er den nye fritekstindeksen klar.

<!-- Referenced links -->
[1]: stopwords.md

<!-- Referenced images -->
