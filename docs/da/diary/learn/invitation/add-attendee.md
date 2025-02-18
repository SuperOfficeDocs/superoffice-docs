---
uid: help-da-invitation-add-attendee
title: Tilføjelse af deltagere i opfølgninger
description: Invitation af kontakter til en aftale kan gøres på forskellige måder. Denne vejledning viser, hvordan du føjer deltagere til en aftale.
keywords: lägg till deltagare, tilføj deltagere, vælg deltagere, lägg till ressourc, dagbog, opfølgning, invitation, deltager, tjek tilgængelighed, inviter
author: Bergfrid Dias
date: 02.21.2025
version: 10.5.2
topic: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Tilføjelse af deltagere og ressourcer til opfølgninger

Når du opretter en opfølgning, som omfatter flere personer end dig selv, kan du knytte personerne til opfølgningen som deltagere. Du kan også reservere mødelokaler og udstyr i organisationen. De personer, der er tilgængelige som deltagere, defineres i Indstillinger og vedligeholdelse.

## Trin

> [!NOTE]
> Kun ejeren af opfølgningen kan tilføje (og fjerne) deltagere.

1. [Åbn eller opret en opfølgning][3].

1. Klik på **Inviter**-knappen. Dette udvider dialogboksen.

    ![Opfølgingsdialog, Inviter-knap -screenshot][img14]

    ![Opfølgingsdialog, udvidet -screenshot][img15]

1. Klik på **Tilføj deltagere**-feltet. Vælg derefter en eller flere personer fra listen.

    * Begynd at skrive for at søge efter en person i hele SuperOffice.
    * Vælg en person fra historielisten (<i class="ph ph-clock" aria-hidden="true"></i>) eller dine favoritter (<i class="ph ph-star" aria-hidden="true"></i>).
    * Klik <i class="ph ph-users" aria-label="Group icon"></i> for at søge efter en kollega eller <i class="ph ph-buildings" aria-label="Company icon"></i> for at vælge personer knyttet til et firma.
    * Du kan også vælge salgsinteressenter (<i class="ph ph-currency-circle-dollar" aria-hidden="true"></i>) og projektdeltagere (<i class="ph ph-clipboard-text" aria-hidden="true"></i>).

    ![Opfølgingsdialog, vælg deltagere -screenshot][img17]

    > [!TIP]
    > For at invitere nogen, der ikke er registreret i SuperOffice, indtast deres fulde e-mailadresse.

    ![Opfølgingsdialog, deltagere tilføjet -screenshot][img16]

    Hvis en deltager ikke er tilgængelig, vises et udråbstegn ved siden af deres navn. Vælg en af de foreslåede tidspunkter eller klik på **Tjek tilgængelighed** for at finde et bedre tidspunkt.

1. Valgfrit, tilføj steder, rum og/eller ressourcer.

1. Valgfrit, vælg **Send e-mailinvitation til deltagere**. (Dette ændrer **Gem**-knappen til **Gem og send**.)

1. Klik på **Gem** for at gemme alle ændringer.

### <a id="availability"></a>Planlægningsassistent

Planlægningsassistenten er en del af **Opfølgning**-dialogen. Den detaljerede kalender viser tilgængeligheden for hver intern deltager (kollega). Den øverste række viser den akkumulerede tilgængelighed. Tilgængeligheden for eksterne deltagere og e-mail deltagere er ukendt.

![Opfølgingsdialog, planlægningsassistent -screenshot][img18]

1. I **Opfølgning**-dialogen skal du klikke på **Tjek tilgængelighed**.

1. Klik og træk markøren til venstre eller højre for at vælge et mødetidspunkt. For eksempel, fra 13:30 til 15:00, som vist i grønt på dette skærmbillede. Brug rullefeltet for at bevæge dig mellem dagene.

    Alternativt, opdater den valgte dato og tid øverst i dialogen.

1. Valgfrit, tilføj eller fjern deltagere og ressourcer. Overvej at justere tiden igen, hvis der er konflikt.

1. Klik på **OK**, når du er færdig.
1. Klik på **Gem** for at gemme alle ændringer.

### <a id="preview"></a>Forhåndsvisning og opdater invitationsemail

Når du klikker på **Gem og send**, vises en forhåndsvisning af e-mailen baseret på titlen og dagsordenen. Eventuelle interne noter, der er tilføjet opfølgningen, ekskluderes.

![Opfølgingsdialog, forhåndsvisning af e-mailinvitation -screenshot][img13]

1. Opdater emnet og brødteksten i e-mailen efter behov. Brug værktøjslinjen til formatering af rig tekst i bunden for at style din invitation.

    > [!NOTE]
    > Eventuelle ændringer foretaget i forhåndsvisningen gemmes **ikke** tilbage til opfølgningen.

1. Når du er klar, skal du klikke på **Send**.

## Hvad sker der herefter

1. Når du gemmer opfølgningen, [modtager den anden person en meddelelse][5].

2. Hvis den anden person afviser invitationen, modtager du en Invitation afslået-meddelelse. Klik på **Forstået** for at bekræfte.

3. Valgfrit, find en ny passende tid og planlæg opfølgningen igen.

### Hvorfor er knappen E-mailinvitation deaktiveret?

Brug af indbakken i SuperOffice: Hvis du ikke har angivet nødvendig information i skærmbilledet **Log ind**, som vises, første gang du klikker på knappen **Indbakke** i SuperOffice CRM, knappen **E-mailinvitation** er deaktiveret.

### Hvordan kan jeg angive, om en ekstern person har accepteret eller afvist invitationen?

Eksterne deltagere bliver påmindet via e-mail (hvis du har valgt denne indstilling). E-mails med invitationer, der sendes til eksterne kontaktpersoner, indeholder et iCal-arkiv (.ics) med invitationsdataene. Når de svarer på din invitation, opdateres [status][1] automatisk i SuperOffice.

Hvis du vil acceptere eller afvise en invitation på vegne af en anden, skal du vælge navnet på listen og klikke én gang på knappen **Skift status** for at indsætte en grøn markering, som viser, at invitationen er accepteret, eller klikke to gange for at sætte et rødt kryds, som viser, at invitationen er afvist.

## Fejlfinding

### Hvorfor sker der ikke noget, når jeg klikker på E-mailinvitation?

Hvis den valgte person ikke har en gyldig e-mailadresse registreret i SuperOffice CRM, vil der ikke ske noget, når du klikker på **E-mail-invitation**.

## Relateret indhold

* [Oprettelse af aftaler][3]
* [Deltag i et videomøde][4]

<!-- Referenced links -->
[1]: index.md#status
[3]: ../create-follow-up.md
[4]: ../video-meetings.md
[5]: accept-decline.md

<!-- Referenced images -->
[img13]: ../../../../media/loc/en/diary/preview-invitation.png
[img14]: ../../../../media/loc/en/diary/invite.png
[img15]: ../../../../media/loc/en/diary/large-follow-up-dialog.png
[img16]: ../../../../media/loc/en/diary/attendees-added.png
[img17]: ../../../../media/loc/en/diary/follow-up-attendees.png
[img18]: ../../../../media/loc/en/diary/schedule-associate-ext-email.png
