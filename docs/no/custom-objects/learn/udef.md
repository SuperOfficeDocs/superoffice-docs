---
uid: help-no-udef
title: Brukerdefinerte felt
description: Introduksjon til brukerdefinerte felt i SuperOffice
keywords: udef, egendefinert, brukerdefinert, felt, felttype
author: Bergfrid Dias
date: 08.27.2024
version: 10.3.1
topic: concept
audience: user
audience_tooltip: SuperOffice CRM
language: no
---

# Brukerdefinerte felt

Et *brukerdefinert* felt (udef) er et tilpasset felt du legger til i en standard SuperOffice-databasetabell. Du kan utvide følgende enheter:

* Firma
* Person
* Dokumenter
* Oppfølging
* Prosjekt
* Salg

Brukerdefinerte felt administreres i Innstillinger og vedlikehold, i **Felter**-skjermen. I applikasjonen er brukerdefinerte felt synlige på **Mer**-fanen til enheten de ble lagt til. For eksempel vises et brukerdefinert felt på et firma på **Mer**-fanen i Firma-skjermen.

> [!NOTE]
> Alle kan **oppdatere** data lagret i et brukerdefinert felt. Bare en administrator kan legge til (eller fjerne) et brukerdefinert felt. Du trenger en Development Tools-lisens for å tilpasse utformingen av **Mer**-fanen og for å bruke [side 1-felt](#page-1).

## <a id="field-types"></a>Felttyper

* **Nummer**: Heltall, ubegrenset antall sifre.
* **Kort tekst**: Tekst på maksimalt 39 tegn. I feltet **Tekstlengde**, som blir aktivert når du velger dette alternativet, angir du maksimalt antall tegn som brukere kan skrive inn i dette feltet.
* **Lang tekst**: Tekst på maksimalt 199 tegn. I feltet **Tekstlengde**, som blir aktivert når du velger dette alternativet, angir du maksimalt antall tegn som brukere kan skrive inn i dette feltet.
* **Dato**: Dato mellom 01.01.1970 og 19.01.2038.
* **Ubegrenset dato**: En hvilken som helst dato.
* **Avmerkingsboks**: En avmerkingsboks.
* **Liste**: En listeboks. Velg en liste fra systemet i feltet under.
* **Desimal**: Et tall med desimaler.

## <a id="limit"></a>Maksimalt antall felt

Følgende begrensninger gjelder for hvor mange brukerdefinerte felt du kan angi i hver av fanene Firma, Person, Prosjekt og Salg.

* **Nummer**, **Dato**, **Avmerkingsboks** og **Liste**: Maksimalt 60 totalt.
* **Kort tekst** og **Ubegrenset dato**: Maksimalt 40 totalt.
* **Lang tekst**: Maksimalt 9 totalt.
* **Desimal**: Maksimalt 10 totalt.

> [!NOTE]
> Indeksering av felt anbefales for bedre ytelse, spesielt i store datasett. Fire felt i hver gruppe er reservert for indeksering. Hvis ingen felt er indeksert, reduseres det totale antallet brukerdefinerte til 103, siden 16 plasser forblir ubrukt.

## <a id="index"></a>Indekserte felt

Indeksering gjør datahenting raskere og forbedrer brukeropplevelsen.

Du kan indeksere så mange felt som nødvendig ved å merke av for **Indeksert** når du oppretter eller redigerer et felt. Indekser oppdateres automatisk når du publiserer endringene dine.

**Nytt fra versjon 10.3.1:**

* Du kan nå indeksere mer enn 4 felt i hver gruppe (Long, Double, String[40], String[200]).

* Data flyttes ikke lenger mellom felt når du publiserer indeksendringer, noe som gjør publisering raskere uavhengig av tabellstørrelsen (antall rader).

## <a id="page-1"></a>Side 1-felt

Blant de brukerdefinerte feltene som vises i **Mer**-fanene i SuperOffice CRM, kan du velge ut *tre* felt som skal fungere som såkalte side 1-felt (fordi de vises på "førstesiden" i sine respektive bilder eller dialogbokser).

**Plassering:**

* Fanen **Firma** i Firma-skjermen
* Fanen **Person** på personkortet
* Fanen **Prosjekt** i Prosjekt-bildet
* Fanen **Salg** i Salg-bildet
* Fanen **Detaljer** i dialogboksen Dokument

> [!NOTE]
> Side-1 felt krever lisensen Development Tools, og er ikke tilgjengelig hvis organisasjonen bruker en annen layout via [Skjermdesigneren][8].

## Eksempler

### Brukerdefinerte felt for firmaer

Firmaet ditt selger programvare og brukerstøttetjenester. Brukerstøtteavdelingen er nødt til å vite hvor mange medarbeidere og PCer de ulike kundene har. De må også vite hva slags vedlikeholdsavtale kundene har, og når de utløper.

Du kan deretter legge til disse feltene i Firma-bildet:

| Feltnavn | Type | Beskrivelse |
|---|---|---|
| Antall PCer | Nummer | Et nummerfelt der du kan registrere antall PCer. |
| Antall ansatte | Nummer | Et nummerfelt der du kan registrere antall ansatte. |
| Vedlikeholdsavtale | Liste | Liste over de ulike vedlikeholdsavtaletypene dere tilbyr. Listen må [opprettes i Lister-bildet][3]. |
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

## Aktuelt innhold

* [Legg til brukerdefinert felt][2]

<!-- Referenced links -->
[1]: ../admin/edit-udef-layout.md#page-1
[2]: ../admin/add-udef.md
[3]: ../../admin/lists/learn/adding-user-defined-lists.md
[8]: ../../ui/screen-designer/learn/index.md

<!-- Referenced images -->