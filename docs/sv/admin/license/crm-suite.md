---
uid: help-sv-crm-suite
title: SuperOffice CRM Suite-planer
description: Översikt av de fem SuperOffice CRM Suite-planerna, hantering av platser, plangränser och prismodell.
keywords: CRM Suite, plan, Starter, Core, Growth, Plus, Super, plangränser, fencing, skalering, plats, prenumeration
author: digitaldiina
date: 05.29.2026
version: 12.0
content_type: concept
tier: starter
category: Settings and maintenance
topic: licenses
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: sv
---

# SuperOffice CRM Suite-planer

SuperOffice CRM Suite tillhandahåller en samlad CRM-plattform för försäljning, marknadsföring och service. Alla användare i din organisation delar en plan, och planen bestämmer vilka funktioner som är tillgängliga i hela organisationen.

## <a id="plans"></a>Planer

Fem planer är tillgängliga. Planerna är kumulativa — varje plan inkluderar allt i planerna under den.

| Plan | Beskrivning |
| --- | --- |
| **Starter** | Börja bygga kundrelationer. Täcker hantering av försäljningspipeline, ärendehantering, marknadsföringskampanjer, kontakt- och dokumenthantering samt inbyggda dataskyddsverktyg. |
| **Core** | Öka produktiviteten och samarbetet. Lägger till mobil CRM, arbetsflödesautomatisering, inbyggt AI-stöd, projekthantering, dashboardanalyser, kalendersynkronisering och CRM-anpassning. |
| **Growth** | Accelerera intäkterna med mål och insikter. Lägger till spårning av försäljningsmål och KPI:er, datadrivna insikter och CRM-ERP-integration. |
| **Plus** | Förbättra kundupplevelsen och öka lojaliteten. Lägger till avancerad ärendelösning, automatiserade marknadsflöden, hantering av kundlivscykeln och sökning med naturligt språk. |
| **Super** | Driv ett säljteam på enterprise-nivå. Lägger till prediktiva försäljningsinsikter, obegränsad spårning av mål och KPI:er, AI-driven tjänsteoptimering och databasreplikering. |

## Hantering av platser

Alla användare i din organisation delar samma plan. En **plats** är en namngiven användare med alternativet **Kan logga in** aktiverat.

* Om du vill ge en användare åtkomst aktiverar du **Kan logga in** på deras användarkort i **Inställningar och underhåll** > **Användare**.
* Om du vill frigöra en plats utan att ta bort användarens data och historik inaktiverar du **Kan logga in** i stället för att ta bort användaren. Borttagning av en användare är permanent.

Du kan visa platsanvändning i **Inställningar och underhåll** > **Licenser** > **SuperOffice-fliken**.

## Prismodell

Ditt abonnemang har tre komponenter:

* **Grundavgift:** En avgift per användare som ger tillgång till hela CRM Suite.
* **Skaleringsmått:** Användningsbaserad prissättning för områden med hög förbrukning. Din plan inkluderar en grundkvot; ytterligare kapacitet kan köpas i block vid behov.
* **Plangränser (fencing):** Fasta nivåbaserade gränser som differentierar planer. Om en plangräns överskrids blockeras den relaterade funktionen tills du frigör kapacitet eller uppgraderar planen.

### Skaleringsmått

Skaleringsmått spårar löpande förbrukning. När din användning överstiger grundkvoten som ingår i din plan faktureras ytterligare kapacitet automatiskt. Områden som är föremål för skalering inkluderar:

* Skickade marknadsföringsmejl
* Lösta ärenden
* Lagring

### <a id="plan-limits"></a>Plangränser

Plangränser är fasta per nivå. När en gräns nås blockeras den relaterade funktionen tills du minskar användningen eller uppgraderar.

| Gräns | Starter | Core | Growth | Plus | Super |
| --- | --- | --- | --- | --- | --- |
| Dashboards | 3 | Obegränsat | Obegränsat | Obegränsat | Obegränsat |
| Aktiva projekt | 0 | 100 | Obegränsat | Obegränsat | Obegränsat |
| Anpassade objekt | 0 | 0 | 15 | Obegränsat | Obegränsat |
| Aktiva marknadsflöden | 0 | 0 | 0 | 10 | Obegränsat |

Både **pågående** och **pausade** flöden räknas mot gränsen för aktiva flöden i Plus-planen. Ett pausat flöde betraktas fortfarande som aktivt eftersom det fortsätter att samla in inkommande kontakter för senare behandling.

Indikatorn **Begränsningar** i **Inställningar och underhåll** > **Licenser** > **Statusfliken** > **Databas** visar din aktuella användning jämfört med varje plangräns.

| Användning | Indikator | Innebörd |
| --- | --- | --- |
| Under 85 % | Antal visas i svart | Normalt — ingen åtgärd krävs |
| 85 % eller mer | <i class="ph ph-warning" aria-label="Warning"></i> Antal visas i rött | Närmar sig gränsen |
| 100 % | <i class="ph ph-prohibit" aria-label="Limit reached"></i> Antal visas i rött | Gränsen nådd — funktionen är blockerad |

Om du är administratör visas en **Uppgradera**-knapp bredvid en varnings- eller stoppindikator. Välj den för att öppna ett kontaktformulär och begära mer kapacitet eller en planuppgradering.

## Övergång från SuperOffice CRM Online

Organisationer som migrerar från **SuperOffice CRM Online** (det modulbaserade abonnemanget) placeras i den CRM Suite-plan som matchar deras aktuella licens.

| Aktuell licens | CRM Suite-plan |
| --- | --- |
| Sales Essentials | Core |
| Service Essentials | Core |
| Marketing Essentials | Growth |
| Sales Premium | Growth |
| Service Premium | Growth |
| Marketing Premium | Plus |

Om du hade flera licenser följer migreringen din aktuella licens.

## Relaterat innehåll

* [CRM och licenser][1]
* [Användarplaner för SuperOffice CRM Online][2]
* [Aktivera licens][3]

<!-- Referenced links -->
[1]: index.md
[2]: user-plans.md
[3]: activate.md

