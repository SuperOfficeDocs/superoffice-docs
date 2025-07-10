---
uid: help-no-licenses
title: CRM og lisenser
description: CRM og lisenser
keywords: lisens, brukerplan, Windows, målt tjeneste, databaseeier, status-fane
author: SuperOffice Product and Engineering
date: 07.10.2025
version: 10.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: no
redirect_from: /no/admin/license/learn/screen/index
---

# SuperOffice og lisenser

For å logge på SuperOffice CRM fra en webklient trenger du påloggingsrettigheter til SuperOffice CRM og en Essential eller en Premium brukerplan

## Vise lisensinformasjon

1. Gå til skjermbildet Lisenser under Innstillinger og vedlikehold.
1. Velg **SuperOffice**-fanen.
1. Listen viser lisensene du har [kjøpt og aktivert.][1] Klikk et lisensnavn for å vise mer informasjon om den.

[!include[Tip](includes/tip-user-licenses.md)]

## Lisenser-bildet

### SuperOffice-fanen

I fanen **SuperOffice** i Lisenser-bildet kan du vise og oppdatere lisensinformasjonen for din versjon av SuperOffice CRM og tilhørende moduler.

> [!NOTE]
> Hvis et tillegg fra tredjepart er installert, vises det flere faner her.

#### Informasjon om eier

Øverst er firmanavnet (firmaet/organisasjonen din) og serienummeret. Hvis lisensen er tidsbegrenset, vises utløpsdatoen under serienummeret.

Listen nederst viser hvilke lisenser som er i bruk, og hvor mange som er tilgjengelige. Klikk på et lisensnavn for å vise informasjon om den.

#### Lisensliste

### Fanen Status

I **Status**-fanen i Lisenser-bildet finner du oppdatert informasjon om systemet. **Status**-bildet er inndelt i følgende hoveddeler:

#### Database

Her vises databasens eier, serienummer og type, som angis ved installering. Det viser også om det er en sentral database eller en satellittdatabase. Du kan se neste utløpsdato og navnet til pålogget bruker.

#### Forbruk

Klikk på denne knappen for å åpne dashbord for ditt forbruk.

Forbruk er tjenester som faktureres når du overskrider et bestemt nivå/antall

* Brukt lagringsplass
* E-post sendt via utsendelser
* Kundesenterpålogginger
* Startede chatsesjoner
* Skjemainnsendinger

Administratorer kan holde oversikt over nøyaktig hvor mye hver tjeneste brukes per måned. Når firmaet overskrider terskelen, blir du automatisk fakturert for disse tjenestene på den neste månedlige fakturaen. Terskelen avhenger av antall brukere. Jo flere brukere du har, desto høyere blir terskelen.

#### Systemmeldinger

Denne listen viser statusmeldinger fra systemet og [hendelser][3] som er lagt til. Varsler om aktiv import, SAINT eller fritekstindeksering og så videre. Velg et varsel i listen for å vise en beskrivelse. Du kan holde oversikt over hendelser som er aktive i systemet.

Fanen **Systemoperasjoner** består av to deler:

* **Operasjoner**.
* **Beskrivelse**, viser detaljinformasjon om hendelsen som er merket under **Hendelser**.

Du finner følgende kolonner under **Systemmeldinger**:

| Kolonner | Beskrivelse |
|---|---|
| Operasjon | Viser navn på operasjonen. |
| Status | Viser status for operasjonen. |
| Melding | Viser beskrivelse for operasjonen. |
| Aktivert | Viser når operasjonen ble satt i gang. |
| Aktivert av | Viser hvem som satt i gang operasjonen (bruker-ID og miniatyrbilde). |
| Avsluttes | Viser når operasjonen antas å være ferdig. |
| Type | Viser om hendelsen gjelder for hele systemet. |

## <a id="types"></a>Lisenstyper

### Systemlisenser

| Lisens | Beskrivelse |
|---|---|
| System | Angir hvilke systemer du har tilgang til. |
| SuperOffice Server | Kreves for å bruke SuperOffice CRM. |
| Online Web Services | Kreves for å få tilgang til SuperOffice CRM fra en webklient. |
| Sales Intelligence | Tillater [SAINT-statusovervåking][2]. |
| Exchange Synchronizer | Tillater bruk av SuperOffice Synchronizer. |
| SuperOffice Expander Services | Tillater funksjonalitet for anonyme og eksterne brukere via blant annet SuperOffice Audience eller tredjepartsapplikasjoner. |
| Kundesenter | Tillater bruk av Kundesenter. |
| Sales Quote Management | Tillater bruk av tilbud. |

### Sitelisenser

Det finnes også såkalte sitelisenser. En *site* i SuperOffice-termer tilsvarer en database eller en satellittdatabase. En sitelisens angir følgende:

| Lisens | Beskrivelse |
|---|---|
| Satellitt | Antall satellittdatabaser organisasjonen kan definere. |
| Reporter Studio | Maksimalt antall siter som kan bruke SuperOffice Reporter Studio. |
| Audience | Maksimalt antall siter som kan bruke SuperOffice Audience. |

### Brukerplaner

Sist er det brukerlisenser for SuperOffice CRM, som kjøpes for et bestemt antall brukere. Dette gjelder blant annet følgende produkter:

* Sales-Essentials
* Sales-Premium
* Service-Essentials
* Service-Premium
* Marketing-Essentials
* Marketing-Premium

Les mer om [SuperOffice-brukerplaner og abonnement][6].

## Sitelisenser og brukerlisenser (Windows – EOL)

Lisenser for SuperOffice CRM for Windows (siste release [SuperOffice G8 8.5 R17][5]) kjøpes for et bestemt antall brukere.

Les mer om lisenser i [tidligere versjoner av SuperOffice][7].

## Relatert innhold

* [Kjøpe og aktivere lisenser][1]
* [Systemoperasjoner][3]

<!-- Referenced links -->
[1]: activate.md
[2]: ../../../saint/learn/index.md
[3]: ../../learn/system-events.md
[5]: https://community.superoffice.com/en/product-releases/release-notes/release-details/?release=SuperOffice_8.5_-_R17
[6]: ../../../../en/admin/license/user-plans.md
[7]: https://help.superoffice.com/Documentation/Help/NO/CRM/WebHelpAdmin/index.htm#t=chap03%2FCRM_and_licences.htm

<!-- Referenced images -->
