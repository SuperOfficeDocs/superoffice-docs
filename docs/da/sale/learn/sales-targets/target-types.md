---
uid: help-da-sales-target-types
title: Opret en salgsmåltype med undertyper
description: Det kan være stressende at holde styr på dine salgsmål. Men hvis du definerer parametre og dimensioner for dine salgsmål, bliver det meget nemmere at holde styr på dine mål.
author: SuperOffice RnD
date: 02.16.2023
keywords: salg
topic: howto
language: da
---

# Opret en salgsmåltype med undertyper

Det kan være stressende at holde styr på dine salgsmål. Men hvis du definerer parametre og dimensioner for dine salgsmål, bliver det meget nemmere at holde styr på dine mål.

Du kan tilføje nye måltyper (dimensioner) ud over standardmåltypen **Alle salg – Beløb**.

> [!NOTE]
> Du skal bruge Sales Premium-licensen sammen med Unlimited Sales Target-licensen for at tilføje mere end én brugergruppe og måltype. Hvis du kun har Sales Premium-licens, kan du tilføje én gruppe for måltypen Alle salg – Beløb.

Du skal have den funktionsrettigheden Måladministrator for din rolle for at kunne tilføje, redigere og fjerne måltyper.

## Angiv måltype

For at definere parametrene og dimensionerne skal du først angive en måltype.

Du kan angive en måltype for både brugere og grupper samt angive andre målparametre: Måltype, Måleenhed, Separate mål. Du kan også definere, om den kun skal være tilgængelig på firma- og gruppeniveau (og ikke på brugerniveau).

![Oversigt over de forskellige måltyper og undertyper for et salgsmål -screenshot][img1]

## Tilføj ny måltype

1. Klik på **Tilføj ny måltype**. Eller klik på <i class="ph ph-gear" aria-label="Gear"></i> (**Konfigurer mål**) på fanen for at redigere en eksisterende måltype.

2. Klik på **Måltype** for at vælge den måltype (dimension), du vil bruge.

3. Klik på **Måleenhed** for at vælge den relevante enhed. De tilgængelige enheder afhænger af den valgte måltype. Hvis du har valgt **Kategori** som måltype, kan du f.eks. vælge at måle efter beløb eller antal (antal salg i en kategori).

4. På den næste liste kan du vælge bestemte elementer af den måltype, du har valgt. Hvis du ikke vælger nogen, vil alle blive medtaget. Eksempel: Hvis du har valgt **Kategori** som måltype, kan du vælge de firmakategorier, du vil oprette mål for.

5. Vælg **Kun tilgængelig på firmaniveau og koncernniveau**, hvis denne måltype ikke skal være tilgængelig på brugerniveau, kun på gruppe-/teamniveau og firmaniveau.

6. Klik på **Gem**. Den nye måltype tilføjes som en fane. Du kan nu tilføje mål som beskrevet ovenfor.

> [!NOTE]
> Måltype og måleenhed ikke kan ændres i en eksisterende måltype. Alternativt kan du oprette en ny måltype med de nødvendige indstillinger og derefter slette den gamle.

### Måltyper (parametre)

* Alle salg
* Salgstype
* Salg, kilde
* Salg krediteret
* Salg, konkurrent
* Firma, kategori
* Firma, branche
* Firma, land

Du kan også angive mål for et hvilket som helst af dine egne brugerdefinerede felter, der indeholder lister. Når en måltype er valgt, er det ikke muligt at vælge denne type mål igen for at undgå at oprette dubletter.

### Måleenhed

Du kan måle et salg på forskellige måder. Vælg din foretrukne enhed afhængigt af, hvilke enheder dit firma bruger.

* Beløb
* Antal
* Fortjeneste

### Separate undertyper af mål (dimensioner)

Den tilgængelige liste afhænger af den valgte måltype. For eksempel:

* Hvis måltypen er angivet til Salgstype, viser målundertyperne listen over salgstyper, der er defineret af dit firma.
* Hvis måltypen er indstillet til Kilde, viser målundertyperne listen over salgskilder, der er defineret af dit firma.

Nederst i dialogboksen er der et afkrydsningsfelt for Kun tilgængelig på firmaniveau og koncernniveau. Når du markerer dette afkrydsningsfelt, tilføjes måltypen kun på firma- og gruppeniveau, og de forskellige brugere vises ikke på din målliste.

> [!NOTE]
> Når du har gemt dit nye mål, kan du stadig gå til Indstillinger og ændre listen Separate mål og afkrydsningsfeltet for Kun tilgængelig på firmaniveau og gruppeniveau. Vær opmærksom på, at hvis du først vælger Kun tilgængelig på firmaniveau og gruppeniveau, efter at du har tilføjet tal på brugerniveauet, får du en advarsel om, at brugertallene slettes, når de gemmes.

Når den nye måltype er gemt, er tiden inde til at [tilføje grupper og brugere til dit salgsmål][3].

![Du finder knappen Tilføj grupper og brugere i oversigten over salgsmål -screenshot][img2]

## Filtrer måltyper

Når det kommer til måltyperne med målundertypelisten, kan du klikke på knappen Filtrer og filtrere de forskellige forekomster.

![Klik på knappen Filtrer for at filtrere efter målundertype -screenshot][img3]

## Fjern måltyper

For at slette en måltype skal du klikke på Målindstillinger og derefter klikke på knappen Slet. Husk, at sletning af en måltype er en handling, der ikke kan fortrydes, og denne handling vil slette alle data for måltypen på forrige, gældende og fremtidige år. Det er ikke muligt at slette standardmåltypen Alle salg – Beløb.

## Relateret indhold

* [Brug af salgsmål i dashboardruder][2]

<!-- Referenced links -->
[2]: ../../../dashboard/learn/show-sales-targets.md
[3]: create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/user-targets-new-target-type.png
[img2]: ../../../../media/loc/en/sale/user-targets-add-groups-users.png
[img3]: ../../../../media/loc/en/sale/user-targets-filter-type.png
