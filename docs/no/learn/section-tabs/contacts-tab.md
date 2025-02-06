---
uid: help-no-section-tab-contacts
title: Personfanen
description: Lær hvordan du administrerer og interagerer med personinformasjon knyttet til firmaer ved å bruke detaljkortet Personer i SuperOffice CRM. Spor personopplysninger og oppretthold kommunikasjon for sømløse kundeopplevelser.
keywords: detaljkortet Personer, Personfanen, Personer-fanen, seksjonsfane, personarkiv, aktiver mellomnavn
author: Bergfrid Skaara Dias
date: 01.29.2025
version: 10.5
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Personfanen

Detaljkortet **Personer** i SuperOffice CRM lar brukere se og administrere alle [personer][1] knyttet til et bestemt firma. Denne fanen hjelper brukerne med å holde oversikt over relasjonene mellom firmaet og dets ansatte eller andre relevante personer. Ved å tilby en organisert liste over alle tilknyttede individer, legger fanen til rette for enkel tilgang til personopplysninger og gjør det enkelt å opprettholde detaljert kommunikasjon. Detaljkortet **Personer** er kun tilgjengelig på [Firmaskjermen][9].

![Detaljkortet Personer i Firmaskjermen -screenshot][img1]

## <a id="columns"></a>Kolonneoversikt for Personfanen

**Personer**-fanen inneholder følgende kolonner for å vise nøkkelinformasjon om hver person:

| Kolonne | Beskrivelse av detaljkortet |
|---|---|
| Info           | Viser et binders-ikon (<i class="ph ph-paperclip" aria-hidden="true"></i>) hvis **Notat**-fanen i Personkortet har et notat. Hold musepekeren over ikonet for å vise notatet. |
| Interesser     | Viser en prikk hvis personen har interesser. Hold musepekeren over ikonet for å se interessene. |
| Hr/Fr       | Viser hvordan personen skal tituleres. |
| Fornavn / Mellomnavn / Etternavn | Fullt navn på personen. Bruken av mellomnavn kan konfigureres i **Innstillinger og vedlikehold**. |
| Tittel         | Viser personens profesjonelle tittel eller rolle i firmaet. |
| Mobiltelefon   | Personens mobiltelefonnummer. |
| E-post         | Personens e-postadresse. Klikk på e-posten for å [åpne en ny melding][7] i ditt foretrukne e-postprogram. |

[!include[Konfigurer kolonner](../includes/tip-configure-columns.md)]

## Se personer i Personfanen

1. Gå til relevant **Firmaskjerm**.

1. Klikk på detaljkortet **Personer** for å se alle personer knyttet til firmaet.

1. Dobbeltklikk på en person i listen for å åpne Personskjermen for mer detaljert informasjon.

### Inkluder tidligere ansatte

For å inkludere personer som har sluttet i firmaet, merk av alternativet **Tidligere ansatte**. Tidligere ansatte vises i en annen farge i listen, samt i detaljkortet **Prosjektdeltakere** i Prosjektskjermen og i medlemslistene på Utvalgsskjermen.

## Opprett en ny person

1. Klikk på **Legg til** for å [opprette en ny person][2] knyttet til firmaet.

1. Fyll inn nødvendig informasjon, og klikk på **Lagre**.

## Rediger kontaktinformasjon

1. Dobbeltklikk på personen du ønsker å [redigere][3].

1. I Personkortet, gjør de ønskede endringene.

1. Klikk på **Lagre** for å bekrefte oppdateringene dine.

## Rediger personinteresser

1. Dobbeltklikk på personens navn for å åpne Personkortet.

1. Gå til **Interesser**-fanen for å oppdatere interessene knyttet til personen.

## Slå sammen eller flytte personer

* For å slå sammen personer, følg trinnene i [sammenføye personer][5].

* For å flytte en person til et annet firma, følg trinnene i [flytte personer][4].

## Aktiver støtte for mellomnavn

Du kan aktivere bruk av mellomnavn i **Innstillinger og vedlikehold** ved å følge disse trinnene:

1. Gå til Innstillinger og vedlikehold.

1. Gå til **Preferanse** > **Globale preferanser** > **Funksjoner**.

1. Velg **Aktiver bruk av mellomnavn**.

Hvis denne preferansen er aktivert, vil den første delen av etternavnet brukes som mellomnavn (men det sorteres ikke på). Hvis ikke aktivert, kan du legge inn et mellomnavn i **Fornavn-feltet**, som da vil bli behandlet som et andre fornavn.

## Relatert innhold

* [Opprett ny person][2]
* [Slett person][6]
* [Konfigurer kolonner i detaljkort][8]

<!-- Referenced links -->
[1]: ../../contact/learn/index.md
[2]: ../../contact/learn/create.md
[3]: ../../contact/learn/edit.md
[4]: ../../contact/learn/move.md
[5]: ../../contact/learn/merge-contacts.md
[6]: ../../contact/learn/delete.md
[7]: ../../contact/learn/send-email.md
[8]: configure-columns.md
[9]: ../../company/learn/index.md#section-tabs

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/contacts-detail.png
