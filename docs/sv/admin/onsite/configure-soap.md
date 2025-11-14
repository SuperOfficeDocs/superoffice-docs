---
uid: help-sv-settings-soap-configure
title: Konfigurera SOAP-gränssnitt
description: Konfigurera SOAP-gränssnitt
keywords: Service, SOAP, gränssnitt, IP-adress, port, konfigurera
author: SuperOffice Product and Engineering
date: 07.10.2025
version: 10.5
content_type: howto
category: service
topic: soap
deployment: onsite
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from:
  - /sv/admin/learn/screen/soap-config
  - /sv/admin/learn/soap-configure-soap
---

# Konfigurera SOAP-gränssnitt (endast LOKALT)

I fönstret SOAP kan du konfigurera SOAP-gränssnittet. Du kan konfigurera 3 typer av portåtkomst:

* **Port: Kund**: Denna flik anger vilka IP-adresser som ska ha åtkomst till den port som erbjuder kundportalsrelaterade funktioner. Detta omfattar bl.a. kundens ärenden och externa meddelanden samt kunskapsbasen.
* **Port: Ärende**: Denna flik avser funktioner för ärendehantering i SuperOffice Service. Datorer med IP-adresser inom en av de intervaller som anges här kommer att kunna köra SOAP-funktioner med denna funktionalitet.
* **Port: Admin**: På den här fliken finns funktioner avseende installation och konfigurering av SuperOffice Service. Datorer med IP-adresser inom en av de intervaller som anges här kommer att kunna köra SOAP-funktioner med denna funktionalitet.

## Lägg till ett IP-adressintervall

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Klicka på **Ärenden** och välj fliken **SOAP**.

1. I listan **Port** väljer du önskad åtkomsttyp.

1. I fälten bredvid **Från** anger du startadressen för IP-adressintervallet.

1. I fälten bredvid **Till** anger du slutadressen för IP-adressintervallet.

1. Klicka på knappen **Lägg till** för att lägga till IP-adressintervallet i listan nedanför.

> [!TIP]
> Om du vill ta bort ett IP-adressintervall från listan klickar du på <i class="ph ph-x-circle" aria-label="Remove icon"></i>.
