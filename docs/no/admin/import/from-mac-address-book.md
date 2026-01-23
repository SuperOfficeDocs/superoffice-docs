---
uid: help-no-import-from-mac-address-book
title: Importere fra Mac-adressebok
description: Importere fra Mac-adressebok
keywords: Innstillinger og vedlikehold, importere
author: SuperOffice Product and Engineering
date: 06.29.2022
version: 10.5
content_type: howto
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /no/admin/import/learn/import-from-mac-address-book
language: no
---

# Importere fra Mac-adressebok

[!include[Back up database before import](includes/caution-backup-before-import.md)]

## Importere firmaer/personer fra Mac-adressebok

<!-- NEED complete rewrite to get correct behavior, need more info from Max/Office integration team.  -->

Ikonet i Importer vises hvis brukeren har WebTools for Mac installert og åpner Innstillinger og vedlikehold.

1. [!include[Open Import](includes/open-import.md)]

2. Klikk på Mac-ikonet under **Velg en importkilde**. Mac-adressebok åpnes, og det vises en dialogboks mens eksporten fra adresseboken pågår.

    > [!NOTE]
    > Firmaene/personene fra Outlook blir ikke importert til SuperOffice-databasen ennå. SuperOffice laster bare inn firma-/personlisten fra Outlook, slik at du kan angi importinnstillingene.

    Når importen fra Outlook er fullført, vises firmaene/personene i **Importer**-bildet.

### Vises det en feilmelding?

Du må installere og konfigurere SuperOffice WebTools for å importere firmaer fra Outlook. I SuperOffice CRM går du til **Fil** > **Last ned** > **SuperOffice WebTools**. Kontakt brukersupport hvis du opplever problemer.

## Tilpasse importen

[!include[Adjust for Gmail/Outlook](includes/adjust-email-only.md)]

### Feilsøking

[!include[Contacts without icons](includes/troubleshoot-import.md)]

## Ferdigstille importen

[!include[Step: complete the import](includes/import-complete.md)]
