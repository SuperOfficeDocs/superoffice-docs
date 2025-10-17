---
uid: help-nl-mailing-settings
title: Instellingen voor mailings definiëren
description: Instellingen voor mailings definiëren
keywords: Marketing, instellingen
author: SuperOffice Product and Engineering
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
redirect_from: /nl/marketing/mailing/learn/admin/define-settings-for-mailings
language: nl
deployment: onsite
---

# Instellingen voor mailings definiëren

> [!NOTE]
> Deze functie is alleen beschikbaar voor gebruikers met de benodigde gebruikersrechten.

Wanneer u in het scherm **Mailings** bent, kunt u op de knop **Instellingen** klikken (in de rechterbenedenhoek) om toegang te krijgen tot de instellingen voor e-mail en SMS.

## Het tabblad Instellingen

De volgende instellingen zijn beschikbaar voor mailings per e-mail:

* **Max aantal e-mails verzonden per SMTP-verbinding voor alle gelijktijdige threads**: Hier stelt u het maximum aantal e-mails in dat wordt verspreid onder de SMTP-threads die hieronder zijn ingesteld. Houd er rekening mee dat een hoge waarde de e-mailserver aanzienlijk kan belasten. Bijvoorbeeld:

    **Max. aantal e-mails...**: 100

    **SMTP-threads**: 5

    Als 1000 e-mails zijn gepland voor verzending stelt SuperOffice 5 processen (threads) op de virtuele SMTP-server op. Elk proces krijgt 20 e-mails (100 e-mails/5 threads) toegewezen in een wachtrij.

    Zodra een proces voltooid is, wordt een nieuw proces gestart en worden de volgende 20 e-mails toegewezen.

* **SMTP-threads**: Hier kunt u het aantal gelijktijdige achtergrondprocessen invoeren voor de verzending van de e-mails in een mailing. Als u dit aantal verhoogt, wordt de doorvoer hoger, maar worden ook de server en de mailserver zwaarder belast.

* **Standaard Van-adres**: Het standaard afzenderadres van de e-mail van het systeem. Dit adres wordt meestal vervangen door de adressen die in de postbussen zijn ingevoerd. Dit moet een e-mailadres zijn dat in SuperOffice Service is geïmporteerd. Bijvoorbeeld, `support@company.com`.

[!include[List of fields for mailings](../../learn/includes/mailing-smtp-fields.md)]

## Het tabblad SMS

De volgende instellingen zijn beschikbaar voor SMS-mailings:

[!include[Settings for mailings - SMS](../../learn/includes/mailing-settings-sms.md)]

## De SMS-instellingen testen

Als u de instellingen wilt testen, voert u een mobiel telefoonnummer en een willekeurige tekst in en klikt u op **Test verzenden**.

Zie [SMS][1] voor informatie over extra modules.

<!-- Referenced links -->
[1]: ../../../../en/marketing/sms/it/set-up.md

<!-- Referenced images -->
