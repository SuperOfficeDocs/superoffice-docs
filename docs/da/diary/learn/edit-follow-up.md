---
uid: help-da-follow-up-edit
title: Rediger opfølgning
description: Sådan åbner, redigerer eller sletter du en opfølgning. Rediger sluttidspunkt for en opfølgning i dagbogen. Rediger eller slet en invitation. Rediger gentagen opfølgning.
keywords: rediger opfølgning, opdater opfølgning, forlæng møde, forkort møde, ændr kun denne forekomst, slet opfølgning, annuller møde, dagbog, opfølgning, aftale, møde, opgave, telefonopkald, invitation
author: Bergfrid Dias
date: 02.21.2025
version: 10.5.2
topic: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Rediger opfølgning

[!include[Note](includes/note-edit-followup.md)]

Hvis du redigerer tidspunkt, dato eller sted for en opfølgning – eller sletter en invitation, du har oprettet og sendt – vil de inviterede modtage en besked om dette.

## Trin

1. Åbn en eksisterende opfølgning ved at dobbeltklikke på den:

    * I detaljekortet **Aktiviteter** i skærmbilledet Firma, Person, Dagbog, Projekt eller Salg.
    * Eller på de forskellige faner i skærmbilledet Dagbog.

2. [Foretag de nødvendige ændringer i dialogen.][3]

    [!include[Recurrence](includes/note-repetition.md)]

3. Klik på **Gem**.

> [!NOTE]
> Du kan ikke redigere afsluttede opfølgninger, før du har fjernet deres status **Udført**.

## <a id="change-end"></a>Rediger sluttidspunkt for en opfølgning i Dagbogen

I skærmbilledet Dagbog kan du ændre sluttidspunktet for en opfølgning uden at åbne den:

1. Klik på opfølgningen på fanen **Dag**, **Uge** eller **Oversigt**.

1. Placer musemarkøren over den nederste kant af opfølgningen. Markøren ændres til en dobbeltpil.

1. Klik og hold nede, og træk den nederste kant op eller ned for at justere opfølgningens varighed. Det opdaterede sluttidspunkt vises, mens du trækker.

1. Slip museknappen for at anvende ændringen.

> [!NOTE]
> Du kan også ændre tidsintervallet ved at åbne opfølgningen og ændre felterne **Start**, **Slut**, **Forfalden** eller **Varighed**.

## <a id="repeat"></a>Rediger gentagen opfølgning

Ændringer fungerer på samme måde som ved redigering af opfølgninger, men når du foretager en ændring, vises dialogboksen **Gentaget opfølgning**.

![Gentaget opfølgning -screenshot][img1]

* Hvis du vælger **Skift kun denne forekomst**, påvirker ændringen ikke andre tidspunkter.

* Hvis du vælger **Skift alle fremtidige forekomster, inklusive denne**, vil ændringen gælde for denne opfølgning samt alle fremtidige gentagelser.

Du kan kun ændre startdatoen for opfølgningen, mens du ser på gentagelsesdetaljerne. For at ændre tiden skal du klikke på **OK** eller **Afbry** for at vende tilbage til opfølgningsdetaljerne.

Hvis du beslutter at ændre mønsteret midt i en serie af møder, oprettes en ny regel, og den gamle regel stoppes på det tidspunkt, hvor ændringen træder i kraft.

Hvis du ændrer starttidspunktet for et enkelt møde, påvirkes reglen ikke. Mødet behandles som en undtagelse. Du kan fjerne undtagelsen ved at flytte mødet tilbage i linje med de andre.

[!include[Caution](includes/caution-do-not-change-recurring-date.md)]

## <a id="delete"></a>Slet en opfølgning i Dagbogen

* Hvis du sletter en opfølgning, du er inviteret til, fjernes den kun fra din dagbog.
* Hvis du sletter en invitation, som du ejer, forsvinder opfølgningen også fra de inviteredes dagbøger.

1. Vælg den opfølgning, du vil slette.
1. Højreklik, og vælg **Slet**.
1. Bekræft eller annuller sletningen i bekræftelsesdialogboksen.

[!include[Deleting items](../../learn/includes/tip-deletion.md)]

## Relateret indhold

* [Ændring af status Udført for en aktivitet][2]
* [Stop gentagne opfølgninger][5]
* [Tilføj link til dokument, salg, projekt eller websted][6]

<!-- Referenced links -->
[2]: change-completed-status.md
[3]: create-follow-up.md#fields
[5]: recurrence/stop.md
[6]: ../../learn/basics/links.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/diary/change-repeating-fo.png
