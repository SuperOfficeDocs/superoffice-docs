---
uid: help-da-invitation-add-participant
title: Tilføjelse af deltagere i opfølgninger
description: "Invitation af kontakter til en aftale kan gøres på forskellige måder. Denne vejledning viser, hvordan du føjer deltagere til en aftale."
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: dagbog, opfølgning, invitation, deltager
so.topic: howto
language: da
---

# Tilføjelse af deltagere og ressourcer til opfølgninger

Når du opretter en opfølgning, som omfatter flere personer end dig selv, kan du knytte personerne til opfølgningen som deltagere. Du kan også reservere mødelokaler og udstyr i organisationen. De personer, der er tilgængelige som deltagere, defineres i Indstillinger og vedligeholdelse.

Se videoen for [Føj deltagere til en aftale][15].

## Trin

> [!NOTE]
> Kun ejeren af opfølgningen kan tilføje (og fjerne) deltagere.

<!-- markdownlint-disable MD051 -->
### [Klassisk](#tab/participants)

1. [Åbn eller opret en opfølgning][3].

    > [!NOTE]
    > Hvis du har oversigten over andre brugere eller ressourcer åben, bliver de automatisk indtastet som deltagere i fanen **Deltagere**. Ellers vælg dem manuelt som beskrevet nedenfor.

2. Åbn fanen **Deltagere** og klik på **Tilføj** i bunden.

3. I dialogboksen **Invitation** kan du vælge, hvor du vil hente deltagerne fra. Vælg mellem **Medarbejdere**, **Firma/person**, **Projekt**, **Udvalg** og **Ressource**.

4. I rullemenuen lige under feltet **Vælg fra** kan du vælge brugergruppen, firmaet, projektet, udvalget eller ressourcen, du vil hente deltagerne fra. Indholdet i denne rullemenu varierer, alt efter hvad du har valgt i forrige trin.
    * Hvis du har valgt **Medarbejdere** eller **Ressourcer** i trin 3, kan du vælge **Alle** i rullemenuen for at vise personerne eller ressourcerne i alle grupperne.
    * Hvis du har valgt **Firma/person**, **Projekt** eller **Udvalg** i trin 3, kan du søge efter ønsket firma, person, projekt eller udvalg i dette felt.

5. Når du har valgt den ønskede kilde, vises en liste over alle de poster, som er tilgængelige for denne kilde. Marker brugerne eller ressourcerne, som opfølgningen skal omfatte, og klik på pileknappen til højre for listen ![ikon][img2]. De vises nu til højre i vinduet. Du kan også tilføje brugere og ressourcer enkeltvist ved at dobbeltklikke på dem.

    > [!NOTE]
    > Hvis nogen af personerne er optaget på det tidspunkt, du har angivet, vises deres navn med rødt, så du nemt kan se, om du skal finde et andet tidspunkt for opfølgningen. Du kan dog altid invitere dem til den nye aftale, hvorefter deres post vises med rødt og ordet "KONFLIKT" i dialogboksen for opfølgninger.

6. Klik på knappen **E-mailinvitation** for at aktivere e-mailinvitationer for alle deltagere på listen (undtagen dig selv). Ikonet ![ikon][img1] til venstre for deltagerens navn betyder, at der er sent en e-mailinvitation til opfølgningen vil blive sendt til denne deltager. Klik på ikonet ![ikon][img1] ud for en deltagers navn for at deaktivere e-mailinvitationen for denne deltager. Ikonet ![icon][img1] ændres til inaktivt ![ikon][img3], og deltageren modtager ikke en invitation via e-mail.

    E-mails med invitationer, der sendes til eksterne kontaktpersoner, indeholder et iCal-arkiv (.ics) med invitationsdataene. Når de svarer på din invitation, opdateres status automatisk i SuperOffice. Opfølgningen vises på detaljekortet **Aktiviteter** for det aktuelle firma.

7. Klik på **OK** for at lukke dialogboksen **Invitation**. Du kan nu se de valgte deltagere og ressourcer på fanen **Deltagere**. Du kan klikke på knappen **E-mail-invitation** og ikonet ![ikon][img1] for at aktivere / deaktivere e-mail-invitationer, svarende til det foregående trin.
    Hvis nogen af de personer, du har valgt, ikke har en gyldig e-mailadresse registreret i SuperOffice CRM, ændres ikonet ![ikon][img1] til inaktivt ![ikon][img3] på fanen **Deltagere**.

    > [!NOTE]
    > Hvis du ved en fejl har valgt brugere eller ressourcer, skal du markere dem på listen yderst til højre og klikke på **Slet** for at fjerne dem.

