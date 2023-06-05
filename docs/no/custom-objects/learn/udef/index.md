---
uid: help-no-udef
title: Felt
description: Felt
author: SuperOffice RnD
so.date: 06.29.2022
keywords: udef, egendefinert felt
so.topic: concept
so.user: admin
so.user.tooltip: Settings and maintenance
language: no
---

# Brukerdefinerte felt

Flere deler av SuperOffice CRM, for eksempel Firma-bildet, har en egen fane som heter **Mer**. Her kan du legge inn egne felt for å tilpasse programmet til organisasjonens egne behov. [!include[SM](../../../learn/includes/are-defined-sm.md)]

Alle firmaer og organisasjoner har sine egne krav til informasjonen de trenger for å registrere om sine kunder, salg, prosjekter, kontrakter og så videre. Du kan angi dine egne felt for SuperOffice CRM i **Felt**-bildet. På den måten kan du tilpasse typen opplysninger som kan registreres om firmaer, personer, prosjekter, salg, dokumenter og oppfølginger.

> [!NOTE]
> Du kan angi 3 felt som kan vises på "førstesiden" i de aktuelle bildene eller dialogboksene. [Slik][1]. Dette gjelder kanskje ikke hvis du bruker et annet utseende via [Skjermdesigner][8].

## <a id="field-types" />Felttyper

[!include[List of field types](includes/field-types.md)]

## Hvilke fordeler får jeg fra opplysningene jeg skriver inn i disse feltene?

* Du kan bruke søkefunksjonen **Finn** for å søke etter opplysningene du registrerer i disse feltene og lage dynamiske utvalg.
    **Eksempel**: Hvis du registrerer utløpsdatoen for vedlikeholdsavtalen du har med kunder, kan du opprette et dynamisk utvalg som viser kunder der avtalen utløper om mindre enn én måned.

* Du kan gjenbruke opplysningene fra disse feltene i dokumenter og e-post ved å bruke malvariabler. Hvert felt du legger til, får sin egen unike ID som kan brukes i dokumenter for å flette kundespesifikke opplysninger.
    **Eksempel**: Hvis du sender e-post til kunder for å si ifra om at vedlikeholdsavtalen snart utløper, kan du bruke malvariabelen for utløpsdato for å angi riktig utløpsdato i meldingen du sender.

## Hvor vises feltene jeg oppretter?

* [Mer-fanen (Firma)][6]
* [Mer-fanen (Kontaktperson)][7]
* [Mer-fanen (Prosjekt)][3]
* [Fanen Mer (oppfølginger)][4]
* [Fanen Mer (Dokument)][5]
* Fanen Detaljer i Salg-bildet

Du kan angi *side 1-felt* (felt som skal vises på "førstesiden" i de aktuelle bildene eller dialogboksene) på følgende steder:

[!include[List](includes/list-page-1-field-locations.md)]

## Eksempler

### Brukerdefinerte felt for firmaer

Firmaet ditt selger programvare og brukerstøttetjenester. Brukerstøtteavdelingen er nødt til å vite hvor mange medarbeidere og PCer de ulike kundene har. De må også vite hva slags vedlikeholdsavtale kundene har, og når de utløper.

Du kan deretter legge til disse feltene i Firma-bildet:

| Feltnavn | Type | Beskrivelse |
|---|---|---|
| Antall PCer | Nummer | Et nummerfelt der du kan registrere antall PCer. |
| Antall ansatte | Nummer | Et nummerfelt der du kan registrere antall ansatte. |
| Vedlikeholdsavtale | Liste | Liste over de ulike vedlikeholdsavtaletypene dere tilbyr. Listen må [opprettes i Lister-bildet][2]. |
| Kontrakten utløper | Dato | Et datofelt der du kan registrere utløpsdatoen for kontrakten. |
| Søknad A, Søknad B, Søknad C | Avmerkingsboks | Tre avmerkingsbokser der du kan merke av for hvilke applikasjoner kunden har kjøpt. |

> [!NOTE]
> Feltene du legger til, vises i fanen **Mer** i Firma-bildet. Hvis du vil vise dem på firmakortet, [angir du dem som *side 1-felt*][1].

### Brukerdefinerte felt for salg

Når du oppretter et salg, kan det være praktisk å angi hvilke produkter du har solgt og hvor mange.

Du kan deretter legge til disse feltene i Salg-bildet:

| Feltnavn | Type | Beskrivelse |
|---|---|---|
| Produkt | Lang tekst | Et tekstfelt der du kan skrive inn navnet på produktet som ble solgt. |
| Antall | Nummer | Et nummerfelt der du kan registrere antall solgte enheter. |

> [!TIP]
> Her kan du også bruke et listefelt hvis du har opprettet en liste over produktene du selger.

### Brukerdefinerte felt for prosjekter

Du vil at budsjettet for et prosjekt skal være enkelt å se for prosjektmedlemmene.

Du kan deretter legge til disse feltene i Prosjekt-bildet:

| Feltnavn | Type | Beskrivelse | Kommentarer |
|---|---|---|---|
| Budsjett | Desimal | Et tallfelt der du kan angi en sum. | [Velg at feltet skal vises på side 1][1]. |

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