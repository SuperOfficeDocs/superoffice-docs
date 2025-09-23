---
uid: help-de-saint-counters
title: Zähler und Zählereinstellungen
description: Zähler für SAINT definieren und konfigurieren
keywords: SAINT, Statuskontrollen, Zähler, Zeitraum
author: SuperOffice Product and Engineering
date: 09.23.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
index: true
redirect_from:
  - /de/sale/saint/learn/admin/specify-period-length
  - /de/saint/admin/specify-period-length
---

# Zähler und Zählereinstellungen

[!include[Requirement](../includes/note-saint-req.md)]

Ein **Zähler** ist ein Wert wie die Anzahl der Verkäufe in einem Zeitraum oder das Datum des letzten erledigten Verkaufs. Zähler können als Suchkriterien verwendet werden, um Firmen, Personen oder Projekte zu finden.

Sie können den Zeitraum (Dauer in Tagen) für die folgenden Zähler festlegen:

* Aktivitäten (erledigter oder offen)
* Verkäufe (erledigter oder offen)
* Anfragen (erledigter oder offen, wenn Ihre Firma SuperOffice Service hat)

Sie können bis zu drei verschiedene Zeiträume definieren. Dadurch können Sie SAINT-Kriterien für kürzere oder längere Zeitspannen erstellen. Zum Beispiel: Wenn Sie **Zeitraum 1** auf 30 Tage und **Zeitraum 2** auf 90 Tage festlegen, können Sie die Kriterien *Anzahl Verkäufe letzte 30 Tage* oder *Anzahl Verkäufe letzte 90 Tage* verwenden.

## Schritte

1. Öffnen Sie die Ansicht **SAINT** in Einstellungen und Wartung.

1. Wählen Sie die Registerkarte **Zähler** aus.

1. Unter **Zählereinstellungen für ...** geben Sie die Zeitraumwerte für Firmen, Personen und Projekte ein. Das **Von**-Datum wird neben jedem Zeitraum angezeigt.

    ![SAINT-Zählereinstellungen auf der Registerkarte Zähler bearbeiten -screenshot][img1]

    Die Änderungen werden automatisch gespeichert.

> [!NOTE]
> Ein Zeitraum wird immer ab dem letzten Regenerieren der Zähler berechnet. Um die Ergebnisse genau zu halten, [regenerieren Sie Zähler häufig][2] (vorzugsweise jede Nacht).

<!-- Referenced links -->
[2]: update.md#regen

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/counters.png
