---
uid: help-de-crm-suite
title: SuperOffice CRM Suite-Pläne
description: Übersicht über die fünf SuperOffice CRM Suite-Pläne, Verwaltung von Benutzerplätzen, Plangrenzen und Preismodell.
keywords: CRM Suite, Plan, Starter, Core, Growth, Plus, Super, Plangrenzen, Fencing, Skalierung, Benutzerplatz, Abonnement
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
language: de
---

# SuperOffice CRM Suite-Pläne

SuperOffice CRM Suite stellt eine einheitliche, integrierte CRM-Plattform bereit, die Vertrieb, Marketing und Service abdeckt. Alle Benutzer in Ihrer Organisation teilen einen Plan, und der Plan bestimmt, welche Funktionen in der gesamten Organisation verfügbar sind.

## <a id="plans"></a>Pläne

Es stehen fünf Pläne zur Verfügung. Die Pläne sind kumulativ — jeder Plan enthält alles aus den Plänen darunter.

| Plan | Beschreibung |
| --- | --- |
| **Starter** | Beginnen Sie mit dem Aufbau von Kundenbeziehungen. Umfasst Verwaltung der Verkaufspipeline, Anfragenbearbeitung, Marketingkampagnen, Personen- und Dokumentenverwaltung sowie integrierte Datenschutztools. |
| **Core** | Steigern Sie Produktivität und Zusammenarbeit. Fügt mobiles CRM, Workflow-Automatisierung, integrierte KI-Unterstützung, Projektverwaltung, Dashboard-Analysen, Kalendersynchronisierung und CRM-Anpassung hinzu. |
| **Growth** | Beschleunigen Sie den Umsatz mit Zielen und Einblicken. Fügt Verfolgung von Verkaufszielen und KPIs, datengetriebene Erkenntnisse und CRM-ERP-Integration hinzu. |
| **Plus** | Verbessern Sie das Kundenerlebnis und steigern Sie die Kundenbindung. Fügt erweiterte Anfragenlösung, automatisierte Marketingabläufe, Verwaltung des Kundenlebenszyklus und Suche in natürlicher Sprache hinzu. |
| **Super** | Führen Sie ein Vertriebsteam auf Enterprise-Niveau. Fügt prädiktive Verkaufserkenntnisse, unbegrenzte Ziel- und KPI-Verfolgung, KI-gesteuerte Serviceoptimierung und Datenbankreplikation hinzu. |

## Verwaltung von Benutzerplätzen

Alle Benutzer in Ihrer Organisation teilen denselben Plan. Ein **Benutzerplatz** ist ein namentlich genannter Benutzer mit der aktivierten Option **Anmelden möglich**.

* Um einem Benutzer Zugriff zu gewähren, aktivieren Sie **Anmelden möglich** auf der Benutzerkarte unter **Einstellungen und Verwaltung** > **Benutzer**.
* Um einen Benutzerplatz freizugeben, ohne die Daten und den Verlauf des Benutzers zu entfernen, deaktivieren Sie **Anmelden möglich**, anstatt den Benutzer zu löschen. Das Löschen eines Benutzers ist dauerhaft.

Sie können die Nutzung von Benutzerplätzen anzeigen unter **Einstellungen und Verwaltung** > **Lizenzen** > **Registerkarte SuperOffice**.

## Preismodell

Ihr Abonnement besteht aus drei Komponenten:

* **Grundgebühr:** Eine Gebühr pro Benutzer, die Zugriff auf die gesamte CRM Suite gewährt.
* **Skalierungsmetriken:** Verbrauchsbasierte Preisgestaltung für Bereiche mit hohem Verbrauch. Ihr Plan enthält ein Basiskontingent; zusätzliche Kapazität kann bei Bedarf in Blöcken erworben werden.
* **Plangrenzen (Fencing):** Feste stufenbasierte Grenzen, die Pläne voneinander unterscheiden. Das Überschreiten einer Plangrenze sperrt die zugehörige Funktion, bis Sie Kapazität freigeben oder Ihren Plan upgraden.

### Skalierungsmetriken

Skalierungsmetriken verfolgen den laufenden Verbrauch. Wenn Ihr Verbrauch das im Plan enthaltene Basiskontingent überschreitet, wird zusätzliche Kapazität automatisch berechnet. Bereiche, die der Skalierungspreisgestaltung unterliegen:

* Gesendete Marketing-E-Mails
* Gelöste Serviceanfragen
* Speicherplatz

### <a id="plan-limits"></a>Plangrenzen

Plangrenzen sind pro Stufe fest. Wenn eine Grenze erreicht wird, wird die zugehörige Funktion gesperrt, bis Sie den Verbrauch reduzieren oder upgraden.

| Grenze | Starter | Core | Growth | Plus | Super |
| --- | --- | --- | --- | --- | --- |
| Dashboards | 3 | Unbegrenzt | Unbegrenzt | Unbegrenzt | Unbegrenzt |
| Aktive Projekte | 0 | 100 | Unbegrenzt | Unbegrenzt | Unbegrenzt |
| Benutzerdefinierte Objekte | 0 | 0 | 15 | Unbegrenzt | Unbegrenzt |
| Aktive Marketingabläufe | 0 | 0 | 0 | 10 | Unbegrenzt |

Sowohl **laufende** als auch **pausierte** Abläufe werden auf das Limit für aktive Abläufe im Plus-Plan angerechnet. Ein pausierter Ablauf gilt weiterhin als aktiv, da er weiterhin eingehende Personen für die spätere Verarbeitung sammelt.

Der Indikator **Einschränkungen** unter **Einstellungen und Verwaltung** > **Lizenzen** > **Registerkarte Status** > **Datenbank** zeigt Ihren aktuellen Verbrauch im Vergleich zu den einzelnen Plangrenzen.

| Verbrauch | Indikator | Bedeutung |
| --- | --- | --- |
| Unter 85 % | Anzahl in Schwarz angezeigt | Normal — keine Maßnahme erforderlich |
| 85 % oder mehr | <i class="ph ph-warning" aria-label="Warning"></i> Anzahl in Rot angezeigt | Nähert sich dem Limit |
| 100 % | <i class="ph ph-prohibit" aria-label="Limit reached"></i> Anzahl in Rot angezeigt | Limit erreicht — die Funktion ist gesperrt |

Wenn Sie Administrator sind, wird neben einem Warn- oder Stoppindikator eine Schaltfläche **Upgrade** angezeigt. Wählen Sie sie aus, um ein Kontaktformular zu öffnen und mehr Kapazität oder ein Plan-Upgrade anzufordern.

## Migration von SuperOffice CRM Online

Organisationen, die von **SuperOffice CRM Online** (dem modulbasierten Abonnement) migrieren, werden in den CRM Suite-Plan eingestuft, der ihrer aktuellen Lizenz entspricht.

| Aktuelle Lizenz | CRM Suite-Plan |
| --- | --- |
| Sales Essentials | Core |
| Service Essentials | Core |
| Marketing Essentials | Growth |
| Sales Premium | Growth |
| Service Premium | Growth |
| Marketing Premium | Plus |

Wenn Sie mehrere Lizenzen hatten, folgt die Migration Ihrer aktuellen Lizenz.

## Verwandte Inhalte

* [CRM und Lizenzen][1]
* [SuperOffice CRM Online-Benutzerpläne][2]
* [Lizenz aktivieren][3]

<!-- Referenced links -->
[1]: index.md
[2]: user-plans.md
[3]: activate.md

