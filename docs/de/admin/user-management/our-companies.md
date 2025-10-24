---
uid: help-de-our-companies-manage
title: Unsere Firmen verwalten
description: Wie man Firmen in der Registerkarte Unsere Firmen hinzufügt oder entfernt
keywords: unsere Firmen
author: digitaldiina
date: 10.24.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: user
platform: web
index: true
redirect_from: 
  - /de/admin/user-management/learn/move-user
  - /de/admin/user-management/learn/our-companies
language: de
---

# Unsere Firmen verwalten

Im Bildschirm Benutzer unter Einstellungen und Wartung können Sie Unsere Firmen verwalten und Benutzer zwischen ihnen verschieben.

## Firma in der Registerkarte Unsere Firmen hinzufügen

Voraussetzungen: Damit Sie ein Unternehmen zur Registerkarte **Unsere Firmen** hinzufügen können, muss es als Firma in SuperOffice CRM erfasst werden.

1. Wählen Sie die Registerkarte **Unsere Firmen**.

1. Klicken Sie unter der Firmenliste auf die Schaltfläche **Hinzu**.

1. Die Ansicht Suchen wird geöffnet. Wenn bereits Suchkriterien eingegeben wurden, Sie diese aber nicht verwenden möchten, klicken Sie auf die Schaltfläche **Alle deaktivieren**, um sie zu entfernen, oder deaktivieren Sie die Kontrollkästchen für die entsprechenden Kriterien.

1. Suchen Sie nach einer Firma. Für weitere Details siehe unten.

1. Klicken Sie nach Auswahl der gewünschten Firma auf **OK**. Die Firma wird nun in der Liste angezeigt.

## Firma aus der Registerkarte Unsere Firmen löschen

1. Überprüfen Sie, ob diese Kriterien erfüllt werden:

    * Für die Firma dürfen keine Mitarbeiter registriert sein. Die Anzahl der Mitarbeiter wird in der Firmenliste in der Spalte **Mitarbeiter** angezeigt. Wenn Sie eine Firma löschen möchten, müssen Sie zunächst [erfasste Mitarbeiter löschen][2].
    * Die Firma darf kein aktiver Satellit sein. Überprüfen Sie, ob die Firma in der Spalte in der Firmenliste **Aktiver Satellit** aufgeführt ist.

1. Wählen Sie die Registerkarte **Unsere Firmen**.

1. Wählen Sie die gewünschte Firma in der Liste aus.

1. Klicken Sie unter der Firmenliste auf die Schaltfläche **Löschen**. Die Firma wird aus der Liste entfernt.

> [!NOTE]
> Sie können eine Firma nicht löschen, wenn sie als Datenbank-Besitzer registriert ist. Wenn Sie den Datenbank-Besitzer auswählen, ist die Schaltfläche **Löschen** deaktiviert.

## <a id="move"></a>Benutzer von einer Firma in eine andere verschieben

Sie können einen Benutzer von einer Firma zu einer anderen verschieben, wenn Ihre Organisation aus mehreren Firmen besteht, die in der Registerkarte Unsere Firmen registriert sind. Wenn ein Benutzer unter der falschen Firma konfiguriert wurde oder die Position/Jobs innerhalb der Organisation gewechselt hat, kann er mitsamt seinen Aktivitäten und Verkäufen verschoben werden.

1. Gähen Sie zur Registerkarte **Mitarbeiter** und wählen Sie den gewünschten Benutzer in der Liste aus.

1. Klicken Sie auf **Aufgabe** und wählen Sie **Benutzer verschieben**.

1. Wählen Sie im Dialogfeld **Verschieben in** und dann die Firma aus, zu der die Person verschoben werden soll.

1. Wählen Sie unter **Aktion für alle vorhandenen Aktivitäten und Verkäufe** eine der folgenden Optionen:

    [!include[Select action](../../learn/includes/select-action-on-activity.md)]

    > [!NOTE]
    > Um die Ergebnisse anzuzeigen, bevor Sie die Aktion bestätigen, müssen Sie auf <i class="ph ph-info" aria-label="Ergebnisse anzeigen"></i> klicken.

1. Klicken Sie auf **Verschieben**. Der Benutzer wird zur die angegebenen Firma verschoben.

## Wie suche ich nach einer Firma?

1. Wählen Sie im Listenfeld rechts neben dem Feld, das Sie für die Suche verwenden möchten, ob mit den eingegebenen Suchkriterien **Beginnt mit**, **Enthält** oder **Ist gleich** nach einer Firma gesucht werden soll.

2. Sie können mehrere [unterschiedliche Suchkriterien](#criteria) wie zum Beispiel Name, Code, Telefonnummer oder E-Mail-Adresse angeben. Wenn Sie mehrere Suchkriterien festlegen, wird eine Suche nach Firmen gestartet, die allen Kriterien gleichzeitig entsprechen.

3. Wenn Sie das gewünschte Kriterium festgelegt haben, klicken Sie auf die Schaltfläche **Suchen**.

4. Der Suchlauf kann drei verschiedene Ergebnisse liefern:

    * **Ein Treffer**: Die Firma, auf die die Auswahlkriterien zutreffen, wird in der Liste angezeigt.

    * **Zwei oder mehr Treffer**: Die Ansicht Suchen zeigt eine Liste der Übereinstimmungen. Markieren Sie hier die gewünschte Firma in der Liste, und klicken Sie auf **OK**, um zu dieser Firma zu wechseln.

    * **Keine Treffer**: Es wird die Meldung angezeigt, dass kein mit den Suchkriterien übereinstimmender Eintrag gefunden wurde. Klicken Sie auf **OK**, und suchen Sie erneut mit anderen Kriterien.

### <a id="criteria"></a>Suchkriterien

Die Felder unten entsprechen den Feldern auf der Firmenkarte.

* Name: Geben Sie den vollständigen Namen oder die Anfangsbuchstaben der Firma ein.
* Nummer: Geben Sie den vollständigen Namen oder die Anfangsbuchstaben der Firma ein.
* Code: Geben Sie den ganzen Code oder den Anfang davon ein.
* USt. ID-Nr.: Geben Sie die ganze USt. ID-Nr. oder den Anfang davon ein.
* Vorname: Geben Sie den ganzen oder einen Teil des Vornamens einer Person ein, die der Firma angehört.
* Nachname: Geben Sie den ganzen oder einen Teil des Nachnamens einer Person ein, die der Firma angehört.
* Telefon: Geben Sie die ganze Telefonnummer der Firma oder einen Teil davon ein.
* E-Mail: Geben Sie die ganze E-Mail-Adresse der Firma oder einen Teil davon ein.
* Ebenso: Hier können Sie weitere [Suchkriterien][1] festlegen.

<!-- Referenced links -->
[1]: ../../search-options/learn/search-criteria.md
[2]: update-user.md#delete

<!-- Referenced images -->
