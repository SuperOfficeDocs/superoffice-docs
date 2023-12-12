---
uid: help-no-invitation-add-participant
title: Legge til deltakere i oppfølginger
description: "Det er flere måter å invitere personer til en avtale på. Denne guiden viser hvordan du legger til deltakere i en avtale."
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: dagbok, oppfølging, invitasjon, deltaker
so.topic: howto
language: no
---

# Legge til deltakere og ressurser i oppfølginger

Når du oppretter en oppfølging som omfatter flere enn deg selv, kan du knytte personene til oppfølgingen som deltakere. Du kan også reservere møterom og utstyr i organisasjonen. Hvem som er tilgjengelige som deltakere, defineres i Innstillinger og vedlikehold.

Se videoen [Legge til deltakere i en avtale][15].

## Trinn

> [!NOTE]
> Bare eieren av oppfølgingen kan legge til (og fjerne) deltakere.

<!-- markdownlint-disable MD051 -->
### [Klassisk](#tab/participants)

1. [Åpne eller opprett en oppfølging][3].

    > [!NOTE]
    > Hvis du har oversikten over andre brukere eller ressurser åpen, blir de automatisk lagt til som deltakere i fanen **Deltakere**. Ellers velger du dem manuelt som beskrevet nedenfor.

2. Åpne fanen **Deltakere** og klikk på **Legg til** i bunnen.

3. I dialogboksen **Invitasjon** velger du hvor du vil hente deltakerne fra. Velg mellom **Medarbeidere**, **Firma/person**, **Prosjekt**, **Utvalg** og **Ressurs**.

4. I listeboksen like under feltet **Velg fra** velger du brukergruppen, firmaet, personen, prosjektet, utvalget eller ressursen du vil hente deltakerne fra. Innholdet i denne listeboksen varierer etter hva du valgte i trinnet over.
    * Hvis du valgte **Medarbeidere** eller **Ressurs** i trinn 3, kan du velge **Alle** i listeboksen for å vise personene eller ressursene i alle gruppene.
    * Hvis du valgte **Firma/person**, **Prosjekt** eller **Utvalg** i trinn 3, kan du søke etter ønsket firma, person, prosjekt eller utvalg fra dette feltet.

5. Når du har valgt ønsket kilde, vises en liste over alle oppføringer som er tilgjengelige for denne kilden. Merk brukerne eller ressursene oppfølgingen skal omfatte, og klikk deretter på pilknappen til høyre for listen ![ikon][img2]. De vises da på høyre side av vinduet. Du kan også legge til brukere og ressurser enkeltvis ved å dobbeltklikke på dem.

    > [!NOTE]
    > Hvis noen av personene er opptatt på det tidspunktet du har angitt, vises navnet deres med rødt, slik at du enkelt ser om du bør finne et annet tidspunkt for oppfølgingen. Du kan likevel invitere dem til den nye avtalen, og oppføringen deres vises da med rødt og ordet "KONFLIKT" i dialogboksen for oppfølginger.

6. Klikk på knappen **E-postinvitasjon** for å aktivere e-postinvitasjoner for alle deltakerne i listen (unntatt deg selv). Ikonet ![ikon][img1] til venstre for deltakernavnet angir at den aktuelle deltakeren vil motta invitasjon til oppfølgingen via e-post. Klikk på ![ikon][img1] ikonet ved siden av navnet på en deltaker for å deaktivere e-postinvitasjon for denne deltakeren. Ikonet ![ikon][img1] endres til inaktivt ![ikon][img3], og deltakeren vil ikke motta invitasjon via e-post.

    E-postinvitasjoner som sendes til eksterne personer, inneholder en iCal-fil (.ics) sammen med invitasjonsdataene. Når de svarer på invitasjonen din, oppdateres statusen automatisk i SuperOffice. Oppfølgingen vises på detaljkortet **Aktiviteter** for det aktuelle firmaet.

7. Klikk på **OK** for å lukke dialogboksen **Invitasjon**. Du ser nå de valgte deltakerne og ressursene i fanen **Deltakere**. Du kan klikke på knappen **E-postinvitasjon** og ![ikon][img1] ikonet for å aktivere/deaktivere e-postinvitasjoner, på samme måte som i forrige trinn.
    Hvis noen av personene du valgte, ikke har en gyldig e-postadresse registrert i SuperOffice CRM, endres ![ikon][img1] ikonet til inaktivt ![ikon][img3] i fanen **Deltakere** .

    > [!NOTE]
    > Hvis du har valgt brukere eller ressurser ved en feiltakelse, merker du dem i listen lengst til høyre, og deretter klikker du på **Slett** for å fjerne dem.

8. Når du har valgt deltakere og ressurser, klikker du på **Lagre** for å lagre det du har valgt, eller på **Avbryt** for å gå ut av dialogboksen uten å lagre.

### [Ny (fra versjon 10.2.11 pilot)](#tab/attendees)

1. [Åpne eller opprett en oppfølging][3].

1. Klikk på **Inviter**-knappen. Dette utvider dialogboksen.

    ![Oppfølgingsdialog, Inviter-knapp -screenshot][img14]

    ![Oppfølgingsdialog, utvidet -screenshot][img15]

