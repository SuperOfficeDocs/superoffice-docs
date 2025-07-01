---
uid: help-de-creating-import-descriptions
title: Importbeschreibungen erstellen
description: Importbeschreibungen erstellen
author: SuperOffice RnD
date: 06.29.2022
keywords: Einstellungen für den Windows-Client
content_type: howto
language: de
client: win
deployment: onsite
---

# Importbeschreibungen erstellen

> [!NOTE]
> Wenn Sie die Importdatei bereits hochgeladen und alle Felder und Einstellungen konfiguriert haben, müssen Sie auf **Speichern** klicken. Wenn Sie auf **Neu** klicken, werden alle Einstellungen, die Sie für die Importdatei vorgenommen haben, GELÖSCHT.

1. [!include[How to open import](includes/open-import.md)]

2. Klicken Sie im oberen Teil rechts in der Ansicht auf die Schaltfläche **Neu**. Die Informationen werden aus der Ansicht **Import** gelöscht.

3. Geben Sie im Feld **Importdatei** eine Datei an.

4. Geben Sie unter **Feldzuordnung** ein, welches Feld der Importdatei welches Feld in der SuperOffice-Datenbank zugeordnet werden soll. (Siehe [Feldzuordnung][1].)

5. Unter **Importeinstellungen** stehen folgende Optionen zur Verfügung:

    * **Datei hat Überschriften**: Aktivieren Sie diese Option, wenn die Datei mit einer Kopfzeile (einer Zeile, die keine Daten enthält) beginnt.
    * **Listenfelder beim Import aktualisieren**: Aktivieren Sie diese Option, wenn Sie möchten, dass alle unbekannten Objekte in die vorhandenen Listen der SuperOffice-Datenbank eingefügt werden. Wenn Sie diese Option nicht aktivieren, werden unbekannte Objekte nicht importiert und das entsprechende Feld der SuperOffice-Datenbank bleibt leer.
    * **In eine NEUE Selektion eintragen**: Aktivieren Sie diese Option, wenn Sie den Firmen- oder Personen-Datentyp importieren und die importierten Firmen/Personen in eine separate Selektion aufnehmen möchten. In diesem Fall müssen Sie zusätzlich einen Namen für die Selektion im Feld **Name** eingeben.

    > [!NOTE]
    > Wenn Sie die Option **In eine NEUE Selektion eintragen** wählen, werden importierte Firmen und Personen in die neue Selektion mit dem von Ihnen festgelegten Namen eingefügt. Nicht betroffene Firmen und Personen (wenn Sie im Dialogfeld **Schlüssel bearbeiten** die Option **Überspringen** gewählt haben) werden nicht zur Selektion hinzugefügt, auch wenn Sie in der Importdatei vorhanden sind.

6. Wenn Sie mehr [erweiterte Einstellungen für den Import][2] festlegen möchten, klicken Sie auf die Schaltfläche **Erweitert**.

7. Unter **Schlüsselfelder** geben Sie Regeln an, um vorhandene [Duplikate][3] zu berücksichtigen. Das heißt, wenn derselbe Datensatz in der importierten Datei und auch in der importierenden Datenbank vorhanden ist.

8. Nachdem Sie die erforderlichen Optionen angegeben haben, klicken Sie auf **Speichern**.

    > [!NOTE]
    > Sie können auch ohne Klicken auf **Speichern** einen Import durchführen, Ihre Änderungen werden dann jedoch nicht für eine spätere Verwendung gespeichert.

9. Geben Sie Im Dialogfeld den Namen für die neue Datei ein und wählen Sie den Ordner aus, in dem die Datei gespeichert werden soll, und klicken Sie auf **Speichern**.

> [!NOTE]
> Sie können eine neue Importbeschreibung auch erstellen, indem Sie eine [vorhandene Beschreibung ändern][4] und unter einem neuen Namen speichern.

<!-- Referenced links -->
[1]: field-mapping.md
[2]: specifying-advanced-import-settings.md
[3]: duplicates-import.md
[4]: editing-import-descriptions.md

<!-- Referenced images -->
