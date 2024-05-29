---
uid: help-da-udef-add
title: Tilføj brugerdefinerede felter
description: Tilføj brugerdefinerede felter
author: Bergfrid Dias
so.date: 01.25.2024
so.version: 10
keywords: udef, brugerdefineret, tilpasset felt
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: da
---

# Tilføj brugerdefinerede felter

Se denne video for at finde ud af, hvordan du kan oprette dine egne ekstrafelter i SuperOffice CRM (videolængde - 2:51):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/SpeZVxpxeMM]

## Trin

1. [!include[Gå til Felter og velg fane](includes/goto-fields.md)]

1. Klik på knappen **Tilføj** under listen **Felt**.

1. Indtast et **Navn** og vælg en [**Type**][2] (for eksempel nummer, tekst eller dato).

1. Indstil eventuelt andre [feltegenskaber](#properties), såsom om feltet er obligatorisk eller skal indekseres.

1. Når du er færdig, klik på **Gem**. Dialogboksen lukkes, og det nye felt vises i **Felt**-listen og i gitteret.

1. [Valgfrit, justér feltets placering][3]. Dette kræver licensen Development Tools!

1. Fortsæt med at tilføje felter. Klik på **Udgiv**, når du er færdig, for at gøre feltet tilgængeligt for SuperOffice-brugere. Upublicerede felter ![ikon][img1] og felter med upublicerede ændringer ![ikon][img2] vises i fed tekst i listen **Felt**.

## <a id="properties" />Feltegenskaber

| Egenskab | Beskrivelse |
|---|---|
| Standardværdi | Værdien, der skal indsættes som standard i dette felt. |
| Værktøjstip | En kort beskrivelse, der vises, når musemarkøren holdes over feltet. For eksempel, brugsoplysninger. |
| Prog-ID | En standard ID for dette felt. Formatet er **tekst:nummer**. For tekst, brug bogstaver a-z eller deres store bogstavækvivalenter. Kan tilsidesættes af SuperOffice-partnere. |
| Obligatorisk | Gør det obligatorisk at udfylde dette felt. Gælder ikke for felttypen *Afkrydsningsfelt*. |
| Skjul etiket | Hvis valgt, vises navnet på feltet ikke. |
| Skrivebeskyttet | Hvis valgt, er det ikke muligt at ændre feltet. |
| Indekseret | Hvis valgt, bliver dette felt søgbart og fremskynder **Find**. Der kan også søges i ikke-indekserede felter, men søgningen tager længere tid. Indekser kun felter, der ofte søges i og som indeholder almindeligt anvendte data. |

> [!NOTE]
> Du kan ikke vælge **Skrivebeskyttet**, hvis du har valgt **Obligatorisk**. Disse muligheder udelukker hinanden.

## Hvor vises de felter, jeg opretter?

* [Fanen Mere (Firma)][16]
* [Fanen Mere (Person)][17]
* [Fanen Mere (projekt)][13]
* [Fanen Mere (opfølgninger)][14]
* [Fanen Mere (Dokument)][15]
* [Fanen Detaljer på skærmbilledet Salg][19]

> [!TIP]
> Nederst til højre i dialogboksen **Felt** er **navnet på skabelonvariablen** efterfulgt af en kode (ID), som kan bruges til at genbruge de oplysninger, du indtaster i dette felt, f.eks. som [skabelonvariabler][12] i dokumenter og mails.

## Fejlfinding

### Jeg kan ikke oprette et nyt felt

Hvis du finder ud af, at du ikke har tilladelse til at oprette et nyt felt, kan det skyldes, at du allerede har nået det [maksimale antal tilladte felter][1] af denne type. Du skal derefter slette et eksisterende felt, før du kan indsætte et nyt.

Fire af hver felttype (kort tekst, lang tekst, tal, decimal) er søgbare. Hvis du f.eks. ikke markerer nogen felter, der kan søges i, kan du kun angive seks decimalfelter.

## Relaterede emner

* [Placering af felter][3]
* [Redigering af feltegenskaber][4]
* [Skærmdesigner][11]

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
