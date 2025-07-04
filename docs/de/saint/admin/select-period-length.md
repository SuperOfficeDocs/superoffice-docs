---
uid: help-de-select-period-length
title: Zeitraum auswählen
description: Zeitraum auswählen
keywords: SAINT, Statuskontrollen, Zähler
author: SuperOffice RnD
date: 02.22.2023
version: 9
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
redirect_from: /de/sale/saint/learn/admin/select-period-length
---

# Zeitraum festlegen

[!include[Requirement](../includes/note-saint-req.md)]

Sie können den Zeitraum (Dauer in Tagen) für die folgenden Zähler festlegen:

* Anzahl erledigter/nicht erledigter Aktivitäten innerhalb von
* Anzahl abgeschlossener/nicht abgeschlossener Verkäufe innerhalb von
* Anzahl erledigter/nicht erledigter Anfragen während des Zeitraums (wenn Ihre Firma irgendwelche SuperOffice Service-Lizenzen hat)

[!include[Define counter](../includes/def-counter.md)]

Sie können bis zu drei unterschiedliche Zeiträume festlegen, so dass Sie zwischen kürzeren bzw. längeren Zeiträumen für die verschiedenen SAINT-Kriterien wählen können. Zum Beispiel: Wenn Sie den **Zeitraum 1** auf 30 Tage und den **Zeitraum 2** auf 90 Tage festlegen, können Sie zum Beispiel zwischen den SAINT-Kriterien "Anzahl von Verkäufen in den letzten 30 Tagen" UND "Anzahl von Verkäufen in den letzten 90 Tagen" auswählen.

## Schritte

1. Öffnen Sie die Ansicht **SAINT**.

2. Wählen Sie die Registerkarte **Zähler** aus.

3. Unter **Zählereinstellungen für ...** legen Sie die Zeiträume für Firmen, Personen und Projekte fest. Das Datum **Von** wird neben jedem Zeitraum angezeigt.

    ![Zählereinstellungen auf der Registerkarte Zähler bearbeiten -screenshot][img1]

    Die Änderungen werden automatisch gespeichert.

> [!NOTE]
> Wenn Sie den Zeitraum zum Beispiel auf 30 Tage festgelegt haben, dauert der Zeitraum vom letzten Erneuern der Zähler immer 30 Tage. Sie sollten daher die [Zähler häufig erneuern][2] (möglichst jede Nacht), damit die Zähler so aktuell wie möglich sind.

<!-- Referenced links -->
[2]: manage-status-monitors.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/admin-saint-counters.png
