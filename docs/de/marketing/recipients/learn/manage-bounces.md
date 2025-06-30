---
uid: help-de-blocked-email-addresses
title: Gesperrte E-Mail-Adressen
description: In dieser Anleitung lernen Sie, wie Sie mit unzustellbaren E-Mails umgehen.
keywords: gesperrte E-Mail-Adressen, nicht zustellbar, Rückläufer, Bounce
author: SuperOffice RnD
date: 06.26.2025
version: 10.5
content_type: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: de
---

# Nicht zustellbare verwalten

Es gibt viele Gründe, warum E-Mail-Adressen unzustellbar sind. Ihre Personen wechseln den Job, eine E-Mail-Adresse wurde falsch geschrieben und selbst vorübergehende Störungen in der Infrastruktur des Kunden sind typische Gründe, warum Kampagnen nicht zugestellt werden.

Wenn Sie Ihre Kampagne zum ersten Mal versenden, erhalten Sie möglicherweise eine große Anzahl von unzustellbaren E-Mails. Das ist eine gute Nachricht, denn es bedeutet, dass Sie jede E-Mail-Adresse aktualisieren können, die falsch geschrieben ist oder nicht mehr verwendet wird. Die Aktualisierung von unzustellbaren E-Mail-Adressen trägt dazu bei, die Erfolgsquote Ihrer zukünftigen Kampagnen zu erhöhen.

Sie können nicht zustellbare und blockierte E-Mails für individuelle Kampagnen sowie für ALLE Kampagnen verwalten.

## Warum werden E-Mails zurückgegeben?

E-Mails können aufgrund von fehlerhaften E-Mail-Adressen, Spamfilter, Internetproblemen oder vollen Posteingängen zurückgegeben werden.

* Vorübergehende Probleme: Lieferverzögerungen, E-Mail-Server vorübergehend nicht erreichbar
* Permanente Probleme: falsche Adresse, unbekannte Domäne.

Vorübergehend fehlerhafte E-Mail-Adressen werden nicht blockiert und in der nächsten Kampagne nicht übersprungen.

> [!NOTE]
> Um falsch geschriebene oder ungültige E-Mail-Adressen zu verhindern, überprüft SuperOffice E-Mail-Adressen, die über Chat und Formulare empfangen wurden. Die Validierung wird mithilfe der DNS-Suche und der Steuerung der grundlegenden E-Mail-Syntax durchgeführt.

Es gibt zwei nicht zustellbare Typen:

Von einem **Hard Bounce** spricht man, wenn Ihre Kampagne dauerhaft nicht zustellbar ist, weil die E-Mail-Adresse nicht existiert, die Domäne nicht (mehr) existiert oder der E-Mail-Server des Empfängers die Zustellung blockiert hat. Die Aktualisierung der E-Mail-Adresse löst das Problem.

Ein **Soft Bounce** tritt auf, wenn ein vorübergehendes Zustellungsproblem vorliegt. SuperOffice CRM wird mehrere Sendeversuche der Kampagne durchführen, wenn die E-Mail nicht zustellbar ist. Erst wenn die E-Mail nach mehrmaligen Versuchen nicht zugestellt werden kann, wird sie als Hard Bounce erfasst.

Verwenden Sie die Filterschaltflächen (Gesendet, Unzustellbar und Geöffnet), damit Sie Ihre [Empfängerliste filtern][1] können. Nachdem Sie alle Personen ausgewählt haben, bei denen die Kampagne nicht zugestellt wurde, können Sie diese über die Menüschaltfläche Aktion in der linken unteren Ecke in einer Auswahl oder einem Projekt zusammenfassen.

![Filtern Sie Ihre unzustellbaren E-Mails und wählen Sie aus, was mit ihnen geschehen soll -screenshot][img2]

## Wie man eine einzelne E-Mail-Adresse korrigiert

1. Wählen Sie diese in der Liste aus und klicken in der Seitenleiste auf **Öffnen**, um die Person zu bearbeiten.
2. Wechseln Sie zur Registerkarte **Details**.
3. Ein Warnsymbol (<i class="ph ph-warning" aria-hidden="true"></i>) neben der E-Mail-Adresse weist auf ein Problem hin. Halten Sie den Mauszeiger über das Symbol, um die Ursache des Problems anzuzeigen.

> [!TIP]
> Klicken Sie auf eine Spalte, um Sortier- und Gruppierungsfunktionen aufzurufen.

## Gesperrte E-Mail-Adressen

E-Mail-Adressen, die aufgrund dauerhaften Fehler oder wiederholter Rückläufer nicht zugestellt wurden, werden automatisch gesperrt. Gesperrte Adressen werden in allen zukünftigen Mailings übersprungen, um Ihren Absender-Ruf zu schützen.

Standardmäßig wird eine E-Mail-Adresse nach 5 aufeinanderfolgenden Rückläufern blockiert. Dieser Schwellenwert definiert, was als **zu viele Rückläufer** gilt. Er hilft, unzuverlässige Adressen zu erkennen, die regelmäßig fehlschlagen. Sie können diesen Grenzwert in der globalen Einstellung **Anzahl der erfolglosen Zustellversuche, nach der die E-Mail-Adresse deaktiviert wird** in Einstellungen und Verwaltung anpassen.

