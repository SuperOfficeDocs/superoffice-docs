---
uid: help-no-import-settings
title: Importinnstillinger
description: Importinnstillinger
author: SuperOffice RnD
date: 02.22.2023
keywords: importere
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Konfigurere importinnstillinger

Hvis du justerer importinnstillingene, sparer du tid og gjør det enklere å importere dataene riktig.

[!include[Back up database before import](includes/caution-backup-before-import.md)]

I dialogboksen **Importinnstillinger** kan du tilpasse importen, slik at den bare inkluderer det du ønsker. For å sikre at importdataene skal ha så god kvalitet som mulig, er det viktig å angi riktige importinnstillinger.

Dette gjelder blant annet følgende:

* Duplikater: Velg den foretrukne metoden for behandling av informasjon som forekommer både i importfilen og databasen.
* Personer som ikke er koblet til firmaer.
* Hjemmel og samtykkekilde for personer.
* Lister: Velg den foretrukne metoden for behandling av listeelementer i importen. For eksempel nye kategorier, bransjetyper og telefonnumre, nye produktkategorier, produktfamilier og produkttyper.

## Tenk gjennom følgende før du importerer person- eller produktinformasjon

* Du kan definere hva systemet skal gjøre hvis du importerer personer som allerede finnes i SuperOffice CRM. Du velger om systemet skal overskrive eller hoppe over oppdateringen.

* Du kan velge at systemet skal opprette nye kategorier automatisk hvis du bruker en kategori som ikke finnes i SuperOffice CRM, i importfilen.

## Typiske scenarier

* Jeg vil importere informasjon som ikke finnes i SuperOffice-dataene, men jeg vil ikke overskrive eksisterende informasjon.
    Velg alternativet **Flett - oppdater tomme felt**. Da blir bare tomme felt i SuperOffice oppdatert med importert informasjon.

* Dataene jeg vil importere, er kvalitetssikret og jeg vil oppdatere SuperOffice-databasen.
    Velg alternativet **Erstatt - overskriv eksisterende**. Dataene fra importen vil overskrive eksisterende felt i SuperOffice.

* Jeg vil bare importere nye firmaer og personer til SuperOffice.
    Velg alternativet **Hopp over - ikke importer**. Firmaer og personer som allerede finnes i SuperOffice, blir ikke oppdatert.

* Jeg vil bare importere nye produkter til valgte prisliste.
    Velg alternativet **Hopp over - ikke importer**. Produkter som allerede finnes i den valgte prislisten, blir ikke oppdatert.

* Jeg vil importere alle firmaer og personer til SuperOffice og håndtere eventuelle duplikater selv.
    Velg alternativet **Legg til alltid**.

* Jeg vil importere alle produkter til valgte prisliste og håndtere eventuelle duplikater selv.
    Velg alternativet **Legg til alltid**.

### Eksempel

**Eksisterende data:**

| | Firma | Adresse | Org.nr. | Kode |
|---|---|---|---|---|
| **Importer Excel/Outlook/Gmail** | ACME Inc. | Broadway 123 | 11223344 | - |
| **SuperOffice** | ACME Inc. | Main street 456 | - | ACME1 |

**Handling:**

| Handling | Firma | Adresse | Org.nr. | Kode |
|---|---|---|---|---|
| **Slå sammen** | ACME Inc. | Broadway 123 | 11223344 | ACME1 |
| **Overskriv** | ACME Inc. | Main street 456 | 11223344 | - |
| **Hopp over** | ACME Inc. | Broadway 123 | - | ACME1 |

## Håndtere duplikater (firma/person)

Det oppstår duplikater hvis samme oppføring finnes i både importfilen og i databasen. I importinnstillingene må du alltid angi regler for duplikathåndtering.

Under **Firma**, **Person** og **Produkt** i **Importinnstillinger**-dialogboksen angir du hvordan duplikater skal behandles.

1. Klikk på listeboksen **Duplikate treff**, og velg deretter feltene som skal brukes for å identifisere duplikater av firmaer eller personer.

    > [!NOTE]
    > Hvis du vil unngå å risikere å overskrive data, bør du velge det alternativet som er unikt for hvert firma, hver person og hvert produkt.
    >
    > Dataene som er valgt for duplikatkontroll, MÅ finnes i importfilen. Hvis du velger navn+ kode, må importfilen minst inneholde disse kolonnene.

1. Klikk på listeboksen **Handling** og velg hvordan duplikattreff skal håndteres:

    * **Legg til alltid**:
      * Nye firmaer, personer og produkter vil alltid bli lagt til, selv om det er duplikater.
      * Nye produkter blir alltid lagt til, selv om det finnes duplikater.

    * **Flett - oppdater tomme felt**:
      * Hvis eksisterende firmaer og personer i SuperOffice har tomme felt, fylles disse tomme feltene ut med data fra importkilden. Data som allerede finnes i SuperOffice-felt, blir ikke overskrevet.

      * Hvis eksisterende produkter i den valgte prislisten har tomme felt, fylles disse tomme feltene ut med data fra importkilden. Data som allerede finnes i den valgte prislisten, blir ikke overskrevet.

    * **Erstatt - overskriv eksisterende**:
      * Importdata vil overskrive eksisterende data i SuperOffice-felt.
      * Importdata vil overskrive eksisterende data i valgte prisliste.

    * **Hopp over - ikke importer**:
      * Hvis firmaer og personer allerede finnes i SuperOffice, blir de ikke importert.
      * Hvis produkter allerede finnes i den valgte prislisten, blir de ikke oppdatert.

