---
uid: help-no-sale-add-type
title: Legge til salgstype
description: Legge til salgstype
author: SuperOffice RnD
date: 06.29.2022
keywords: salgstype
topic: howto
language: no
---

# Legge til salgstype

[!include[Must be admin](../../../learn/includes/req-admin.md)]

[!include[Note difference](includes/different-edit-list-item-dialog.md)]

> [!NOTE]
> Et tilbud tilhører et salg, og alle salg har en salgstype. I hver salgstype kan du definere mange av egenskapene for tilbud, blant annet vedlegg, innstillinger for godkjenning, bruk av alternativer, og maler.

[!include[Edit list item](includes/edit-list-item.md)] når forekomster er salgstyper:

1. Skriv inn ønsket navn på forekomsten i feltet **Navn**.

    [!include[Mandatory](includes/note-mandatory-field.md)]

2. Velg eventuelt ønsket kategori for salgstypen i listeboksen **Kategori for salgstype**.

    > [!TIP]
    > Du kan opprette nye alternativer i tillegg til de forhåndsdefinerte ved å [legge til forekomster][2] på listen **Salg - Kategori (for salgstype)** i Innstillinger og vedlikehold.

3. I feltet **Anslått tid for denne salgstypen** angir du en varighet for salgstypen (antall uker, dager eller måneder). Når du oppretter et nytt salg med denne salgstypen, settes salgsdatoen i henhold til tiden du har angitt her (dagens dato + estimert tid).

4. Skriv inn en beskrivelse av salgstypen nederst i dialogboksen.

5. Angi informasjon i fanene **Faser**, **Vedlegg**, **Standardverdier** og **Godkjenning**. Dette er beskrevet nedenfor.

    > [!NOTE]
    > Fanene **Vedlegg**, **Standardverdier** og **Godkjenning** er bare relevante hvis du har Sales Quote Management-lisensen.

6. [!include[Save or cancel](includes/save-or-cancel.md)]

## Fanen Faser

I fanen **Faser** gjør du følgende:

1. I listen **Aktive faser for denne salgstypen** merker du av for de fasene du vil ha med i salgstypen. Dette trinnet er ikke obligatorisk, men for å tilknytte salgstypen til en salgsguide, bør du merke av for minst to faser.

    [Slik oppretter du en fase][3].

2. Merk av for **Denne salgstypen er tilknyttet en guide** hvis du vil at alle salg med denne salgstypen skal følge en [salgsguide][5].

3. Velg eventuelt **Foreslå automatisk flytting av salget til neste fase**.

    Når alle oppfølginger og dokumenter for en fase er fullført, blir du spurt om du vil gå til neste fase.

4. Merk av for **Denne salgstypen har interessenter** for å gjøre det mulig å knytte til [interessenter][4] til salg med denne salgstypen.

## Fanen Vedlegg

I fanen **Vedlegg** kan du legge til dokumenter som skal sendes til kunden sammen med et tilbud. For eksempel produktspesifikasjoner, brosjyrer og så videre.

> [!NOTE]
> Dokumentene må først legges til som dokumentmaler i SuperOffice.

### Legge til tilbudsvedlegg

1. Klikk på **Legg til**.
2. [Søk etter dokumentene du vil legge til][1], i Finn-bildet.
3. Velg ett eller flere dokumenter, og klikk på **OK**. Dokumentene vises i fanen **Vedlegg**.
4. Merk av for dokumentene du vil inkludere, i kolonnen **Inkluder**.

Når du oppretter et tilbud med denne salgstypen, blir de avmerkede dokumentene lagt til som vedlegg i tilbudet. De blir imidlertid ikke lagt til på detaljkortet **Aktiviteter** i salget.

## Standardverdier

Innstillinger for tilbud med denne salgstypen:

* **Tillat bruk av alternativer i tilbud**: Merk av her hvis brukerne skal kunne legge til flere alternativer i et tilbud.
* **Antall dager et tilbud er gyldig**: Angi antall dager som tilbudet skal være gyldig. Denne verdien kan endres når tilbudet sendes.
* **Mal for tilbudsformat**: Merk av for malen du vil bruke for tilbudet.
* **Bekreftelsesdokument**: Merk av for malen du vil bruke for bekreftelsen.

## Godkjenning

Her kan du velge om tilbudet må godkjennes hvis totalrabatten er over en viss grense eller total fortjeneste er under en viss grense:

* Ingen godkjenning kreves. Ingen begrensninger. Tilbudet behøver ikke å godkjennes.
* **Totalrabatt er over grensen**. Angi en prosentverdi.
* **Total fortjeneste er under grensen**. Angi en prosentverdi.

## Aktuelt innhold

* [Tilbudsmaler][6]

<!-- Referenced links -->
[2]: adding-items.md
[3]: ../../../sale/learn/screen/sale-stage.md
[4]: ../../../sale/learn/stakeholders/index.md
[5]: ../../../sale/learn/screen/sales-guide-admin.md
[1]: ../../../search-options/learn/search-criteria.md
[6]: ../../../document/templates/learn/quote-templates.md

<!-- Referenced images -->
