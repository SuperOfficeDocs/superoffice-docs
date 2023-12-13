---
uid: help-da-time-zones
title: Tidszoner
description: Tidszoner
author: SuperOffice RnD
so.date: 07.04.2022
keywords: CRM
so.topic: concept
language: da
---

# Tidszoner

SuperOffice CRM understøtter opfølgninger i forskellige tidszoner. Du kan se, at tidszoner er aktiveret, ved at toppanelet indeholder en liste, hvor du kan vælge ønsket tidszone, nederst til venstre i kalenderen (flag og land).

> [!NOTE]
> Brug af tidszoner skal aktiveres pr. land i Indstillinger og vedligeholdelse (under **Indstillinger** > **Tidszoner**). Derudover kan du gå til **Præferencer** for at få vist tidszonevælgeren og angive standardtidszonen. Der findes også mere hjælp til, hvordan tidszoner oprettes.

## Hvordan fungerer tidszoner i SuperOffice CRM?

Tidszonefunktionaliteten kan være nyttig, hvis firmaet har kontorer i flere lande med forskellige tidszoner, og du skal planlægge møder eller telefonkonferencer med nogen, som arbejder i et land med en anden tidszone end dit eget land. Opfølgingen oprettes i så fald i den tidszone, som svarer til det land, du har valgt.

Hvis dit hovedkontor f.eks. ligger i Danmark, og du skal have et møde med personer i datterselskaberne, som befinder sig i Finland og USA, kan du oprette mødetidspunkterne med dansk tid og derefter kontrollere, hvornår det er i amerikansk og finsk tid. På den måde kan du f.eks. undgå at oprette et møde, som foregår midt om natten amerikansk tid. Hos dem, du inviterer til mødet, vises mødet i den tidszone, de har angivet i deres egen SuperOffice CRM-klient, selvom du har oprettet mødet i dansk tid.

Funktionen understøtter sommertid.

> [!NOTE]
> Opfølginger, som du har oprettet, før du aktiverede tidszoner, bevares i den tidszone, som er standard for din SuperOffice-database.

## Hvordan vælger du tidszoner?

Tidszoner vises i form af en liste i [Dagbogen][1] og for [opfølgninger][3]. Den tidszone, som er standard for din SuperOffice-database, vises øverst med dette ikon: ![ikon][img1].

Tidszonelisten er sorteret efter land. Øverst i tidszonelisten finder du navnet på det valgte land med flag.

## Søge efter land og byer

Brug det øverste felt med det valgte land med flag som et søgefelt. Du kan søge efter både land og større byer, forudsat at byen er med i tidszonedataene. Hvis du f.eks. ikke ved, hvilken tidszone Canberra befinder sig i, kan du søge efter Canberra, og du får så den aktuelle tidszone i Australien op på listen.

1. Sæt musemarkøren i landefeltet.
2. Indtast navnet på den by eller det land, som du vil kende tidszonen for.
3. Når du har fundet den ønskede by eller det ønskede land, skal du klikke på posten for at aktivere den ønskede tidszone.

## Søge på antal timer

Ved at søge på antal timer for at finde den rigtige tidszone. Hvis du for eksempel indtaster +3 vises alle de tidszoner, som ligger tre timer efter den angivne tidszone i SuperOffice CRM.

> [!NOTE]
Navnene på regioner i tidszonevælgeren vil altid være på engelsk, mens navne på lande afhænger af sprogindstillingerne i SuperOffice CRM. Vær opmærksom på dette, når du søger efter lande og regioner.

## Nyttige tip om tidszoner

* Hvis du holder musemarkøren over tidszonelisten, vises der en infoboks med oplysninger om, hvilke større byer (i det aktuelle land) der indgår i den valgte tidszone.

* Hvis du holder musemarkøren over en opfølging i dagbogen, som er oprettet i en anden tidszone, end den som er standard for din SuperOffice-database, vises der en infoboks med oplysninger om tidspunktet for opfølgingen i din tidszone og i tidszonen for den person, som har oprettet den.

<!-- Referenced links -->
[1]: ../../diary/learn/index.md
[3]: ../../diary/learn/follow-ups.md

<!-- Referenced images -->
[img1]: ../../../media/icons/time-zone-local.png
