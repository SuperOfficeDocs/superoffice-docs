---
uid: help-de-project-type
title: Projekttyp
description: Erfahren Sie, wie Sie in SuperOffice CRM einen neuen Projekttyp erstellen. Definieren Sie Namen, legen Sie geschätzte Dauern fest, verknüpfen Sie Statuswerte und optional Projektleitfäden für eine optimierte Projektverwaltung.
keywords: Projekttyp hinzufügen, Projekttyp erstellen, neuen Projekttyp, Projekttyp, Liste Projekt - Typ Status, Projekt
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
topic: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Projekttyp

[!include[Muss Admin sein](../../learn/includes/req-admin.md)]

Das Feld **Typ** in der Projektkarte kategorisiert Projekte und definiert deren Arbeitsabläufe. Diese Typen sind in der Liste **Projekt - Typ, Stufen** vordefiniert, die Sie in Einstellungen und Verwaltung unter **Listen** verwalten können.

Jedes Projekt benötigt einen Typ. Diese Typen können mit bestimmten [Statuswerten][1] und optional mit [Projektleitfäden][4] verknüpft werden. Projektleitfäden erleichtern die Ausführung, indem sie Benutzer durch vordefinierte Phasen, Folgeaufgaben und Dokumente führen.

## Einen Projekttyp hinzufügen

1. Wählen Sie <i class="ph ph-list-bullets" aria-hidden="true"></i> **Listen** im Navigator.

1. Wählen Sie im Dropdown-Menü **Projekt - Typ, Stufen** aus. Die Registerkarte **Objekte** zeigt alle vorhandenen Projekttypen an.

1. Klicken Sie auf **Hinzufügen**, um das Dialogfeld **Listenobjekt bearbeiten** zu öffnen.

    ![Dialogfeld zum Bearbeiten eines Listenelements mit Feldern zur Konfiguration von Projekttypen -screenshot][img1]

1. Geben Sie im Feld **Name** einen Namen für den Projekttyp ein. *(Pflichtfeld)*

    Dieser Name wird im Feld **Typ** der Projektkarte angezeigt.

1. Legen Sie die geschätzte Projektdauer im Feld **Geschätzte Zeit für diesen Projektfortschritt** fest (Wochen, Tage oder Monate).

    Diese Angabe bestimmt das standardmäßige Enddatum bei der Erstellung eines Projekts (aktuelles Tagesdatum + geschätzte Zeit).

1. Wählen Sie in der Liste **Für diesen Projekttyp verwendete Status** die benötigten Statuswerte aus.

    > [!NOTE]
    > Um den Projekttyp mit einem Projektleitfaden zu verknüpfen, müssen mindestens zwei Statuswerte ausgewählt sein.

1. *(Optional)* Aktivieren Sie **Dieser Projekttyp ist mit einem Leitfaden verknüpft**, wenn alle Projekte dieses Typs einem Projektleitfaden folgen sollen.

1. *(Optional)* Aktivieren Sie **Vorschlag, das Projekt automatisch in den nächsten Status zu verschieben**, um Benutzer aufzufordern, das Projekt [in den nächsten Status zu verschieben][5], sobald alle Aktivitäten des aktuellen Status abgeschlossen sind.

1. *(Optional)* Fügen Sie eine Beschreibung des Typs im Feld **Beschreibung** hinzu.

1. Klicken Sie auf **Speichern**, um die Änderungen zu übernehmen, oder auf **Abbrechen**, um den Vorgang abzubrechen.

    Der Projekttyp wird zur **Objekte**-Liste hinzugefügt. Wiederholen Sie diese Schritte, um weitere Projekttypen hinzuzufügen.

## Einen Projekttyp bearbeiten oder löschen

1. Folgen Sie den Schritten 1–2 oben, um die Liste **Projekt - Typ, Stufen** zu öffnen.

1. **Bearbeiten:**
    * Doppelklicken Sie auf den gewünschten Projekttyp, um das Dialogfeld **Listenobjekt bearbeiten** zu öffnen.
    * Nehmen Sie die gewünschten Änderungen vor und klicken Sie auf **Speichern**.

1. **Löschen:**
    * Wählen Sie den Projekttyp in der Liste aus und klicken Sie auf **Löschen**.

    > [!CAUTION]
    > Das Löschen eines Projekttyps entfernt auch dessen Verknüpfung mit Statuswerten und Projektleitfäden. Stellen Sie sicher, dass der Typ nicht mehr aktiv verwendet wird, bevor Sie ihn löschen.

## <a id="restore"></a>Einen gelöschten Projekttyp wiederherstellen

Falls ein Projekttyp gelöscht wurde, können Sie ihn aus der Liste **Projekt - Typ, Stufen** wiederherstellen. Beachten Sie jedoch, dass dadurch nicht automatisch die ursprünglichen Verknüpfungen zu Statuswerten oder Projektleitfäden wiederhergestellt werden. Falls erforderlich, müssen diese manuell neu eingerichtet werden.

1. Wechseln Sie zur Liste **Projekt - Typ, Stufen**.

1. Aktivieren Sie unten die Option **Gelöschte Elemente und Überschriften anzeigen**. Gelöschte Einträge werden in der Registerkarte **Objekte** durchgestrichen dargestellt.

1. Doppelklicken Sie auf das wiederherzustellende Element. Das Dialogfeld **Listenobjekt bearbeiten** öffnet sich.

1. Klicken Sie auf **Wiederherstellen**.

1. Nehmen Sie erforderliche Anpassungen vor und klicken Sie auf **Speichern**. Das Element ist nun aktiv und wird in der **Objekte**-Liste angezeigt.

## Verwandte Inhalte

* [Einen Projektstatus hinzufügen][1]
* [Einen Projektleitfaden erstellen][2]
* [Einen Projektleitfaden bearbeiten][3]

<!-- Referenced links -->
[1]: project-status.md
[2]: create-project-guide.md
[3]: edit-project-guide.md
[4]: ../learn/project-guides.md
[5]: ../learn/project-guides.md#change-status

<!-- Referenced images -->
[img1]: ../../../media/loc/en/project/edit-project-type.png
