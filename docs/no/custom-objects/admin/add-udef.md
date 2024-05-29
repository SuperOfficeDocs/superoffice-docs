---
uid: help-no-udef-add
title: Legge til brukerdefinert felt
description: Legge til brukerdefinert felt
keywords: udef, brukerdefinert, egendefinert felt, feltegenskaper
author: Bergfrid Dias
so.date: 01.25.2024
so.version: 10
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: no
---

# Legge til brukerdefinert felt

Se denne videoen for å finne ut hvordan du kan opprette dine egne ekstra felt i SuperOffice CRM (videolengde – 2.51):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/SpeZVxpxeMM]

## Trinn

1. [!include[Gå til Felt og velg fane](includes/goto-fields.md)]

1. Klikk på **Legg til** under listen **Felt**.

1. Skriv inn et **Navn** og velg en [**Type**][2] (for eksempel nummer, tekst eller dato).

1. Sett eventuelt andre [feltegenskaper](#properties), som om feltet er obligatorisk eller skal indekseres.

1. Når du er ferdig, klikk på **Lagre**. Dialogen lukkes, og det nye feltet vises i **Felt**-listen og i rutenettet.

1. [Valgfritt, juster feltets posisjon][3]. Dette krever lisensen Development Tools!

1. Fortsett å legge til felt. Klikk på **Publiser** når du er ferdig for å gjøre feltet tilgjengelig for SuperOffice-brukere. Upubliserte felt ![ikon][img1] og felt med upubliserte endringer ![ikon][img2] vises i fet tekst i listen **Felt**.

## <a id="properties" />Feltegenskaper

| Egenskap | Beskrivelse |
|---|---|
| Standardverdi | Verdien som skal settes inn som standard i dette feltet. |
| Tekst i infoboks | En kort beskrivelse som vises når du holder musepekeren over feltet. For eksempel bruksinformasjon. |
| Prog-ID | En standard-ID for dette feltet. Formatet er **tekst:nummer**. Behold tekstdelen som bokstaver a-z eller deres store bokstav-ekvivalenter. Kan overstyrres av SuperOffice-partnere. |
| Obligatorisk | Gjør det obligatorisk å fylle ut dette feltet. Gjelder ikke for felttypen **Avmerkingsboks**. |
| Skjul ledetekst | Hvis valgt, vises ikke navnet på feltet. |
| Kun lesbart | Hvis valgt, er det ikke mulig å endre feltet. |
| Indeksert | Hvis valgt, blir dette feltet søkbart og det blir raskere å søke på disse feltene ved hjelp av **Finn**. Ikke-indekserte felt kan også søkes på, men søkingen vil ta lengre tid. Indekser bare felt som ofte blir søkt og inneholder ofte brukte data. |

> [!NOTE]
> Du kan ikke krysse av for **Kun lesbart** hvis du har krysset av for **Obligatorisk**. Disse alternativene er gjensidig utelukkende.

## Hvor vises feltene jeg oppretter?

* [Mer-fanen (Firma)][16]
* [Mer-fanen (Kontaktperson)][17]
* [Mer-fanen (Prosjekt)][13]
* [Mer-fanen (Oppfølginger)][14]
* [Mer-fanen (Dokument)][15]
* [Mer-fanen (Salg)][19]

> [!TIP]
> Nederst til høyre i dialogboksen **Felt** er **Malvariabelnavn** etterfulgt av en kode (ID), som kan brukes til å gjenbruke informasjonen du skriver inn i dette feltet, for eksempel som [malvariabler][12] i dokumenter og e-poster.

## Feilsøking

### Jeg kan ikke opprette et nytt felt

Hvis du ikke får lov til å opprette et nytt felt, kan det skyldes at du allerede har nådd [maksimalt antall tillatte felt][1] av denne typen. Da må du eventuelt slette et eksisterende felt før du kan sette inn et nytt.

Fire av hver felttype (Kort tekst, Lang tekst, Nummer, Desimaltall) er søkbare. Hvis du for eksempel ikke merker noen felt som søkbare, kan du bare angi seks Desimaltall-felt.

## Aktuelle emner

* [Plassere felt][3]
* [Rediger feltegenskaper][4]
* [Skjermdesigner][11]

<!-- Referenced links -->
[1]: ../learn/udef.md#limit
[2]: ../learn/udef.md#field-types
[3]: edit-udef-layout.md
[4]: edit-udef.md
[11]: ../../ui/screen-designer/learn/index.md
[12]: ../../document/learn/template-variables.md
[13]: ../../project/learn/index.md#more-tab
[14]: ../../diary/learn/follow-ups.md#more-tab
[15]: ../../document/learn/screen/index.md
[16]: ../../company/learn/create.md#more-tab
[17]: ../../contact/learn/create.md#more-tab
[19]: ../../sale/learn/index.md

<!-- Referenced links -->
[img1]: ../../../media/icons/admin/fields-unpublish-new.png
[img2]: ../../../media/icons/admin/fields-unpublish-changed.png
