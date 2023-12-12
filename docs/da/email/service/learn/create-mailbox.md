---
uid: help-da-service-mailbox-create
title: Oprettelse af e-mailkonti
description: Oprettelse af e-mailkonti
author: SuperOffice RnD
so.date: 12.12.2023
so.version: 10.2.11
keywords: e-mail
so.topic: howto
language: da
---

# Oprettelse af e-mailkonti

Du kan oprette en e-mailkonto, der bruges til at importere e-mail i SuperOffice Service. Før du gør dette, er du nødt til at oprette en e-mailkonto på den e-mailserver, som e-mailen leveres til.

> [!NOTE]
> Før du opsætter en e-mailkonto, skal du sørge for, at der ikke ligger gamle meddelelser på denne e-mailkonto på e-mailserveren. SuperOffice Service importerer alle e-mails, der ligger på e-mailkontoen, og du risikerer derfor at sende kvitteringer til alle de personer, der har sendt e-mails til denne e-mailadresse. Hvis du vil importere disse gamle e-mailmeddelelser, bør du deaktivere funktionen for automatisk afsendelse af kvittering. Dette gælder først og fremmest funktionerne **Send ikke automatisk svar** i skærmbilledet **Egenskaber for e-mailkonto** og **Send ikke e-mail til nye personer** på fanen **Indstillinger** i skærmbilledet **System** i SuperOffice Service.

## Sådan opretter du en ny e-mailkonto - online

1. [!include[Go to email](includes/goto-email.md)]

1. Klik på **Ny mailboks**. Skærmbilledet **Egenskaber for e-mailkonto** vises med fanen **Egenskaber** åben.

1. I feltet **Adresse** skal du angive navnet uden @domæne.xx og trykke på **TAB** for at føje CRM online-indstillingerne til e-mailadressen.

    > [!NOTE]
    > Kaldenavne for e-mailadresser kan føjes til adresser ved at tilføje ("kaldenavn") ved slutningen af e-mail-adressen.Eksempel: <info@company.com> (Customer Ltd.).

1. Vælg kategori, prioritet, og sagstype:

    [!include[Select category and priority](includes/step-select-category-priority.md)]

1. [!include[Set customer language](includes/step-set-language.md)]

1. Angiv svar:

    [!include[Common steps](includes/step-set-reply.md)]

1. [!include[Import stuff](includes/step-import.md)]

1. **AI-tjenester**: Her kan du vælge følgende indstillinger for kategorisering og tekstanalyse ved hjælp af [AI][4]:

    * **Brug AI til at foreslå kategorier**: Vælg denne indstilling for at [lade AI foreslå en kategori][3] for sager baseret på indholdet af e-mails.
    * **Brug tekstanalyse**: Vælg denne indstilling for at [lade AI'en analysere teksten][2] i e-mails for at registrere sprog (til oversættelse) og udføre synspunktsanalyse.

1. Klik på **OK**. E-mailkontoen oprettes.

## Sådan opretter du en ny e-mailkonto - onsite

1. [!include[Go to email](includes/goto-email.md)]

1. Klik på **Ny mailboks**. Skærmbilledet **Egenskaber for e-mailkonto** vises med fanen **Egenskaber** åben.

1. I feltet **Adresse** skal du indtaste den e-mailadresse, du vil bruge til e-mailkontoen.

    > [!NOTE]
    > Konfigurer videresendelse til denne e-mail-konto, hvis du vil bruge din virksomheds e-mailadresse (f.eks. <info@company.com>). Brug **Videresendelsesadresse** i skærmbilledet**E-mail-konti**.

1. I rullemenuen **Protokol** skal du vælge, hvilken protokol der skal bruges til at kommunikere med e-mailserveren. Nogle af protokollerne kan kræve yderligere konfiguration.

1. I feltet **E-mailserver** skal du indtaste værtsnavnet (hostname) på e-mailserveren.

1. I felterne **Brugernavn** og **Adgangskode** skal du indtaste hhv. brugernavnet og adgangskoden til e-mailkontoen.

1. I feltet **Mappe** skal du indtaste mappenavnet på e-mailkontoen på serveren.

1. I feltet **Port** kan du eventuelt ændre den foreslåede standardport for den valgte protokol.

1. Vælg kategori, prioritet, og sagstype:

    [!include[Select category and priority](includes/step-select-category-priority.md)]

1. På listen **Interval** skal du vælge, hvor ofte SuperOffice Service skal tjekke for meddelelser i denne e-mailkonto.

1. [!include[Set customer language](includes/step-set-language.md)]

1. Angiv svar:

    [!include[Common steps](includes/step-set-reply.md)]

1. Gå til fanen **Alias**. Her kan du indtaste ethvert e-mail-alias for en postkasse (for eksempel hvis <sales@company.com> og <sale@company.com> gå til den samme postkasse). Du tilføjer et alias ved at indtaste en e-mailadresse og derefter klikke på ![ikon][img1].

1. [!include[Import stuff](includes/step-import.md)]

1. Klik på **OK**. E-mailkontoen oprettes.

## Hvad vil du foretage dig nu?

* [Sletning af e-mail-konti][1]

<!-- Referenced links -->
[1]: delete-mailbox.md
[2]: ../../../ai/learn/text-analysis.md
[3]: ../../../ai/learn/categorization.md
[4]: ../../../ai/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-add.png
