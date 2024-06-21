---
uid: help-no-import-from-excel
title: Importere fra Excel
description: "I denne veiledningen lærer du hvordan du kan importere alle potensielle kunder, kunder og deres personer."
author: Bergfrid Dias
date: 02.22.2023
keywords: importere, Excel, firma, person, regneark
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Importere fra Excel

Du kan [importere kundedataene][2] dine på én gang ved hjelp av Excel, Outlook, Gmail eller ERP Synchronizer i SuperOffice CRM.

Excel-regnearket kan for eksempel inneholde:

* En liste over leads/prospekter som du vil legge inn i SuperOffice.

    > [!TIP]
    > Legg til en kolonne med for eksempel teksten "potensiell kunde" for alle personene, slik at det blir enkelt å koble dem til riktig kategori i SuperOffice CRM.

* En firma-/personliste med "vaskede" data (eksportert og kvalitetskontrollert for deretter å importeres igjen).

* Firmaer og personer fra andre programmer og formater, for eksempel økonomisystemer, andre CRM-klienter, e-postklienter (bortsett fra Gmail og Outlook) og Windows-installasjoner av SuperOffice CRM.

## Før du begynner

[!include[Back up database before import](includes/caution-backup-before-import.md)]

Før du starter importen, må du [klargjøre Excel-filen][1]. Sjekkliste:

* Excel-regnearket bør minimum inneholde kolonner med firmanavn og personnavn (fornavn og etternavn).

* Kontroller at dataene er oppdaterte. Er for eksempel postadresser og telefonnumre riktige?

## Importere firmaer/personer fra en Excel-fil

Se denne videoen, eller følg trinnene nedenfor for å finne ut hvordan du importerer personene dine til SuperOffice CRM ved hjelp av importmalen vår (videolengde – 4.02):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/dVkCfpOkNl8]

### Trinn

1. [!include[Open Import](includes/open-import.md)]

2. Kontroller at **Personer** er valgt under **Velg en importkilde**, og klikk deretter på ![ikon][img1] Excel-ikonet.

3. I dialogboksen **Last opp fil** klikker du på **Last opp fil** for å velge Excel-regnearket du vil importere.

4. Bla deg frem til ønsket Excel-regneark, og klikk på **Åpne**. Dataene fra regnearket vises i tabellen.

> [!NOTE]
> På dette stadiet er ikke firmaer/personer fra Excel importert til SuperOffice-databasen ennå. SuperOffice laster bare inn firma-/personlisten fra regnearket, slik at du kan angi importinnstillingene.

## Tilpasse importen

Siden Excel-regnearket kan inneholde alt fra noen få kolonner til svært mange kolonner, er det viktig at kolonnene med data du vil importere, blir koblet til riktig SuperOffice-felt.

> [!NOTE]
> Hvis Excel-regnearket hadde en tittelrad øverst, vises også den i listen. Du kan fjerne den når du forhåndsviser dataene i neste trinn.

1. Finn kolonnen som inneholder navnet på firmaer, klikk på kolonnetittelen **(Ingen valgt)**, og velg **Firma: Navn**.

1. Finn kolonnene som inneholder fornavn og etternavn på personer, klikk på kolonnetittelen **(Ingen valgt)**, og velg **Person: Fornavn** og **Person: Etternavn**. Hvis det bare er én kolonne med både fornavn og etternavn, velger du **Person: Fullt navn**.

1. Velg SuperOffice-feltene for resten av kolonnene i tabellen. Hopp over kolonnene du ikke vil importere.

1. [!include[Configure import settings](includes/configure-import-settings.md)]

1. [!include[Enter concent comment](includes/step-concent-comment.md)]

[!include[Preview import](includes/step-preview-import.md)]

1. Fjern merkingen for de radene du IKKE vil importere. Hvis Excel-regnearket inneholdt en overskriftsrad, kan du fjerne den her.

1. Når du har kontrollert at dette faktisk er de dataene du vil importere, klikker du på **Importer**.

### Feilsøking

[!include[Contacts without icons](includes/troubleshoot-import.md)]

**Jeg kommer ikke videre!**

Du må koble alle de påkrevde SuperOffice-feltene til hver sin kolonne for å gå videre. De obligatoriske feltene vises over tabellen. Hvis du har angitt at personer uten firmaer skal legges til som nytt firma, er bare SuperOffice-feltet **Firma: Navn** obligatorisk.

## Ferdigstille importen

[!include[Step: complete the import](includes/import-complete.md)]

## Relatert

* [Konfigurere importinnstillinger][3]
* [Importere fra Outlook][4]
* [Importere fra Gmail][5]
* [Importere fra ERP][6]

<!-- Referenced links -->
[1]: create-import-file.md
[2]: index.md
[3]: configure-import-settings.md
[4]: import-from-outlook.md
[5]: import-from-gmail.md
[6]: import-from-erp.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/admin/import-excel-small.png
