---
uid: help-da-udef
title: Felter
description: Felter
author: SuperOffice RnD
so.date: 06.29.2022
keywords: udef, tilpasset felt
so.topic: concept
so.user: admin
so.user.tooltip: Settings and maintenance
language: da
---

# Brugerdefinerede felter

Flere dele af SuperOffice CRM, for eksempel skærmbilledet Firma, har en separat fane, der hedder Mere. Her kan du tilføje dine egne felter for at tilpasse programmet organisationens egne behov.

Alle virksomheder og organisationer har deres egne krav til de oplysninger, de har brug for at registrere vedrørende deres kunder, salg, projekter, kontrakter og så videre. Du kan indtaste dine egne felter til SuperOffice CRM på skærmbilledet **Felter** . På denne måde kan du tilpasse den type oplysninger, der kan registreres vedrørende virksomheder, kontakter, projekter, salg, dokumenter og opfølgninger.

> [!NOTE]
> Du kan angive 3 felter, der kan vises på "første side" i deres respektive skærme eller dialoger. [Hvordan][1]. Bemærk, at dette muligvis ikke gælder, hvis du bruger et andet layout via [skærmdesigneren][8].

## <a id="field-types" />Felttyper

[!include[List of field types](includes/field-types.md)]

## Hvilken fordel får jeg af de oplysninger, jeg indtaster i disse felter?

* Ved hjælp af funktionen **Find** kan du søge efter de oplysninger, du registrerer i disse felter, og foretage valg.
    **For eksempel**: Hvis du f.eks. registrerer udløbsdatoen for den vedligeholdelsesaftale, du har med personer, kan du oprette et dynamisk valg, der viser de personer, som aftalen udløber for, om mindre end en måned.

* Du kan genbruge oplysningerne fra disse felter i dokumenter og mails ved hjælp af skabelonvariabler. Hvert felt, du tilføjer, får sit eget entydige id, som kan bruges i dokumenter til at flette personspecifikke oplysninger.
    **For eksempel**: Hvis du sender mail til kunder, der angiver, at vedligeholdelsesaftalen snart udløber, kan skabelonvariablen for udløbsdato bruges til at angive den korrekte udløbsdato i den meddelelse, der sendes.

## Hvor vises de felter, jeg opretter?

* [Fanen Mere (Firma)][6]
* [Fanen Mere (Person)][7]
* [Fanen Mere (projekt)][3]
* [Fanen Mere (opfølgninger)][4]
* [Fanen Mere (Dokument)][5]
* Fanen Detaljer på skærmbilledet Salg

 Du kan angive *side 1-felter* (felter, der kan vises på "første side" i deres respektive skærme eller dialoger) på følgende steder.

[!include[List](includes/list-page-1-field-locations.md)]

## Eksempler

### Brugerdefinerede felter til virksomheder

Din virksomhed sælger software og brugersupporttjenester. Brugersupportafdelingen har brug for at vide, hvor mange medarbejdere og pc'er de forskellige kunder har. De har også brug for at vide, hvilken slags vedligeholdelsesaftale kunderne har, og hvornår de udløber.

Du kan derefter tilføje disse felter til skærmbilledet Virksomhed:

| Feltnavn | Type | Beskrivelse |
|---|---|---|
| Antal PC'er | Antal | Et talfelt, hvor du kan registrere antallet af pc'er. |
| Medarbejderantal | Antal | Et talfelt, hvor du kan registrere antallet af medarbejdere. |
| Vedligeholdelsesaftale | Liste | En liste over de forskellige typer vedligeholdelsesaftaler, du tilbyder. Listen skal [oprettes på skærmbilledet][2]Lister. |
| Kontrakten udløber | Dato | Et datofelt, hvor du kan registrere kontraktens udløbsdato. |
| Ansøgning A; Ansøgning B; Ansøgning C | Afkrydsningsfelt | Tre afkrydsningsfelter, hvor du kan markere de applikationer, som kunden har købt. |

> [!NOTE]
> De felter, du tilføjer, vises på fanen **Mere** på skærmbilledet Firma. Hvis du vil have dem vist på virksomhedskortet, [skal du angive dem som *side 1-felter*][1].

### Brugerdefinerede felter for salg

Når du opretter et salg, kan det være praktisk at indtaste de produkter, du har solgt, og hvor mange.

Du kan derefter tilføje disse felter til skærmbilledet Salg:

| Feltnavn | Type | Beskrivelse |
|---|---|---|
| Produkt | Lang tekst | Et tekstfelt, hvor du kan indtaste navnet på det produkt, der blev solgt. |
| Antal | Antal | Et talfelt, hvor du kan registrere antallet af solgte enheder. |

> [!TIP]
> Her kan du også bruge et listefelt, hvis du har oprettet en liste over de produkter, du sælger.

### Brugerdefinerede felter for projekter

Du ønsker, at budgettet for et projekt skal være let synligt for projektmedlemmerne.

Du kan derefter tilføje disse felter til skærmbilledet Projekt:

| Feltnavn | Type | Beskrivelse | Bemærkninger |
|---|---|---|---|
| Budget | Decimal | Et talfelt, hvor du kan angive en sum. | [Vælg, at feltet skal vises på side 1][1]. |

<!-- Referenced links -->
[1]: page-1-fields.md
[2]: ../../../admin/lists/learn/adding-user-defined-lists.md
[3]: ../../../project/learn/index.md#more-tab
[4]: ../../../diary/learn/screen/dialog-for-followups.md
[5]: ../../../document/learn/screen/index.md
[6]: ../../../company/learn/create.md#more-tab
[7]: ../../../contact/learn/create.md#more-tab
[8]: ../../../ui/screen-designer/learn/index.md

<!-- Referenced images -->