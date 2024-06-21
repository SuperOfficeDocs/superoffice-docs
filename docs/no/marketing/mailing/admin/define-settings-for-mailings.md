---
uid: help-no-mailing-settings
title: Angi innstillinger for utsendelser
description: Angi innstillinger for utsendelser
keywords: Markedsføring, innstillinger
author: SuperOffice RnD
date: 02.12.2024
version: 10
topic: reference
language: no
envir: onsite
audience: person
audience_tooltip: SuperOffice Marketing
---

# Angi innstillinger for utsendelser

> [!NOTE]
> Denne funksjonen er bare tilgjengelig for brukere med tilstrekkelige brukerrettigheter.

Når bildet **Utsendelser** er aktivt, kan du klikke på knappen **Innstillinger** (nederst til høyre) for å få tilgang til innstillinger for e-post og SMS.

## Fanen Innstillinger

Følgende innstillinger er tilgjengelige for utsendelser av e-post:

* **Maks. antall e-postmeldinger sendt per SMTP-forbindelse for alle samtidige tråder**: Her angir du maks. antall e-postmeldinger som skal fordeles blant SMTP-trådene angitt nedenfor. Vær oppmerksom på at et høyt tall her kan gi svært høy belastning på e-postserveren. Eksempel:

    **Maks. antall e-postmeldinger ...**: 100

    **SMTP-tråder**: 5

    Hvis 1000 e-postmeldinger er planlagt sendt, konfigurerer SuperOffice 5 prosesser (tråder) på SMTP-serveren. Hver prosess tildeles 20 e-postmeldinger (100 e-postmeldinger / 5 tråder) i en kø.

    Så snart en prosess er ferdig, startes en ny prosess, og nye 20 e-postmeldinger tildeles.

* **SMTP-tråder**: Her kan du angi hvor mange samtidige bakgrunnsprosesser som vil sende ut e-postene i en utsendelse. Ved å øke dette antallet, kan du få en høyere gjennomstrømming, men det vil øke belastningen på serveren og e-postserveren.

* **Standardavsender**: Systemets standard avsenderadresse for e-post. Denne adressen vil normalt overstyres av adressene som legges inn i e-postkasser. Dette må være en e-postadresse som importeres i SuperOffice Service. For eksempel `support@company.com`.

[!include[List of fields for mailings](../../learn/includes/mailing-smtp-fields.md)]

## Fanen SMS

Følgende innstillinger er tilgjengelige for SMS-utsendelser:

[!include[Settings for mailings - SMS](../../learn/includes/mailing-settings-sms.md)]

## Teste SMS-innstillingene

Du kan teste innstillingene ved å skrive inn et mobiltelefonnummer og noe tekst, og deretter klikke på **Send test**.

Du kan lese mer om tilleggsmoduler under [SMS][1].

<!-- Referenced links -->
[1]: ../../../admin/preferences/learn/global-preferences/sms.md

<!-- Referenced images -->
