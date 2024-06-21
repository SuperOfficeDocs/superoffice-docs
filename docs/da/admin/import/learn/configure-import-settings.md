---
uid: help-da-import-settings
title: Importindstillinger
description: Importindstillinger
author: SuperOffice RnD
date: 02.22.2023
keywords: importer
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Konfiguration af importindstillinger

Justering af importindstillingerne sparer dig tid og gør det nemmere at importere dine data korrekt.

[!include[Back up database before import](includes/caution-backup-before-import.md)]

I dialogboksen **Importindstillinger** kan du tilpasse importen, så den omfatter præcis det, du ønsker. For at sikre, at importdataene er af så god kvalitet som muligt, er det vigtigt at angive de rigtige importindstillinger.

Dette gælder blandt andet følgende:

* Dubletter: Vælg den foretrukne metode til at håndtere information, der findes både i importfilen og databasen.
* Personer, der ikke er knyttet til firmaer.
* Retsgrundlag og samtykke for personer.
* Lister: Vælg den foretrukne metode til administration af listeelementer i importen. Det kan f.eks. være nye kategorier, branchetyper og telefonnumre, nye produktkategorier, produktfamilier og produkttyper.

## Det skal du overveje, før du importerer dine person- eller produktoplysninger

* Du kan definere, hvad systemet skal gøre, hvis du importerer personer, der allerede findes i SuperOffice CRM. Systemet kan overskrive eller springe opdatering over – det er dit valg.

* Du kan vælge at få systemet til at oprette nye kategorier automatisk, hvis du bruger en kategori, der ikke findes i SuperOffice CRM i din importfil.

## Typiske scenarier

* Jeg vil importere oplysninger, der ikke findes i SuperOffice-dataene, men jeg vil ikke overskrive eksisterende oplysninger.
    Vælg **Flet tomme**. Så opdateres kun tomme felter i SuperOffice med importerede oplysninger.

* De data, jeg vil importere, er kvalitetssikret, og jeg vil opdatere SuperOffice-databasen.
    Vælg **Erstat – overskriv eksisterende**. Dataene fra importen vil overskrive eksisterende felter i SuperOffice.

* Jeg vil kun importere nye firmaer og personer til SuperOffice.
    Vælg indstillingen **Udelad**. Firmaer og personer, som allerede findes i SuperOffice, bliver ikke opdateret.

* Jeg vil kun importere nye produkter til den valgte prisliste.
    Vælg indstillingen **Udelad**. Produkter, der allerede findes i den valgte prisliste, opdateres ikke.

* Jeg vil importere alle firmaer og personer til SuperOffice og håndtere eventuelle dubletter selv.
    Vælg indstillingen **Tilføj altid**.

* Jeg vil importere alle produkter til den valgte prisliste og selv administrere eventuelle dubletter.
    Vælg indstillingen **Tilføj altid** .

### Eksempel

**Eksisterende data:**

| | Firma | Adresse | SE-nr. | Kode |
|---|---|---|---|---|
| **Importér Excel/Outlook/Gmail** | ACME Inc. | Broadway 123 | 11223344 | - |
| **SuperOffice** | ACME Inc. | Hovedgade 456 | - | ACME1 |

**Handling:**

| Handling | Firma | Adresse | SE-nr. | Kode |
|---|---|---|---|---|
| **Sammenflet** | ACME Inc. | Broadway 123 | 11223344 | ACME1 |
| **Overskriv** | ACME Inc. | Hovedgade 456 | 11223344 | - |
| **Udelad post** | ACME Inc. | Broadway 123 | - | ACME1 |

## Håndtering af dubletter (firma/person)

Der opstår dubletter, hvis den samme post findes både i importfilen og i databasen. I importindstillingerne skal du altid angive regler for dublethåndtering.

Under **Firma** og **Person** og **Produkt** i dialogboksen **Importindstillinger** angiver du, hvordan dubletter skal håndteres.

1. Klik på rullemenuen **Dobbelt resultat**, og vælg de felter, der skal bruges til at identificere dubletter af firmaer eller personer.

    > [!NOTE]
    > For at undgå risikoen for at overskrive data bør du vælge den indstilling, der er unik for hvert firma, hver person og hvert produkt.
    >
    > De data, der vælges til dubletkontrol, SKAL findes i importfilen. Hvis du vælger navn+kode, skal importfilen som minimum indeholde disse kolonner.

1. Klik på rullemenuen **Handling**, og vælg, hvordan dobbelte resultater skal håndteres

    * **Tilføj altid**:
      * Nye firmaer, personer og produkter tilføjes altid, selvom der findes dubletter.
      * Nye produkter tilføjes altid, selvom der findes dubletter.

    * **Flet tomme**:
      * Hvis firmaer og personer, som allerede findes i SuperOffice, har tomme felter, er disse tomme felter udfyldt med data fra importkilden. Data, som allerede findes i SuperOffice-felter, bliver ikke overskrevet.

      * Hvis produkter, som allerede findes i SuperOffice, har tomme felter, er disse tomme felter udfyldt med data fra importkilden. Eksisterende data i den valgte prisliste overskrives ikke.

    * **Erstat – overskriv eksisterende**:
      * Importdata vil overskrive eksisterende data i SuperOffice-felt.
      * Importdata vil overskrive eksisterende data i den valgte prisliste.

    * **Udelad**:
      * Hvis firmaer og personer allerede findes i SuperOffice, importeres de ikke.
      * Hvis der allerede findes produkter i den valgte prisliste, importeres de ikke.

