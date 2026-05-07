---
uid: help-da-service-mailbox-create
title: Oprettelse af e-mailkonti
description: Oprettelse af e-mailkonti
keywords: e-mail
author: digitaldiina
date: 05.04.2026
version: 11.13
content_type: howto
category: email
topic: Service mailbox
license: serviceessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: da
---

# Oprettelse af e-mailkonti

Du kan oprette en e-mailkonto, der bruges til at importere e-mail i SuperOffice Service. Før du gør dette, er du nødt til at oprette en e-mailkonto på den e-mailserver, som e-mailen leveres til.

> [!NOTE]
> Før du opsætter en e-mailkonto, skal du sørge for, at der ikke ligger gamle meddelelser på denne e-mailkonto på e-mailserveren. SuperOffice Service importerer alle e-mails, der ligger på e-mailkontoen, og du risikerer derfor at sende kvitteringer til alle de personer, der har sendt e-mails til denne e-mailadresse. Hvis du vil importere disse gamle e-mailmeddelelser, bør du deaktivere funktionen for automatisk afsendelse af kvittering. Dette gælder først og fremmest funktionerne **Send ikke automatisk svar** i skærmbilledet **Egenskaber for e-mailkonto** og **Send ikke e-mail til nye personer** på fanen **Indstillinger** i skærmbilledet **System** i SuperOffice Service.

## Trin

1. [!include[Go to email](includes/goto-email.md)]

1. Klik på **Ny mailboks**. Skærmbilledet **Egenskaber for e-mailkonto** vises med fanen **Egenskaber** åben.

1. I feltet **Adresse** skal du angive navnet uden @domæne.xx og trykke på **TAB** for at føje CRM online-indstillingerne til e-mailadressen.

    > [!NOTE]
    > Kaldenavne for e-mailadresser kan føjes til adresser ved at tilføje ("kaldenavn") ved slutningen af e-mail-adressen. Eksempel: `info@company.com` (Customer Ltd.).

1. Vælg kategori, prioritet, og sagstype:

    * På listen **Kategori** skal du vælge, hvilken kategori meddelelserne i denne e-mailkonto skal tilhøre.

    * I rullelisten **Prioritet** skal du vælge, hvilken prioritet sager fra denne e-mailkonto skal have.

    * I rullelisten **Sagstype** skal du vælge den type beskeder, der hører til i denne postkasse.

1. [!include[Set customer language](includes/step-set-language.md)]

1. Angiv svar:

    1. Marker **Send ikke automatisk svar**, hvis du vil deaktivere funktionen for automatisk svar. Se noten øverst i dette emne.

    1. I feltet **E-mailfelt** kan du tilføje en kommasepareret liste med e-mailfelter (hovedfelter), der skal vises i sagsmeddelelsen. Eksempler på sådanne felter er Til og Kopi.

    1. På listen **Svarskabelon til svar til kunde** skal du vælge, hvilken svarskabelon der skal bruges ved automatisk besvarelse til kunden.

    1. **Foreslå FAQ-poster fra**: Hvis du markerer denne valgmulighed, foreslår systemet FAQ-poster ud fra teksten i indgående e-mail-meddelelser. De foreslåede FAQ-poster er tilgængelige som skabelonvariabler og kan derfor gentages i den valgte svarskabelon. Du kan også angive, hvilken gren af FAQ-træet der skal søges i, ved at angive den ønskede mappe.

1. **Importér autosvar og systemmeddelelser**: Som standard importeres e-mails, der indeholder fraværsmeddelelser, systemmeddelelser og andre irrelevante meddelelser, ikke. Hvis du ønsker at importere sådanne e-mails, kan du markere denne mulighed.

1. **AI-tjenester**: Her kan du vælge følgende indstillinger for kategorisering og tekstanalyse ved hjælp af [AI][4]:

    * **Brug AI til at foreslå kategorier**: Vælg denne indstilling for at [lade AI foreslå en kategori][3] for sager baseret på indholdet af e-mails.
    * **Brug tekstanalyse**: Vælg denne indstilling for at [lade AI'en analysere teksten][2] i e-mails for at registrere sprog (til oversættelse) og udføre synspunktsanalyse.

1. Klik på **OK**. E-mailkontoen oprettes.

## Relateret indhold

* [Sletning af e-mail-konti][1]
* [E-mail i Service og Marketing][5]
* [Opret e-mailkonto (onsite)][6]

<!-- Referenced links -->
[1]: delete-mailbox.md
[2]: ../../../ai/learn/text-analysis.md
[3]: ../../../ai/learn/categorization.md
[4]: ../../../ai/learn/index.md
[5]: ../../../../en/online/mail-services/curl/index.md
[6]: https://help.superoffice.com/docs/11/da/email/admin/mailbox/create-mailbox.html
