---
uid: help-da-custom-objects
title: Brugerdefinerede objekter og felter
description: Brugerdefinerede objekter
keywords: brugerdefinerede objekter, udef, ekstrafelt, ekstra tabel, tilpassede felter
author: Bergfrid Dias
date: 05.28.2026
version: 11
content_type: concept
tier: core
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Brugerdefinerede objekterog felter

Alle firma og organisationer har deres egne krav til de oplysninger, de skal registrere vedrørende deres kunder, salg, projekter, kontrakter og så videre. Administratorer kan tilføje felter og tabeller i SuperOffice for at tilpasse typen information, der kan registreres.

SuperOffice CRM og Service var engang to separate applikationer med forskellige udvidelsesmuligheder. [**Brugerdefinerede felter**][1] (kaldet udefs) hører til i SuperOffice CRM, mens [**ekstra tabeller**][3] (også kaldet tredjepartstabeller) og [**ekstra felter**][2] hører til i Service. Begrebet **tilpasset felt** inkluderer både brugerdefinerede felter og ekstra felter.

## Anvendelse

* Et godt eksempel på et brugerdefineret felt, du kan bruge på kortet **Person**, er et felt kaldet "Tilfreds kunde", hvor værdien af feltet er Ja eller Nej. Du kan f.eks. sende dine kontakter en e-mail (med linkhandling), hvor de kan angive, om de er tilfredse med dine tjenester. Dette giver dig værdifuld indsigt i den generelle kundetilfredshed.

* Ved hjælp af funktionen **Find** kan du søge efter de oplysninger, du registrerer i brugerdefinerede felter, og oprette udvalg. Hvis du f.eks. registrerer udløbsdatoen for vedligeholdelsesaftalen, du har med kontakter, kan du oprette et dynamisk udvalg, der viser kontakter, hvor aftalen udløber om mindre end en måned.

* Du kan genbruge oplysningerne fra disse felter i dokumenter og e-mails som **skabelonvariabler**. Hvert felt, du tilføjer, får sin egen unikke ID (Prog ID), som kan bruges i dokumenter til at flette person-specifik information. Så hvis du vil sende en e-mail til dine kunder, der siger, at deres vedligeholdelsesaftale udløber snart, kan du bruge skabelonvariablen for udløbsdato til at vise den korrekte udløbsdato for deres aftale i meddelelsen.

## Krav

[!include[License requirement](../../includes/req-dev-tools-transition.md)]

> [!NOTE]
> **CRM Suite (Growth-plan):** Din plan inkluderer en grænse for antallet af brugerdefinerede objekter. Når grænsen er nået, er oprettelse af yderligere objekter blokeret. Se [Plangrænser][13] for detaljer.

Felter vises automatisk på [fanen Mere][12], når de er tilføjet.

## Layout (placering af felter)

Eventuelle brugerdefinerede skærmlayouts (oprettet i Skærmdesigneren) kan tilsidesætte indstillingerne for individuelle brugerdefinerede felter.

Hvis du ikke har **Core**-planen, skal du bruge rækkefølgen af de forskellige felter for at sortere dem på fanen **Mere**.

## Relateret indhold

* [Brugerdefinerte felt][1]
* [Ekstrafelt][2]
* [Ekstra tabeller][3]

<!-- Referenced links -->
[1]: udef.md
[2]: extra-field.md
[3]: extra-table.md
[5]: ../../customization/screen-designer/admin/index.md
[6]: ../../../en/ui/blogic/custom-screens/index.md
[12]: more-tab.md
[13]: ../../admin/license/crm-suite.md
