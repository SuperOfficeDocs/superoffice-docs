---
uid: help-no-udef-add
title: Legge til brukerdefinert felt
description: Legge til brukerdefinert felt
keywords: udef, brukerdefinert, egendefinert felt, feltegenskaper
author: Bergfrid Dias
date: 11.29.2024
version: 10
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
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

    Bruk et [språkprefiks](#language) for å spesifisere navnet på flere språk som dette: `US:"Language";NO:"Språk"`

    ![UDEF-feltnavn på flere språk -screendshot][img3]

1. Sett eventuelt andre [feltegenskaper](#properties), som om feltet er obligatorisk eller skal indekseres.

1. Når du er ferdig, klikk på **Lagre**. Dialogen lukkes, og det nye feltet vises i **Felt**-listen og i rutenettet.

1. [Valgfritt, juster feltets posisjon][3]. Dette krever lisensen Development Tools!

1. Fortsett å legge til felt. Klikk på **Publiser** når du er ferdig for å gjøre feltet tilgjengelig for SuperOffice-brukere. Upubliserte felt og felt med upubliserte endringer vises i fet tekst i listen **Felt**.

## <a id="properties"></a>Feltegenskaper

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

## <a id="language"></a>Språkkoder

[!include[Språkkoder](../../globalization-and-localization/includes/table-legacy-language-codes.md)]

## Hvor vises feltene jeg oppretter?

Egendefinerte felter du oppretter, vil vises i [Mer-fanen][5] for firmaer, personer, salg og prosjekter, samt i oppfølgings- og dokumentdialogene.

Nederst til høyre i dialogboksen **Felt** er **Malvariabelnavn** etterfulgt av en kode (ID), som kan brukes til å gjenbruke informasjonen du skriver inn i dette feltet, for eksempel som [malvariabler][12] i dokumenter og e-poster.

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
[5]: ../learn/more-tab.md
[11]: ../../ui/screen-designer/learn/index.md
[12]: ../../document/templates/learn/template-variables.md

<!-- Referenced links -->
[img3]: ../../../media/loc/en/custom-objects/add-udef-multi-languages.png
