---
uid: help-de-project-status
title: Projektstatus
description: Erfahren Sie, wie Sie in SuperOffice CRM einen neuen Projektstatus hinzufügen. Erstellen und verwalten Sie vordefinierte Statuswerte, um Projektphasen zu verfolgen und Arbeitsabläufe effizient zu steuern.
keywords: Projektstatus hinzufügen, Projektstatus, Projekt
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
content_type: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Projektstatus

[!include[Muss Admin sein](../../learn/includes/req-admin.md)]

Das Feld **Status** in der Projektkarte hilft dabei, den Fortschritt eines Projekts zu kategorisieren und nachzuverfolgen. Diese Statuswerte sind vordefiniert in der Liste **Projekt - Status**, die Sie in Einstellungen und Verwaltung unter **Listen** verwalten können.

Statuswerte können mit [Projekttypen][1] verknüpft werden, um festzulegen, welche Status für welche Projekttypen verfügbar sind. Falls kein Projektleitfaden definiert ist, bleibt das Feld **Status** dennoch im Projekt sichtbar, sodass Benutzer den aktuellen Status des Projekts anzeigen und aktualisieren können.

## Einen Status hinzufügen

1. Wählen Sie <i class="ph ph-list-bullets" aria-hidden="true"></i> **Listen** im Navigator.

1. Wählen Sie im Dropdown-Menü **Projekt - Status** aus. Die Registerkarte **Objekte** zeigt alle vorhandenen Statuswerte an.

1. Klicken Sie auf **Hinzufügen**, um das Dialogfeld **Listenobjekt bearbeiten** zu öffnen.

1. Geben Sie im Feld **Name** den Namen des neuen Status ein. *(Pflichtfeld)*

    Dieser Name wird im Feld **Status** der Projektkarte angezeigt.

1. *(Optional)* Fügen Sie im Feld **Beschreibung** eine Beschreibung hinzu, um die Bedeutung des Status zu erläutern.

1. Klicken Sie auf **Speichern**, um die Änderungen zu übernehmen, oder auf **Abbrechen**, um den Vorgang abzubrechen.

## Einen Status bearbeiten oder löschen

1. Folgen Sie den Schritten 1–2 unter **Einen Status hinzufügen**, um die Liste **Projekt - Status** zu öffnen.

1. **Bearbeiten:**
    1. Doppelklicken Sie auf den gewünschten Status, um das Dialogfeld **Listenobjekt bearbeiten** zu öffnen.
    1. Aktualisieren Sie die Felder nach Bedarf und klicken Sie auf **Speichern**.

1. **Löschen:**
    1. Wählen Sie den Status in der Liste aus und klicken Sie auf **Löschen**.

    > [!CAUTION]
    > Das Löschen eines Status entfernt ihn aus allen verknüpften Projekttypen und Projektleitfäden. Stellen Sie sicher, dass der Status nicht mehr aktiv verwendet wird, bevor Sie ihn löschen.

## Einen gelöschten Projektstatus wiederherstellen

Falls ein Projektstatus gelöscht wurde, können Sie ihn aus der Liste **Projekt - Status** wiederherstellen. Beachten Sie jedoch, dass dadurch nicht automatisch die ursprünglichen Verknüpfungen zu Projekttypen oder Projektleitfäden wiederhergestellt werden. Falls erforderlich, müssen diese manuell neu eingerichtet werden.

Die Schritte entsprechen denen zur [Wiederherstellung eines gelöschten Projekttyps][2].

## Verwandte Inhalte

* [Projekttypen hinzufügen oder aktualisieren][1]
* [Einen Projektleitfaden erstellen][3]
* [Einen Projektleitfaden bearbeiten][4]
* [Projekt in den nächsten Status verschieben][5]

<!-- Referenced links -->
[1]: project-type.md
[2]: project-type.md#restore
[3]: create-project-guide.md
[4]: edit-project-guide.md
[5]: ../learn/project-guides.md#change-status