### Valg for duplikate treff

**Firma:**

* **Navn**: Firmanavnet må være identisk.
* **Navn + Avdeling**: Både firmanavnet og avdelingen må være identiske.
* **Nummer**: Firmanummeret må være identisk.
* **Kode**: Firmaets kode må være identisk.
* **Organisasjonsnummer**: Firmaets organisasjonsnummer må være identisk.
* **ID**: Firmaets ID må være identisk.

**Person:**

* **Navn**: Personens fulle navn (fornavn+etternavn) må være identisk.
* **E-postadresse**: Personens e-postadresse må være identisk.
* **Mobiltelefon**: Personens mobiltelefonnummer må være identisk.
* **Nummer**: Personens nummer må være identisk.
* **Ingen - Ikke importer person**: Velg dette alternativet hvis du ikke vil importere personer.
* **ID**: Personens ID må være identisk.

**Produkt:**

* **Navn**: Produktnavnet må være identisk.
* **Kode**: Produktkoden må være identisk.
* **Navn + Kode**: Både produktnavnet og produktkoden må være identiske.

## Håndtere personer som ikke tilhører et firma

Hvis personer i importkilden ikke står oppført på et firma, har du tre alternativer i listeboksen **Hvis firmanavn er tomt**:

* **Opprett firma med personens navn**: Det blir opprettet et firma med personens navn, og personen blir eneste kontaktperson.

* **Hopp over – ikke opprett firma eller person**: Personen blir ikke importert.

* **Importer personer uten firma**: Personen importeres uten kobling til et firma. Dette alternativet er bare mulig hvis den globale preferansen **Obligatorisk firma for personer** er satt til **Nei**.

## Personvernsinnstillinger for importerte personer

Når du importerer personer, må du også angi hjemmel og samtykkekilde for formålet **Salg og kundeservice**:

* **Hjemmel**: Velg en [hjemmel][1] fra listen, eller velg **Bruk standard** for å bruke standardverdien som er definert i Personvern-bildet.

* **Samtykkekilde**: Denne verdien er som standard satt til **Import**, men du kan velge en annen verdi i listen.

## Håndtere listeverdier som ikke finnes i SuperOffice

Importkilden kan for eksempel inneholde bransjer som ikke er registrert i SuperOffice. Da må du deretter velge hvordan nye kategorier, bransjer, posisjoner, tilpassede listeverdier og interesser skal håndteres. I listeboksene under **Lister** har du følgende valg:

* **Legg til nytt element i listen**: Nye verdier blir lagt til i SuperOffice.
* **Ignorer - bruk standardverdi**: Nye verdier blir ikke importert, og standardverdien for kategori eller bransje blir brukt. Du angir standardverdien under **Preferanser** > **Standardverdier**.

    > [!NOTE]
    > **Posisjon** har ingen standardverdi.

* **Ignorer - sett til tomt**: Ingen nye verdier blir importert til SuperOffice.

## Administrere nye telefonnumre, koblinger og e-postadresser

Importkilden kan for eksempel inneholde telefonnumre, koblinger og e-postadresser som ikke er registrert i SuperOffice. På samme måte som det er mulig å registrere flere telefonnumre, koblinger og e-postadresser for ett firma / én person, må du spesifisere hvordan nye verdier skal behandles. I listeboksene **Telefonnummer** og **Lenker + e-postadresse** under **Lister** har du følgende alternativer:

* **Legg til ny - behold eksisterende**: Nye verdier blir lagt til i SuperOffice, og eksisterende verdier beholdes.
* **Erstatt - overskriv eksisterende**: Eksisterende verdier i SuperOffice blir overskrevet med importerte verdier.
    For eksempel: Dette kan være aktuelt hvis du vet at importen inneholder riktige e-postadresser til personene dine. Hvis e-postadressene som er registrert i SuperOffice, er utdatert, kan du overskrive dem for å rydde opp i systemet.
* **Ignorer - behold eksisterende**: Ingen nye verdier blir importert til SuperOffice.

## Administrere produktkategorier, -familier og -typer som ikke er i SuperOffice

Importkilden kan for eksempel inneholde produktkategorier som ikke er registrert i SuperOffice. Da må du velge hvordan nye produktkategorier, produktfamilier og produkttyper skal håndteres. I listen **Nye verdier for...** har du følgende alternativer:

* **Legg til nytt element i listen**: Nye verdier blir lagt til i SuperOffice.
* **Ignorer - sett til tomt**: Ingen nye verdier blir lagt til i SuperOffice.

<!-- Referenced links -->
[1]: ../../../security/privacy/learn/index.md

<!-- Referenced images -->
