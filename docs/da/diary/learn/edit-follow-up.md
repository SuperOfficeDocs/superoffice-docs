---
uid: help-da-follow-up-edit
title: Rediger opfølgning
description: Åbn, rediger, slet opfølgning; Rediger sluttidspunkt for opfølgninger i dagbogen; Rediger eller slet invitation
author: Bergfrid Dias
so.version: 10.2.11
keywords: dagbog, opfølgning, invitation, aftale, oppgave, telefonopkald, gentag
so.topic: howto
language: da
---

# Rediger opfølgning

[!include[Note](includes/note-edit-followup.md)]

Hvis du redigerer tid, dato eller sted for en opfølgning - eller sletter en invitation, du har oprettet og sendt - modtager de inviterede en meddelelse om dette.

## Trin

1. Åbn den ønskede opfølgning ved at dobbeltklikke på den:

    * I detaljekortet **Aktiviteter** i skærmbilledet Firma, Person, Salg, Projekt, Dagbog.
    * På de forskellige faner i skærmbilledet Dagbog.

2. [Foretag de ønskede ændringer i dialogboksen.][3]

    [!include[Recurrence](includes/note-repetition.md)]

3. Klik på **Gem**.

> [!NOTE]
> Du kan ikke redigere afsluttede ændringer, før du har sat deres status til **Udført**.

## <a id="change-end" />Rediger sluttidspunkt for opfølgninger i dagbogen

På skærmbilledet Dagbog kan du ændre sluttidspunktet for en opfølgning uden at skulle åbne den:

1. Klik på opfølgningen på fanen **Dag**, fanen **Uge** eller fanen **Vis**.

2. Placer musemarkøren på den nederste kant af opfølgningen. Markøren ændres til en dobbeltpil.

3. Klik på kanten, og hold museknappen nede, mens du trækker den blå linje op eller ned for at mindske eller øge tidsintervallet for opfølgningen. Du kan se sluttidspunktet for opfølgningen øverst i det blå område.

4. Slip museknappen. Tidsintervallet for opfølgningen ændres.

> [!NOTE]
> Du kan også ændre tidsintervallet ved at åbne opfølgningen og ændre felterne **Start**, **Slut**, **Forfalden** eller **Varighed**.

## <a id="repeat" />Rediger gentagne opfølgninger

Ændringer fungerer på samme måde, som når du redigerer opfølgninger, men når du foretager en ændring, vises dialogboksen **Gentaget opfølgning**.

![Repeating follow-up dialog -screenshot][img1]

* Hvis du vælger **Skift kun denne forekomst**, påvirker ændringen ikke andre tidspunkter.

* Hvis du vælger **Skift alle fremtidige forekomster, herunder denne**, vil ændringen gælde for denne opfølgning og alle gentagelser i fremtiden.

Du kan kun ændre startdatoen for opfølgningen, mens du ser på gentagelsesdetaljerne. For at ændre tiden, skal du klikke på **OK** eller **Afbry** for at vende tilbage til opfølgningsoplysningerne.

Hvis du beslutter at ændre mønsteret midt i en række møder, oprettes en ny regel, og den gamle regel stoppes ved det punkt, hvor afbrydelsen opstår.

Hvis du ændrer starttidspunktet for et enkelt møde, påvirkes reglen ikke. Mødet behandles som en undtagelse fra reglen. Undtagelsen kan gøres normal igen ved at flytte den tilbage i linje med de andre møder.

[!include[Caution](includes/caution-do-not-change-recurring-date.md)]

## <a id="delete" />Slet opfølgning ved hjælp af Dagbogen

* Hvis du sletter en opfølgning, som du er inviteret til, fjernes opfølgningen kun fra din dagbog.
* Hvis du sletter en invitation, som du ejer, fra din dagbog, forsvinder denne opfølgning også fra de inviteredes dagbøger.

1. Vælg den ønskede opfølgning.
2. Højreklik, og vælg **Slet**.
3. Bekræft eller annuller sletningen i bekræftelsesdialogboksen.

[!include[Deleting items](../../learn/includes/tip-deletion.md)]

## Relaterede emner

* [Ændring af status Udført for en aktivitet][2]
* [Stop af gentagne opfølgninger][5]

<!-- Referenced links -->
[2]: change-completed-status.md
[3]: create-follow-up.md#fields
[5]: recurrence/stop.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/diary/change-repeating-fo.png
