---
uid: help-sv-service-settings-system-sms
title: SMS
description: SMS
keywords: SMS inställningar
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: reference
category: Settings and maintenance
topic: preferences
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: sv
redirect_from: /sv/admin/preferences/learn/global-preferences/sms
---

# SMS-konfiguration under Globala inställningar

Gå till <i class="ph ph-gear" aria-hidden="true"></i> **Inställningar** i navigatorn och välj fliken **Globala inställningar**. I sektionen för **SMS-konfiguration** finns alternativ för konfigurering av SMS-lösningar i SuperOffice.

## Allmänna fält

[!include[Settings for mailings - SMS](../../marketing/learn/includes/mailing-settings-sms.md)]

> [!NOTE]
> Dessa inställningar är också tillgängliga när du konfigurerar SMS-utskick i **Marketing**.

### Testa SMS-inställningarna

Testa inställningarna genom att ange ett mobiltelefonnummer och lite text och sedan klicka på **Test**.

## Fält tillgängliga för ursprunglig Intelecom (endast LOKALT)

* **SMS-slutpunkt**: Det här fältet ska innehålla en kod som gör att SuperOffice Service känner igen ett inkommande SMS.
* **Använd webbtjänst**: Om det här alternativet markeras skickas SMS via en webbtjänst i stället för via e-post. Detta är den metod som föredras eftersom den ger större funktionalitet. Metoden kräver att befintliga brandväggar tillåter utgående trafik till SMS-gateways.
* **Leveransbekräftelse**: Om det här alternativet markeras stöds leveransbekräftelse för SMS i SuperOffice Service. Det betyder att du kan se om ett SMS har levererats till den aktuella mobiltelefonen. Detta alternativ kräver också konfigurering från leverantörens sida.
* **Tjänste-ID**: Tjänste-ID för SMS-tjänsten. Tillhandahålls av SuperOffice AS.
* **Användarnamn**: Här anger du det användarnamn som Intelecom har gett dig.
* **Lösenord**: Här anger du det lösenord som Intelecom har gett dig.
* **SMS-prioritet**: Här anger du 1, 2 eller 3. Detta nummer specificerar hur snabbt SMS-meddelandena skickas ut.

## Fält tillgängliga för ursprunglig PsWinCom (endast LOKALT)

* **SMS-slutpunkt**: Det här fältet ska innehålla en kod som gör att SuperOffice Service känner igen ett inkommande SMS.
* **Användarnamn**: Här anger du det användarnamn som PsWinCom har gett dig.
* **Lösenord**: Här anger du det lösenord som PsWinCom har gett dig.
