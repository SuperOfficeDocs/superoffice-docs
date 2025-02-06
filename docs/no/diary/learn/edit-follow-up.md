---
uid: help-no-follow-up-edit
title: Redigere oppfølging
description: Hvordan åpne, redigere eller slette en oppfølging; endre sluttidspunktet for en oppfølging i dagboken; redigere eller slette invitasjon; redigere repeterende oppfølging.
keywords: redigere oppfølging, oppdatere oppfølging, forlenge møte, forkorte møte, endre kun denne forekomsten, slette oppfølging, avlyse møte, dagbok, oppfølging, avtale, møte, oppgave, gjøremål, samtale, telefon, invitasjon, gjenta
author: Bergfrid Dias
date: 02.05.2025
version: 10.5.2
topic: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Redigere oppfølging

[!include[Note](includes/note-edit-followup.md)]

Hvis du redigerer tid, dato eller sted for en oppfølging – eller sletter en invitasjon du har opprettet og sendt – vil de inviterte motta et varsel om dette.

## Trinn

1. Åpne en eksisterende oppfølging ved å dobbeltklikke på den:

    * I detaljkortet **Aktiviteter** i skjermbildet Firma, Person, Dagbok, Prosjekt eller Salg.
    * Eller, på de ulike fanene i dagboken.

2. [Gjør ønskede endringer i dialogboksen.][3]

    [!include[Recurrence](includes/note-repetition.md)]

3. Klikk på **Lagre**.

> [!NOTE]
> Du kan ikke redigere utførte oppfølginger før du har deaktivert statusen **Utført**.

## <a id="change-end"></a>Endre sluttidspunktet for en oppfølging i dagboken

I dagboken kan du endre sluttidspunktet for en oppfølging uten å åpne den:

1. Klikk på oppfølgingen i fanen **Dag**, **Uke** eller **Oversikt**.
2. Hold musepekeren over nedre kant av oppføringen. Pekeren endres til en dobbeltpil.
3. Klikk og hold, og dra deretter kanten opp eller ned for å justere varigheten. Oppdatert sluttidspunkt vises mens du drar.
4. Slipp museknappen for å lagre endringen.

> [!NOTE]
> Du kan også endre tidsrommet ved å åpne oppfølgingen og justere feltene **Start**, **Slutt**, **Frist** eller **Varighet**.

## <a id="repeat"></a>Redigere repeterende oppfølging

Endringer fungerer på samme måte som når du redigerer oppfølginger, men når du gjør en endring, vises dialogboksen **Repeterende oppfølginger**.

![Repeterende oppfølging-dialog -screenshot][img1]

* Hvis du velger **Endre bare denne forekomsten**, vil endringen ikke påvirke andre tidspunkter.
* Hvis du velger **Endre alle fremtidige forekomster inkludert denne**, vil endringen gjelde for denne og alle fremtidige repetisjoner.

Du kan kun endre startdatoen mens du ser på detaljene for repetisjon. For å endre tidspunktet, klikk **OK** eller **Avbryt** for å gå tilbake til oppfølgingsdetaljene.

Hvis du endrer regelen midt i en serie møter, opprettes en ny regel, og den gamle avsluttes ved bruddpunktet.

Hvis du endrer starttidspunktet for ett møte, påvirkes ikke regelen. Møtet behandles som et unntak, men kan justeres tilbake i linje med resten av møtene.

[!include[Caution](includes/caution-do-not-change-recurring-date.md)]

## <a id="delete"></a>Slette oppfølging via dagboken

* Hvis du sletter en oppfølging du er invitert til, fjernes den kun fra din dagbok.
* Hvis du sletter en invitasjon du eier, fjernes oppfølgingen også fra dagbøkene til de inviterte.

1. Velg ønsket oppfølging.
2. Høyreklikk og velg **Slett**.
3. Klikk **Ja** for å bekrefte slettingen eller **Nei** for å beholde oppfølgingen.

[!include[Deleting items](../../learn/includes/tip-deletion.md)]

## Relatert innhold

* [Endre Utført-status for en aktivitet][2]
* [Stoppe repeterende oppfølginger][5]
* [Legg til kobling til dokument, salg, prosjekt eller nettsted][6]

<!-- Refererte lenker -->
[2]: change-completed-status.md
[3]: create-follow-up.md#fields
[5]: recurrence/stop.md
[6]: ../../learn/basics/links.md

<!-- Refererte bilder -->
[img1]: ../../../media/loc/en/diary/change-repeating-fo.png
