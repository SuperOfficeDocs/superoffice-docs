---
uid: help-de-document-lock
title: Dokumente ein-/auschecken
description: Dokumente ein-/auschecken
keywords: Dokument
author: Bergfrid Dias
date: 10.29.2024
version: 10.3.11
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Dokumente ein-/auschecken

In SuperOffice CRM sind häufig viele Benutzer gleichzeitig damit befasst, Dokumente zu erstellen, zu bearbeiten oder zu lesen. Wenn jedoch ein Dokument gleichzeitig von mehreren Benutzern bearbeitet wird, besteht die Gefahr, dass sie ihre Änderungen gegenseitig überschreiben. Damit dies nicht geschieht, wird ein Dokument in SuperOffice CRM automatisch gesperrt, wenn es von einem Benutzer bearbeitet wird. Andere Benutzer können das Dokument weiterhin öffnen, aber nur im Lesemodus. (Wenn Ihre Organisation eine Dokumentbibliothek wie SharePoint nutzt, können mehrere Personen ein Dokument gleichzeitig bearbeiten.)

## Bearbeitungsmodus und Lesemodus

* Bearbeitungsmodus: Das Dokument ist zur Bearbeitung geöffnet. Das Dokument kann von anderen Benutzern erst wieder bearbeitet werden, wenn Sie es speichern und schließen, wodurch es automatisch eingecheckt wird.

    Wenn ein Dokument beim Speichern und Schließen nicht automatisch eingecheckt werden soll, können Sie die Option **Einchecken nach Abschluss der Bearbeitung empfohlen** unter **Einstellungen** in SuperOffice WebTools aktivieren.

* Lesemodus: Das Dokument ist zum Lesen geöffnet. Änderungen, die Sie am Dokument vornehmen, werden nicht gespeichert. Um das [Dokument mit den Änderungen speichern][1] möchten, müssen Sie in SuperOffice CRM ein neues Dokument erstellen und die Datei mit den Änderungen hochladen.

Standardmäßig werden Dokumente im Bearbeitungsmodus geöffnet. Wenn Sie es vorziehen, beim Öffnen eines Dokuments den Lese- oder den Bearbeitungsmodus auszuwählen, müssen Sie zu ![Symbol][img2] **Persönliche Einstellungen** > **Einstellungen** > **Funktionen** gehen und **Zum Bearbeiten oder Lesen auffordern** auf **Ja** setzen.

## Woran erkannt man, ob ein Dokument ausgecheckt wurde?

<!-- markdownlint-disable MD051 -->
### [Neu (ab Version 10.3.1)](#tab/lock-new)

Im Dialogfeld **Dokument** zeigt ein ausgechecktes Dokument ein Banner mit Informationen darüber, wer das Dokument bearbeitet.

![Symbol][img5] **Sie** bearbeiten dieses Dokument.

![Symbol][img5] Sie können dieses Dokument nicht bearbeiten, da es von **NN** gesperrt ist.

### [Klassisch (onsite)](#tab/lock-old)

Im Dialogfeld **Dokument** ist ein ausgechecktes Dokument mit einem der folgenden Symbole gekennzeichnet:

![Symbol][img3] Das Dokument ist derzeit zur Bearbeitung durch Sie ausgecheckt.

![Symbol][img4] Das Dokument ist derzeit zur Bearbeitung durch einen anderen Benutzer ausgecheckt.

Zeigen Sie mit dem Mauszeiger auf ein Symbol, um Informationen über den Benutzer anzuzeigen, der das Dokument ausgecheckt hat.

Wenn Sie versuchen, ein ausgechecktes Dokument zu öffnen, wird ein Dialogfeld mit Informationen über den Benutzer angezeigt, der das Dokument ausgecheckt hat. Sie können das Dokument nur im Lesemodus öffnen.

***
<!-- markdownlint-restore -->

## Dokument zur Bearbeitung auschecken

Öffnen Sie ein Dokument und wählen Sie die Option [Dokument bearbeiten][1] aus. Das Dokument wird ausgecheckt, sodass Sie es bearbeiten können. Andere Benutzer können das Dokument lediglich im Lesemodus öffnen.

## Dokument nach der Bearbeitung einchecken

In den meisten Fällen können Sie in der Anwendung das [Dokument speichern und schließen][1], woraufhin es automatisch eingecheckt wird.

## Auschecken rückgängig machen (zurück zur gespeicherten Version)

Für den Zugriff auf diese Option benötigen Sie spezielle Rechte. Zudem benötigen Sie Schreibzugriff auf das Dokument.

> [!CAUTION]
> Wenn ein Dokument von einem anderen Benutzer ausgecheckt wurde, sollten Sie sich unbedingt an den Benutzer wenden, bevor Sie die folgenden Schritte ausführen. Andernfalls besteht die Gefahr, dass Sie die Änderungen eines anderen Benutzers überschreiben oder ein anderer Benutzer beim Einchecken des Dokuments Ihre Änderungen überschreibt
>
> Am besten ist es unter Umständen, eine Kopie des Dokuments zu erstellen und diese zu bearbeiten.

Wenn ein Dokument von Ihnen oder einem anderen Benutzer ausgecheckt wurde und Sie das Dokument bearbeiten möchten, können Sie das Auschecken wie folgt abbrechen:

1. Klicken Sie mit der rechten Maustaste auf das Dokument und wählen Sie **Dokument**.
2. Klicken Sie in der Anzeige Dokument auf **Aufgabe** und wählen Sie **Zurück zur gespeicherten Version** aus.

<!-- Referenced links -->
[1]: edit.md

<!-- Referenced images -->
[img2]: ../../../media/icons/personal-settings-small.png
[img3]: ../../../media/icons/document-lock-editing.png
[img4]: ../../../media/icons/document-lock-locked.png
[img5]: ../../../../common/icons/ops.png
