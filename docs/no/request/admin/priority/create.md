---
uid: help-no-request-priority-create
title: Opprett saksprioritet
description: Opprett saksprioritet
keywords: opprett saksprioritet, legg til saksprioritet, ny saksprioritet, ny prioritet, saksprioritet, eskalering, sak, prioritet
author: Hanne Gunnarsson
date: 02.05.2025
version: 10.5.1
topic: howto
license: serviceessentials
audience: settings
audience_tooltip: Innstillinger og vedlikehold
language: no
---

# Opprett saksprioritet

Standardprioritetene som følger med systemet, er **Høy**, **Medium** og **Lav**. Du kan imidlertid både opprette nye prioriteter og redigere innstillingene for eksisterende prioriteter.

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

## Trinn

1. I **Innstillinger og vedlikehold**, gå til **Saker** i navigatoren og velg fanen **Prioriteter**.

1. Klikk på **Legg til**.

1. Skriv inn et beskrivende navn i feltet **Prioritetsnavn**.

1. I fanen **Egenskaper**, angi følgende informasjon:

    * Ekstern
    * Bruk som standard
    * Tidsfrist
    * Slettet

    For mer informasjon om hvert felt, se [Prioritetsinnstillinger](#priority-settings).

1. Under **Tidsramme**, spesifiser hvilken tidsramme som skal gjelde for saksbehandlingen.

    * Angi tidsintervaller for hver ukedag.

    * Valgfritt: Skriv inn dager som skal ekskluderes i feltet **Helligdager (dag/måned)**. Velg **Inkluder år** for å inkludere året i disse datoene.

1. I fanen **Eskaleringshendelser**, spesifiser hvordan eskaleringskjeden skal håndtere ulike hendelser i saken. Alternativer:

    * Sak lest av eier
    * Byttet eier (manuelt)
    * Ny informasjon
    * Sak avsluttet
    * Byttet prioritet

        > [!NOTE]
        > Hvis du velger **Fortsett**, fortsetter saken på samme nivå i eskaleringskjeden som før endringen. Med andre ord brukes ikke tidsrammen på nytt ved endring, bare nivået beholdes.

    * Ny sak
    * Eskalere saker i henhold til tidsramme

    For mer informasjon om hvert alternativ, se [Alternativer for eskalering](#escalation-options).

1. Klikk på **Lagre**. Prioriteten opprettes. Nå kan du for eksempel [knytte eskaleringsnivåer til denne prioriteten][1].

## <a id="priority-settings"></a>Prioritetsinnstillinger

| Innstilling | Beskrivelse |
|---|---|
| Navn | Et beskrivende navn på prioriteten. |
| Slettet | Er prioriteten aktiv (normal) eller slettet (utilgjengelig).|
| Eksterne | Hvis du merker av her, vil prioriteten være tilgjengelig fra SuperOffice Kundesenter. |
| Bruk som standard | Hvis du merker av her, er det denne prioriteten som velges som standard. |
| Tidsfrist | Tidsfristen saker med denne prioriteten skal ha. Denne verdien beregnes ut fra tidsrammen for prioriteten og lagres for hver sak. Resultatet angir når sakens tidsramme går ut. |
| Tidsramme | Tidsintervaller for hver ukedag som gjelder for saksbehandling. |
| Helligdager (dag/måned) | Dager som skal utelates fra tidsrammen. Dette brukes vanligvis til feriedager der det ikke er ønskelig at saker skal eskalere. Formatet er en kommadelt liste med dag/måned. Hvis du f.eks. vil ekskludere 25. og 26. desember, skriver du inn følgende: 25/12, 26/12. Du kan også legge til datoer ved hjelp av datofeltet nedenfor. |
| Inkluder år | Her inkluderer du året i feriedatoene. |
| Eskalere saker i henhold til tidsramme | Hvis det er merket av her, eskaleres saker med denne prioriteten bare i løpet av prioritetens definerte tidsramme. Utenfor periodene som er definert i fanen **Tidsramme** blir eskaleringen "frosset". |

## <a id="escalation-options"></a>Alternativer for eskalering

| Alternativ | Beskrivelse |
|---|---|
| Sak lest av eier | Hvis du merker av her, styres eskaleringskjeden som angitt i listeboksen til høyre, når en sak leses av eieren. I alle listeboksene i denne fanen kan du velge mellom operasjonene: **Stopp**, **Fortsett** og **Omstart**. |
| Byttet eier (manuelt) | Hvis du merker av her, styres eskaleringskjeden som angitt i listeboksen til høyre, når en sak bytter eier manuelt. |
| Ny informasjon | Hvis du merker av her, styres eskaleringskjeden som angitt i listeboksen til høyre, når det kommer ny informasjon i en sak. Kunden eller brukeren legger for eksempel til en ny melding i saken. |
| Sak avsluttet | Hvis du merker av her, styres eskaleringskjeden som angitt i listeboksen til høyre når en sak avsluttes. |
| Byttet prioritet | Hvis det er merket av her, styres eskaleringskjeden som angitt i listeboksen til høyre når prioriteten for en sak byttes med denne prioriteten. |
| Ny sak | Hvis du merker av her, styres eskaleringskjeden som angitt i listeboksen til høyre når en ny sak med denne prioriteten kommer inn i systemet. |

## Relatert innhold

* [Opprett eskaleringsnivå][1]

<!-- Refererte lenker -->
[1]: escalation-levels.md
