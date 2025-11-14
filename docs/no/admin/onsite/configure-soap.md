---
uid: help-no-settings-soap-configure
title: Konfigurere SOAP-grensesnitt
description: Konfigurere SOAP-grensesnitt
keywords: SOAP, IP-adresse, konfigurere port
author: SuperOffice Product and Engineering
date: 07.10.2025
version: 10.5
content_type: howto
category: service
topic: soap
deployment: onsite
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: no
redirect_from:
  - /no/admin/learn/screen/soap-config
  - /no/admin/learn/soap-configure-soap
---

# SOAP (bare ONSITE)

På SOAP-bildet kan du konfigurere SOAP-grensesnittet. Du kan sette opp tre typer porttilgang:

* **Port: Kunde**: Denne fanen angir hvilke IP-adresser som skal ha tilgang til porten som tilbyr funksjonalitet rundt kundeportalen. Dette omfatter blant annet kundens saker og eksterne meldinger samt kunnskapsbasen.
* **Port: Sak**: Denne fanen gjelder funksjonalitet for håndtering av forespørsler i SuperOffice Service. Maskiner med IP-adresser som ligger innenfor et av områdene som er angitt her, vil ha tilgang til å kjøre SOAP-funksjoner som gir denne funksjonaliteten.
* **Port: Admin**: Denne fanen handler om funksjonalitet knyttet til oppsett og konfigurasjon av SuperOffice Service. Maskiner med IP-adresser som ligger innenfor et av områdene som er angitt her, vil ha tilgang til å kjøre SOAP-funksjoner som gir denne funksjonaliteten.

## Legge til et IP-adresseområde

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Klikk på **Saker**, og velg deretter **SOAP**-fanen.

1. I listen **Port** velger du ønsket tilgangstype.

1. I feltene ved siden av **Fra** skriver du inn adressen som IP-adresseområdet begynner med.

1. I feltene ved siden av **Til** skriver du inn adressen som IP-adresseområdet slutter med.

1. Klikk på **Legg til**-knappen for å legge til IP-adresseområdet i listen nedenfor.

> [!TIP]
> Du sletter et IP-adresseområde fra listen ved å klikke på <i class="ph ph-x-circle" aria-label="Remove icon"></i>.
