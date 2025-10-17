---
uid: help-sv-mailing-settings
title: Ange inställningar för utskick
description: Ange inställningar för utskick
keywords: Marknadsföring, inställningar
author: SuperOffice Product and Engineering
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
redirect_from: /sv/marketing/mailing/learn/admin/define-settings-for-mailings
language: sv
deployment: onsite
---

# Ange inställningar för utskick

> [!NOTE]
> Denna funktion är endast tillgänglig för användare med tillräckliga användarrättigheter.

När fönstret **Utskick** visas kan du klicka på knappen **Inställningar** (i det nedre högra hörnet) om du vill få åtkomst till inställningarna för e-post och SMS.

## Fliken Inställningar

Följande inställningar finns för e-postutskick:

* **Max antal skickade e-postmeddelanden per SMTP-anslutning för alla samtidiga trådar**: Här kan du ställa in maximalt antal e-postmeddelanden som ska fördelas bland de SMTP-trådar som anges nedan. Observera att höga värden kan ge väldigt hög belastning på e-postservern. Exempel:

    **Max antal e-postmeddelanden ...**: 100

    **SMTP-trådar**: 5

    Om 1 000 e-postmeddelanden schemaläggs för sändning startar SuperOffice 5 processer (trådar) på SMTP-servern. Varje process tilldelas 20 e-postmeddelanden (100 e-postmeddelanden/5 trådar) i en kö.

    När en process är klar startas en ny process och tilldelas ytterligare 20 e-postmeddelanden.

* **SMTP-trådar**: Här kan du ange hur många samtidiga bakgrundsprocesser som ska skicka ut e-postmeddelandena i ett utskick. Genom att höja antalet kan du uppnå en snabbare genomströmning men det ökar även belastningen på servern och e-postservern.

* **Standardavsändare**: Systemet standardavsändare för e-post. Denna adress åsidosätts normalt av adresser som läggs till i e-postlådor. Detta måste vara en e-postadress som har importerats i SuperOffice Service. Till exempel `support@company.com`.

[!include[List of fields for mailings](../../learn/includes/mailing-smtp-fields.md)]

## Fliken SMS

Följande inställningar finns för SMS-utskick:

[!include[Settings for mailings - SMS](../../learn/includes/mailing-settings-sms.md)]

## Testa SMS-inställningarna

Testa inställningarna genom att ange ett mobiltelefonnummer och lite text, och sedan klicka på **Skicka test**.

Information om ytterligare moduler finns i [SMS][1].

<!-- Referenced links -->
[1]: ../../../../en/marketing/sms/it/set-up.md

<!-- Referenced images -->
