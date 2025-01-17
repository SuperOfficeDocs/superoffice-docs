---
uid: help-de-document-library-change-to-sharepoint
title: SharePoint-Dokumentbibliothek konfigurieren
description: SharePoint-Dokumentbibliothek konfigurieren
author: SuperOffice RnD
so.date: 03.21.2023
keywords: Dokument, SharePoint
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: de
---

# SharePoint-Dokumentbibliothek konfigurieren

> [!NOTE]
> Für diese Konfiguration müssen Sie vorab Ihre SharePoint-Website, Bibliotheken und Berechtigungen festlegen. Alle Benutzer müssen sich mit Microsoft 365 authentifizieren.

Beim Konfigurieren Ihrer neuen Dokumentbibliothek zeigt Admin einen Zwischenstatus an.

Wenn Sie fertig sind und bestätigt haben, dass Sie SharePoint nutzen, wechselt der Status in Admin zu Microsoft SharePoint Online.

Einige Einstellungen können später im Assistenten noch geändert werden

**Schritte:**

1. [!include[Open preferences](../includes/open-preferences.md)]
2. Wählen Sie die Registerkarte **Dokumentbibliothek** aus.
3. Klicken Sie auf **Ändern**. Die Seite wird mit Informationen über die verbundene SharePoint-Website abgeglichen. Der Wechsel ist noch nicht abgeschlossen.
4. Klicken Sie auf **Änderung abschließen**, um zu bestätigen, dass Sie SharePoint als Standarddokumentbibliothek nutzen wollen. Der Wechsel ist nun abgeschlossen.
5. Klicken Sie auf **Einstellungen**.
6. Führen Sie die vier Schritte des unten beschriebenen Konfigurationsassistenten aus.

## Schritt 1 - Websites und Ordner

In diesem Schritt müssen Sie Speicherort, Ordner- und Dateinamen für Ihre SuperOffice-Dokumente und -Vorlagen festlegen.

### SuperOffice-Dokumente – Speicherort, Ordner- und Dateinamen

* **Website in SharePoint**: Wählen Sie Ihre Website aus der Liste aus.
* **Dokumentbibliothek**: Wählen Sie die Bibliothek aus der Liste aus.
* **Ordnerstruktur**: Wählen Sie die bevorzugte Ordnerstruktur (Ordnernamen) aus.
* **Ordner in jährlichen Unterordnern organisieren**: Wählen Sie diese Option, um Unterordner pro Jahr hinzuzufügen.
* **Dateiname**: Wählen Sie die bevorzugte Benennung Dateien aus.

### SuperOffice-Dokumentvorlagen – Speicherort

* **Website in SharePoint**: Wählen Sie Ihre Website aus der Liste aus.
* **Dokumentbibliothek**: Wählen Sie die Bibliothek aus der Liste aus.

Klicken Sie zum Fortfahren auf **Nächster Schritt**.

## Schritt 2 - Dokumenteigenschaften

In diesem Schritt müssen Sie auswählen, welche Dokumentfelder als Dokumenteigenschaften von SuperOffice an SharePoint übertragen werden sollen.

> [!NOTE]
> Es wird empfohlen, alle verfügbaren Felder auszuwählen. Diese Felder werden in Ihrer SharePoint-Dokumentbibliothek als Spalten angezeigt.

Mit diesen Feldern können Sie Ansichten in Ihrer SharePoint-Dokumentbibliothek erstellen. Zudem können Sie in SharePoint nach diesen Feldern suchen und sie gruppieren. Bestimmte Felder können gegebenenfalls ausgeblendet werden.

> [!NOTE]
> Um Änderungen an Dokumenten in SuperOffice beizubehalten, muss die ID der Felder gespeichert werden. ID-Spalten können in SharePoint-Dokumentansichten ausgeblendet werden.

Klicken Sie zum Fortfahren auf **Nächster Schritt**.

## Schritt 3 - Gruppen und Zugriff

In diesem Schritt können Sie den Gruppenzugriff auf SharePoint-Dokumente je nach den Einstellungen "Sichtbar für" in SuperOffice aktivieren.

Wenn Sie "Sichtbar für" nicht verwenden wollen, deaktivieren Sie diese Option.

1. Wählen Sie **Gruppenzugriff auf SharePoint-Dokumente basierend auf den SuperOffice-Einstellungen "Sichtbar für" aktivieren** aus.

2. Um Berechtigungen für Dokumente in SharePoint festzulegen, sind Lese-/Schreibberechtigungen für die ausgewählte Website erforderlich. Dies ist eine einmalige Autorisierung und umfasst nur die Website, die Sie für Ihre SuperOffice-Dokumente ausgewählt haben.

    > [!NOTE]
    > Nur ein globaler Microsoft 365-Administrator kann diese Berechtigungen autorisieren. Darüber hinaus muss der globale Microsoft 365-Administrator Mitglied der Eigentümergruppe der Website sein, weil zum Festlegen von Lese-/Schreibberechtigungen die Berechtigungen eines Website-Eigentümers erforderlich sind.

    Führen Sie einen der folgenden Schritte aus:

    * Wenn Sie ein globaler Microsoft 365-Administrator sind: Klicken Sie zum Autorisieren auf **Jetzt autorisieren**.

    * Wenn Sie KEIN globaler Microsoft 365-Administrator sind: Klicken Sie auf **Autorisierungs-URL kopieren** und senden Sie sie an einen globalen Microsoft 365-Administrator in Ihrer Organisation.

3. Sie haben folgende Optionen, wenn Sie auf eine Autorisierung warten müssen:

    * Klicken Sie auf **Speichern und schließen**, um später mit der Konfiguration fortzufahren. Der Seitentext wird aktualisiert und weist darauf hin, dass die Autorisierung aussteht.

    * Klicken Sie auf **Status erneut prüfen**, um festzustellen, ob der globale Microsoft 365-Administrator die App autorisiert hat.

4. Wählen Sie für jede SuperOffice-Benutzergruppe die entsprechende Benutzergruppe in SharePoint aus. Alle SuperOffice-Benutzergruppen müssen zugeordnet werden, bevor Sie zum nächsten Schritt übergehen können.

5. Klicken Sie zum Fortfahren auf **Nächster Schritt**.

## Schritt 4 - Überprüfen und bestätigen

Überprüfen Sie die Konfiguration sorgfältig und vergewissern Sie sich, dass die Einstellungen korrekt sind.

Nachdem Sie die Einstellungen bestätigt haben, können sie nicht mehr bearbeitet werden:

SuperOffice-Dokumente

* Website in SharePoint
* Dokumentbibliothek

SuperOffice-Dokumentvorlagen

* Website in SharePoint
* Dokumentbibliothek

Klicken Sie, wenn Sie fertig sind, auf **Bestätigen**.

## Verwandte Themen

* [SharePoint-Dokumente][1] – technische Übersicht

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/cloud/sharepoint-documents/index.html

<!-- Referenced images -->
