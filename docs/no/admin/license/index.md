---
uid: help-no-licenses
title: CRM og lisenser
description: CRM og lisenser
keywords: lisens, brukerplan, målt tjeneste, databaseeier, status-fane
author: digitaldiina, xt1
date: 06.10.2026
version: 12.0
content_type: concept
category: Settings and maintenance
topic: licenses
audience: settings
audience_tooltip: Settings and maintenance
index: true
tier: starter
language: no
redirect_from:
  - /no/admin/license/learn/screen/index
  - /no/admin/license/learn/index
  - /no/learn/administration
---

# SuperOffice og lisenser

For å logge på SuperOffice CRM fra en webklient trenger du påloggingsrettigheter til SuperOffice CRM og en Essential eller en Premium brukerplan.

## Vise lisensinformasjon

1. Gå til skjermbildet Lisenser under Innstillinger og vedlikehold.
1. Velg **SuperOffice**-fanen.
1. Listen viser lisensene du har [kjøpt og aktivert][1]. Klikk på et lisensnavn for å vise mer informasjon om den.

## Lisenser-bildet

### SuperOffice-fanen

Fanen **SuperOffice** viser lisensinformasjon for ditt SuperOffice-abonnement.

<!-- markdownlint-disable-file MD051 -->
#### [Modulbaserte abonnementer](#tab/module-based)

![SuperOffice tab showing system licences and user licences for a module-based subscription -screenshot][img1]

#### [CRM Suite](#tab/crm-suite)

![SuperOffice tab showing system licences and Core user licences for a CRM Suite subscription -screenshot][img3]

***

> [!NOTE]
> Hvis et tillegg fra tredjepart er installert, vises det flere faner her.

#### Informasjon om eier

Øverst er firmanavnet (firmaet/organisasjonen din) og serienummeret. Hvis lisensen er tidsbegrenset, vises utløpsdatoen under serienummeret.

#### Lisensliste

Listen nederst viser hvilke lisenser som er i bruk, og hvor mange som er tilgjengelige.

### Fanen Status

Oppdatert informasjon om systemet vises i fanen **Status** i Lisenser-bildet.

<!-- markdownlint-disable-file MD051 -->
#### [Modulbaserte abonnementer](#tab/module-based-status)

![Status tab showing database information and Metered services button for a module-based subscription -screenshot][img2]

#### [CRM Suite](#tab/crm-suite-status)

![Status tab showing a plan limit warning with an Upgrade button for a CRM Suite subscription -screenshot][img4]

***

**Status**-bildet er inndelt i følgende hoveddeler:

#### Database

Her vises databasens eier, serienummer, abonnement og type, som angis ved installering. Du kan se neste utløpsdato og navnet til pålogget bruker.

Hvis organisasjonen din har et **SuperOffice CRM Suite**-abonnement, viser **Database**-delen også:

* **Plan:** planen som inngår i abonnementet ditt, for eksempel *Core*
* **Begrensninger:** gjeldende forbruk mot plangrensene dine, for eksempel *1 av 100 aktive prosjekter*

Plangrenser hindrer organisasjonen din fra å overskride kapasiteten i gjeldende plan. Indikatoren **Begrensninger** viser hvor nær du er en grense:

| Forbruk | Indikator | Betydning |
|---|---|---|
| Under 85 % | Antall vist i svart, for eksempel *1 av 100 aktive prosjekter* | Normal – ingen handling nødvendig |
| 85 % eller mer | <i class="ph ph-warning" aria-label="Warning"></i> Antall vist i gult | Nærmer seg grensen |
| 100 % | <i class="ph ph-prohibit" aria-label="Limit reached"></i> Antall vist i rødt | Grense nådd – funksjonen er begrenset |

Velg indikatoren for å åpne siden [SuperOffice CRM Suite][16] for mer informasjon.

Hvis du er systemadministrator, vises en **Oppgrader**-knapp ved siden av advarsel- eller stoppindikatoren. Velg den for å åpne et kontaktskjema for å be om mer kapasitet eller planoppgradering.

#### Forbruk

> [!NOTE]
> Kun tilgjengelig med modulbaserte abonnementer. På CRM Suite-abonnementer åpner knappen **Mine apper** SuperOffice App Store.

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

* [CRM Suite][16]
* Sales-Essentials
* Sales-Premium
* Service-Essentials
* Service-Premium
* Marketing-Essentials
* Marketing-Premium

## Relatert innhold

* [SuperOffice-brukerplaner og abonnement][4]
* [Kjøpe og aktivere lisenser][1]
* [Lisenser i tidligere versjoner av SuperOffice][7]
* [Systemoperasjoner][3]

<!-- Referenced links -->
[16]: crm-suite.md
[1]: activate.md
[2]: ../../saint/learn/index.md
[3]: https://help.superoffice.com/docs/11/no/admin/onsite/add-system-event.html
[4]: user-plans.md
[7]: https://help.superoffice.com/Documentation/Help/EN/CRM/WebHelpAdmin/index.htm#t=chap03%2FCRM_and_licences.htm

<!-- Referenced images -->
[img1]: ../../../media/loc/en/admin/licenses-online-superoffice-tab.png
[img2]: ../../../media/loc/en/admin/licenses-online-status-tab.png
[img3]: ../../../media/loc/en/admin/licenses-suite-superoffice-tab.png
[img4]: ../../../media/loc/en/admin/licenses-suite-core-with-upgrade.png
