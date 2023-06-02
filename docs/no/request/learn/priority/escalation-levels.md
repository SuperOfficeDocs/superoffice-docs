---
uid: help-no-request-escalation
title: Eskaleringsnivå
description: Eskaleringsnivå
author: Hanne Gunnarsson
so.date: 03.29.2023
keywords: sak, prioritet, eskalere
so.topic: howto
language: no
---

# Eskaleringsnivå

Til hver saks**prioritet** kan du definere ett eller flere eskaleringsnivåer, slik at systemet sender henvendelsen videre i organisasjonen dersom den ikke er blitt lest eller behandlet innen en viss tid.

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

## Slik definerer du nye nivåer

1. Klikk på **Saker**-knappen i navigatoren, og velg fanen **Prioriteter**.

1. Velg en prioritet du vil opprette eskaleringsnivåer for.

1. Velg fanen **Eskaleringsnivåer**.

1. Klikk på **Legg til**-knappen. Du oppretter nå det første eskaleringsnivået.

1. Angi følgende informasjon:

    * **Inntreffer etter**
    * **Fordel på nytt til**
    * **Kjør skript**

    Detaljer om hvert felt er angitt nedenfor.

1. Under **Send svarmal** kan du definere hvem som skal motta en e-post og SMS når dette eskaleringsnivået utløses.

    Merk av for **E-post** eller **SMS** ved siden av hver mottaker, og velg den relevante svarmalen. Hvis du velger **Andre**, må du angi de relevante e-postadressene (bruk komma) og telefonnumrene i feltene nedenfor.

    > [!NOTE]
    > Hvis fanen **Send svarmal på SMS** ikke vises, betyr det at SMS ikke er aktivert for lisensen du bruker. Ta kontakt med systemansvarlig hvis du ønsker mer informasjon.

1. Klikk på **Lagre**.

1. Gjenta disse trinnene for å opprette flere eskaleringsnivåer.

1. Hvis du har opprettet flere eskaleringsnivåer, kan du definere i hvilken rekkefølge de skal aktiveres. Du gjør dette ved hjelp av pilknappene under listen over eskaleringsnivåer.

## Innstillinger for eskalering

| Innstilling | Beskrivelse |
|---|---|
| Prioritet | Prioriteten du vil knytte eskaleringsnivået til. |
| Inntreffer etter | Hvor lang tid som må gå før dette eskaleringsnivået aktiveres. Hvis det er angitt for prioriteten at eskaleringen skal følge tidsrammen, vil det påvirke dette tidspunktet. En prioritet med tidsramme fra mandag til fredag, 09.00 til 17.00, og første eskaleringsnivå etter 2 timer, vil for eksempel eskaleres mandag kl. 10.00 hvis saken ble registrert fredag kl. 16.00. |
| Fordel på nytt til | Hvis du vil at saken skal sendes til en annen bruker når dette eskaleringsnivået inntreffer, kan du merke av her. Deretter velger du ønsket bruker i listen. |
| Kjør skript | Hvis du vil at det skal kjøres et skript når dette eskaleringsnivået inntreffer, kan du merke av her. Deretter velger du ønsket skript i listen. |

## Innstillinger for svarmal

| Innstilling | Beskrivelse |
|---|---|
| Person | Hvis du merker av her, sendes svarmalen som er angitt i feltet til høyre, til personen som er tilknyttet saken, når dette eskaleringsnivået inntreffer. Velg ønsket svarmal i listen. |
| Sakseier | Hvis du merker av her, sendes svarmalen som er angitt i feltet til høyre, til eieren av saken, når dette eskaleringsnivået inntreffer. Velg ønsket svarmal i listen. |
| Kategorisjef | Hvis du merker av her, sendes svarmalen som er angitt i feltet til høyre, til kategorisjefen når dette eskaleringsnivået inntreffer. Velg ønsket svarmal i listen. |
| Andre | Hvis du merker av her, sendes svarmalen som er angitt i feltet til høyre, til e-postadressen(e) som er angitt i feltet nedenfor. Velg ønsket svarmal i listen. |
| E-postadresse | Her skriver du inn e-postadressen som svarmalen i feltet **Andre** skal sendes til. Du kan legge inn flere adresser ved å sette komma mellom dem. |

## Slette eskaleringsnivåer

1. Velg eskaleringsnivået du vil slette.
2. Klikk på **Slett**-knappen nederst i bildet.

<!-- Referenced images -->
