---
uid: help-de-report-search-criteria-edit
title: Suchkriterien in Berichten bearbeiten
description: Suchkriterien in Berichten bearbeiten
author: SuperOffice RnD
date: 07.04.2022
keywords: Bericht
topic: howto
language: de
---

# Suchkriterien in Berichten bearbeiten

Sie können Suchkriterien in Ihren eigenen Berichten (Favoriten) bearbeiten. Standardberichte als solche können nicht bearbeitet werden. Sie können deren Suchkriterien aber ändern und die Berichte dann als Ihre eigenen Favoriten speichern (siehe [Favoriten][1]).

1. [!include[How to-goto-reports](../includes/goto-reports.md)]

1. Wählen Sie eine Registerkarte aus. Die Berichte werden in der Berichtsliste angezeigt.

    > [!NOTE]
    > Sie sollten keine Berichte ausführen, ohne vorher Suchkriterien festzulegen, da dies zu extrem großen Berichten und einer zeitaufwändigen Verarbeitung führen kann.

1. Wählen Sie den gewünschten Bericht aus der Liste aus.

1. Doppelklicken Sie in der Kriterienliste auf das Kriterium, das Sie bearbeiten möchten.

1. Das Dialogfeld **Suchkriterien hinzufügen/ändern** wird angezeigt.

1. [Erforderliche Information bearbeiten][2].

    > [!NOTE]
    > Die zur Auswahl stehenden Kriterien hängen von der ausgewählten Registerkarte und dem ausgewählten Bericht ab.

1. Wenn Sie Auswahl ausgeführt haben, klicken Sie unten im Dialogfeld **Suchkriterien hinzufügen/ändern** auf **OK**.

## Beispiel

Im Folgenden wird beschrieben, wie Sie die Kriterien in einem Verkaufsbericht anpassen können.

1. Klicken Sie auf die Registerkarte **Verkauf**. In der Berichtsliste wird eine Liste von Standardberichten für die ausgewählte Registerkarte angezeigt.
1. Klicken Sie auf den Standardbericht **Verkaufsbericht – Tatsächlicher Verkauf**. Im Textfeld wird eine Beschreibung des Berichts angezeigt. Auf der darunter angezeigten Kriterienliste sind die Kriterien für den von Ihnen gewählten Standardbericht aufgelistet.

Die Standardberichtskriterien werden jetzt etwas geändert, um Ihnen zu zeigen, wie Sie sie an Ihre Anforderungen anpassen können. Der Standardbericht wird dahingehend geändert, dass er alle tatsächlichen Verkäufe des vorhergehenden Monats anzeigt, die *nicht* den Status **Offen** haben.

1. Doppelklicken Sie auf das Kriterium **Verkauf: Datum** in der Kriterienliste. Das Dialogfeld **Suchkriterien hinzufügen/ändern** wird angezeigt.

    ![Suchkriterien hinzufügen/ändern -screenshot][img3]

1. Klicken Sie auf den Pfeil neben dem Feld **Dieser Monat**. Ändern Sie den Zeitraum in **Letzter Monat**, und klicken Sie auf **OK**. Der Bericht enthält nur Verkäufe aus dem vorhergehenden Monat.

1. Wählen Sie das Kriterium **Verkauf: Eigentümer** in der Kriterienliste, und klicken Sie unten auf die Schaltfläche **Löschen**. Der Bericht bezieht jetzt alle Verkäufe ein und nicht nur die Verkäufe, für die der betreffende Benutzer (Sie) als Eigentümer erfasst ist.

1. Doppelklicken Sie auf **Verkauf: Status** in der Kriterienliste. Das Dialogfeld **Suchkriterien hinzufügen/ändern** wird angezeigt. Jetzt wird das Kriterium **Verkauf: Status** so geändert, dass der Bericht nur Verkäufe enthält, die nicht den Status **Offen** aufweisen.

    ![Suchkriterien hinzufügen/ändern -screenshot][img4]

1. Klicken Sie auf den Pfeil neben dem Feld **Ist eines von**, und ändern Sie den Wert in **Ist nicht eines von**.

1. Wählen Sie in der Spalte **Ausgewählte Werte** die Option **Verkauft** aus, und klicken Sie auf das ![Symbol][img2]. Das Kriterium wird in die ganz linke Spalte verschoben.

1. Wählen Sie in der Spalte ganz links **Öffnen** aus und klicken Sie auf das ![Symbol][img1]. Das Kriterium wird in die Spalte **Ausgewählte Werte** verschoben. Der Bericht enthält jetzt Verkäufe, die nicht den Status **Offen** haben.

1. Klicken Sie auf **OK**.

<!-- Referenced links -->
[1]: ../favorites/add.md
[2]: ../../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/arrow-right.png
[img2]: ../../../../media/icons/arrow-left.png
[img3]: ../../../../media/loc/en/reports/edit-criteria.png
[img4]: ../../../../media/loc/en/reports/edit-criteria-2.png
