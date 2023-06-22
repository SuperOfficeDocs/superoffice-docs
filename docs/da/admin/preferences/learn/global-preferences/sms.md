---
uid: help-da-service-settings-system-sms
title: SMS
description: SMS
author: SuperOffice RnD
so.date: 03.27.2023
keywords: Tjeneste, indstillinger
so.topic: help
so.user: admin
so.user.tooltip: Settings and maintenance
language: da
---

# SMS-konfiguration i Globale præferencer

Gå til ![icon][img1] **Præferencer** i navigatoren, og vælg fanen **Globale præferencer**. Afsnittet for **SMS-konfiguration** indeholder muligheder for at konfigurere SMS-løsninger i SuperOffice.

## Generelle felter

[!include[Settings for mailings - SMS](../../../../marketing/learn/includes/mailing-settings-sms.md)]

### Test af SMS-indstillingerne

Hvis du vil teste indstillingerne, skal du angive et mobiltelefonnummer og noget tekst og derefter klikke på **Test**.

## Felter, der er tilgængelige for Original Intelecom (kun onsite)

* **SMS-slutpunkt**: Dette felt skal indeholde kode, der lader SuperOffice Service genkende en indgående SMS.
* **Brug webtjeneste**: Hvis feltet er markeret, sendes SMS'er via en webtjeneste i stedet for via e-mail. Dette er den foretrukne metode, eftersom den giver flere funktioner. Dette kræver, at en eventuel firewall accepterer udgående trafik mod SMS-gateway.
* **Leveringsbekræftelse**: Hvis denne valgmulighed er markeret, understøttes leveringsbekræftelser for SMS'er i SuperOffice Service. Det betyder, at du kan se, om en SMS er blevet leveret til den aktuelle mobiltelefon. Dette kræver også konfiguration hos leverandøren.
* **Tjeneste-id**: Tjeneste-id på sms-tjenesten. Tildeles af SuperOffice AS.
* **Brugernavn**: Her skriver du det brugernavn, du har fået tildelt fra Intelecom.
* **Adgangskode**: Her skriver du den adgangskode, du har fået tildelt fra Intelecom.
* **SMS-prioritet**: Her kan du angive 1, 2 eller 3. Tallene angiver, hvor hurtigt sms-meddelelserne sendes ud.

## Felter, der er tilgængelige for Original PsWinCom (kun onsite)

* **SMS-slutpunkt**: Dette felt skal indeholde kode, der lader SuperOffice Service genkende en indgående SMS.
* **Brugernavn**: Her skriver du det brugernavn, du har fået tildelt fra PsWinCom.
* **Adgangskode**: Her skriver du den adgangskode, du har fået tildelt fra PsWinCom.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../../../common/icons/nav-admin-preferences-active.png
