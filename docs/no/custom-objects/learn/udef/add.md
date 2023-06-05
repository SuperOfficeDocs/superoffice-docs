---
uid: help-no-udef-add
title: Legge til felt
description: Legge til felt
author: SuperOffice RnD
so.date: 02.23.2023
keywords: udef, brukerdefinerte, egendefinert felt
so.topic: howto
so.user: admin
so.user.tooltip: Settings and maintenance
language: no
---

# Legge til brukerdefinert felt

Se denne videoen for å finne ut hvordan du kan opprette dine egne ekstra felt i SuperOffice CRM (videolengde – 2.51):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/SpeZVxpxeMM]

## Trinn

1. [!include[Go to fields and select tab](includes/goto-fields.md)]

1. Klikk på **Legg til**-knappen under listen **Felt**.

1. Skriv inn ønsket navn i **Navn**-feltet.

1. I listeboksen **Type** velger du [hvilken type felt ][6]du vil legge til (for eksempel nummer, tekst eller dato).

1. I feltet **Standardverdi** skriver du inn verdien som settes inn som standard i dette feltet.

1. I feltet **Tekst i infoboks** skriver du inn en kort beskrivelse som skal vises når du holder musepekeren over feltet. Dette kan være en beskrivelse med informasjon til brukerne som skal bruke dette feltet.

1. **Prog-ID**-feltet inneholder en standard-ID for dette feltet. Prog-ID-en kan overstyres av partnerne våre for bedre forbindelse med partnerapplikasjoner. I stedet for å endre koden, kan de skrive et navn som er mer hensiktsmessig, eller en bestemt ID for et brukerdefinert felt (UDEF).

1. Merk av for **Obligatorisk** hvis du vil at utfyllingen av dette feltet skal være obligatorisk.

    > [!NOTE]
    > Gjelder ikke for felttypen **Avmerkingsboks**.

1. Merk av for **Skjul ledetekst** hvis du ikke vil at navnet på feltet skal vises.

1. Merk av for **Kun lesbart** hvis du ikke vil at det skal være mulig å endre feltet.

    > [!NOTE]
    > Du kan ikke merke av for **Kun lesbart** hvis du har merket av for **Obligatorisk**. Du kan bare merke av for ett av disse alternativene om gangen.

1. Merk av for **Indeksert** hvis du vil at det skal være mulig å søke på dette feltet.

1. Når du har angitt ønskede alternativer, klikker du på **Lagre**. Dialogboksen lukkes, og det nye feltet vises i **Felt**-listen og i rutenettet.

    > [!TIP]
    > Nederst til høyre i dialogboksen **Felt** er **Malvariabelnavn** etterfulgt av en kode (ID), som kan brukes til å gjenbruke informasjonen du skriver inn i dette feltet, for eksempel som [malvariabler][2] i dokumenter og e-poster.

1. [Juster feltets posisjon][3].

1. Klikk på **Publiser** hvis du vil at feltet skal være tilgjengelig for SuperOffice CRM-brukere. Upubliserte felt ![ikon][img1] og felt med upubliserte endringer ![ikon][img2] vises med fet skrift i listen **Felt**.

## Hvorfor er det lurt å indeksere?

Når du velger **Indeksert**, blir det raskere å søke på disse feltene ved hjelp av **Finn**. Det er mulig å søke på ikke-indekserte felt også, men søkingen vil ta lengre tid. Du bør bare indeksere felt som det ofte søkes på, og som inneholder data som brukes ofte.

## Feilsøking

### Jeg kan ikke opprette et nytt felt

Hvis du ikke får lov til å opprette et nytt felt, kan det skyldes at du allerede har nådd [maksimalt antall tillatte felt][1] av denne typen. Da må du eventuelt slette et eksisterende felt før du kan sette inn et nytt.

Fire av hver felttype (Kort tekst, Lang tekst, Nummer, Desimaltall) er søkbare. Hvis du for eksempel ikke merker noen felt som søkbare, kan du bare angi seks Desimaltall-felt.

## Aktuelle emner

* [Plassere felt][3]
* [Rediger felt][4]
* [Redigere TAB-rekkefølgen på felt][5]
* [Maksimalt antall felt][1]
* [Skjermdesigner][7]

<!-- Referenced links -->
[1]: limitations.md
[2]: ../../../document/learn/template-variables.md
[3]: move.md
[4]: edit.md
[5]: change-tab-order.md
[6]: index.md#field-types
[7]: ../../../ui/screen-designer/learn/index.md

<!-- Referenced links -->
[img1]: ../../../../media/icons/admin/fields-unpublish-new.png
[img2]: ../../../../media/icons/admin/fields-unpublish-changed.png
