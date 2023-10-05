---
uid: help-no-invitation-add-participant
title: Legge til deltakere i oppfølginger
description: "Det er flere måter å invitere personer til en avtale på. Denne guiden viser hvordan du legger til deltakere i en avtale."
author: Bergfrid Dias
so.date: 10.04.2023
keywords: dagbok, oppfølging, invitasjon, deltaker
so.topic: howto
language: no
---

# Legge til deltakere og ressurser i oppfølginger

Når du oppretter en oppfølging som omfatter flere enn deg selv, kan du knytte personene til oppfølgingen som deltakere. Du kan også reservere møterom og utstyr i organisasjonen. Hvem som er tilgjengelige som deltakere, defineres i Innstillinger og vedlikehold.

Klikk på **Legg til**-knappen for å invitere en person til en avtale fra fanen deltakere. Se videoen [Legge til deltakere i en avtale][5].

## Trinn

1. Åpne dialogboksen **Avtale**, **Oppgave** eller **Samtale**, og [angi deretter den nødvendige informasjonen][2].

2. Åpne fanen **Deltakere**, og klikk deretter på **Legg til** nederst til venstre i vinduet. Dialogboksen **Invitasjon** vises.

    > [!NOTE]
    > Hvis du har oversiktene til andre brukere eller ressurser åpne, legges disse automatisk inn som deltakere i fanen **Deltakere**. Ellers velger du dem manuelt, som beskrevet under.

3. I feltet **Velg fra** velger du hvor du vil hente deltakerne fra. Velg mellom **Medarbeidere**, **Firma/person**, **Prosjekt**, **Utvalg** og **Ressurs**.

4. I listeboksen like under feltet **Velg fra** velger du brukergruppen, firmaet, personen, prosjektet, utvalget eller ressursen du vil hente deltakerne fra. Innholdet i denne listeboksen varierer etter hva du valgte i trinnet over.
    * Hvis du valgte **Medarbeidere** eller **Ressurs** i trinn 3, kan du velge **Alle** i listeboksen for å vise personene eller ressursene i alle gruppene.
    * Hvis du valgte **Firma/person**, **Prosjekt** eller **Utvalg** i trinn 3, kan du søke etter ønsket firma, person, prosjekt eller utvalg fra dette feltet.

5. Når du har valgt ønsket kilde, vises en liste over alle oppføringer som er tilgjengelige for denne kilden. Merk brukerne eller ressursene oppfølgingen skal omfatte, og klikk deretter på pilknappen til høyre for listen (![ikon][img2]). De vises da på høyre side av vinduet. Du kan også legge til brukere og ressurser enkeltvis ved å dobbeltklikke på dem.

    > [!NOTE]
    > Hvis noen av personene er opptatt på det tidspunktet du har angitt, vises navnet deres med rødt, slik at du enkelt ser om du bør finne et annet tidspunkt for oppfølgingen. Du kan likevel invitere dem til den nye avtalen, og oppføringen deres vises da med rødt og ordet "KONFLIKT" i dialogboksen for oppfølginger.

6. Klikk på knappen **E-postinvitasjon** for å aktivere e-postinvitasjoner for alle deltakerne i listen (unntatt deg selv). Ikonet ![ikon][img1] til venstre for deltakernavnet angir at den aktuelle deltakeren vil motta invitasjon til oppfølgingen via e-post. Klikk på ![ikon][img1] ikonet ved siden av navnet på en deltaker for å deaktivere e-postinvitasjon for denne deltakeren. Ikonet ![ikon][img1] endres til inaktivt ![ikon][img3], og deltakeren vil ikke motta invitasjon via e-post.

7. Klikk på **OK** for å lukke dialogboksen **Invitasjon**. Du ser nå de valgte deltakerne og ressursene i fanen **Deltakere**. Du kan klikke på knappen **E-postinvitasjon** og ![ikon][img1] ikonet for å aktivere/deaktivere e-postinvitasjoner, på samme måte som i forrige trinn.
    Hvis noen av personene du valgte, ikke har en gyldig e-postadresse registrert i SuperOffice CRM, endres ![ikon][img1] ikonet til inaktivt ![ikon][img3] i fanen **Deltakere** .

    > [!NOTE]
    > Hvis du har valgt brukere eller ressurser ved en feiltakelse, merker du dem i listen lengst til høyre, og deretter klikker du på **Slett** for å fjerne dem.

8. Når du har valgt deltakere og ressurser, klikker du på **Lagre** for å lagre det du har valgt, eller på **Avbryt** for å gå ut av dialogboksen uten å lagre.

## Hva skjer neste

1. Når du har lagret oppfølgingen, vises den i dialogboksen **Invitasjoner** i SuperOffice CRM hos den andre personen.

2. Hvis den andre personen avslår invitasjonen, vises den som avslått i dialogboksen **Invitasjoner** hos deg.

3. Du kan nå klikke på knappen **Finn ny tid** for å finne en ny tid som passer. Dialogboksen for oppfølginger vises, og du kan angi en ny tid. I praksis blir punkt 2 til 4 gjentatt til dere finner et tidspunkt som passer.

> [!TIP]
> Hvis du har mye informasjon på listen med invitasjoner, og bare ønsker å vise tilbakemeldinger fra andre, kan du filtrere ved hjelp av avmerkingsboksen **Vis svar**.

### Hvordan angir jeg om en ekstern person har godtatt eller avslått invitasjonen?

Eksterne deltakere blir varslet via e-post (hvis du valgte dette alternativet i dialogboksen for invitasjonen). E-postinvitasjoner som sendes til eksterne personer, inneholder en iCal-fil (.ics) sammen med invitasjonsdataene. Når de svarer på invitasjonen din, oppdateres [statusen][1] automatisk i SuperOffice.

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
[2]: ../screen/dialog-for-followups.md
[3]: ../create-follow-up.md
[4]: ../video-meetings.md
[5]: https://community.superoffice.com/globalassets/user--admin/learning/user-guide/diary--appointments/add-contact-to-appointment.mp4

<!-- Referenced images -->
[img1]: ../../../../../common/icons/pref-email.png
[img2]: ../../../../media/icons/arrow-right.png
[img3]: ../../../../media/icons/email-inactive.png
