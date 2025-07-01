---
uid: help-de-backup-routines
title: Sicherungsroutinen
description: Sicherungsroutinen
author: SuperOffice RnD
date: 06.29.2022
keywords: Einstellungen für den Windows-Client
content_type: concept
language: de
platform: win
deployment: onsite
---

# Sicherungsroutinen

Bei einem Datenbankfehler sind gute Sicherungsroutinen äußerst wichtig. Das Erstellen einer Sicherheitskopie mag lästig erscheinen, da Sie jeden Tag Zeit dafür aufwenden müssen. Wenn aber ein Fehler auftritt, kann dieser mithilfe einer Sicherheitskopie der Datenbank vom Vortag schnell behoben werden.

Angenommen, Sie haben im Laufe eines Jahres eine Firmendatenbank mit 1500 Firmen eingerichtet. Sie arbeiten jeden Tag mit SuperOffice CRM und haben Firmen erfasst, die Sie wöchentlich anrufen und mit denen Sie fortwährend zu tun haben. Sie haben Termine weit im Voraus geplant und alle Dokumente und Folgeaufgaben in SuperOffice CRM erfasst. Aber Sie haben es versäumt, eine Sicherung für die letzten sechs Monate vorzunehmen.

Eines Tages tritt im Büro ein Fehler auf der Festplatte auf, der nicht sofort behoben werden kann. Sie rufen SuperOffice an und werden gefragt, ob Sie gestern eine Sicherheitskopie erstellt haben.

Stellen Sie sich vor, Sie müssen nun eine sechs Monate alte Sicherheitskopie verwenden. Wie viele wichtige Firmendaten haben Sie danach hinzugefügt? Wie viele wichtige Telefonnummern waren in der Datenbank gespeichert? Wie viele Adressen?

> [!NOTE]
> Denken Sie daran, dass Datenbanken und Festplatten nicht vor Ausfällen sicher sind. Ein Fehler kann jederzeit auftreten und Ihr wichtigstes Tool sind dann gute Sicherungsroutinen. Sie sollten die Datenbank daher jeden Tag sichern.

## Nur Datendatei sichern

* Wenn Sie eine SQL-Datenbank verwenden, folgen Sie den Anweisungen zum Herstellen von Sicherheitskopien, die in der Dokumentation der betreffenden SQL-Datenbank enthalten sind. Dadurch wird eine Datenbank erstellt, die nur in Verbindung mit der Datenbank verwendet werden kann, von der sie erstellt wurde. Dies ist die schnellste Methode, um eine Sicherung zu erstellen.

* Öffnen Sie die Datei **dbsetup.exe** im Installationsordner von SuperOffice Server und wählen Sie die Option **Datenbank in Datei exportieren**. Dadurch wird eine Datenbank erstellt, die auf allen von SuperOffice CRM unterstützten Servertypen installiert werden kann.

Wenn Sie zusätzlich noch alle Dokumente und Vorlagen sichern möchten, müssen Sie eine Sicherheitskopie des gesamten Ordners **SO_ARC** mit den dazugehörigen Unterordnern erstellen.

<!-- online --> Online customers must contact SuperOffice Support to create a backup.
