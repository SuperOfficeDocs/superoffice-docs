---
uid: help-da-mailing-settings
title: Angive indstillinger for udsendelser
description: Angive indstillinger for udsendelser
keywords: Marketing, indstillinger
author: SuperOffice RnD
date: 02.12.2024
version: 10
topic: howto
language: da
envir: onsite
audience: person
audience_tooltip: SuperOffice Marketing
---

# Angive indstillinger for udsendelser

> [!NOTE]
> Denne funktion er kun tilgængelig for brugere med tilstrækkelige brugerrettigheder.

Når du er på skærmbilledet **Forsendelser** kan du klikke på **Indstillinger** (i nederste højre hjørne) for at få adgang til indstillinger for e-mail og SMS.

## Fanen Indstillinger

Følgende indstillinger er tilgængelige for e-mail-forsendelser:

* **Maks. antal e-mails sendt pr. SMTP-forbindelse for alle samtidige tråde**: Her indstiller du det maksimale antal e-mails, der skal fordeles mellem SMTP-trådene nedenfor. Vær opmærksom på, at et stort antal kan være en stor belastning for mailserveren. Eksempel:

    **Maks. antal e-mails ...**: 100

    **SMTP-tråde**: 5

    Hvis 1000 e-mails er indstillet til afsendelse, opsætter SuperOffice 5 processer (tråde) på SMTP-serveren. Hver proces tildeles 20 e-mails (100 e-mails / 5 tråde) i en kø.

    Så snart en proces er afsluttet, påbegyndes en ny proces, der tildeles yderligere 20 e-mails.

* **SMTP-tråde**: Her kan du indtaste det ønskede antal samtidige baggrundsprocesser, der kan sende mailudsendelser ud. Ved at øge antallet kan du få et højere gennemløb, men det vil også øge belastningen på serveren og mailserveren.

* **Standardafsender**: Systemets standardafsenderadresse til e-mails. Denne adresse vil normalt blive tilsidesat af de adresser, der figurerer som mailkonti. Der skal være tale om en e-mailadresse, som er importeret til SuperOffice Service. For eksempel, <support@company.com>.

[!include[List of fields for mailings](../../learn/includes/mailing-smtp-fields.md)]

## Fanen SMS

Følgende indstillinger er tilgængelige for sms-udsendelser:

[!include[Settings for mailings - SMS](../../learn/includes/mailing-settings-sms.md)]

## Test af sms-indstillingerne

Hvis du vil teste indstillingerne, skal du angive et mobiltelefonnummer og noget tekst og derefter klikke på **Send test**.

For information om yderligere moduler, se [SMS.][1]

<!-- Referenced links -->
[1]: ../../../admin/preferences/learn/global-preferences/sms.md

<!-- Referenced images -->
