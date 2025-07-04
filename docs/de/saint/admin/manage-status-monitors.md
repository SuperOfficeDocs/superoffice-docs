---
uid: help-de-manage-status-monitors
title: Statuskontrollen verwalten
description: Statuskontrollen verwalten
keywords: SAINT, Statuskontrollen
author: SuperOffice RnD
date: 02.22.2023
version: 9
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
redirect_from: /de/sale/saint/learn/admin/manage-status-monitors
---

# Statuskontrollen verwalten

[!include[Requirement](../includes/note-saint-req.md)]

Wenn Sie mehrere Statuskontrollen und unterschiedliche Zeiträume/Zähler einrichten, ist es wichtig, diese regelmäßig zu überprüfen, um sicherzustellen, dass die Zähler und Status erneuert und aktualisiert werden und die [Kriterien][1] für die verschiedenen Status korrekt sind.

Die folgenden Abschnitte enthalten Informationen über das Aktivieren und Deaktivieren von Statuskontrollen und über das Erneuern von Statusangaben und Zählern. [!include[Define counter](../includes/def-counter.md)]

<!-- markdownlint-disable-next-line MD013 -->
## Allgemeine Informationen zum Aktualisieren und Erneuern von Statusangaben und Zählern

Unten auf der Registerkarte **Statuskontrollen** befinden sich Anzeigen für das Erneuern von Statusangaben und Zählern (Text, der das letzte Erstellungsdatum anzeigt, angibt, ob der ausgewählte Status oder die ausgewählten Zähler überhaupt generiert wurden oder ob der ausgewählte Status aufgrund von Änderungen erneuert werden soll).

Erneuern Sie Statusangaben bzw. Zähler, wenn die Anzeigen darauf hindeuten, dass die letzte Erneuerung lang her ist oder dass die Statusangaben und/oder Zähler bisher nicht erneuert wurden. Das Gleiche gilt, wenn Statusangaben geändert werden. Statusangaben und Zähler, die nicht aktualisiert werden, werden dennoch aktiviert und sind in SuperOffice CRM verwendbar. Allerdings sind die zurückgegebenen Datumsangaben möglicherweise falsch. In den folgenden Abschnitten wird beschrieben, wie Statusangaben und Zähler erneuert werden.

### Wie man erkennt, ob es aktualisiert wurde

Wenn das Objekt nicht aktualisiert wird, wird er in SuperOffice CRM als ausgegraut angezeigt.

## Statusangaben erneuern <i class="ph ph-arrow-circle-right" aria-label="Arrow right"></i>

Wenn Sie ein [Kriterium hinzugefügt, bearbeitet oder gelöscht][2] haben oder wenn Sie z.B. einen Zweck für eine Aufgabe in SuperOffice CRM bearbeitet haben, wird ein rotes Kreuz neben den betroffenen Statusangaben in der Statusliste angezeigt. Mit einem roten Kreuz gekennzeichnete Statusangaben sind nicht aktiviert.

Diese Statusangaben müssen Sie anschließend aktualisieren, indem Sie auf eine der folgenden Schaltflächen klicken:

| Name | Beschreibung | Ort |
|---|---|---|
| Ausgewählte Statusangaben erneuern | Wählen Sie die Option aus, um den gewählten Status zu erneuern | Unten auf der Registerkarte **Unternehmen**, **Kontakt** oder **Projekt** |
| Alle Statuskontrollen erneuern | Wählen Sie die Option aus, um alle Statusangaben zu erneuern. | Unterer Teil der Registerkarte **Status** |

## Zählerwerte erneuern

| Name | Beschreibung |
|---|---|
| Alle Zähler erneuern | Wählen Sie die Option aus, um alle Zähler zu erneuern |

<!-- Referenced links -->
[1]: ../../search-options/learn/search-criteria.md
[2]: select-status-criteria.md
