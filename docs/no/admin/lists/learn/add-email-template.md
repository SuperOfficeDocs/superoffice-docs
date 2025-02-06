---
uid: help-no-add-email-template
title: Legge til e-postmal
description: Legge til e-postmal
author: SuperOffice RnD
date: 06.29.2022
keywords: Innstillinger og vedlikehold
topic: help
language: no
---

# Legge til en e-postmal

E-postmaler kan brukes til å opprette nye e-postmeldinger i SuperOffice-innboksen, og når du sender tilbud, ordrebekreftelser og personvernbekreftelser.

Maler vises som elementer i listen **E-post – mal**, og du kan legge til nye maler i SuperOffice CRM ved å angi dem som et element i listen.

[!include[Edit list item](includes/edit-list-item.md)] når elementene er e-postmaler:

1. Skriv inn ønsket navn på forekomsten i feltet **Malnavn**.

2. Velg maltypen du oppretter i feltet **Maltype**. Velg **Normal** hvis du vil at malen skal være tilgjengelig i **Innboks**. Du kan også gjøre malen tilgjengelig som en tilbudsmal, et [bekreftelsesdokument][3] eller en [personvernbekreftelsesmal][4].

3. Velg eventuelt hvor du vil lagre dokumentmalen, i listen **Lagre malen i**.

4. Du har tre valg:

    * **Opprette en ny e-postmal**
    * **Kopiere en eksisterende e-postmalfil**.
        1. Klikk på listen **Kopier mal**.
        2. Velg ønsket mal på listen.
    * **Laste opp en ny e-postmal fra harddisken (.md/.md)**
        1. Klikk på **Last opp**.
        2. Klikk på **Last opp fil** i dialogboksen **Last opp fil**.
        3. Velg ønsket fil, og klikk på **Åpne**. Navnet på filen vises i dialogboksen **Rediger forekomst**.

5. Klikk på **Lagre** i dialogboksen **Rediger forekomst**. Dialogboksen oppdateres.

6. Valgfritt: Rediger malnavnet om nødvendig.

7. Klikk på **Rediger** for å redigere selve malfilen. Hvis du har opprettet en ny e-postmal, legger du til innhold i malen.

8. Angi ønsket informasjon i fanene **Detaljer** og **Språk**.

9. Klikk på **Lagre**. Malen blir nå lagt til som en egen forekomst i listen **Forekomster**. Gjenta prosedyren hvis du vil legge til flere maler.

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
2. I dialogboksen **Rediger forekomst** velger du ønsket språk fra listen **Legg til språk**.
3. Legg til den oversatte dokumentmalen som beskrevet ovenfor.
4. Klikk på **Legg til**. Språket vises i fanen **Språk**.
5. Gjenta trinnene ovenfor for å legge til flere språk.

> [!TIP]
> Klikk på <i class="ph ph-translate" aria-label="Translate"></i> ved siden av det relevante feltet for å [legge til oversettelser][1] av malnavn og e-postemne.

<!-- Referenced links -->
[1]: ../../../globalization-and-localization/learn/translate-fields.md
[2]: ../../../document/templates/learn/template-variables.md
[3]: ../../../sale/admin/sale-type.md
[4]: privacy-source-add.md
[5]: ../../../saint/learn/index.md

<!-- Referenced images -->
