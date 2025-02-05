---
uid: help-no-request-next-in-queue
title: Hent neste sak i køen
description: Hent neste sak i køen
keywords: hent neste sak i køen, sak
author: Hanne Gunnarsson
date: 02.05.2025
version: 10.5.1
topic: howto
audience: person
audience_tooltip: SuperOffice Service
language: no
---

# Slik setter du opp Hent neste sak i køen

I SuperOffice fordeles saker vanligvis til brukere basert på en fordelingsmetode. En annen måte å fordele saker på er å plassere nye saker i **Saker** > **Ufordelte saker**, hvor saksbehandlere må overta sakene manuelt.

Det er imidlertid også mulig å opprette et intelligent køsystem for håndtering av nye saker. Saksbehandlere kan da klikke på **Hent neste sak i køen** under **Saker** for å overta neste sak i køen. Sakene i køen filtreres etter [kategori][2], slik at brukerne kun tildeles saker som tilhører kategorier de er medlem av.

## Hvordan prioriteres saker i køen?

Rekkefølgen på sakene i køen bestemmes av tidsfristen for hver enkelt sak. Sakene som har tidsfrist nærmest i tid, plasseres først i køen. Tidsfristen beregnes ut fra hvilke prioriteter som er angitt for person, firma, e-postkasse, e-postfilter og standardprioritet.

Dette sikrer at sakene blir prioritert i en logisk og rettferdig rekkefølge.

> [!NOTE]
> Det er også mulig å bruke en kombinasjon av køsystem og fordelingsmetode. Saker kan for eksempel plasseres i køen eller fordeles til brukerne basert på hvilken kategori sakene tilhører.

## Hvilke saker kan hentes fra køen?

Følgende faktorer avgjør hvilke saker en saksbehandler kan hente fra køen:

* Saken må ha en saksstatus med **Køstatus** aktivert.
* Saken må tilhøre en kategori hvor saksbehandleren er medlem.
* Sakens eier må være **Uten tildeling**.

## Opprett ny saksstatus "I kø"

Først oppretter vi en ny saksstatus: **I kø**. Nye saker skal automatisk få denne statusen.

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Velg **Saker** > **Saksstatus**.

1. Klikk på **Legg til**.

1. I feltet **Navn** skriver du et beskrivende navn, for eksempel "I kø".

1. I listen **Intern status** velger du **Åpen**.

1. Merk av for **Standard**, slik at nye saker automatisk får denne statusen.

1. Merk av for **Køstatus**. Saksbehandlere kan nå hente saker med denne statusen fra køen.

    > [!NOTE]
    > Dette betyr ikke at sakene MÅ hentes fra køen. Vi bruker kategorier til å bestemme hvilke saker som skal plasseres i køen, og hvilke som skal fordeles via fordelingsmetoden.

1. Du trenger ikke å merke av for **Opprett ny sak ved kundesvar**.

1. I listen **Registrer tid som** velger du **I kø**.

1. Klikk på **Lagre**.

Den nye saksstatusen vises i listen, og kolonnene **Standard** og **Køstatus** er avmerket.

## Bruke kategorier til å plassere saker i køen

Nå må du sørge for at du er medlem av kategoriene du skal håndtere. Vi må også angi at saker som tilhører disse kategoriene, ikke skal fordeles i henhold til fordelingsmetoden.

> [!NOTE]
> Medlemskap i kategorier kan også defineres på gruppenivå. I Innstillinger og vedlikehold (**Brukere** > **Brukergrupper**) kan du angi kategorier for de ulike brukergruppene.

### Trinn

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Velg **Saker** > **Kategorier**.

1. Klikk på ønsket kategori for å åpne **Egenskaper for kategori**.

1. Gå til fanen **Medlemmer**.

1. Velg deg selv i **Bruker**-listen, og klikk på **+** for å legge deg til som medlem av kategorien.

1. Legg til eventuelle andre brukere som medlemmer.

1. Gå til fanen **Fordelingsmetode** og velg **Ikke fordel**. Saker i denne kategorien vil nå ikke fordeles automatisk.

1. Klikk på **Lagre**.

Gjenta eventuelt for andre kategorier som skal kunne hentes fra køen. Kategorier som følger en fordelingsmetode, vil bli tildelt en bruker og vil derfor ikke plasseres i køen.

## Angi ny status for saker hentet fra køen

Når en sak hentes fra køen, må statusen endres fra **I kø** til **Åpen** (eller en annen aktiv status som viser at saken behandles). Dette skjer normalt automatisk.

## Kontrollere at køen fungerer

Opprett en ny sak, sett **Eier** til **Uten tildeling**, velg en kategori du er medlem av, og sett **Status** til **I kø**. Klikk deretter på **Saker** > **Hent neste sak i køen**.

<!-- Referenced links -->
[2]: category/index.md
