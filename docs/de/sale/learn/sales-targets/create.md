---
uid: help-de-sales-targets-create
title: Verkaufsziele festlegen
description: Legen Sie Vertriebsziele fest, um den Überblick über Ihre Budgets zu behalten. Dies wird Ihnen helfen, die richtigen Erwartungen zu setzen, Ihr Wachstum zu planen, die Motivation zu steigern und Zeit zu sparen.
keywords: Vertriebsziele
author: SuperOffice Product and Engineering
date: 09.17.2025
version: 10.5.2
content_type: howto
license: salespremium
deployment: online
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Verkaufsziele festlegen

Legen Sie Vertriebsziele fest, um den Überblick über Ihre Budgets zu behalten. Dies wird Ihnen helfen, die richtigen Erwartungen zu setzen, Ihr Wachstum zu planen, die Motivation zu steigern und Zeit zu sparen.

![Das Dialogfeld Ziele gibt Ihnen einen Überblick über Ihre aktuellen und früheren Verkaufsziele -screenshot][img1]

Die Zielliste kann folgende Abschnitte enthalten:

* Ziel der Firma
* Ziel der Benutzergruppe
* Ziel des Benutzers
* Summe der Ziele für alle Benutzer in einer Benutzergruppe (nicht bearbeitbar)

Es ist optional, ob Sie das Unternehmensziel hinzufügen und benutzerspezifische Ziele haben (gehen Sie zu Zieleinstellungen, um sie zu ändern). Die Summe aller Ziele für eine Benutzergruppe  ist nicht bearbeitbar. Es zeigt die Summe für alle Benutzer in einer Benutzergruppe an und dient als Richtlinie, um das Einrichten des Ziels für die gesamte Benutzergruppe zu erleichtern. Sie können das Unternehmensziel hinzufügen und bearbeiten, da das Ziel für das gesamte Unternehmen nicht unbedingt mit der Summe aller Benutzergruppen identisch ist.

## Anforderungen

> [!NOTE]
> Nur für **ONLINE**-Kunden. (Nicht verfügbar für Onsite-Kunden.)

## Bevor Sie beginnen

Vor der Nutzung der Vertriebsziele-Funktion müssen Sie in Einstellungen und Verwaltung einige Dinge konfigurieren:

* Standardmäßig sind die Vertriebsziele in Monate unterteilt, aber Sie können dies in vierteljährliche Ziele ändern. Gehen Sie in Einstellungen und Verwaltung zu **Einstellungen** > **Globale Systemeinstellungen** > **Ziele**, um Änderungen vorzunehmen.

* Das Sperren und Entsperren von Vertriebszielen steht nur Benutzern mit dem funktionellen Recht **Kann Ziele sperren und entsperren** zur Verfügung. Dies kann unter **Rollen** in Einstellungen und Verwaltung geändert werden.

* Das Erstellen, Bearbeiten und Löschen von Vertriebszielen erfordert bestimmte Datenrechte. Dies kann unter **Rollen** in Einstellungen und Verwaltung geändert werden.

## Ziele für ein Jahr hinzufügen

1. Klicken Sie auf <i class="ph ph-list" aria-label="Hauptmenü"></i> und wählen Sie **Ziele** aus.

    * Wenn noch keine Vertriebsziele erstellt wurden, ist die Liste leer.

1. Wählen Sie auf der Anzeige **Verkaufsziele** das Jahr aus der Liste **Jahr auswählen** aus, für das Sie ein Verkaufsziel erstellen möchten.

    * Wenn Sie ein Jahr ausgewählt haben UND das frühere Jahr Vertriebsziele enthält, werden Sie gefragt, ob Sie Ziele basierend auf dem früheren Jahr erstellen möchten. Sie können die Ziele unverändert kopieren oder um einen bestimmten Prozentsatz erhöhen.

