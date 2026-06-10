---
uid: help-da-licenses
title: SuperOffice og licenser
description: SuperOffice og licenser
keywords: licens, forbrugstjeneste, databaseejer, fanen status
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
language: da
redirect_from:
  - /da/admin/license/learn/screen/index
  - /da/admin/license/learn/index
  - /da/learn/administration
---

# SuperOffice og licenser

For at du kan logge på SuperOffice CRM fra en webklient kræves logonrettigheder til SuperOffice CRM og Essential- eller Premium-brugerlicens

## Se licensoplysninger

1. I Indstillinger og vedligeholdelse skal du gå til skærmbilledet Licenser.
1. Vælg fanen **SuperOffice**.
1. Listen viser de licenser, du har [købt og aktiveret][1]. Klik på et licensnavn for at få vist flere oplysninger om det.

## Skærmbilledet Licenser

### Fanen SuperOffice

Fanen **SuperOffice** viser licensoplysninger for dit SuperOffice-abonnement.

<!-- markdownlint-disable-file MD051 -->
#### [Modulbaserede abonnementer](#tab/module-based)

![SuperOffice tab showing system licences and user licences for a module-based subscription -screenshot][img1]

#### [CRM Suite](#tab/crm-suite)

![SuperOffice tab showing system licences and Core user licences for a CRM Suite subscription -screenshot][img3]

***

> [!NOTE]
> Hvis der er installeret en tredjepartstilføjelse, vises der flere faner her.

#### Ejeroplysninger

Øverst er firmanavnet (dit firma/din organisation) og serienummeret. Hvis licensen er tidsbegrænset, vises udløbsdatoen under serienummeret.

#### Licensliste

Listen nederst viser, hvilke licenser der er i brug, og hvor mange der er tilgængelige.

### Fanen Status

Opdaterede oplysninger om systemet vises under fanen **Status** i skærmbilledet Licenser.

<!-- markdownlint-disable-file MD051 -->
#### [Modulbaserede abonnementer](#tab/module-based-status)

![Status tab showing database information and Metered services button for a module-based subscription -screenshot][img2]

#### [CRM Suite](#tab/crm-suite-status)

![Status tab showing a plan limit warning with an Upgrade button for a CRM Suite subscription -screenshot][img4]

***

Skærmbilledet **Status** er inddelt i følgende hoveddele:

#### Database

Her vises databasens ejer, serienummer, abonnement og type, som angives ved installation. Du kan se den næste udløbsdato og navnet på den bruger, der er logget på.

Hvis din organisation er på et **SuperOffice CRM Suite**-abonnement, viser **Database**-sektionen også:

* **Plan:** den plan, der er inkluderet i dit abonnement, f.eks. *Core*
* **Begrænsninger:** dit aktuelle forbrug i forhold til planens grænser, f.eks. *1 af 100 aktive projekter*

Plangrænser forhindrer din organisation i at overskride kapaciteten i den aktuelle plan. Indikatoren **Begrænsninger** viser, hvor tæt du er på en grænse:

| Forbrug | Indikator | Betydning |
|---|---|---|
| Under 85 % | Antal vist med sort, f.eks. *1 af 100 aktive projekter* | Normal – ingen handling nødvendig |
| 85 % eller mere | <i class="ph ph-warning" aria-label="Warning"></i> Antal vist med gult | Nærmer sig grænsen |
| 100 % | <i class="ph ph-prohibit" aria-label="Limit reached"></i> Antal vist med rødt | Grænse nået – funktionen er begrænset |

Vælg indikatoren for at åbne siden [SuperOffice CRM Suite][16] for yderligere oplysninger.

Hvis du er systemadministrator, vises en **Opgrader**-knap ud for advarsel- eller stopindikatoren. Vælg den for at åbne en kontaktformular for at anmode om mere kapacitet eller planopgradering.

#### Forbrugstjenester

> [!NOTE]
> Kun tilgængeligt med modulbaserede abonnementer. På CRM Suite-abonnementer åbner knappen **Mine apps** SuperOffice App Store.

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

* [CRM Suite][16]
* Sales-Essentials
* Sales-Premium
* Service-Essentials
* Service-Premium
* Marketing-Essentials
* Marketing-Premium

## Relateret indhold

* [SuperOffice brugerplaner og abonnementer][4]
* [Køb og aktivering af licenser][1]
* [Tidligere versioner af SuperOffice][7]
* [Systemhændelser][3]
* [Modullicenser][14]
* [Skjulte licenser][15]
* [Licens - teknisk oversigt][17]

<!-- Referenced links -->
[16]: crm-suite.md
[1]: activate.md
[2]: ../../saint/learn/index.md
[3]: https://help.superoffice.com/docs/11/da/admin/onsite/add-system-event.html
[4]: user-plans.md
[7]: https://help.superoffice.com/Documentation/Help/EN/CRM/WebHelpAdmin/index.htm#t=chap03%2FCRM_and_licences.htm
[14]: ../../../en/admin/license/dev/module-licenses.md
[17]: ../../../en/admin/license/dev/index.md
[15]: ../../../en/admin/license/dev/hidden-licenses.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/admin/licenses-online-superoffice-tab.png
[img2]: ../../../media/loc/en/admin/licenses-online-status-tab.png
[img3]: ../../../media/loc/en/admin/licenses-suite-superoffice-tab.png
[img4]: ../../../media/loc/en/admin/licenses-suite-core-with-upgrade.png
