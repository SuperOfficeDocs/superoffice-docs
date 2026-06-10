---
uid: help-da-crm-suite
title: SuperOffice CRM Suite
description: Oversigt over de 5 SuperOffice CRM Suite-planer, styring af pladser, plangrænser og prismodel.
keywords: CRM Suite, plan, Starter, Core, Growth, Plus, Super, plangrænser, fencing, skalering, plads, abonnement
author: digitaldiina
date: 06.10.2026
version: 12.0
content_type: concept
tier: starter
category: Indstillinger og vedligehold
topic: licenses
audience: settings
audience_tooltip: Indstillinger og vedligehold
index: true
language: da
---

# SuperOffice CRM Suite

SuperOffice CRM Suite er en samlet, integreret CRM-platform, der dækker salg, marketing og service. Alle brugere i din organisation deler én plan, og planen bestemmer, hvilke funktioner der er tilgængelige i hele organisationen.

## <a id="plans"></a>Planer

Fem planer er tilgængelige. Planerne er kumulative — hver plan inkluderer alt fra planerne nedenfor.

| Plan | Beskrivelse |
| --- | --- |
| **Starter** | Begynd at opbygge kunderelationer. Dækker administration af salgspipeline, sagshåndtering, marketingkampagner, person- og dokumentadministration og indbyggede databeskyttelsesværktøjer. |
| **Core** | Øg produktiviteten og samarbejdet. Tilføjer mobil CRM, workflowautomatisering, indbygget AI-support, projektstyring, dashboardanalyse, kalendersynkronisering og CRM-tilpasning. |
| **Growth** | Accelerer omsætningen med mål og indsigt. Tilføjer sporing af salgsmål og KPI'er, datadrevne indsigter og CRM-ERP-integration. |
| **Plus** | Forbedre kundeoplevelsen og øg fastholdelsen. Tilføjer avanceret sagshåndtering, automatiserede marketingflows, styring af kundecyklus og naturlig sprogssøgning. |
| **Super** | Kør et salgsteam på enterprise-niveau. Tilføjer prædiktive salgsindsigter, ubegrænset sporing af mål og KPI'er, AI-drevet serviceoptimering og databasereplikering. |

## Styring af pladser

Alle brugere i organisationen deler den samme plan. En **plads** er en navngiven bruger med indstillingen **Kan logge på** aktiveret.

* Hvis du vil give en bruger adgang, skal du aktivere **Kan logge på** på brugerens brugerkort i **Indstillinger og vedligehold** > **Brugere**.
* Hvis du vil frigøre en plads uden at fjerne brugerens data og historik, skal du deaktivere **Kan logge på** i stedet for at slette brugeren. Sletning af en bruger er permanent.

Du kan se pladsforbrug i **Indstillinger og vedligehold** > **Licenser** > fanen **SuperOffice**.

## Prismodel

Dit abonnement har tre komponenter:

* **Grundpris:** Et gebyr pr. bruger, der giver adgang til den fulde CRM Suite.

* **Skaleringsmålinger:** Forbrugsbaseret prissætning for områder med højt forbrug. Planen inkluderer en grundkvote; yderligere kapacitet kan købes i blokke ved behov.

* **Plangrænser (fencing):** Faste niveaubaserede grænser, der differentierer planerne. Overskridelse af en plangrænse begrænser den relaterede funktion, indtil du frigør kapacitet eller opgraderer planen.

### Skaleringsmålinger

Skaleringsmålinger sporer løbende forbrug. Når forbruget overstiger grundkvoten i planen, faktureres ekstra kapacitet automatisk. Områder, der er underlagt skalering, omfatter:

* Sendte marketing-e-mails
* Løste sager
* Lager

### <a id="plan-limits"></a>Plangrænser

Plangrænser er faste pr. niveau. Når en grænse nås, begrænses den relaterede funktion, indtil du reducerer forbruget eller opgraderer.

| Grænse | Starter | Core | Growth | Plus | Super |
| --- | --- | --- | --- | --- | --- |
| Dashboards | 3 | Ubegrænset | Ubegrænset | Ubegrænset | Ubegrænset |
| Aktive projekter | 0 | 100 | Ubegrænset | Ubegrænset | Ubegrænset |
| Brugerdefinerede objekter | 0 | 0 | 15 | Ubegrænset | Ubegrænset |
| Aktive marketingflows | 0 | 0 | 0 | 10 | Ubegrænset |

Både **kørende** og **pausede** flows tæller mod grænsen for aktive flows i Plus-planen. Et pauset flow betragtes stadig som aktivt, fordi det fortsætter med at indsamle indkommende personer til senere behandling.

Indikatoren **Begrænsninger** i **Indstillinger og vedligehold** > **Licenser** > fanen **Status** > **Database** viser dit aktuelle forbrug i forhold til de enkelte plangrænser.

| Forbrug | Indikator | Betydning |
| --- | --- | --- |
| Under 85 % | Antal vist i sort | Normal — ingen handling påkrævet |
| 85 % eller mere | <i class="ph ph-warning" aria-label="Warning"></i> Antal vist i rødt | Nærmer sig grænsen |
| 100 % | <i class="ph ph-prohibit" aria-label="Limit reached"></i> Antal vist i rødt | Grænsen nået — funktionen er begrænset |

![Licences Status tab showing a plan limit warning with an Upgrade button -screenshot][img1]

Hvis du er administrator, vises en **Opgrader**-knap ud for en advarsels- eller stopindikator. Vælg den for at åbne en kontaktformular til at anmode om mere kapacitet eller en planopgradering.

## Overgang fra SuperOffice CRM Online

Organisationer, der migrerer fra **SuperOffice CRM Online** (det modulbaserede abonnement), placeres på den CRM Suite-plan, der svarer til den aktuelle licens. Hvis du havde flere licenser, er din plan baseret på det højeste licensniveau. Overgangstidspunktet fastsættes individuelt pr. konto — du vil blive kontaktet.

| Nuværende licens | CRM Suite-plan |
| --- | --- |
| Sales Essentials | Core |
| Service Essentials | Core |
| Marketing Essentials | Growth |
| Sales Premium | Growth |
| Service Premium | Growth |
| Marketing Premium | Plus |

## Relateret indhold

* [CRM og licenser][1]
* [Brugerplaner til SuperOffice CRM Online][2]
* [Aktiver licens][3]

<!-- Referenced links -->
[1]: index.md
[2]: user-plans.md
[3]: activate.md

[img1]: ../../../media/loc/en/admin/licenses-suite-core-with-upgrade.png
