---
uid: help-no-add-email-template
title: Legge til e-postmal
description: Legge til e-postmal
keywords: listen E-post - Mal, e-postmal
author: digitaldiina
date: 10.29.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Innstillinger og vedlikehold
index: true
redirect_from:
  - /no/admin/lists/learn/email-template
  - /no/admin/lists/learn/add-email-template
  - /no/admin/lists/learn/create-email-template
  - /no/email/admin/index
language: no
---

# ## Legge til e-postmal

Det er viktig for en organisasjons profil at e-postmeldinger har et unikt og helhetlig utseende. Det betyr at alle e-postmeldinger som sendes ut av organisasjonen, bør bruke samme skrifttyper, formatering, logoer og så videre. Ved å lage e-postmaler som er tilpasset din organisasjon, sikrer du at organisasjonens personer lett gjenkjenner organisasjonens korrespondanse. E-postmaler brukes også når du sender tilbud, ordrebekreftelser og personvernbekreftelser.

SuperOffice CRM leveres med flere standardmaler som du kan bruke umiddelbart etter at du har installert programmet.

Du kan også opprette dine egne maler. Dette gjør du ved å legge inn [malvariabler][2] i e-postmalene, som deretter henter informasjon fra tilsvarende felt i SuperOffice CRM når du skriver en e-post med en mal du har laget.

Maler vises som elementer i listen **E-post – mal**, og du kan legge til nye maler i SuperOffice CRM ved å angi dem som et element i listen.

## Trinn

1. Velg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i navigatoren.

1. Velg **E-post – mal** fra rullegardinmenyen. Fanen **Elementer** viser alle eksisterende ressurser.

1. Klikk på **Legg til** for å åpne dialogboksen **Rediger listeelement**.

1. Skriv inn ønsket navn på forekomsten i feltet **Malnavn**.

1. Velg maltypen du oppretter i feltet **Maltype**. Velg **Normal** hvis du vil at malen skal være tilgjengelig i **Innboks**. Du kan også gjøre malen tilgjengelig som en tilbudsmal, et [bekreftelsesdokument][3] eller en [personvernbekreftelsesmal][4].

1. Velg eventuelt hvor du vil lagre dokumentmalen, i listen **Lagre malen i**.

1. Du har tre valg:

    * **Opprette en ny e-postmal**
    * **Kopiere en eksisterende e-postmalfil**.
        1. Klikk på listen **Kopier mal**.
        2. Velg ønsket mal på listen.
    * **Laste opp en ny e-postmal fra harddisken (.md/.md)**
        1. Klikk på **Last opp**.
        2. Klikk på **Last opp fil** i dialogboksen **Last opp fil**.
        3. Velg ønsket fil, og klikk på **Åpne**. Navnet på filen vises i dialogboksen **Rediger forekomst**.

1. Klikk på **Lagre** i dialogboksen **Rediger forekomst**. Dialogboksen oppdateres.

1. Valgfritt: Rediger malnavnet om nødvendig.

1. Klikk på **Rediger** for å redigere selve malfilen. Hvis du har opprettet en ny e-postmal, legger du til innhold i malen.

1. Angi ønsket informasjon i fanene **Detaljer** og **Språk**.

1. Klikk på **Lagre**. Malen blir nå lagt til som en egen forekomst i listen **Forekomster**. Gjenta prosedyren hvis du vil legge til flere maler.

1. Gjør e-postmalen tilgjengelig for de nødvendige brukergruppene. Se [Brukergruppefiltrering][7].

## Fanen Detaljer

Angi følgende informasjon i fanen **Detaljer**:

1. (valgfritt) Endre navnet på malen i **Navn**-feltet. Du kan også [legge til malnavnet på andre språk][1] ved å klikke på <i class="ph ph-translate" aria-label="Translate"></i>.

2. Skriv inn tittelen på e-postmeldingen i feltet **Emne**. Du kan også [legge til tittelen på andre språk][1] ved å klikke på <i class="ph ph-translate" aria-label="Translate"></i>.

3. Velg **Bruk signatur i ny e-post** til å legge til signaturen i nye e-postmeldinger. Hvis du ikke har en egen signatur, brukes systemsignaturen.

4. Velg **Vis e-postdialogen** for å vise dialogboksen **Ny e-post** når du oppretter en ny e-post basert på denne malen. I denne dialogboksen kan du skrive inn data som firma, person og prosjekt, som er nødvendig hvis e-postmalen inneholder malvariabler.

5. Legg eventuelt inn en beskrivelse av malen i feltet **Beskrivelse**.

6. I feltet **Retning** angir du om malen er utgående eller innkommende ved å klikke på <i class="ph ph-caret-down" aria-label="Chevron"></i> og velge fra listeboksen. Velg **Utgående** hvis du vil at malen skal være tilgjengelig i **Innboks**.

7. I **Hensikt**-feltet klikker du på <i class="ph ph-caret-down" aria-label="Chevron"></i> og velger et av de forhåndsdefinerte alternativene fra listeboksen. Disse elementene brukes i forbindelse med statusovervåking (krever lisens for [Sales Intelligence][5]).

    > [!TIP]
    > Du kan opprette nye alternativer i tillegg til de forhåndsdefinerte ved å legge til forekomster på listen **Oppfølging - Hensikt** i Innstillinger og vedlikehold.

8. I feltet **Dokument lagret i** kan du velge å lagre dokumentet et annet sted enn standardalternativet.

9. Angi standardoppsett for feltet **Vår referanse** ved hjelp av [malvariabler][2], for eksempel *auth* for avsenders fornavn og etternavn.

> [!NOTE]
> Du kan åpne malen for redigering direkte fra dialogboksen **Rediger forekomst** ved å klikke på **Rediger**-knappen øverst. Bare htm/html-filer kan redigeres i dette redigeringsprogrammet. Filtypen vises i feltet **Filnavn** i fanen **Detaljer**. Klikk på knappen **Last ned** for å laste ned andre filtyper og redigere dem i det aktuelle programmet.

## Fanen Språk

Her kan du legge til oversatte versjoner av dokumentmalen.

1. Klikk på **Legg til**.
1. I dialogboksen **Rediger forekomst** velger du ønsket språk fra listen **Legg til språk**.
1. Legg til den oversatte dokumentmalen som beskrevet ovenfor.
1. Klikk på **Legg til**. Språket vises i fanen **Språk**.
1. Gjenta trinnene ovenfor for å legge til flere språk.

> [!TIP]
> Klikk på <i class="ph ph-translate" aria-label="Translate"></i> ved siden av det relevante feltet for å [legge til oversettelser][1] av malnavn og e-postemne.

## Aktuelt innhold

* [Tilbudsmaler][6]

<!-- Referenced links -->
[1]: ../../localization/learn/translate-fields.md
[2]: ../../document/templates/learn/template-variables.md
[3]: ../../sale/admin/sale-type.md
[4]: ../../security/privacy/admin/add-source.md
[5]: ../../saint/learn/index.md
[6]: ../../document/templates/learn/quote-templates.md
[7]: ../../admin/lists/user-group-filtering.md
