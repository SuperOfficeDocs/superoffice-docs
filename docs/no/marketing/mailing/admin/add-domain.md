---
uid: help-no-add-mailing-domain
title: Legg til domener for utsendelser
description: Legge til elementer i listen over domene for utsendelser
keywords: utsendelse, domene, SPF
author: digitaldiina
date: 10.28.2025
version: 11.5
content_type: howto
license: marketingessentials
category: Marketing
topic: mailing
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /no/admin/lists/learn/add-items-to-mailing-domain
language: no
---

# Legg til domener for utsendelser

Når den globale preferansen **Bruk bare godkjente domener for sending av e-post** er satt til **Ja**, kan brukerne bare sende e-post fra domener som er lagt til i denne listen i SuperOffice CRM. Derfor er det viktig å legge til godkjente domener med en gyldig [Sender Policy Framework-oppføring (SPF)][1] i denne listen.

> [!NOTE]
> Den globale preferansen **Bruk bare godkjente domener for sending av e-post** i **Markedsføring**-gruppen må være satt til **Ja** for at listen over domener for utsendelser skal kunne brukes.

## Trinn

1. Under **Innstillinger og vedlikehold** klikker du på **Lister**, og deretter velger du **Domener for utsendelser**.

1. Klikk på **Legg til** for å legge til et nytt godkjent domene.

1. Legg til domenenavnet, og klikk deretter på **Lagre**. Systemet utfører et SPF-oppslag for å undersøke om domenet har en gyldig SPF-post. Hvis ikke, vises en advarsel som forteller deg at det kreves en gyldig SPF-oppføring for domener for utsendelser. Klikk på **OK**, og prøv et annet domene.

1. Hvis domenet består SPF-oppslaget, legges det til i listen over godkjente domener, og brukere kan sende utsendelser fra dette domenet.

> [!NOTE]
> Du kan konfigurere en SPF-oppføring for domenet for å sikre at organisasjonen kan sende utsendelser som blir levert (BARE PÅ NETT). Hvis miljøet ditt er ONSITE, utføres ikke et SPF-oppslag. Du kan imidlertid fortsatt bruke listen til å gi brukerne forhåndsinnstilte domener for **Fra**- og **Svar til**-adresser.

<!-- Referenced links -->
[1]: ../../../../en/email/mailgun/spf/index.md

<!-- Referenced images -->
