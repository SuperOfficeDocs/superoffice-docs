---
uid: help-no-request-next-in-queue
title: Hente neste sak i køen
description: Hente neste sak i køen
author: Hanne Gunnarsson
so.date: 03.29.2023
keywords: sak
so.topic: howto
so.user: user
so.user.tooltip: SuperOffice Service
language: no
---

# Slik setter du opp Hent neste sak i køen

I SuperOffice fordeles vanligvis saker til brukere etter en fordelingsmetode. En annen metode for å fordele saker til saksbehandlere, er å plassere nye saker i **Saker** > **Ufordelte saker**. Saksbehandlerne må deretter overta sakene manuelt.

Du har imidlertid også mulighet til å opprette et intelligent køsystem for håndtering av nye saker. Da kan saksbehandlerne klikke på **Hent neste sak i køen** under **Saker** for å overta neste sak i køen. Sakene i køen filtreres etter [kategori][2], slik at brukerne kun blir tildelt saker som tilhører kategorier de er medlem av.

## Hvordan prioriteres sakene i køen?

Rekkefølgen på sakene i køen bestemmes av tidsfristen for hver enkelt sak. Sakene som har tidsfrist nærmest i tid, plasseres først i køen. Tidsfristen beregnes ut fra hvilke prioriteter som er angitt for person, firma, e-postkasse, e-postfilter og standardprioritet.

Dette sikrer at sakene blir prioritert i en logisk og rettferdig rekkefølge.

> [!NOTE]
> Det er også mulig å bruke en kombinasjon av køsystem og fordelingsmetode. Saker kan for eksempel plasseres i køen eller fordeles til brukerne basert på hvilken kategori sakene tilhører.

## Hvilke saker kan hentes fra køen?

Følgende faktorer bestemmer hvilke saker en saksbehandler kan hente fra køen:

* Sakene må ha en saksstatus med **Køstatus** aktivert.
* Sakene må ha en kategori hvor saksbehandleren er medlem.
* Sakseier må være **Uten tildeling**.

## Opprette ny saksstatus "I kø"

Først skal vi opprette en ny saksstatus: **I kø**. Nye saker skal automatisk tilordnes denne saksstatusen.

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Velg **Saker** > **Saksstatus**.

1. Klikk på **Legg til**-knappen.

1. I feltet **Navn** angir du et beskrivende navn på saksstatusen. For eksempel "I kø".

1. I listeboksen **Intern status** velger du **Åpen**.

1. Merk av for **Standard**, slik at alle nye saker (aktive saker) som standard tilordnes denne saksstatusen.

1. Merk av for **Køstatus**. Brukerne kan nå få saker med denne statusen fra køen.

    > [!NOTE]
    > Dette betyr ikke at disse sakene MÅ hentes fra køen. Vi skal bruke kategorier til å bestemme hvilke saker som skal plasseres i køen, og hvilke saker som skal fordeles etter fordelingsmetoden for kategorien.

1. Du behøver ikke å merke av for **Opprett ny sak ved kundesvar**.

1. I listen **Registrer tid som** velger du **I kø**.

1. Klikk på **Lagre**.

Den nye saksstatusen vises i listen, og det er et merke i kolonnene **Standard** og **Køstatus**.

## Bruke kategorier til å plassere saker i køen

Nå må du sørge for at du er medlem av den/de kategorien(e) du skal håndtere. I tillegg må vi angi at saker som tilhører disse kategoriene, ikke skal fordeles i henhold til fordelingsmetoden.

> [!NOTE]
> Medlemskap i kategorier kan også defineres på gruppenivå. I Innstillinger og vedlikehold (**Brukere** > **Brukergrupper**) kan du angi kategorier for de ulike brukergruppene.

**Trinn:**

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Velg **Saker** > **Kategorier**.

1. Klikk på ønsket kategorinavn. Du kommer til bildet **Egenskaper for kategori**.

1. Velg fanen **Medlemmer**.

1. Velg deg selv i listen **Bruker**, og klikk på ![ikon][img1] for å legge til deg selv som medlem av kategorien.

1. Legg til eventuelle andre brukere som medlemmer av denne kategorien.

1. Velg fanen **Fordelingsmetode**, og velg **Ikke fordel**. Saker i denne kategorien blir nå ikke fordelt til brukere i henhold til fordelingsmetoden.

1. Klikk på **Lagre**.

Gjenta eventuelt denne fremgangsmåten for andre kategorier som skal kunne hentes fra køen. Kategorier som følger en fordelingsmetode, vil bli tildelt en bruker og vil dermed ikke havne i køen.

## Angi ny status for sak som hentes fra køen

Når du har hentet en sak fra køen, må statusen for saken endres fra **I kø** til **Åpen** (eller en annen aktiv status som indikerer at saken er under behandling). Dette håndteres som regel automatisk.

## Kontrollere at køen fungerer

Opprett en ny sak, sett **Eier** til **Uten tildeling**, velg kategorien du er medlem av, og sett **Status** til **I kø**. Prøv deretter å klikke på **Saker** > **Hent neste sak i køen**.

<!-- Referenced links -->
[2]: category/index.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-add.png
