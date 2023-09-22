---
uid: help-da-invitation-add-participant
title: Tilføjelse af deltagere i opfølgninger
description: "Invitation af kontakter til en aftale kan gøres på forskellige måder, afhængigt af om det er en intern eller en ekstern person eller en ressource, såsom et mødelokale eller specielt udstyr. Denne vejledning viser, hvordan du føjer deltagere til en aftale."
author: SuperOffice RnD
so.date: 02.10.2023
keywords: dagbog, opfølgning, invitation, deltager
so.topic: howto
language: da
---

# Tilføjelse af deltagere og ressourcer til opfølgninger

Når du opretter en opfølgning, som omfatter flere personer end dig selv, kan du knytte personerne til opfølgningen som deltagere. Du kan også reservere mødelokaler og udstyr i organisationen. De personer, der er tilgængelige som deltagere, defineres i Indstillinger og vedligeholdelse.

Inviter en kontakt til en aftale fra fanen deltagere ved at klikke på knappen **Tilføj** . Se videoen for [Føj deltagere til en aftale][5].

<!--
> [!Video https://community.SuperOffice.com/globalassets/user--admin/learning/user-guide/diary--appointments/add-contact-to-appointment.mp4] -->

## Trin

1. Åbn dialogboksen **Aftale**, **Opgave** eller **Samtale**, og[angiv de ønskede oplysninger][2].

2. Åbn fanen **Deltagere**, og klik på **Tilføj** nederst til venstre i vinduet. Dialogboksen **Invitation** vises.

    > [!NOTE]
    > Hvis du har oversigter til andre brugere eller ressourcer åbne, tilføjes disse automatisk som deltagere på fanen **Deltagere**. Ellers vælger du dem manuelt som beskrevet nedenfor.

3. I feltet **Vælg fra** kan du vælge, hvor du vil hente deltagerne fra. Vælg mellem **Medarbejdere**, **Firma/person**, **Projekt**, **Udvalg** og **Ressource**.

4. I rullemenuen lige under feltet **Vælg fra** kan du vælge brugergruppen, firmaet, projektet, udvalget eller ressourcen, du vil hente deltagerne fra. Indholdet i denne rullemenu varierer, alt efter hvad du har valgt i forrige trin.
    * Hvis du har valgt **Medarbejdere** eller **Ressourcer** i trin 3, kan du vælge **Alle** i rullemenuen for at vise personerne eller ressourcerne i alle grupperne.
    * Hvis du har valgt **Firma/person**, **Projekt** eller **Udvalg** i trin 3, kan du søge efter ønsket firma, person, projekt eller udvalg i dette felt.

5. Når du har valgt den ønskede kilde, vises en liste over alle de poster, som er tilgængelige for denne kilde. Marker brugerne eller ressourcerne, som opfølgningen skal omfatte, og klik på pileknappen til højre for listen (![ikon][img2]). De vises nu til højre i vinduet. Du kan også tilføje brugere og ressourcer enkeltvist ved at dobbeltklikke på dem.

    > [!NOTE]
    > Hvis nogen af personerne er optaget på det tidspunkt, du har angivet, vises deres navn med rødt, så du nemt kan se, om du skal finde et andet tidspunkt for opfølgningen. Du kan dog altid invitere dem til den nye aftale, hvorefter deres post vises med rødt og ordet "KONFLIKT" i dialogboksen for opfølgninger.

6. Klik på knappen **E-mailinvitation** for at aktivere e-mailinvitationer for alle deltagere på listen (undtagen dig selv). Ikonet ![ikon][img1] til venstre for deltagerens navn betyder, at der er sent en e-mailinvitation til opfølgningen vil blive sendt til denne deltager. Klik på ikonet ![ikon][img1] ud for en deltagers navn for at deaktivere e-mailinvitationen for denne deltager. Ikonet ![icon][img1] ændres til inaktivt (![ikon][img3]), og deltageren modtager ikke en invitation via e-mail.

7. Klik på **OK** for at lukke dialogboksen **Invitation**. Du kan nu se de valgte deltagere og ressourcer på fanen **Deltagere**. Du kan klikke på knappen **E-mail-invitation** og ikonet ![ikon][img1] for at aktivere / deaktivere e-mail-invitationer, svarende til det foregående trin.
    Hvis nogen af de personer, du har valgt, ikke har en gyldig e-mailadresse registreret i SuperOffice CRM, ændres ikonet ![ikon][img1] til inaktivt (![ikon][img3]) på fanen **Deltagere**.

    > [!NOTE]
    > Hvis du ved en fejl har valgt brugere eller ressourcer, skal du markere dem på listen yderst til højre og klikke på **Slet** for at fjerne dem.

8. Når du er færdig med at vælge deltagere og ressourcer, skal du klikke på **Gem** for at gemme det, du har valgt, eller på **Afbryd** for at afslutte dialogboksen uden at gemme.

## Fejlfinding

### Hvorfor sker der ikke noget, når jeg klikker på E-mailinvitation?

Hvis den valgte person ikke har en gyldig e-mailadresse registreret i SuperOffice CRM, vil der ikke ske noget, når du klikker på **E-mail-invitation**.

### Hvorfor er knappen E-mailinvitation deaktiveret?

Brug af indbakken i SuperOffice: Hvis du ikke har angivet nødvendig information i skærmbilledet **Log ind**, som vises, første gang du klikker på knappen **Indbakke** i SuperOffice CRM, knappen **E-mailinvitation** er deaktiveret.

### Hvordan kan jeg angive, om en ekstern person har accepteret eller afvist invitationen?

Eksterne deltagere bliver påmindet via e-mail (hvis du har valgt denne indstilling i dialogboksen Invitation). E-mails med invitationer, der sendes til eksterne kontaktpersoner, indeholder et iCal-arkiv (.ics) med invitationsdataene. Når de svarer på din invitation, opdateres [status][1] automatisk i SuperOffice.

Hvis du vil acceptere eller afvise en invitation på vegne af en anden, skal du vælge navnet på listen og klikke én gang på knappen **Skift status** for at indsætte en grøn markering, som viser, at invitationen er accepteret, eller klikke to gange for at sætte et rødt kryds, som viser, at invitationen er afvist.

## Relateret indhold

* [Oprettelse af aftaler][3]
* [Deltag i et videomøde][4]

<!-- Referenced links -->
[1]: index.md#status
[2]: ../screen/dialog-for-followups.md
[3]: ../create-appointment.md
[4]: ../video-meetings.md
[5]: https://community.superoffice.com/globalassets/user--admin/learning/user-guide/diary--appointments/add-contact-to-appointment.mp4

<!-- Referenced images -->
[img1]: ../../../../../common/icons/pref-email.png
[img2]: ../../../../media/icons/arrow-right.png
[img3]: ../../../../media/icons/email-inactive.png
