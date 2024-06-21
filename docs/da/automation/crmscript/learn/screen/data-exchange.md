---
uid: help-da-data-exchange
title: Data Exchange
description: Data Exchange
author: SuperOffice RnD
date: 06.29.2022
keywords: Tjeneste, Data Exchange
topic: reference
audience: settings
audience_tooltip: Settings and maintenance
language: da
envir: onsite
---

# Data Exchange (kun ONSITE)

[!include[Requirement](../../../../learn/includes/req-expander-services.md)]

Dette område anvendes til at konfigurere eventuelle databaseintegrationer mellem systemet og andre datakilder.

## Agenter

Dette skærmbillede indeholder en liste over eventuelle eksisterende dataudvekslingsagenter (databaseintegrator). SuperOffice Service kan forbindes til en eller flere agenter for at synkronisere med andre databaser.

| Element | Beskrivelse |
|---|---|
| Ny agent | Bruges til at oprette en ny agent. |
| Navn | Viser navnet på agenten. |
| Protokol | Viser, hvilken protokol der skal anvendes. |

## Egenskaber for agent

I dette skærmbillede kan du få vist egenskaberne for en Data Exchange agent.

| Element | Beskrivelse |
|---|---|
| Redigere agent | Bruges til at redigere egenskaberne for en agent. |
| Ny agentopgave | Bruges til at oprette en ny agent. |
| Redigering af felter | Bruges til at tilføje felter, som kun skal være læsbare i SuperOffice Service. |
| Agent | Her finder du forskellige egenskaber for agenten. |
| Navn | Navn på Data Exchange agenten. |
| Protokol | Angiv hvilken kommunikationsprotokol, der skal anvendes for Data Exchange agenten. |
| Sti/URL | Den filsti eller webadresse, der anvendes til at kommunikere med Data Exchange agenten. |
| Parametre | De parametre, der kan anvendes af CRMScript eller af Data Exchange agenten. |
| Opgaver | Her finder du en oversigt over alle registrerede opgaver for denne agent. Der vises desuden statusoplysninger for opgaven. Klik på en opgave for at redigere den. |
| Felter | Her vises alle felter, der ikke skal være redigerbare i SuperOffice Service på grund af en Data Exchange integration. Klik på **Rediger felt**, hvis du vil tilføje et nyt felt. |

## Redigere agent

I dette skærmbillede kan du redigere egenskaberne for en ny eller eksisterende Data Exchange agent. Du kan også oprette tidsplaner for, hvor ofte agenten skal aktiveres.

| Element | Beskrivelse |
|---|---|
| Navn | Navn på Data Exchange agenten. |
| Protokol | Angiv hvilken kommunikationsprotokol, der skal anvendes for Data Exchange agenten. |
| Sti/URL | Den filsti eller webadresse, der anvendes til at kommunikere med Data Exchange agenten. |
| Parametre | De parametre, der kan anvendes af CRMScript eller af Data Exchange agenten. |
| OK (Alt-O) | Klik på denne knap for at gemme. |
| Annuller | Klik på denne knap for at annullere. |
| Slet | Klik på denne knap for at slette. |
| Anvend | Vælg at bruge disse indstillinger. |

## Egenskaber for agenttidsplan

I dette skærmbillede kan du redigere egenskaberne for Data Exchange agentens tidsplan. Her kan du vælge, hvor ofte agenten skal synkroniseres med SuperOffice.

| Element | Beskrivelse |
|---|---|
| Navn | Her kan du angive navnet på tidsplanen. |
| ejScript/CRMScript | Her kan du vælge det CRMScript, som tidsplanen aktiverer. |
| Parametre | De parametre, der kan anvendes af CRMScript eller af Data Exchange agenten. |
| OK (Alt-O): Klik på denne knap for at gemme. |
| Annuller | Klik på denne knap for at annullere. |
| Slet | Klik på denne knap for at slette. |
| Nulstil | Hvis agentopgaven ikke stopper, kan du klikke på denne knap for at nulstille den. |
| Stop | Klik på denne knap for at stoppe agentopgaven. |
| Anvend | Klik på denne knap for at anvende indstillingerne. |

## Egenskaber for agentfelt

I dette skærmbillede kan du redigere egenskaberne for et felt, der er knyttet til en agent. De felter, der vises, vil kun være læsbare ved brug af SuperOffice Service.

| Element | Beskrivelse |
|---|---|
| Feltnavne | Liste med navn på databasefelt, der kun skal kunne læses i brugerfladen. f.eks. cust_company.name. |

<!-- Referenced links -->

<!-- Referenced images -->
