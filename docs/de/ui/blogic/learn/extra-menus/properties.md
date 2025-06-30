---
uid: help-de-ui-extra-menu-properties
title: Eigenschaften des Menüs
description: Eigenschaften des Menüs
author: SuperOffice RnD
date: 06.29.2022
keywords: Service
content_type: howto
language: de
---

# Eigenschaften des Menüs

[!include[Legacy](../includes/legacy-extra-menus.md)]

Hier können Sie die Eigenschaften von Optionen auf Zusatzmenüs und Web-Bildschirmen bearbeiten.

* **Basisprogramm**: Wählen Sie ein Basisprogramm aus, wenn der Inhalt des URL-Feldes einem ausgewählten Basisprogramm hinzugefügt werden soll. Damit dies funktioniert, muss der Text im URL-Feld mit &action=... beginnen.

* **URL**: Die URL, die beim Klicken auf die Menüoption aktiviert wird.

* **ID anhängen**: An das Ende der URL wird automatisch die ID des aktuellen Eintrags angefügt.

* **Zur selben Ansicht zurückkehren**: Wenn Sie das Kontrollkästchen aktivieren, gelangt der Benutzer automatisch wieder zu der Ansicht, in der er auf die Schaltfläche oder Ähnliches geklickt hat. Andernfalls müsste der Benutzer von Hand zurückschalten.

  * Beispiel für eine sinnvolle Verwendung dieser Option: Wenn Sie in der Ansicht Anfrage eine Schaltfläche (ein Makro) erstellen, mit der sich die Kategorie der Anfrage ändern lässt, soll nach dem Klicken auf die Schaltfläche wieder dieselbe Anfrage angezeigt werden.

  * Beispiel dafür, wann diese Option NICHT verwendet werden sollte: Wenn Sie eine Schaltfläche (ein Skript) erstellen, um viele Informationen auf der Anzeige einzublenden, sollte diese Option nicht aktiviert sein, weil Sie die Informationen auch auf der Anzeige anzeigen möchten. Gleiches gilt für externe URLs, weil Sie die entsprechende Website aufrufen möchten, wenn Sie die Schaltfläche anklicken.

* **Append &lt;usec&gt;**: &lt;usec&gt; ist der Sitzungsschlüssel für die NetServer-Sitzung. Um einen Web-Bildschirm mit NetServer mit Authentifizierung zu betreiben, muss dieser Schlüssel hinzugefügt werden.

* **Ziel**: Ziel für die URL. Sie können wählen, in welchem Fenster sich die URL öffnen wird, indem Sie den Namen der Fensterinstanz in das Feld **Ziel** eingeben. Sie können "_blank" eingeben, wenn Sie immer ein neues Fenster bzw. eine neue Registerkarte (zum Beispiel "Kunde") öffnen möchten, um ein separates Fenster für diese Menüoption bzw. eine Gruppe des Menüoptionen zu öffnen.

* **Symbol-URL**: Wenn Sie das Zusatzmenü mit einem bestimmten Symbol anzeigen möchten, geben Sie hier die URL der Bilddatei ein.

* **Position**: Die Position des Zusatzmenüs (0 = oben).