8. Når du er færdig med at vælge deltagere og ressourcer, skal du klikke på **Gem** for at gemme det, du har valgt, eller på **Afbryd** for at afslutte dialogboksen uden at gemme.

### [Ny (fra version 10.2.11 pilot)](#tab/attendees)

1. [Åbn eller opret en opfølgning][3].

1. Klik på **Inviter**-knappen. Dette udvider dialogboksen.

    ![Opfølgingsdialog, Inviter-knap -screenshot][img14]

    ![Opfølgingsdialog, udvidet -screenshot][img15]

1. Klik på **Tilføj deltagere**-feltet. Vælg derefter en eller flere personer fra listen.

    * Begynd at skrive for at søge efter en person i hele SuperOffice.
    * Vælg en person fra historielisten ![ikon][img4] eller dine favoritter ![ikon][img5].
    * Klik ![ikon][img6] for at søge efter en kollega eller ![ikon][img7] for at vælge personer knyttet til et firma.
    * Du kan også vælge salgsinteressenter ![ikon][img8] og projektdeltagere ![ikon][img9].

    ![Opfølgingsdialog, vælg deltagere -screenshot][img17]

    > [!TIP]
    > For at invitere nogen, der ikke er registreret i SuperOffice, indtast deres fulde e-mailadresse.

    ![Opfølgingsdialog, deltagere tilføjet -screenshot][img16]

    Hvis en deltager ikke er tilgængelig, vises et udråbstegn ved siden af deres navn. Vælg en af de foreslåede tidspunkter eller klik på **Tjek tilgængelighed** for at finde et bedre tidspunkt.

1. Valgfrit, tilføj steder, rum og/eller ressourcer.

1. Valgfrit, vælg **Send e-mailinvitation til deltagere**. (Dette ændrer **Gem**-knappen til **Gem og send**.)

1. Klik på **Gem** for at gemme alle ændringer.

***
<!-- markdownlint-restore -->

### <a id="availability" />Planlægningsassistent (kun tilgængelig i pilot)

Planlægningsassistenten er en del af den nye **Opfølgning**-dialog. Den detaljerede kalender viser tilgængeligheden for hver intern deltager (kollega). Den øverste række viser den akkumulerede tilgængelighed. Tilgængeligheden for eksterne deltagere og e-mail deltagere er ukendt.

![Opfølgingsdialog, planlægningsassistent -screenshot][img18]

1. I **Opfølgning**-dialogen skal du klikke på **Tjek tilgængelighed.**

1. Klik og træk markøren til venstre eller højre for at vælge et mødetidspunkt. For eksempel, fra 13:30 til 15:00, som vist i grønt på dette skærmbillede. Brug rullefeltet for at bevæge dig mellem dagene.

    Alternativt, opdater den valgte dato og tid øverst i dialogen.

1. Valgfrit, tilføj eller fjern deltagere og ressourcer. Overvej at justere tiden igen, hvis der er konflikt.

1. Klik på **OK**, når du er færdig.
1. Klik på **Gem** for at gemme alle ændringer.

### <a id="preview" />Forhåndsvisning og opdater invitationsemail (kun i pilot)

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
[15]: https://community.superoffice.com/globalassets/user--admin/learning/user-guide/diary--appointments/add-contact-to-appointment.mp4

<!-- Referenced images -->
[img1]: ../../../../../common/icons/pref-email.png
[img2]: ../../../../media/icons/arrow-right.png
[img3]: ../../../../media/icons/email-inactive.png
[img4]: ../../../../../common/icons/history-icon.png
[img5]: ../../../../../common/icons/favourite-icon.png
[img6]: ../../../../../common/icons/personblack.png
[img7]: ../../../../../common/icons/singlecolour/contact.png
[img8]: ../../../../../common/icons/sale.png
[img9]: ../../../../../common/icons/singlecolour/project.png
[img13]: ../../../../media/loc/en/diary/preview-invitation.png
[img14]: ../../../../media/loc/en/diary/invite.png
[img15]: ../../../../media/loc/en/diary/large-follow-up-dialog.png
[img16]: ../../../../media/loc/en/diary/attendees-added.png
[img17]: ../../../../media/loc/en/diary/follow-up-attendees.png
[img18]: ../../../../media/loc/en/diary/schedule-associate-ext-email.png
