---
uid: help-de-extra-table-create
title:  Zusatztabellen definieren
description:  Zusatztabellen definieren
author: Hanne Gunnarsson
so.date: 03.29.2023
keywords: Zusatztabelle
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance

language: de
---

# Zusatztabellen hinzufügen

Sie können Zusatztabellen in SuperOffice Service erstellen, um unterschiedliche Datentypen zu erfassen. Nachdem Sie die Tabelle und darin [Zusatzfelder erstellt][1] wurden, können Sie die Tabelle öffnen, um ihr Inhalte hinzuzufügen, indem Sie zum **Systemdesign** &gt; **Tabellen** gehen, mit dem Mauszeiger auf die Tabelle zeigen und die Schaltfläche ![Symbol][img1] anklicken.

> [!NOTE]
> In SuperOffice können Sie Web-Bildschirme erstellen, die Tabelleninformationen enthalten können. Um die entsprechenden Zugriffsrechte festzulegen, muss der Benutzer einer Rolle angehören, die über die Funktionsrechte **Tabellen anzeigen** und **Tabellen bearbeiten**verfügt.

**Schritte:**

1. Gehen Sie zur Anzeige **Tabellen**.

    * In Einstellungen und Verwaltung: Klicken Sie im Navigator auf das ![Symbol][img3] der Schaltfläche **Systemdesign**. Wählen Sie dann die Registerkarte **Tabellen** aus.

2. Klicken Sie auf die Schaltfläche ![Symbol][img4]. Die Ansicht **Eigenschaften der Tabelle** wird geöffnet.

3. In der Ansicht **Eigenschaften der Tabelle** geben Sie Daten über die neue Tabelle ein. Weitere Details zu den folgenden Feldern finden Sie hier.

4. Klicken Sie auf **OK**, um die neue Tabelle zu speichern.

## Felder

| Feld | Beschreibung |
|---|---|
| Ordner | Um die Tabelle in einen vorhandenen Ordner zu kopieren, wählen Sie einen Ordner von der Liste aus. |
| Name | Der Name der Tabelle. |
| Datenbanktabelle Der Name der Datenbanktabelle. Kann nur bei der Erstellung festgelegt und nicht mehr geändert werden. Der Tabellenname kann Unterstriche, die Buchstaben a-z und Zahlen enthalten, und der Name muss mit „y_“ beginnen. Ein logischer Name ist am besten, weil er es einfacher macht, zu sehen, was die Datenbank enthält. |
| Kopfzeile für Suche | Die Kopfzeile wird für diese Tabelle in der Ansicht Suchen verwendet. |
| Kopfzeile für Datenanzeige | Die Kopfzeile wird zur Anzeige eines Eintrags in dieser Tabelle verwendet. |
| Kopfzeile für neuen Eintrag | Die Kopfzeile wird zum Erstellen eines neuen Eintrags in dieser Tabelle verwendet. |
| Kopfzeile für Datenbearbeitung | Die Kopfzeile wird für die Bearbeitung eines Eintrags in dieser Tabelle verwendet. |
| Sortierreihenfolge | Die Spalte, nach der die Tabelle sortiert wird. Wenn Sie **Absteigend** aktivieren, werden die Werte in absteigender Reihenfolge sortiert. Für Zahlenwerte bedeutet dies, dass der höchste Wert ganz oben in der Tabelle angezeigt wird. Die Tabelle muss Felder enthalten, bevor Sie hier etwas auswählen können. |
| Anzeigefeld | Wenn Daten aus dieser Tabelle in einer anderen Tabelle (eine Beziehung) angezeigt werden sollen, müssen Sie hier auswählen, welches Feld in der anderen Tabelle angezeigt werden soll. Die Tabelle muss Felder enthalten, bevor Sie hier etwas auswählen können. |
| Übergeordnetes Feld | Dieses Feld kommt in Verbindung mit Tabellen mit hierarchischer Struktur zum Einsatz. |
| Vollständiger Name |  Für hierarchisch strukturierte Tabellen können Sie hier ein Feld angeben, in das automatisch der vollständige Name des Eintrags eingefügt wird. Der Name wird aus dem Namensfeld des Eintrags und aller übergeordneten Einträge abgeleitet. |
| ID-Feld ausblenden | Wenn diese Option ausgewählt ist, wird das ID-Feld bei der Auflistung von Einträgen in der Tabelle nicht angezeigt. |
| Tabelle ausblenden | Wenn diese Option aktiviert ist, ist die Tabelle nicht über das ![Symbol][img3] **Systemdesign** &gt; **Tabellen**sichtbar. |

## Was möchten Sie jetzt tun?

* [Zusatzfelder definieren][1]

<!-- Referenced links -->
[1]: ../extra-field/create.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/service/new-field.png
[img3]: ../../../../../common/icons/nav-admin-systemdesign-active.png
[img4]: ../../../../media/icons/service/new-table.png
