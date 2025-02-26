---
uid: help-da-import-from-excel
title: Import fra Excel
description: I denne guide lærer du, hvordan du kan importere alle dine kundeemner, kunder og deres personer.
author: Bergfrid Dias
date: 02.22.2023
keywords: importer, Excel, firma, contact, regneark
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Import fra Excel

Du kan [importere dine kundedata][2] på én gang ved hjælp af Excel, Outlook, Gmail eller din ERP Synchronizer i SuperOffice CRM.

Excel-regnearket kan f.eks. indeholde:

* En liste over leads/prospekter, som du vil tilføje til SuperOffice.

    > [!TIP]
    > Sørg for at tilføje en kolonne med for eksempel teksten "prospekt" for alle firmaerne, så de nemt kan kobles til den rigtige kategori i SuperOffice CRM.

* En firma-/personliste med "rensede" data (eksporteres og kontrolleres for kvalitet og importeres igen).

* Firmaer og personer fra andre programmer og formater, for eksempel økonomisystemer, andre CRM-klienter, e-mailklienter (andre end Gmail og Outlook) og Windows-installationer af SuperOffice CRM.

## Før du starter

[!include[Back up database before import](includes/caution-backup-before-import.md)]

Før du starter importen, skal du [forberede Excel-filen][1]. Tjekliste:

* Excel-regnearket bør som minimum indeholde kolonner med firmanavn og personnavn (fornavn og efternavn).

* Kontroller, at dataene er opdaterede. Er postadresser og telefonnumre f.eks. korrekte?

## Eksport af firmaer/personer fra en Excel-fil

Se denne video, eller følg nedenstående trin for at lære, hvordan du importerer dine personer til SuperOffice CRM ved hjælp af vores importskabelon (videolængde - 4:02):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/dVkCfpOkNl8]

### Trin

1. [!include[Open Import](includes/open-import.md)]

2. Kontroller, at **Personer** er valgt under **Vælg en importkilde**, og klik derefter på Excel-ikonet ![icon][img1].

3. Klik på **Upload fil** i dialogboksen **Upload fil** for at vælge det Excel-regneark, du vil importere.

4. Find det ønskede Excel-regneark, og klik på **Åbn**. Dataene fra regnearket vises i tabellen.

> [!NOTE]
> Firmaer/personer fra Excel bliver ikke importeret i SuperOffice-databasen endnu. SuperOffice indlæser blot firma-/personlisten fra regnearket, så du kan angive importindstillingerne.

## Tilpas importen

Da Excel-regnearket kan indeholde alt fra nogle få kolonner til et meget stort antal kolonner, er det vigtigt, at kolonnerne med data, du vil importere, knyttes til det rigtige SuperOffice-felt.

> [!NOTE]
> Hvis Excel-regnearket havde en titellinje øverst, vises denne også på listen. Du kan fjerne den, når du forhåndsviser dataene i næste trin.

1. Find kolonnen, der indeholder navnet på firmaerne, klik på kolonnetitlen **(Ingen valgt)**, og vælg **Firma: Navn**.

1. Find de kolonner, der indeholder fornavn og efternavn på personer, klik på kolonnetitlen **(Ingen valgt)**, og vælg **Person: Fornavn** og **Person: Efternavn**. Hvis der kun er én kolonne med både fornavn og efternavn, vælger du **Person: Fulde navn**.

1. Vælg SuperOffice-felterne for resten af kolonnerne i tabellen. Spring over de kolonner, du ikke vil importere.

1. [!include[Configure import settings](includes/configure-import-settings.md)]

1. [!include[Enter concent comment](includes/step-concent-comment.md)]

[!include[Preview import](includes/step-preview-import.md)]

1. Fjern markeringen af de rækker, du IKKE vil importere. Hvis Excel-regnearket indeholdt en overskriftsrække, kan du fjerne den her.

1. Når du har kontrolleret, at dette rent faktisk er de data, du ønsker at importere, skal du klikke på **Importér**.

### Fejlfinding

[!include[Contacts without icons](includes/troubleshoot-import.md)]

**Jeg kan ikke komme videre!**

Du skal knytte alle de påkrævede SuperOffice-felter til hver sin kolonne for at kunne fortsætte. De påkrævede felter vises over tabellen. Hvis du har angivet, at personer uden firmaer skal tilføjes som nyt firma, ser du kun SuperOffice-feltet **Firma: Navn** obligatorisk.

## Fuldfør importen

[!include[Step: complete the import](includes/import-complete.md)]

## Relateret

* [Konfiguration af importindstillinger][3]
* [Importér fra Outlook][4]
* [Import fra Gmail][5]
* [Import fra ERP][6]

<!-- Referenced links -->
[1]: create-import-file.md
[2]: index.md
[3]: configure-import-settings.md
[4]: import-from-outlook.md
[5]: import-from-gmail.md
[6]: import-from-erp.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/admin/import-excel-small.png