1. Klikk på boksen **Legg til deltakere**. Velg deretter en eller flere personer fra listen.

    * Begynn å skrive for å søke etter en person i hele SuperOffice.
    * Velg en person fra historielisten ![ikon][img4] eller favorittene dine ![ikon][img5].
    * Klikk ![ikon][img6] for å søke etter en kollega eller ![ikon][img7] for å velge personer knyttet til et selskap.
    * Du kan også velge salgsinteressenter ![ikon][img8] og prosjektdeltakere ![ikon][img9].

    ![Oppfølgingsdialog, velg deltakere -screenshot][img17]

    > [!TIP]
    > Hvis du vil invitere noen som ikke er registrert i SuperOffice, skriv inn deres fulle e-postadresse.

    ![Oppfølgingsdialog, deltakere lagt til -screenshot][img16]

    Hvis en deltaker er utilgjengelig, vises et utropstegn ved siden av navnet deres. Velg en av de foreslåtte tidspunktene eller klikk på **Sjekk tilgjengelighet** for å finne en bedre tid.

1. Valgfritt, legg til steder, rom og/eller ressurser.

1. Valgfritt, velg **Send e-postinvitasjon til deltakere**. (Dette endrer **Lagre**-knappen til **Lagre og send**.)

1. Klikk på **Lagre** for å lagre alle endringer.

***
<!-- markdownlint-restore -->

### <a id="availability" />Planleggingsassistent (kun tilgjengelig i pilot)

Planleggingsassistenten er en del av den nye **Oppfølgings**-dialogen. Den detaljerte kalenderen viser tilgjengeligheten til hver intern deltaker (kollega). Den øverste raden viser den akkumulerte tilgjengeligheten. Tilgjengeligheten til eksterne deltakere og e-postdeltakere er ukjent.

![Oppfølgingsdialog, planleggingsassistent - skjermbilde][img18]

1. I **Oppfølgings**-dialogen, klikk på **Sjekk tilgjengelighet.**

1. Klikk og dra pekeren til venstre eller høyre for å velge et møtetidspunkt. For eksempel, fra 13.30 til 15:00, som vist i grønt på dette skjermbildet. Bruk rullefeltet for å bevege deg mellom dagene.

    Alternativt, oppdater den valgte datoen og tiden øverst i dialogen.

1. Valgfritt, legg til eller fjern deltakere og ressurser. Vurder å justere tiden igjen hvis det er en konflikt.

1. Klikk **OK** når du er ferdig.
1. Klikk **Lagre** for å lagre alle endringer.

### <a id="preview" />Forhåndsvisning og oppdater invitasjons-e-post (kun pilot)

Når du klikker på **Lagre og send**, vises en forhåndsvisning av e-posten basert på tittelen og agendaen. Eventuelle interne notater som er lagt til i oppfølgingen, ekskluderes.

![Oppfølgingsdialog, forhåndsvisning av e-postinvitasjon - skjermbilde][img13]

1. Oppdater emne og brødtekst i e-posten etter behov. Bruk verktøylinjen for rik tekst i bunnen for å style invitasjonen din.

    > [!NOTE]
    > Eventuelle endringer gjort i forhåndsvisningen lagres **ikke** tilbake til oppfølgingen.

1. Når du er klar, klikk på **Send**.

## Hva skjer neste

1. Når du lagrer oppfølgingen, [mottar den andre personen et aktivitetsvarsel][5].

2. Hvis den andre personen avslår invitasjonen, får du en Invitasjon avslått-melding. Klikk **Greit** for å bekrefte.

3. Valgfritt, finn en ny passende tid og endre tidspunktet for oppfølgingen.

### Hvordan angir jeg om en ekstern person har godtatt eller avslått invitasjonen?

Eksterne deltakere blir varslet via e-post (hvis du valgte dette alternativet). E-postinvitasjoner som sendes til eksterne personer, inneholder en iCal-fil (.ics) sammen med invitasjonsdataene. Når de svarer på invitasjonen din, oppdateres [statusen][1] automatisk i SuperOffice.

Hvis du vil godta eller avslå en invitasjon på vegne av noen, velger du navnet i listen og klikker på **Bytt status**-knappen for å sette inn en grønn hake som viser at invitasjonen er godtatt, eller klikk to ganger for å sette inn et rødt kryss som viser at invitasjonen er avslått.

## Feilsøking

### Hvorfor skjer det ikke noe når jeg klikker på E-postinvitasjon?

Hvis personen du har merket, ikke har en gyldig e-postadresse registrert i SuperOffice CRM, vil det ikke skje noe når du klikker på **E-postinvitasjon**.

### Hvorfor er knappen E-postinvitasjon deaktivert?

Bruke innboksen i SuperOffice: Hvis du ikke har angitt nødvendig informasjon i skjermbildet **Logg på**, som vises første gang du klikker på **Innboks**-knappen i SuperOffice CRM, er knappen **E-postinvitasjon** deaktivert.

## Aktuelt innhold

* [Opprett avtaler][3]
* [Bli med i et videomøte][4]

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