1. Klicken Sie auf **Gruppen und Benutzer hinzufügen** und verwenden Sie das Suchfeld, um die relevante Gruppe zu finden. Wählen Sie die Gruppe in der Liste aus. Um ein Ziel für die ganze Firma hinzuzufügen, wählen Sie **Firmenziel**.

    * Die Gruppe wird zur Übersicht hinzugefügt. Die monatlichen oder vierteljährlichen Ziele sind in der Standardwährung auf 0 gesetzt (es sei denn, Sie haben Zahlen von einem früheren Jahr kopiert). Alle Benutzer (Mitglieder der Primärgruppe), die zur Gruppe gehören, sind darunter aufgeführt.

1. Ändern Sie gegebenenfalls die Währung für die Firma oder Gruppe. Die Standardwährung ist die Basiswährung für Ihre Firma. Sie können keine Währung für einzelne Benutzer konfigurieren.

1. Geben Sie die Zahlen manuell ein. Dabei gelangen Sie mit der **TAB-Taste** zum nächsten Feld. Sie können auch [Zahlen aus Excel kopieren und einfügen](#import) oder auf <i class="ph ph-list" aria-label="Menüsymbol"></i> am Ende einer Zeile klicken und **Zahlen anpassen** auswählen.

    ![Zahlen für ein bestimmtes Ziel anpassen -screenshot][img3]

1. Optional: Wenn eine Zeile abgeschlossen ist, können Sie sie sperren (<i class="ph ph-lock-simple" aria-hidden="true"></i>), um eine Bearbeitung zu verhindern. Zum Beispiel, nachdem ein Budget genehmigt wurde und nicht bearbeitet werden soll. Gesperrte Zeilen können nicht entfernt, geleert oder anderweitig bearbeitet werden.

1. Wenn für eine bestimmte Gruppe oder einen bestimmten Benutzer kein Vertriebsziel festgelegt werden soll, klicken Sie auf <i class="ph ph-list" aria-label="Menüsymbol"></i> und wählen **Löschen**, um die Werte zu löschen.

1. Klicken Sie auf **Speichern**.

    * Fügen Sie wie in den Schritten 3-10 erläutert weitere Gruppen oder Firmen hinzu. Dazu ist die Sales Targets Unlimited-Lizenz erforderlich.

    * Fügen Sie wie in Schritt 2 erläutert Vertriebsziele für ein weiteres Jahr hinzu oder klicken Sie auf **Speichern und schließen**, um diese Ansicht zu schließen.

## Nummern vom Ziel eines anderen Benutzers kopieren

Um zu vermeiden, dass Sie die Verkaufsziele für einen anderen Benutzer erneut von Grund auf neu einrichten müssen, können Sie das Verkaufsziel eines anderen Benutzers kopieren (feste Zahlen), danach das Ziel mit % nach oben oder unten anpassen oder den anfänglichen Jahresbetrag festlegen.

Optionen:

* **Anfänglichen Betrag festlegen:** Geben Sie den Betrag für das ganze Jahr ein. Der Betrag wird zu gleichen Teilen auf die Monate bzw. Quartale der aktuellen Zeile verteilt.

* **Kopieren aus:** Damit kopieren Sie die Werte einer anderen Gruppe oder eines anderen Benutzers.

* **Aus letztem Jahr kopieren:** Damit können Sie Werte aus dem letzten Jahr kopieren und um einen bestimmten Prozentsatz erhöhen. Diese Option ist nicht verfügbar, wenn für das letzte Jahr keine Werte angegeben sind.
    Klicken Sie, sobald Sie fertig sind, auf **Speichern**. Die Summen für alle Benutzer werden in die Zeile **Alle** oben in der Benutzerliste eingefügt.

## Ziele löschen oder entfernen

Um das Ziel für eine Firma oder Gruppe zu entfernen, klicken Sie auf <i class="ph ph-list" aria-label="Menüsymbol"></i> und wählen **Firmenziel entfernen** oder **Gruppenziel entfernen** aus.

Wenn Sie einige nicht korrekte Nummern hinzugefügt haben oder wenn ein Benutzer das Unternehmen verlassen hat, können Sie die hinzugefügten Nummern löschen. Beachten Sie, dass Sie einen Benutzer in einer Benutzergruppe nicht löschen können, wenn der Benutzer keine Verkaufsziele hat, wohingegen Sie die Zeile löschen können.

![Zahlen für ein bestimmtes Ziel löschen -screenshot][img2]

## Exportieren

Klicken Sie auf die Schaltfläche **Aufgabe** (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>), wenn Sie das Vertriebsziel für das ausgewählte Jahr in eine Excel- oder PDF-Datei exportieren wollen.

## <a id="import"></a>Import

Sie können die gesamte Zielliste exportieren, in einer Tabelle bearbeiten und dann wieder in Ziele importieren.

Führen Sie dazu die folgenden Schritte aus:

1. Exportieren Sie das Vertriebsziel für das ausgewählte Jahr in eine Excel-Datei.

1. Bearbeiten Sie die Zieldaten (Beträge) in der Tabelle.

1. Kopieren Sie die Zieldaten in die Tabellenkalkulation (nur Beträge). Sie können einen beliebigen Bereich auswählen.

1. Wählen Sie die obere linke Zelle im relevanten Bereich in SuperOffice aus und fügen Sie die Daten ein. Wenn einige Zeilen gesperrt sind, können Sie die Daten nicht einfügen.

## Sperr-/Entriegelungsfunktion

Je nach Ihrer Benutzerrolle (Funktionsrecht "Kann Ziele sperren/entsperren") können Sie ein Verkaufsziel sperren und entsperren. Wenn das Verkaufsziel genehmigt wurde, können Sie die Zeile auswählen, um die Verkaufsziele zu sperren, wonach die Zeile für die Bearbeitung deaktiviert wird. Wenn das Verkaufsziel genehmigt und gesperrt wurde, sollte es nicht entsperrt werden, sofern es keine bestimmte Gründe für seine Änderung gibt.

## Revisionsverlauf

Zum Anzeigen des Revisionsverlaufs für ein Vertriebsziel (Zeile) klicken Sie auf <i class="ph ph-list" aria-label="Menüsymbol"></i> und wählen **Revisionsverlauf** aus. In der daraufhin angezeigten Ansicht sind alle Änderungen zu sehen, die bislang am aktuellen Verkaufsziel vorgenommen wurden. einschließlich geänderter Werte, Sperren/Entsperren, wann und von wem eine Änderung vorgenommen wurde. Mit den Schaltflächen zum Erweitern/Ausblenden oben können Sie Details ein-/ausblenden.

## Tipps

* Mit den Schaltflächen zum Erweitern/Ausblenden oben oder den Pfeilen neben den einzelnen Gruppen können Sie Benutzer ein- oder ausblenden.

* Sie können auch Ziele für frühere Jahre definieren, um Budgetstatistiken für die Vergangenheit zu erstellen.

* Der Standardzieltyp ist **Alle Verkäufe - Betrag**. Mit der Sales Targets Unlimited-Lizenz können Sie zusätzliche Zieltypen erstellen.

* Sie können mit dem Feld **Volltextsuche** nach Vertriebszielen für bestimmte Gruppen und Benutzer in einem bestimmten Jahr suchen.

* Für Zieltypen, die Untertypen enthalten, verwenden Sie die Schaltfläche **Filter** (<i class="ph ph-funnel" aria-hidden="true"></i>), um bestimmte Elemente anzuzeigen oder damit zu arbeiten.

    ![Klicken Sie auf das Trichtersymbol, um Verkaufsziele nach Untertyp zu filtern -screenshot][img4]

## Verwandte Inhalte

* [Verwenden von Vertriebszielen in Kacheln][2]

<!-- Referenced links -->
[2]: ../../../dashboard/learn/show-sales-targets.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/targets-dialog-group-expanded.png
[img2]: ../../../../media/loc/en/sale/target-line-menu.png
[img3]: ../../../../media/loc/en/sale/target-adjust-number.png
[img4]: ../../../../media/loc/en/sale/filter-targets-by-dimension.png
