---
uid: help-da-request-next-in-queue
title: Hent næste sag i køen
description: Hent næste sag i køen
keywords: hent næste sag i køen, sag
author: Hanne Gunnarsson
date: 03.07.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice Service
language: da
---

# Sådan konfigurerer du Hent næste sag i køen

I SuperOffice tildeles sager normalt til brugere efter en fordelingsmetode. En anden metode til at tildele sager til sagsbehandlere er at placere nye sager i **Sager** > **Ikke fordelte sager**. Sagsbehandlerne skal derefter acceptere sagerne manuelt.

Det er dog også muligt at oprette et intelligent køsystem til håndtering af nye sager. Sagsbehandlere kan derefter klikke på **Hent næste sag i køen** under **Sager** for at acceptere den næste sag i køen. Sager i køen filtreres efter [kategori][2], således at brugere kun tildeles sager, der tilhører kategorier, som de er medlemmer af.

## Hvordan prioriteres sager i køen?

Rækkefølgen af sager i køen bestemmes af tidsfristen for hver enkelt sag. Sager med de tætteste tidsfrister kommer først i køen. Tidsfristen beregnes på baggrund af prioriteter, der er defineret for person, firma, e-mail-konto, e-mail-filter og standardprioritet.

Det sikrer, at sager prioriteres højere i en logisk og retfærdig rækkefølge.

> [!NOTE]
> Det er også muligt at bruge en kombination af et køsystem og en fordelingsmetode. Sager kan for eksempel placeres i køen eller tildeles til brugere på baggrund af, hvilken kategori af sager, de tilhører.

## Hvilke sager kan hentes fra køen?

Følgende faktorer bestemmer, hvilke sager en sagsbehandler kan få fra køen:

* Sagerne skal have en sagsstatus med **Køstatus** aktiveret.
* Sagerne skal have en kategori, som sagsbehandleren er medlem af.
* Sagens ejer skal være **Ufordelt**.

## Opret ny sagsstatus "I kø"

Først opretter vi en ny sagsstatus: **I kø**. Nye sager skal automatisk tildeles denne sagsstatus.

1. [!include[Gå til](../../learn/includes/goto-sm.md)]

1. Vælg **Sager** > **Sagsstatus**.

1. Klik på knappen **Tilføj**.

1. I feltet **Navn** skal du angive et beskrivende navn for sagsstatussen. For eksempel "I kø".

1. I rullelisten **Intern status** skal du vælge **Aktiv**.

1. Markér **Standard**, så alle nye sager (aktive sager) som standard tildeles denne status.

1. Markér **Køstatus**. Brugerne kan nu hente sager med denne status fra køen.

    > [!NOTE]
    > Det betyder ikke, at disse sager SKAL hentes fra køen. Vi bruger kategorier til at bestemme, hvilke sager der skal placeres i køen, og hvilke sager der skal tildeles efter kategoriens fordelingsmetode.

1. Du behøver ikke at markere **Opret ny sag ved kundesvar**.

1. I listen **Registrer tid som** skal du vælge **I kø**.

1. Klik på **Gem**.

Den nye sagsstatus vises nu i listen, og der er markering i kolonnerne **Standard** og **Køstatus**.

## Brug kategorier til at placere sager i køen

Nu skal du sikre dig, at du er medlem af den eller de kategorier, du skal håndtere. Vi skal også specificere, at sager, der tilhører disse kategorier, ikke bør tildeles via fordelingsmetoden.

> [!NOTE]
> Medlemskab af kategorier kan også defineres på gruppeniveau. I Indstillinger og vedligeholdelse (**Brugere** > **Brugergrupper**) kan du angive kategorier for de forskellige brugergrupper.

**Trin:**

1. [!include[Gå til](../../learn/includes/goto-sm.md)]

1. Vælg **Sager** > **Kategorier**.

1. Klik på det ønskede kategorinavn. Du kommer til skærmbilledet **Egenskaber for kategori**.

1. Vælg fanen **Medlemmer**.

1. Vælg dig selv i listen **Bruger**, og klik på **+** for at tilføje dig selv som medlem af kategorien.

1. Tilføj eventuelle andre brugere som medlemmer af denne kategori.

1. Vælg fanen **Fordelingsmetode**, og vælg **Fordel ikke**. Nu vil sager i denne kategori ikke tildeles brugere automatisk.

1. Klik på **Gem**.

Gentag om nødvendigt denne fremgangsmåde for andre kategorier, der skal kunne hentes fra køen. Kategorier, der følger en fordelingsmetode, tildeles en bruger og kommer derfor ikke i køen.

## Definer ny status for sager, der er hentet fra køen

Når du har hentet en sag fra køen, skal status ændres fra **I kø** til **Aktiv** (eller en anden aktiv status, der angiver, at sagen behandles). Dette er håndteres normalt automatisk.

## Kontroller, at køen fungerer

Opret en ny sag, indstil **Ejer** til **Ufordelt**, vælg den kategori, du er medlem af, og indstil **Status** til **I kø**. Prøv derefter at klikke på **Sager** > **Hent næste sag i køen**.

<!-- Referenced links -->
[2]: category/index.md
