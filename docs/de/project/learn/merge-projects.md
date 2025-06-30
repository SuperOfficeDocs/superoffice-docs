---
uid: help-de-project-merge
title: Projekte zusammenführen
description: Wie man Projekte in SuperOffice zusammenführt
keywords: Projekte zusammenführen, Projektmanagement, Projekt
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Projekte zusammenführen

Wenn Sie zwei nahezu identische Projekte haben, können Sie diese zusammenführen, einschließlich der Projektmitglieder und Aktivitäten. Das Quellprojekt wird anschließend gelöscht.

## Schritte

1. Wechseln Sie zu dem Projekt, das Sie mit einem anderen Projekt zusammenführen möchten. Siehe [Suchansicht verwenden][1].

1. Klicken Sie auf die Schaltfläche **Aufgabe** (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) in der oberen rechten Ecke der Projektkarte und wählen Sie **Projekte zusammenführen**.

    > [!NOTE]
    > Wenn die Option **Zusammenführen** ausgegraut ist, bedeutet dies, dass Sie nicht über die erforderlichen Benutzerrechte verfügen, um Projekte zusammenzuführen.

1. Im Dialogfeld **Projekte zusammenführen**:

    * Wählen Sie unter **In** das Projekt aus, in das das aktuelle Projekt zusammengeführt werden soll. Beginnen Sie mit der Eingabe, um nach einem Projekt zu suchen.
    * Um die Projekte in den Feldern **Von** und **In** zu tauschen, klicken Sie auf die Pfeil-Schaltfläche (<i class="ph ph-arrows-left-right" aria-hidden="true"></i>).

    > [!CAUTION]
    > Stellen Sie sicher, dass Sie die richtigen Projekte in den Feldern **Von** und **In** auswählen, bevor Sie fortfahren. **Das Zusammenführen kann nicht rückgängig gemacht werden**.

1. (Optional) Aktivieren Sie die Option **Leere Felder mit Daten aus [Quellprojekt] ersetzen**, um leere Felder im Zielprojekt mit Daten aus dem Quellprojekt zu aktualisieren.

1. Klicken Sie auf **Zusammenführen**. Dabei werden folgende Aktionen ausgeführt:
    * Projektmitglieder werden verschoben oder zusammengeführt.
    * Alle Aktivitäten werden verschoben.
    * Verknüpfte Verkäufe werden verschoben.
    * Details werden zusammengeführt (falls festgelegt).
    * Wenn Sie ein Projekt zusammenführen, das mit einem Projektleitfaden verknüpft ist, und das Zielprojekt einen anderen oder keinen Projektleitfaden hat, wird der Projektleitfaden aus dem Quellprojekt entfernt.
    * Das Quellprojekt wird gelöscht.

![Dialogfeld Projekte zusammenführen mit Feldern zur Auswahl von Quell- und Zielprojekt, Optionen zum Ersetzen leerer Felder und einer Zusammenfassungsübersicht der Aktionen. -screenshot][img2]

## Verwandte Inhalte

* [Projekte bearbeiten][3]
* [Firmen zusammenführen][2]

<!-- Referenced links -->
[1]: ../../search-options/learn/find-screen.md
[2]: ../../company/learn/merge-companies.md
[3]: edit.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/project/merge-projects.png
