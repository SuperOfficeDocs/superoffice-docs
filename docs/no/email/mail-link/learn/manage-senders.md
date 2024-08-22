---
uid: help-no-mail-link-senders
title: Administrere avsendere
description: Administrere avsendere
author: SuperOffice RnD
date: 06.29.2022
keywords: Mail Link
topic: howto, sender
language: no
---

# Administrere avsendere

Når du arkiverer en e-post eller et vedlegg, utfører SuperOffice CRM et søk for å se om avsenderen samsvarer med noen av de registrerte firmaene eller personene.

## Søke etter avsenderen av en e-post

Du kan bruke **Søk etter avsender**-knappen for å søke etter den nøyaktige e-postadressen til avsenderen i din [foretrukne SuperOffice-klient][4].

1. Velg e-posten i e-postklientens innboks (du kan bare velge én) hvis avsender du vil søke etter i SuperOffice.

2. Klikk på knappen **Søk etter avsender**.

3. Hva som skjer videre, avhenger av om avsenderen finnes i SuperOffice:
    * Hvis e-postadressen blir funnet på firma/person, åpnes firmaet/personen i SuperOffice.
    * Hvis e-postadressen er registrert på mer enn ett firma/person, vises en dialogboks som viser alternativene og lar deg velge en.
    * Hvis e-postadressen ikke er registrert i SuperOffice, kan du legge den til.
    * Bare SuperOffice CRM: Hvis avsenderen av den valgte e-posten er merket som en tidligere ansatt, vil firmaet/personen fortsatt være åpen, men avsenderen vises ikke i SuperOffice CRM med mindre du har valgt å vise tidligere ansatte.

## Håndtere e-post fra en avsender med flere oppføringer

Hvis avsenderen er oppført flere ganger i SuperOffice CRM, vises en dialogboks som informerer deg om dette og lar deg velge riktig oppføring.

## Håndtere en e-post fra en avsender som ikke er oppført i SuperOffice

Hvis avsenderen ikke er oppført i SuperOffice CRM, kan du legge til avsenderens e-postadresse i SuperOffice CRM.

1. Gjør ett av følgende:
    * [Arkiver e-postmeldingen på firmaer/personer][1]
    * [Arkiver e-posten som aktivitet][2]
    * [Arkivere vedlegg][3]

2. Hvis avsenderen av e-posten eller vedlegget ikke er registrert i SuperOffice CRM, vises en advarsel øverst i dialogboksen for arkivering av e-post når du prøver å arkivere: "Denne avsenderens e-postadresse gjenkjennes ikke. Klikk her for å oppdatere SuperOffice med denne e-postadressen". Klikk på advarselen.

3. I dialogboksen **Lagre e-postadresse** velger du en av følgende alternativknapper:
    * **Opprett ny person**: Klikk dette alternativet for å [legge til e-postadressen i en ny person](#new-contact).
    * **Legg til e-postadresse på eksisterende person**: Klikk dette alternativet for å [legge til e-postadressen i en eksisterende person](#existing-contact).

4. Klikk på **OK**. Personen og e-postadressen deres vises på detaljkortet **Personer** på det angitte firmakortet.

> [!NOTE]
> Hvis du prøver å arkivere mer enn én e-post om gangen, vil du bli spurt om hver avsender som ikke er oppført i SuperOffice CRM.

## <a id="new-contact"></a>Legge til en e-postadresse for en ny person

1. Åpne dialogboksen **Lagre e-postadresse**.

2. Velg alternativet **Opprett ny person**.

3. I **Firma**-feltet velger du firmaet du vil lagre den nye personen i. Du kan søke etter et firma ved å begynne å skrive inn firmanavnet og deretter velge blant treffene som vises.

4. Skriv inn nødvendig informasjon om personen, for eksempel navn, e-postadresse og telefonnummer.

5. Klikk på **OK**. Personen og e-postadressen deres vises på detaljkortet **Personer** på det angitte firmakortet.

## <a id="existing-contact"></a>Legge til en e-postadresse for en eksisterende person

1. Åpne dialogboksen **Lagre e-postadresse**.

2. Velg alternativet **Legg til e-postadresse på eksisterende person**.

3. I **Firma**-feltet velger du firmaet du vil registrere e-postadressen på. Du kan søke etter et firma ved å begynne å skrive inn firmanavnet og deretter velge blant treffene som vises.

4. I **Person**-feltet velger du blant personene som er registrert for det aktuelle firmaet.

5. Velg **Angi som primær e-postadresse for denne personen** hvis personen har mer enn én e-postadresse, og du vil at denne skal brukes som standardadresse.

6. Klikk på **OK**. Personen og e-postadressen deres vises på detaljkortet **Personer** på det angitte firmakortet.

## Ikke legge til en e-postadresse i SuperOffice

Det er mulig å arkivere en e-post/et vedlegg eller søke etter en avsender uten å legge til e-postadressen i SuperOffice CRM.

Hvis du ikke vil legge til e-postadressen i SuperOffice CRM, må du ikke klikke på advarselen i dialogboksen **Arkiver e-post**.

<!-- Referenced links -->

[1]: archive-on-contact.md
[2]: archive-as-activity.md
[3]: archive-attachment.md
[4]: settings/superoffice-account.md

<!-- Referenced images -->
