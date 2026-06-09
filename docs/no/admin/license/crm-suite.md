---
uid: help-no-crm-suite
title: SuperOffice CRM Suite
description: Oversikt over de 5 SuperOffice CRM Suite-planene, administrasjon av plasser, plangrenser og prismodell.
keywords: CRM Suite, plan, Starter, Core, Growth, Plus, Super, plangrenser, fencing, skalering, plass, abonnement
author: digitaldiina
date: 06.10.2026
version: 12.0
content_type: concept
tier: starter
category: Innstillinger og vedlikehold
topic: licenses
audience: settings
audience_tooltip: Innstillinger og vedlikehold
index: true
language: no
---

# SuperOffice CRM Suite

SuperOffice CRM Suite gir én samlet CRM-plattform som dekker salg, markedsføring og service. Alle brukere i organisasjonen din deler én plan, og planen bestemmer hvilke funksjoner som er tilgjengelige i hele organisasjonen.

## <a id="plans"></a>Planer

Fem planer er tilgjengelige. Planene er kumulative — hver plan inkluderer alt i planene under den.

| Plan | Beskrivelse |
| --- | --- |
| **Starter** | Begynn å bygge kunderelasjoner. Dekker administrasjon av salgspipeline, saksbehandling, markedsføringskampanjer, person- og dokumentadministrasjon og innebygde personvernverktøy. |
| **Core** | Øk produktiviteten og samarbeidet. Legger til mobil CRM, arbeidsflytautomatisering, innebygd KI-støtte, prosjektadministrasjon, dashboardanalyser, kalendersynkronisering og CRM-tilpasning. |
| **Growth** | Øk inntektene med mål og innsikt. Legger til sporing av salgsmål og KPI-er, datadrevne innsikter og CRM-ERP-integrasjon. |
| **Plus** | Forbedre kundeopplevelsen og øk lojaliteten. Legger til avansert saksløsning, automatiserte markedsflyter, administrasjon av kundelivssyklus og naturlig språksøk. |
| **Super** | Driv et salg på enterprise-nivå. Legger til prediktive salgsinnsikter, ubegrenset sporing av mål og KPI-er, KI-drevet tjenesteoptimalisering og databasereplikering. |

## Administrasjon av plasser

Alle brukere i organisasjonen deler den samme planen. En **plass** er en navngitt bruker med alternativet **Kan logge inn** aktivert.

* For å gi en bruker tilgang aktiverer du **Kan logge inn** på brukerkortet i **Innstillinger og vedlikehold** > **Brukere**.
* Hvis du vil frigjøre en plass uten å fjerne brukerens data og historikk, deaktiverer du **Kan logge inn** i stedet for å slette brukeren. Sletting av en bruker er permanent.

Du kan se plassforbruk i **Innstillinger og vedlikehold** > **Lisenser** > fanen **SuperOffice**.

## Prismodell

Abonnementet ditt har tre komponenter:

* **Grunnpris:** En avgift per bruker som gir tilgang til hele CRM Suite.

* **Skaleringsmålinger:** Bruksbasert prising for områder med høyt forbruk. Planen din inkluderer en grunnkvote; ekstra kapasitet kan kjøpes i blokker ved behov.

* **Plangrenser (fencing):** Faste nivåbaserte grenser som skiller planene. Overskridelse av en plangrense begrenser den tilknyttede funksjonen til du frigjør kapasitet eller oppgraderer planen.

### Skaleringsmålinger

Skaleringsmålinger sporer løpende forbruk. Når forbruket overstiger grunnkvoten inkludert i planen, faktureres ekstra kapasitet automatisk. Områder som er underlagt skalering inkluderer:

* Sendte markedsføringse-poster
* Løste saker
* Lagring

### <a id="plan-limits"></a>Plangrenser

Plangrenser er faste per nivå. Når en grense nås, begrenses den relaterte funksjonen til du reduserer forbruket eller oppgraderer.

| Grense | Starter | Core | Growth | Plus | Super |
| --- | --- | --- | --- | --- | --- |
| Dashboards | 3 | Ubegrenset | Ubegrenset | Ubegrenset | Ubegrenset |
| Aktive prosjekter | 0 | 100 | Ubegrenset | Ubegrenset | Ubegrenset |
| Egendefinerte objekter | 0 | 0 | 15 | Ubegrenset | Ubegrenset |
| Aktive markedsflyter | 0 | 0 | 0 | 10 | Ubegrenset |

Både **kjørende** og **pausede** flyter teller mot grensen for aktive flyter i Plus-planen. En pauset flyt regnes fortsatt som aktiv fordi den fortsetter å samle inn innkommende kontakter for senere behandling.

Indikatoren **Begrensninger** i **Innstillinger og vedlikehold** > **Lisenser** > fanen **Status** > **Database** viser gjeldende forbruk opp mot hver plangrense.

| Forbruk | Indikator | Betydning |
| --- | --- | --- |
| Under 85 % | Antall vises i svart | Normalt — ingen tiltak nødvendig |
| 85 % eller mer | <i class="ph ph-warning" aria-label="Warning"></i> Antall vises i rødt | Nærmer seg grensen |
| 100 % | <i class="ph ph-prohibit" aria-label="Limit reached"></i> Antall vises i rødt | Grensen nådd — funksjonen er begrenset |

![Licences Status tab showing a plan limit warning with an Upgrade button -screenshot][img1]

Hvis du er administrator, vises en **Oppgrader**-knapp ved siden av en advarsel eller stoppindikator. Velg den for å åpne et kontaktskjema for å be om mer kapasitet eller en planoppgradering.

## Overgang fra SuperOffice CRM Online

Organisasjoner som migrerer fra **SuperOffice CRM Online** (det modulbaserte abonnementet), plasseres i CRM Suite-planen som samsvarer med gjeldende lisens. Hvis du hadde flere lisenser, er planen din basert på lisensen med høyest nivå. Tidspunktet for overgangen fastsettes individuelt per konto — du vil bli kontaktet.

| Gjeldende lisens | CRM Suite-plan |
| --- | --- |
| Sales Essentials | Core |
| Service Essentials | Core |
| Marketing Essentials | Growth |
| Sales Premium | Growth |
| Service Premium | Growth |
| Marketing Premium | Plus |

## Aktuelt innhold

* [CRM og lisenser][1]
* [Brukerplaner for SuperOffice CRM Online][2]
* [Aktivere lisens][3]

<!-- Referenced links -->
[1]: index.md
[2]: user-plans.md
[3]: activate.md

[img1]: ../../../media/loc/en/admin/licenses-suite-core-with-upgrade.png
