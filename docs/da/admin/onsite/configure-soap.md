---
uid: help-da-settings-soap-configure
title: Konfigurering af SOAP-grænseflade
description: Konfigurering af SOAP-grænseflade
keywords: SOAP
author: SuperOffice Product and Engineering
date: 07.10.2025
version: 10.5
content_type: howto
category: service
topic: soap
deployment: onsite
audience: settings
audience_tooltip: Settings and maintenance
language: da
redirect_from: 
  - /da/admin/learn/screen/soap-config
  - /da/admin/learn/configure-soap
---

# SOAP (kun ONSITE)

I skærmbilledet SOAP kan du konfigurere SOAP-brugerfladen. Du kan konfigurere 3 typer portadgang:

* **Port: Kunde**: Denne fane angiver, hvilke IP-adresser der skal have adgang til den port, der tilbyder funktionalitet på kundeportalen. Dette omfatter blandt andet kundens sager og eksterne meddelelser samt vidensbasen.
* **Port: Sag**: Denne fane gælder funktionalitet for sagsbehandling i SuperOffice Service. Maskiner med IP-adresser, der ligger inden for et af de områder, der er angivet her, har adgang til at køre SOAP-funktioner, der giver denne funktionalitet.
* **Port: Admin**: Denne fane gælder funktionalitet relateret til opsætning og konfiguration af SuperOffice Service. Maskiner med IP-adresser, der ligger inden for et af de områder, der er angivet her, har adgang til at køre SOAP-funktioner, der giver denne funktionalitet.

## Tilføjelse af et IP-adresseområde

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Klik på **Sager**, og vælg fanen **SOAP**.

1. I listen **Port** skal du vælge den ønskede adgangstype.

1. I felterne bag **Fra** skal du indtaste startadressen for IP-adresseområdet.

1. I felterne bag **Til** skal du indtaste den slutadressen for IP-adresseområdet.

1. Klik på knappen **Tilføj** for at tilføje adresseområdet på listen nedenfor.

> [!TIP]
> For at slette et IP-adresseområde fra listen skal du klikke på <i class="ph ph-x-circle" aria-label="x"></i>.