Alle blockierten E-Mail-Adressen aller Kampagnen werden auf der Registerkarte **Blockierte E-Mail-Adressen** archiviert. Diese Registerkarte bietet einen hervorragenden Überblick über E-Mail-Adressen, die bereinigt werden müssen.

> [!TIP]
> Klicken Sie auf eine Spalte, um Sortier- und Gruppierungsfunktionen aufzurufen.

## Absprung-Optionen

Um mehrere E-Mail-Adressen zu verarbeiten, haben Sie mit der Schaltfläche **Aktionen** eine Reihe von Möglichkeiten.

### Exportieren

1. Wählen Sie die E-Mail-Adressen aus, die Sie exportieren möchten.
2. Wählen Sie **Aktionen** > **Exportieren**.
3. Wählen Sie ein Exportformat aus. Die Exportdatei wird unten im Browser angezeigt. Sie kann auch in Ihrem Download-Ordner gefunden werden.

### Zu neuer Selektion hinzufügen

1. Wählen Sie die E-Mail-Adressen aus, die Sie einer neuen Selektion hinzufügen möchten.
2. Wählen Sie **Aktionen** > **Zur neuer Selektion** hinzufügen.
3. Geben Sie den Namen der neuen Selektion ein und klicken auf **OK**. Mit den ausgewählten E-Mail-Adressen wird eine neue statische Selektion erstellt.

### Zu neuem Projekt hinzufügen

1. Wählen Sie die E-Mail-Adressen aus, die Sie einem neuen Projekt hinzufügen möchten.
2. Wählen Sie **Aktionen** > **Zu neuem Projekt hinzufügen** .
3. Geben Sie den Namen des neuen Projektes ein und klicken auf **OK**. Mit den ausgewählten E-Mail-Adressen wird ein neues Projekt erstellt.

### Zu bestehender Selektion hinzufügen

1. Wählen Sie die E-Mail-Adressen aus, die Sie einer bestehenden Selektion hinzufügen möchten.
2. Wählen Sie **Aktionen** > **Zu bestehender Selektion hinzufügen**.
3. Beginnen Sie mit der Eingabe in das Suchfeld, um die entsprechende Selektion zu finden.
4. Klicken Sie in der Ergebnisliste auf die Selektion, die Sie verwenden möchten.
5. Klicken Sie auf **OK**. Die ausgewählten E-Mail-Adressen werden der Selektion hinzugefügt.

### Zu bestehendem Projekt hinzufügen

1. Wählen Sie die E-Mail-Adressen aus, die Sie einem bestehenden Projekt hinzufügen möchten.
2. Wählen Sie **Aktionen** > **Zu bestehendem Projekt hinzufügen**.
3. Beginnen Sie mit der Eingabe in das Suchfeld, um das entsprechende Projekt zu finden.
4. Klicken Sie in der Ergebnisliste auf das Projekt, das Sie verwenden möchten.
5. Klicken Sie auf **OK**. Die ausgewählten E-Mail-Adressen werden dem Projekt hinzugefügt

### Ausgewählte E-Mail-Adressen löschen

Verwenden Sie diese Option, um E-Mail-Adressen dauerhaft aus der Datenbank zu löschen.

1. Wählen Sie die E-Mail-Adressen aus, die Sie löschen möchten.
2. Wählen Sie **Aktionen** > **Ausgewählte E-Mail-Adressen löschen**.
3. Klicken Sie zur Bestätigung auf **OK**.

### Kennzeichnung "Zustellung nicht möglich" aufheben

Verwenden Sie diese Option, um E-Mail-Adressen aus der Liste zu entfernen, damit sie in Kampagnen verwendet werden können. Dies kann relevant sein, wenn Unzustellbarkeiten aufgrund einer falschen Konfiguration oder aus temporären technischen Gründen auftreten, oder wenn Sie wissen, dass diese E-Mail-Adressen korrekt sind und einen zweiten Sendeversuch unternehmen möchten.

1. Wählen Sie die E-Mail-Adressen aus, deren Kennzeichnung Zustellung nicht möglich entfernt werden soll.
2. Wählen Sie **Aktionen** > **Kennzeichnung "Zustellung nicht möglich" aufheben**.
3. Klicken Sie zur Bestätigung auf **OK**.

### Als ausgeschiedenen Mitarbeiter festlegen

Mit dieser Option können Sie eine Person als ausgeschiedenen Mitarbeiter festlegen.

1. Wählen Sie die E-Mail-Adressen aus, die Sie löschen möchten.
2. Wählen Sie **Aktionen** > **Als ausgeschiedenen Mitarbeiter festlegen**.
3. Klicken Sie zur Bestätigung auf **OK**.

<!-- Referenced links -->
[1]: look-at-recipient-list.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/marketing/handle-bounced-emails.png
