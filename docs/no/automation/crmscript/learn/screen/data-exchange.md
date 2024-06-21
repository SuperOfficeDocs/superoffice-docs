---
uid: help-no-data-exchange
title: Data Exchange
description: Data Exchange
author: SuperOffice RnD
date: 06.29.2022
keywords: Tjeneste, Data Exchange
topic: reference
audience: settings
audience_tooltip: Settings and maintenance

language: no
envir: onsite
---

# Datautveksling (bare ONSITE)

[!include[Requirement](../../../../learn/includes/req-expander-services.md)]

Dette området brukes til å konfigurere databaseintegrasjon mellom systemet og andre datakilder.

## Agent

Dette bildet inneholder en liste over eksisterende Data Exchange-agenter (databaseintegrator). SuperOffice Service kan kobles til én eller flere agenter for å synkronisere med andre databaser.

| Element | Beskrivelse |
|---|---|
| Ny agent | Brukes til å opprette en ny agent. |
| Navn | Viser agentnavnet. |
| Protokoll | Viser kommunikasjonsprotokollen som brukes for å koble til agenten. |

## Egenskaper for agent

Dette bildet viser egenskapene til en Data Exchange-agent.

| Element | Beskrivelse |
|---|---|
| Redigere agent | Brukes til å redigere agentegenskapene. |
| Ny agentoppgave | Brukes til å opprette en ny agentoppgave. |
| Rediger felt | Brukes til å angi felt som skal være skrivebeskyttet i SuperOffice Service. |
| Agent | Dette vinduet viser ulike egenskaper for agenten. |
| Navn | Navn på Data Exchange-agenten. |
| Protokoll | Velg protokollen som skal brukes til å kommunisere med Data Exchange-agenten. |
| Bane/URL | Bane eller nettverksadressen som skal brukes til å kommunisere med Data Exchange-agenten. |
| Parametere | Parametere som brukes av CRMScript eller Data Exchange-agenten. |
| Oppgaver | I dette vinduet vises alle registrerte oppgaver for denne agenten. Statusen for hver oppgave vises også. Klikk på en oppgave for å redigere den. |
| Felt | Viser alle felt i SuperOffice Service som ikke kan redigeres. Klikk på **Rediger felt** for å legge til et nytt felt. |

## Redigere agent

I dette bildet kan du redigere egenskapene til en ny eller eksisterende Data Exchange-agent. Du kan også opprette tidsplaner for å aktivere agenten ved gitte intervaller.

| Element | Beskrivelse |
|---|---|
| Navn | Navn på Data Exchange-agenten. |
| Protokoll | Velg protokollen som skal brukes til å kommunisere med Data Exchange-agenten. |
| Bane/URL | Bane eller URL som skal brukes til å kommunisere med Data Exchange-agenten. |
| Parametere | Parametere som brukes av CRMScript eller Data Exchange-agenten. |
| OK (Alt-O) | Klikk på denne knappen for å lagre. |
| Avbryt | Klikk på denne knappen for å avbryte. |
| Slett | Klikk på denne knappen for å slette. |
| Bruk | Velg for å bruke disse innstillingene. |

## Egenskaper for agenttidsplan

I dette bildet kan du redigere egenskapene til en ny eller eksisterende tidsplan brukt av en Data Exchange-agent. Her kan du velge hvor ofte agenten skal synkroniseres med SuperOffice.

| Element | Beskrivelse |
|---|---|
| Navn | Her kan du skrive inn navnet på tidsplanen. |
| ejScript/CRMScript | Her kan du velge CRMScript som tidsplanen aktiverer. |
| Parametere | Parametere som brukes av CRMScript eller Data Exchange-agenten. |
| OK (Alt-O): Klikk på denne knappen for å lagre. |
| Avbryt | Klikk på denne knappen for å avbryte. |
| Slett | Klikk på denne knappen for å slette. |
| Tilbakestille | Hvis agentoppgaven ikke stopper, kan du klikke på denne knappen for å tilbakestille den. |
| Stopp | Klikk på denne knappen for å stoppe agentoppgaven. |
| Bruk | Klikk på denne knappen for å bruke innstillingene. |

## Egenskaper for agentfelt

I dette bildet kan du redigere egenskapene til et felt knyttet til en agent. Feltene som vises, er skrivebeskyttet i SuperOffice Service.

| Element | Beskrivelse |
|---|---|
| Feltnavn | En liste over databasefeltnavn som er skrivebeskyttet i grensesnittet, for eksempel 'cust-company.name'. |

<!-- Referenced links -->

<!-- Referenced images -->