### Indstillinger for dobbelte resultater

**Firma:**

* **Navn**: Firmanavnet skal være identisk.
* **Navn + afdeling**: Både firmanavnet og afdelingen skal være identiske.
* **Nummer**: Firmanummeret skal være identisk.
* **Kode**: Firmaets kode skal være identisk.
* **Organisationsnummer**: Firmaets organisationsnummer skal være identisk.
* **Id**: Firmaets ID skal være identisk.

**Kontaktperson:**

* **Navn**: Personens fulde navn (fornavn+efternavn) skal være identisk.
* **E-mailadresse**: Personens e-mailadresse skal være identisk.
* **SMS-nummer**: Personens mobiltelefonnummer skal være identisk.
* **Nummer**: Personens nummer skal være identisk.
* **Ingen – importér ikke person**: Vælg denne indstilling, hvis du vil importere personer.
* **Id**: Personens ID skal være identisk.

**Produkt:**

* **Navn**: Produktnavnet skal være identisk.
* **Kode**: Produktkoden skal være identisk.
* **Navn + kode**: Både produktnavnet og produktkoden skal være identiske.

## Håndtering af personer, der ikke tilhører et firma

Hvis personer i importkilden ikke er opført på et firma, har du tre valgmuligheder i rullemenuen **Hvis firmanavn er tomt**:

* **Brug personens navn**: Der oprettes et firma med personens navn, og personen bliver eneste kontaktperson.

* **Udelad – opret ikke firma eller person**: Firmaet bliver ikke importeret.

* **Importer personer uden firma**: Personen importeres uden tilknytning til et firma. Denne indstilling er kun mulig, hvis den globale præference **Obligatorisk firma ved person** er angivet til **Nej**.

## Indstillinger om personbeskyttelse for importerede personer

Når du importerer personer, skal du også angive retsgrundlag og samtykkekilde til formålet **Salg og kundeservice**:

* **Retsgrundlag**: Vælg et [retsgrundlag][1] i listen, eller vælg **Brug standard** for at bruge den standardværdi, der er angivet i skærmbilledet Personbeskyttelse.

* **Samtykkekilde**: Denne værdi er som standard indstillet til **Import**, men du kan vælge en anden værdi på listen.

## Håndtering af listeværdier, der ikke findes i SuperOffice

Importkilden kan for eksempel indeholde brancher, der ikke er registreret i SuperOffice. Så skal du derefter vælge, hvordan nye kategorier, brancher, stillinger, tilpassede listeværdier og interesser skal håndteres. I rullemenuerne under **Lister** har du følgende valgmuligheder:

* **Tilføj nyt element i listen**: Der tilføjes nye værdier i SuperOffice.
* **Ignorer – brug standardværdi**: Nye værdier importeres ikke, og standardværdien for kategori eller branche anvendes. Du angiver standardværdien under **Præferencer** > **Standardværdier**.

    > [!NOTE]
    > **Position** har ingen standardværdi.

* **Sæt til tom**: Der importeres ingen nye værdier til SuperOffice.

## Håndtering af nye telefonnumre, links og e-mailadresser

Importkilden kan for eksempel indeholde telefonnumre, links og e-mailadresser, der ikke er registreret i SuperOffice. Fordi det er muligt at registrere flere telefonnumre, links og e-mailadresser for et enkelt firma/en enkelt person, skal du angive, hvordan nye værdier skal håndteres. I rullemenuerne **Telefonnummer** og **Links + e-mailadresse** under **Lister** har du følgende indstillinger:

* **Tilføj ny – behold eksisterende**: Nye værdier tilføjes i SuperOffice, og eksisterende værdier beholdes.
* **Erstat – overskriv eksisterende**: Eksisterende værdier i SuperOffice overskrives med importerede værdier.
    For eksempel: Dette kan være relevant, hvis du ved, at importen indeholder korrekte e-mailadresser på dine kontaktpersoner. Hvis e-mailadresserne, der er registreret i SuperOffice, er forældede, kan du overskrive dem for at rydde op i systemet.
* **Ignorer – behold eksisterende**: Der importeres ingen nye værdier til SuperOffice.

<!-- markdownlint-disable-next-line MD013 -->
## Håndtering af produktkategorier, produktfamilier og produkttyper, der ikke findes i SuperOffice

Importkilden kan for eksempel indeholde produktkategorier, der ikke er registreret i SuperOffice. Du skal derefter vælge, hvordan nye produktkategorier, produktfamilier og produkttyper skal håndteres. I listerne **Nye værdier for** har du følgende valgmuligheder:

* **Tilføj nyt element i listen**: Der tilføjes nye værdier i SuperOffice.
* **Sæt til tom**: Der tilføjes ingen nye værdier i SuperOffice.

<!-- Referenced links -->
[1]: ../../../security/privacy/learn/index.md

<!-- Referenced images -->
