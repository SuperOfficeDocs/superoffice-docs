---
uid: help-nl-settings-soap-configure
title: SOAP-interface configureren
description: SOAP-interface configureren
keywords: SOAP, IP-adres, poort configureren
author: SuperOffice Product and Engineering
date: 07.10.2025
version: 10.5
content_type: howto
category: service
topic: soap
deployment: onsite
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from:
  - /nl/admin/learn/screen/soap-config
  - /nl/admin/learn/soap-configure-soap
---

# SOAP (alleen ONSITE)

Via het scherm SOAP kunt u de SOAP-interface configureren. U kunt 3 soorten poorttoegang instellen:

* **Poort: Klant**: Op dit tabblad worden de IP-adressen toegang getoond die kunnen communiceren via de poort die toegang biedt tot de portal voor klanten. Via deze poort kan toegang worden verkregen tot verzoeken en externe berichten van de klant, tot de kennisdatabase, enzovoort.
* **Poort: Aanvraag**: Deze tab heeft betrekking op verzoekafhandeling in SuperOffice Service. Computers met een IP-adres binnen een hier opgegeven bereik hebben toegang tot actieve SOAP-functies die deze functionaliteit bieden.
* **Poort: Beheerder**: Dit tabblad heeft betrekking op functionaliteit met betrekking tot het beheer en de configuratie van SuperOffice Service. Computers met een IP-adres binnen een hier opgegeven bereik hebben toegang tot actieve SOAP-functies die deze functionaliteit bieden.

## Een IP-adresbereik toevoegen

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Klik op **Verzoeken** en selecteer het tabblad **SOAP**.

1. In de lijst **Poort** selecteert u het vereiste toegangstype.

1. Voer in de velden naast **Van** het beginadres van het IP-adresbereik in.

1. Voer in de velden naast **Tot** het eindadres van het IP-adresbereik in.

1. Klik op de knop **Toevoegen** om het IP-adresbereik toe te voegen aan de lijst hieronder.

> [!TIP]
> Als u een IP-adresbereik wilt verwijderen uit de lijst, klikt u op <i class="ph ph-x-circle" aria-label="Remove icon"></i>.
