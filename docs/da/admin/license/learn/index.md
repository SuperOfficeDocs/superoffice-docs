---
uid: help-da-licenses
title: SuperOffice og licenser
description: SuperOffice og licenser
keywords: licens, forbrugstjeneste, databaseejer, fanen status
author: SuperOffice Product and Engineering
date: 07.10.2025
version: 10.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: da
redirect_from: /da/admin/license/learn/screen/index
---

# SuperOffice og licenser

For at du kan logge på SuperOffice CRM fra en webklient kræves logonrettigheder til SuperOffice CRM og Essential- eller Premium-brugerlicens

## Se licensoplysninger

1. I Indstillinger og vedligeholdelse skal du gå til skærmbilledet Licenser.
1. Vælg fanen **SuperOffice**.
1. Listen viser de licenser, du har [købt og aktiveret][1]. Klik på et licensnavn for at få vist flere oplysninger om det.

[!include[Tip](includes/tip-user-licenses.md)]

## Skærmbilledet Licenser

### Fanen SuperOffice

Under fanen **SuperOffice** i skærmbilledet Licenser kan du se og opdatere licensinformationen til din version af SuperOffice CRM og tilhørende moduler.

> [!NOTE]
> Hvis der er installeret en tredjepartstilføjelse, vises der flere faner her.

#### Ejeroplysninger

Øverst er firmanavnet (dit firma/din organisation) og serienummeret. Hvis licensen er tidsbegrænset, vises udløbsdatoen under serienummeret.

Listen nederst viser, hvilke licenser der er i brug, og hvor mange der er tilgængelige. Klik på et licensnavn for at få vist oplysninger om licensen.

#### Licensliste

### Fanen Status

Opdaterede oplysninger om systemet vises under fanen **Status** i skærmbilledet Licenser. Skærmbilledet **Status** er inddelt i følgende hoveddele:

#### Database

Her vises den ejer af databasen, det serienummer og den type, som angives ved installation. Derudover vises, om det er en central database eller en satellitdatabase. Du kan se den næste udløbsdato og navnet på den bruger, der er logget på.

#### Forbrugstjenester

Klik på denne knap for at åbne dashboardet for dine forbrugsafregnede tjenester.

Forbrugsafregnede tjenester er tjenester, der faktureres, når du har overskredet et vist niveau/en vis mængde af

* Brugt lagerplads
* E-mails sendt via Udsendelser
* Logon på kundecenter
* Indledte chatsessioner
* Formularindsendelser

Administratorer kan følge med i, præcis hvor meget hver tjeneste bliver brugt pr. måned. Når dit firma overskrider grænsen, faktureres du automatisk for disse tjenester på din næste månedlige faktura. Grænsen afhænger af antallet af brugere. Jo flere brugere du har, jo højere bliver grænsen.

#### Systemmeddelelser

Denne liste viser statusmeddelelser fra systemet og tilføjede [hændelser][3]. Meddelelser om aktive importer, SAINT- eller fritekstindeksering osv. Vælg en meddelelse på listen for at få vist en beskrivelse. Du kan holde styr på hændelser, der er aktive i systemet.

Fanen **Systemhændelser** består af to dele:

* **Hændelser**.
* **Beskrivelse**, viser detaljerede oplysninger om den hændelse, der aktuelt er valgt under **Hændelser**.

Under **Systemmeddelelser** finder du følgende kolonner:

| Kolonne | Beskrivelse |
|---|---|
| Hændelse | Viser navnet for hændelsen. |
| Status | Viser status for hændelsen. |
| Meddelelse | Viser beskrivelsen af hændelsen. |
| Aktiveret | Viser, hvornår begivenheden blev startet. |
| Aktiveret af | Viser, hvem der startede hændelsen (bruger-id og portræt). |
| Afsluttet | Viser, hvornår hændelsen forventes at slutte. |
| Type | Viser, om hændelsen gælder for hele systemet. |

## <a id="types"></a>Licenstyper

### Systemlicenser

| Licens | Beskrivelse |
|---|---|
| System | Angiver, hvilke systemer du har adgang til. |
| SuperOffice Server | Påkrævet til at bruge SuperOffice CRM. |
| Online Web Services | Påkrævet for at få adgang til SuperOffice CRM fra en webklient. |
| Sales Intelligence | Tillader [SAINT-statusovervågning][2]. |
| Exchange Synchronizer | Tillader brug af SuperOffice Synchronizer. |
| SuperOffice Expander Services | Tillader funktionalitet for anonyme og eksterne brugere via blandt andet SuperOffice Audience eller tredjepartsapplikationer. |
| Customer Centre | Tillader brug af Kundecenteret. |
| Håndtering af salgstilbud | Tillader brug af tilbud. |

### Brugerplaner

Endelig er der brugerplaner til SuperOffice CRM, som købes til et bestemt antal brugere. Dette gælder blandt andet følgende produkter:

* Sales-Essentials
* Sales-Premium
* Service-Essentials
* Service-Premium
* Marketing-Essentials
* Marketing-Premium

Læs mere om [SuperOffice brugerplaner og abonnementer][6].

### Site-licenser og bruger-licenser (Windows - ældre)

Licenser til SuperOffice CRM til Windows (sidste udgivelse [SuperOffice G8 8.5 R17][5]) købes til et bestemt antal brugere.

Læs mere om licenser i [tidligere versioner af SuperOffice][7].

## Relateret indhold

* [Køb og aktivering af licenser][1]
* [Systemhændelser][3]

<!-- Referenced links -->
[1]: activate.md
[2]: ../../../saint/learn/index.md
[3]: ../../learn/system-events.md
[5]: https://community.superoffice.com/en/product-releases/release-notes/release-details/?release=SuperOffice_8.5_-_R17
[6]: ../../../../en/admin/license/user-plans.md
[7]: https://help.superoffice.com/Documentation/Help/DA/CRM/WebHelpAdmin/index.htm#t=chap03%2FCRM_and_licences.htm

<!-- Referenced images -->
