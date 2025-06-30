---
uid: help-de-importing-files
title: Dateien importieren
description: Dateien importieren
author: SuperOffice RnD
date: 06.29.2022
keywords: Einstellungen für den Windows-Client
content_type: howto
language: de
client: win
envir: onsite
---

# Datendatei in die SuperOffice-Datenbank importieren

Nachdem Sie die Datenbankdatei gesichert haben, die richtige Datendatei gefunden und in einen Ordner kopiert haben, in dem Sie sie problemlos wiederfinden können (siehe [Importroutinen][1]), können Sie mit dem Importvorgang beginnen.

> [!NOTE]
> In einigen Programmen werden geöffnete Dateien gesperrt, damit andere Programme nicht darauf zugreifen können. Stellen Sie vor dem Start des Importvorgang sicher, dass weder die Importbeschreibungsdatei noch die Datendatei in einem anderen Programm (zum Beispiel Excel) geöffnet ist.

**Schritte:**

<!-- markdownlint-disable-file MD029 -->
1. [!include[How to open import](includes/open-import.md)]

[!include[Import description](includes/step-import-description.md)]
<!-- Include covers steps 2-3. Next line MUST be 4. -->

4. Nachdem Sie eine Importbeschreibung gewählt haben und die Importdatei gefunden wurde, werden die anderen Felder automatisch ausgefüllt. Anderenfalls können Sie die [Details in der Importbeschreibung bearbeiten][3].

5. Es ist ratsam zu prüfen, ob der Inhalt der Felder mit den von Ihnen gewählten Feldern übereinstimmt. In der Spalte **Feld in Datei** unter **Feldzuordnung** wird der Inhalt des ersten Datensatzes der gerade importierten Datendatei angezeigt, während die Spalte **Feld in SuperOffice CRM** anzeigt, in welche Felder der SuperOffice-Datenbank diese Informationen importiert werden. Klicken Sie einige Male auf die Schaltfläche **Nächster**, um auch den Inhalt einiger Folgedatensätze anzuzeigen.

    > [!NOTE]
    > Wenn die Felder nicht wie gewünscht angezeigt werden, müssen Sie entweder die [Feldzuordnung][4] ändern oder die erforderlichen Änderungen in der Importdatei vornehmen.

6. Klicken Sie auf **Start**, um den Import zu starten. Unten in der Ansicht wird eine Statusanzeige eingeblendet.

> [!NOTE]
> Die Dauer des Imports der Daten aus der Importdatei in die SuperOffice-Datenbank hängt von der Größe der Datenbank und der Datenverbindung (langsame oder schnelle Verbindung zum Datenbankserver) ab. Sie können den Importvorgang jedoch jederzeit abbrechen, indem Sie auf die Schaltfläche **Stopp** rechts von der Statusanzeige klicken.

<!-- Referenced links -->
[1]: import-routines.md
[3]: editing-import-descriptions.md
[4]: field-mapping.md

<!-- Referenced images -->
